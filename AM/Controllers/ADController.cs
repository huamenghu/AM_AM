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
    public class adController : BaseController
    {
        public ActionResult Index(string id)
        {
            ViewBag.pid = id;
            ViewBag.toolbar = "yes";
           
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
                if (pageIndex < 1) pageIndex = 1;
                string F1 = Request["F1"] == null ? string.Empty : Request["F1"].ToString();
                var x = DB.Instant.AdManager.Where(a => true).ToList();
                var data = DB.Instant.AdManager.Where(a => 
                    (string.IsNullOrEmpty(F1) ? true : a.F1.IndexOf(F1) > -1)                                      
                    ).Select(a => new
                {
                    a.adid,
                    a.adimgurl,
                    a.F1 
                });
                total = data.Count();
                var list = data.OrderBy(a => a.F1).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                
                    result.Add("rows", list);
               
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(string id)
        {
            var data = DB.Instant.AdManager.Where(a => a.adid == id).ToList().Select(a => new
            {
                a.adid,
                a.F1,
                a.adimgurl,
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form,HttpPostedFileBase typelogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (typelogo != null && typelogo.ContentLength > 1)
            {
                var root = "/fileupload/ad/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(typelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new ad();
            MVCTools.SetValueFormToModel(t, form);
            t.adid = Guid.NewGuid().ToString();
             
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.adimgurl = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var r = DB.Instant.AdManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form,HttpPostedFileBase typelogo)
        {
            var t = DB.Instant.AdManager.Find(id);
         
            var logo = t.adimgurl;
            IAOPResult rx = null;
            //上传文件
            if (typelogo != null && typelogo.ContentLength > 1)
            {
                var root = "/fileupload/ad/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(typelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            MVCTools.SetValueFormToModel(t, form);
         
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.adimgurl = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            else
            {
                t.adimgurl = logo;
            }
            var r = DB.Instant.AdManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<ad> us = new List<ad>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new ad() { adid = item });
            }
            var r = DB.Instant.AdManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.AdManager.Where(a => a.adid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("ID", result.adid));
                list.Add(new KeyValuePair<string, string>("图片",string.Format("<img src='{0}' class='img'/>", result.adimgurl)));
                list.Add(new KeyValuePair<string, string>("F1", MVCTools.ConvertToString(result.F1)));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
