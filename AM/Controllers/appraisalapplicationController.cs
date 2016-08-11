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
    public class appraisalapplicationController : BaseController
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

                string appraisalcompanyname = Request["appraisalcompanyname"] == null ? string.Empty : Request["appraisalcompanyname"].ToString();
                string appraisallinktel = Request["appraisallinktel"] == null ? string.Empty : Request["appraisallinktel"].ToString();
                string appraisallinkname = Request["appraisallinkname"] == null ? string.Empty : Request["appraisallinkname"].ToString();
                string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

                var data = DB.Instant.AppraisalapplicationManager.Where(a => (string.IsNullOrEmpty(appraisalcompanyname) ? true : a.appraisalcompanyname.IndexOf(appraisalcompanyname) > -1)
                    && (string.IsNullOrEmpty(appraisallinktel) ? true : a.appraisallinktel.IndexOf(appraisallinktel) > -1)
                    && (string.IsNullOrEmpty(appraisallinkname) ? true : a.appraisallinkname.IndexOf(appraisallinkname) > -1)
                    && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1)
                    ).Select(a => new
                {
                    a.GUID,
                    a.appraisallinkname,
                    a.appraisallinktel,
                    a.appraisalcompanyname,
                    a.appraisalapplicationdate,
                    ispay = a.ispay == true ? "已支付" : "未支付",
                    a.state,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.GUID,
                    a.appraisallinkname,
                    a.appraisallinktel,
                    a.appraisalcompanyname,
                    appraisalapplicationdate = MVCTools.DateTimeConvertToString(a.appraisalapplicationdate),
                    a.ispay,
                    state = string.IsNullOrEmpty(a.state) ? "未处理" : a.state,
                });
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(String id)
        {
            var data = DB.Instant.AppraisalapplicationManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.appraisalcompanyname,
                a.appraisalcompanyaddr,
                a.appraisalgoodsname,
                a.appraisalgoodstype,
                a.appraisalmanufacturer,
                appraisaloutfactorydate = MVCTools.DateTimeConvertToString(a.appraisaloutfactorydate),
                a.appraisalgoodssummary,
                appraisalplandate = MVCTools.DateTimeConvertToString(a.appraisalplandate),
                appraisalapplicationdate = MVCTools.DateTimeConvertToString(a.appraisalapplicationdate),
                a.appraisallinkname,
                a.appraisallinktel,
                a.appraisalemail,
                a.ispay,
                a.state
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new appraisalapplication();
            MVCTools.SetValueFormToModel(t, form);
            t.operatetime = DateTime.Now;
            t.@operator = UserName;
            t.GUID = Guid.NewGuid().ToString();
            t.userid = UserName;
            if (string.IsNullOrEmpty(t.state))
            {
                t.state = "未处理";
            }
            if (t.ispay == null)
            {
                t.ispay = false;
            }
            var r = DB.Instant.AppraisalapplicationManager.Add(t);
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
            var t = DB.Instant.AppraisalapplicationManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.AppraisalapplicationManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<appraisalapplication> us = new List<appraisalapplication>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new appraisalapplication() { GUID = item });
            }
            var r = DB.Instant.AppraisalapplicationManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.AppraisalapplicationManager.Where(a => a.GUID == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("公司名称", result.appraisalcompanyname));
                list.Add(new KeyValuePair<string, string>("公司地址", result.appraisalcompanyaddr));
                list.Add(new KeyValuePair<string, string>("产品名称", result.appraisalgoodsname));
                list.Add(new KeyValuePair<string, string>("产品型号", result.appraisalgoodstype));
                list.Add(new KeyValuePair<string, string>("生产厂家", result.appraisalmanufacturer));
                list.Add(new KeyValuePair<string, string>("出厂日期", result.appraisaloutfactorydate));
                list.Add(new KeyValuePair<string, string>("产品简介", result.appraisalgoodssummary));
                list.Add(new KeyValuePair<string, string>("计划鉴定时间", MVCTools.DateTimeConvertToString(result.appraisalplandate)));
                list.Add(new KeyValuePair<string, string>("申请时间", MVCTools.DateTimeConvertToString(result.appraisalapplicationdate)));
                list.Add(new KeyValuePair<string, string>("联系人", result.appraisallinkname));
                list.Add(new KeyValuePair<string, string>("联系电话", result.appraisallinktel));
                list.Add(new KeyValuePair<string, string>("邮箱", result.appraisalemail));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
