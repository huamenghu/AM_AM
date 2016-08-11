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
    public class appraisalaccidentController : BaseController
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

                string accidentcompanyname = Request["accidentcompanyname"] == null ? string.Empty : Request["accidentcompanyname"].ToString();
                string accidentlinkname = Request["accidentlinkname"] == null ? string.Empty : Request["accidentlinkname"].ToString();
                string accidentlinktel = Request["accidentlinktel"] == null ? string.Empty : Request["accidentlinktel"].ToString();
                string accidenttype = Request["accidenttype"] == null ? string.Empty : Request["accidenttype"].ToString();
                string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

                var data = DB.Instant.AppraisalaccidentManager.Where(a => (string.IsNullOrEmpty(accidentcompanyname) ? true : a.accidentcompanyname.IndexOf(accidentcompanyname) > -1)
                    && (string.IsNullOrEmpty(accidentlinkname) ? true : a.accidentlinkname.IndexOf(accidentlinkname) > -1)
                    && (string.IsNullOrEmpty(accidentlinktel) ? true : a.accidentlinktel.IndexOf(accidentlinktel) > -1)
                    && (string.IsNullOrEmpty(accidenttype) ? true : a.accidenttype.IndexOf(accidenttype) > -1)
                     && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1)
                    ).Select(a => new
                {
                    a.GUID,
                    a.accidentlinkname,
                    a.accidentlinktel,
                    a.accidentcompanyname,
                    a.accidentoccurrencetime,
                    ispay = a.ispay == true ? "已支付" : "未支付",
                    a.state,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.GUID,
                    a.accidentlinkname,
                    a.accidentlinktel,
                    a.accidentcompanyname,
                    accidentoccurrencetime = MVCTools.DateTimeConvertToString(a.accidentoccurrencetime),
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
            var data = DB.Instant.AppraisalaccidentManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.accidentcompanyname,
                a.accidentcompanyaddr,
                a.accidentnenginename,
                a.accidentnenginenaddr,
                a.accidentgoodsname,
                a.accidentgoodstype,
                a.accidenttype,
                a.accidentdescription,
                accidentoccurrencetime = MVCTools.DateTimeConvertToString(a.accidentoccurrencetime),
                a.accidentlinkname,
                a.accidentlinktel,
                a.accidentemail,
                a.ispay,
                a.state
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new appraisalaccident();
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
            var r = DB.Instant.AppraisalaccidentManager.Add(t);
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
            var t = DB.Instant.AppraisalaccidentManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.AppraisalaccidentManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<appraisalaccident> us = new List<appraisalaccident>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new appraisalaccident() { GUID = item });
            }
            var r = DB.Instant.AppraisalaccidentManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.AppraisalaccidentManager.Where(a => a.GUID == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("公司名称", result.accidentcompanyname));
                list.Add(new KeyValuePair<string, string>("公司地址", result.accidentcompanyaddr));
                list.Add(new KeyValuePair<string, string>("工程名称", result.accidentnenginename));
                list.Add(new KeyValuePair<string, string>("工程地址", result.accidentnenginenaddr));
                list.Add(new KeyValuePair<string, string>("设备名称", result.accidentgoodsname));
                list.Add(new KeyValuePair<string, string>("设备型号", result.accidentgoodstype));
                list.Add(new KeyValuePair<string, string>("申请类型", result.accidenttype));
                list.Add(new KeyValuePair<string, string>("事故情况描述", result.accidentdescription));
                list.Add(new KeyValuePair<string, string>("事故发生时间", MVCTools.DateTimeConvertToString(result.accidentoccurrencetime)));
                list.Add(new KeyValuePair<string, string>("联系人", result.accidentlinkname));
                list.Add(new KeyValuePair<string, string>("联系电话", result.accidentlinktel));
                list.Add(new KeyValuePair<string, string>("邮箱", result.accidentemail));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
