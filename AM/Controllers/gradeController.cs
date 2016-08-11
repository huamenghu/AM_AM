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
    public class gradeController : BaseController
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
                if (pageIndex < 1) pageIndex = 1;

                string gradename = Request["gradename"] == null ? string.Empty : Request["gradename"].ToString();

                var data = from a in DB.Instant.GradeManager.Where(a => string.IsNullOrEmpty(gradename) ? true : a.gradename.IndexOf(gradename) > -1)
                           select new
                               {
                                   a.gradeid,
                                   a.gradename,
                                   a.gradediscount,
                                   a.gradefull
                               };
                total = data.Count();
                var list = data.OrderByDescending(a => a.gradefull).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(string id)
        {
            var data = DB.Instant.GradeManager.Where(a => a.gradeid == id).ToList().Select(a => new
            {
                a.gradeid,
                a.gradename,
                a.gradediscount,
                a.gradefull
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form, HttpPostedFileBase gradelogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (gradelogo != null && gradelogo.ContentLength > 1)
            {
                var root = "/fileupload/grade/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(gradelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new grade();
            MVCTools.SetValueFormToModel(t, form);

            t.gradeid = Guid.NewGuid().ToString();
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.gradelogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var r = DB.Instant.GradeManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form, HttpPostedFileBase gradelogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (gradelogo != null && gradelogo.ContentLength > 1)
            {
                var root = "/fileupload/grade/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(gradelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            var t = DB.Instant.GradeManager.Find(id);
            var logo = t.gradelogo;
            MVCTools.SetValueFormToModel(t, form);
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.gradelogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            else
            {
                t.gradelogo = logo;
            }
            var r = DB.Instant.GradeManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<grade> us = new List<grade>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new grade() { gradeid = item });
            }
            var r = DB.Instant.GradeManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.GradeManager.Where(a => a.gradeid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("id", result.gradeid));
                list.Add(new KeyValuePair<string, string>("等级名称", result.gradename));
                list.Add(new KeyValuePair<string, string>("消费条件", result.gradefull.ToString()));
                list.Add(new KeyValuePair<string, string>("折扣率", result.gradediscount.ToString()));
                list.Add(new KeyValuePair<string, string>("等级logo", string.Format("<img src='{0}' class='img'/>", result.gradelogo)));
            }
            else
            {
            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
