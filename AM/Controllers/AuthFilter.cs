using AM.BLL;
using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM
{
    public class AuthFilter : FilterAttribute, IActionFilter
    {
        /// <summary>
        /// 是否返回为ActionResult,
        /// </summary>
        public bool IsJsonResult
        {
            get;
            set;
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //判断是否登录，未登录或登录超时，跳转登录页
            if (filterContext.HttpContext.Session.IsNewSession)
            {
                HttpContext.Current.Response.Redirect("/");
            }
            else
            {
                //验证是否有此url的授权
                if (filterContext == null)
                {
                    throw new ArgumentNullException("filterContext");
                }
                var path = filterContext.HttpContext.Request.Url.PathAndQuery.ToLower();  //得到路径，比如：/Home/Index?id=1
                var controllerName = filterContext.RouteData.Values["controller"].ToString().ToLower();  //controller 名称
                var actionName = filterContext.RouteData.Values["action"].ToString().ToLower();          //action 名称
                //使路径更规则【主要是把缺省的部分补上，这个与路由相关】                
                if (!path.StartsWith(string.Format("/{0}", controllerName)))  //如果缺省controllerName，actionName
                {
                    path = path.Insert(0, string.Format("/{0}/{1}", controllerName, actionName));
                }
                else if ((!path.StartsWith(string.Format("/{0}/{1}", controllerName, actionName)))) //如果缺省 actionName
                {
                    path = path.Insert(controllerName.Length + 1, string.Format("/{0}", actionName));
                }
                path = path.Replace("/?", "?");
                var actionPath = string.Format("/{0}/{1}", controllerName, actionName);
                if (path.StartsWith(string.Format("/{0}/{1}/", controllerName, actionName)))
                {
                    if (path.IndexOf("?") > -1)
                    {
                        //得到id
                        var wenLen = path.IndexOf("?");
                        var idstart = path.Substring(0, wenLen).LastIndexOf("/");
                        var id = path.Substring(idstart + 1, wenLen - idstart - 1);
                        path = string.Format("{0}?id={1}&{2}", actionPath, id, path.Substring(wenLen + 1));
                    }
                    else
                    {
                        path = path.Replace(actionPath + "/", actionPath + "?id=");         //像这样的：/admin/home/index/2    后面的/2是id=2
                    }
                }
                //判断这个路径与权限表里的路径是否对应，这里对于查询数据库的地方，可以用静态数据来存放，减少数据库查询次数，提高效率

                List<string> list = filterContext.HttpContext.Session["CurPermissions"] as List<string>;
                var count = list.Count(a => path.ToLower().StartsWith(a.ToLower()));
                if (count == 0)  //判断是否有权限
                {
                    if (IsJsonResult == true)
                    {
                        //如果是JsonResult  ,Ajax提交
                        filterContext.HttpContext.Response.StatusCode = 500;
                        filterContext.Result = new JsonResult
                        {
                            //如果是Ajax请求，就返回失败信息
                            Data = new AOPResult(-100, "没有权限！"),
                            JsonRequestBehavior = JsonRequestBehavior.AllowGet
                        };
                    }
                    else
                    {
                        HttpContext.Current.Response.RedirectToRoute(new { Controller = "Error", action = "Index", message = "没有权限" });
                    }
                }
            }
        }
    }
}