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
    public class faultController : BaseController
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
                string faulttitle = Request["faulttitle"] == null ? string.Empty : Request["faulttitle"].ToString();
                string faultcontent = Request["faultcontent"] == null ? string.Empty : Request["faultcontent"].ToString();

                var data = DB.Instant.FaultManager.Where(a => (string.IsNullOrEmpty(faulttitle) ? true : a.faulttitle.IndexOf(faulttitle) > -1)
                    && (string.IsNullOrEmpty(faultcontent) ? true : a.faultcontent.IndexOf(faultcontent) > -1)
                    ).Select(a => new
                {
                    a.faultid,
                    a.faulttitle,
                    a.faultdate,
                    a.faultsummary,
                    a.type1,
                    a.type2
                });
                total = data.Count();
                var types = DB.Instant.FaultTypeManager.Where(a => true).ToList();
                var list = data.OrderByDescending(a => a.faultdate).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.faultid,
                    a.faulttitle,
                    faultdate = a.faultdate.ToString("yyyy-MM-dd"),
                    a.faultsummary,
                    type1 = types.FirstOrDefault(t => t.typeid == a.type1) == null ? string.Empty : types.FirstOrDefault(t => t.typeid == a.type1).typename,
                    type2 = types.FirstOrDefault(t => t.typeid == a.type2) == null ? string.Empty : types.FirstOrDefault(t => t.typeid == a.type2).typename,
                });
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(String id)
        {
            var data = DB.Instant.FaultManager.Where(a => a.faultid == id).ToList().Select(a => new
            {
                a.faultid,
                a.faulttitle,
                //a.faultlogo,
                faultdate = a.faultdate.ToString("yyyy-MM-dd"),
                a.faultsummary,
                a.faultcontent,
                a.type1,
                a.type2
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Add(FormCollection form, HttpPostedFileBase faultlogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (faultlogo != null && faultlogo.ContentLength > 1)
            {
                var root = "/fileupload/fault/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(faultlogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new fault();
            MVCTools.SetValueFormToModel(t, form);
            t.faultid = Guid.NewGuid().ToString();
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.faultlogo = rx.ResultDescription; 
                    t.faultislogo = true;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var r = DB.Instant.FaultManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Update(string id, FormCollection form, HttpPostedFileBase faultlogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (faultlogo != null && faultlogo.ContentLength > 1)
            {
                var root = "/fileupload/fault/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(faultlogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = DB.Instant.FaultManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.faultislogo = true;
                    t.faultlogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var r = DB.Instant.FaultManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<fault> us = new List<fault>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new fault() { faultid = item });
            }
            var r = DB.Instant.FaultManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.FaultManager.Where(a => a.faultid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("故障名", result.faulttitle));
                list.Add(new KeyValuePair<string, string>("故障时间", result.faultdate.ToString("yyyy-MM-dd")));
                list.Add(new KeyValuePair<string, string>("故障描述", result.faultsummary));
                list.Add(new KeyValuePair<string, string>("预览图", string.Format("<img src='{0}' class='img'/>", result.faultlogo)));
            }
            else
            {
            }
            var r = MVCTools.BuildViewString(list);
            var x = string.Format("{0}<div>故障内容：{1}</div>", r, result.faultcontent);
            return Json(x);
        }
    }
}
