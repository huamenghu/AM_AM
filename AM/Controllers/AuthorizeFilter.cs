using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MFXinY.Common;

namespace AM.Controllers
{
    /// <summary>
    /// 权限过滤器
    /// </summary>
    public class AuthorizeFilter : ActionFilterAttribute
    //, IActionFilter, IResultFilter,
    {
        /// <summary>
        /// 是否返回为ActionResult,
        /// </summary>
        public bool IsJsonResult
        {
            get;
            set;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            //var qeury = filterContext.HttpContext.Session.IsNewSession;
            ////if (filterContext.HttpContext.Session.IsNewSession)   //判断是否登录，未登录或登录超时，跳转登录页
            //if (filterContext.HttpContext.Session["UserName"] == null)
            //{
            //    // string domain = "http://" + filterContext.HttpContext.Request.Url.Authority;
            //    // HttpContext.Current.Response.Redirect("/Admin/Login");
            //    filterContext.Result = new RedirectResult("/Admin/Login");
            //    filterContext.j
            //}

            if (filterContext.HttpContext.Session["UserName"] == null)
            {
                if (!filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    if (filterContext.HttpContext.Request.HttpMethod == "HttpPost")
                    {
                        filterContext.Result = new JsonResult { Data = new AOPResult(-10, "Session失效，请重新登录！"), ContentType = "text/html" };
                    }
                    else
                    {
                         filterContext.Result = new RedirectResult("/Login/Index");
                    }
                    // filterContext.Result = new JsonResult { Data = new AOPResult(-10, "Session失效，请重新登录！"), ContentType = "text/html" };
                    // 
                }
                else
                {

                    filterContext.Result = new JsonResult { Data = new AOPResult(-10, "Session失效，请重新登录！"), ContentType = "text/html" };
                }


            }

            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
        //void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    //var qeury = filterContext.HttpContext.Session.IsNewSession;
        //    ////if (filterContext.HttpContext.Session.IsNewSession)   //判断是否登录，未登录或登录超时，跳转登录页
        //    //if (filterContext.HttpContext.Session["UserName"] == null)
        //    //{
        //    //    string domain = "http://" + filterContext.HttpContext.Request.Url.Authority;
        //    //    HttpContext.Current.Response.Redirect("/Admin/Login");
        //    //}
        //}



    }
}