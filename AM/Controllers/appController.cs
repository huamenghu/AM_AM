
using AM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MFXinY.Common;
using AM.Common;
using Dao;


namespace AM.Controllers
{
    public class AppController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetData()
        {
            int total;  //记录总条数
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码

                List<app> data = new List<app>();
                using (var db = new amEntities())
                {
                    data = db.app.Where(a => true).ToList();
                }
                total = data.Count();
                var list = data.OrderBy(a => a.appid).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();//Skip跳过 


                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch (Exception Exc)
            {
                log4net.ILog iLog = Manager.Instant.Log4NetManager.TXTLog;
                if (iLog.IsDebugEnabled)
                {
                    string msg = string.Format("{0}:{1}", "AppController_GetData", Exc.ToString());
                    iLog.Debug(msg);
                }

                return Json(result);

            }
        }

        public JsonResult FillForm(string id)
        {
            try
            {
                var data = DB.Instant.AppManager.Where(a => a.appid == id).Select(a => new
                {
                    a.appid,
                    a.content,
                    a.description

                }).FirstOrDefault();
                return Json(data);
            }
            catch (Exception Exc)
            {
                return new JsonResult();
            }


        }


        [HttpPost]

        public JsonResult Update(string id, FormCollection form)
        {
            return _Update(id, form);
        }
        private JsonResult _Update(string id, FormCollection form)
        {
            try
            {
                #region 获取数据并开始验证
                string content = form.Get("content");
             
                string description = form.Get("description");
                int sort = Convert.ToInt32(form.Get("sort"));
                #endregion

                #region 开始验证
                bool flag = false;
                string desc = string.Empty;
                #endregion

                #region content
                if (content.Length > 2000)
                {
                    flag = true;
                    desc = string.Format("{0}长度不能超过2000位", "内容");
                }
                if (string.IsNullOrEmpty(content))
                {
                    flag = true;
                    desc = string.Format("{0}不允许为空", "内容");
                }
                #endregion

                #region 验证唯一

                #endregion

                #region 开始判断
                if (flag)
                {
                    return Json(new AOPResult(-2, desc), "text/html");
                }
                #endregion

                #region 更新数据
                #region app

                var t = DB.Instant.AppManager.Find(id);
                t.content = content;
                t.description = description;
                t.sort = sort;
                var r = DB.Instant.AppManager.Update(t);

                #endregion

                return Json(r, "text/html");
                #endregion
            }
            catch (Exception Exc)
            {
                return Json(new AOPResult(-100, string.Format("{0}", Exc.Message)), "text/html");
            }
        }

    }
}
