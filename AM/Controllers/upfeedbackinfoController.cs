
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
    public class UpfeedBackInfoController : BaseController
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
                if (pageIndex < 1) pageIndex = 1;


                var data = (from a in DB.Instant.UpfeedBackInfoManager.Where(a => true)
                            join b in DB.Instant.UserManager.Where(a => true) on a.userid equals b.userid
                            select new
              {
                  a.guid,
                  a.content,
                  userid = b.username,
                  a.dt,
                  a.description
              });
                total = data.Count();
                var list = data.OrderByDescending(a => a.dt).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.guid,
                    a.content,
                    a.userid,
                    dt = a.dt.ToString("yyyy-MM-dd HH:mm"),
                    a.description
                });//Skip跳过 

                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch (Exception Exc)
            {
                log4net.ILog iLog = Manager.Instant.Log4NetManager.TXTLog;
                if (iLog.IsDebugEnabled)
                {
                    string msg = string.Format("{0}:{1}", "UpfeedBackInfoController_GetData", Exc.ToString());
                    iLog.Debug(msg);
                }

                return Json(result);
            }
        }

        public JsonResult FillForm(string id)
        {
            try
            {
                var data = DB.Instant.UpfeedBackInfoManager.Where(a => a.userid == id).Select(a => new
                {
                    a.guid,
                    a.content,
                    a.userid,
                    a.dt,
                    a.description
                }).ToList().Select(a => new
                {
                    a.guid,
                    a.content,
                    a.userid,
                    dt = a.dt.ToString("yyyy-MM-dd HH:mm"),
                    a.description
                }).FirstOrDefault();
                return Json(data);
            }
            catch (Exception Exc)
            {
                return new JsonResult();
            }
        }

        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new upfeedbackinfo();
            MVCTools.SetValueFormToModel(t, form);
            t.guid = Guid.NewGuid().ToString();
            var r = DB.Instant.UpfeedBackInfoManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form)
        {
            var t = DB.Instant.UpfeedBackInfoManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.UpfeedBackInfoManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<upfeedbackinfo> us = new List<upfeedbackinfo>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new upfeedbackinfo() { guid = item });
            }

            var r = DB.Instant.UpfeedBackInfoManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.UpfeedBackInfoManager.Where(a => a.guid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("用户id", result.userid));
              
                list.Add(new KeyValuePair<string, string>("描述", result.description));
              
                list.Add(new KeyValuePair<string, string>("内容", result.content));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString1(list);
            return Json(r);
        }

    }
}
