using Dao;
using AM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MFXinY.Common;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class adminController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData()
        {
            int total;  //记录总条数                                                                     
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典            
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小                      
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码                      

                string UserName = Request["UserName"] == null ? string.Empty : Request["UserName"].ToString();
                string Type = Request["Type"] == null ? string.Empty : Request["Type"].ToString();

                var data = DB.Instant.AdminManager.Where(a => (string.IsNullOrEmpty(UserName) ? true : a.UserName.IndexOf(UserName) > -1)
                    && (string.IsNullOrEmpty(Type) ? true : a.Type.IndexOf(Type) > -1)
                    ).Select(a => new
                {
                    a.GUID,
                    a.UserName,
                    a.Type,
                    a.Remark,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(Guid id)
        {
            var data = DB.Instant.AdminManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.UserName,
                a.Password,
                a.Type,
                a.Remark,
                
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new admin();
            MVCTools.SetValueFormToModel(t, form);
            t.GUID = Guid.NewGuid();
            var r = DB.Instant.AdminManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(Guid? id, FormCollection form)
        {
            var t = DB.Instant.AdminManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.AdminManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<admin> us = new List<admin>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
            }
            var r = DB.Instant.AdminManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var guid = new Guid(id);
            var result = DB.Instant.AdminManager.Where(a => a.GUID == guid).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("用户名", result.UserName));
                list.Add(new KeyValuePair<string, string>("密码", result.Password));
                list.Add(new KeyValuePair<string, string>("用户类型", result.Type));
                list.Add(new KeyValuePair<string, string>("备注", result.Remark));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
