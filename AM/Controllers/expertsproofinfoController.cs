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
    public class expertsproofinfoController : BaseController
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

                string proofemail = Request["proofemail"] == null ? string.Empty : Request["proofemail"].ToString();
                string prooflinkname = Request["prooflinkname"] == null ? string.Empty : Request["prooflinkname"].ToString();
                string prooflinktel = Request["prooflinktel"] == null ? string.Empty : Request["prooflinktel"].ToString();
                string prooftype = Request["prooftype"] == null ? string.Empty : Request["prooftype"].ToString();
                string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

                var data = DB.Instant.ExpertsproofinfoManager.Where(a => (string.IsNullOrEmpty(proofemail) ? true : a.proofemail.IndexOf(proofemail) > -1)
                    && (string.IsNullOrEmpty(prooflinkname) ? true : a.prooflinkname.IndexOf(prooflinkname) > -1)
                    && (string.IsNullOrEmpty(prooflinktel) ? true : a.prooflinktel.IndexOf(prooflinktel) > -1)
                    && (string.IsNullOrEmpty(prooftype) ? true : a.prooftype.IndexOf(prooftype) > -1)
                    && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1)
                    ).Select(a => new
                {
                    a.GUID,
                    a.prooflinkname,
                    a.prooflinktel,
                    a.proofcompanyname,
                    a.proofapplicationdate,
                    ispay = a.ispay == true ? "已支付" : "未支付",
                    a.state,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.GUID,
                    a.prooflinkname,
                    a.prooflinktel,
                    a.proofcompanyname,
                    proofapplicationdate = MVCTools.DateTimeConvertToString(a.proofapplicationdate),
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
            var data = DB.Instant.ExpertsproofinfoManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.proofcompanyname,
                a.proofcompanyaddr,
                a.proofnenginename,
                a.proofnengineaddr,
                a.proofdesigncompany,
                a.proofgoodsname,
                a.proofgoodstype,
                a.prooftype,
                proofplandate = MVCTools.DateTimeConvertToString(a.proofplandate),
                proofapplicationdate = MVCTools.DateTimeConvertToString(a.proofapplicationdate),
                a.prooflinkname,
                a.prooflinktel,
                a.proofemail,
                a.ispay,
                a.state
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new expertsproofinfo();
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
            var r = DB.Instant.ExpertsproofinfoManager.Add(t);
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
            var t = DB.Instant.ExpertsproofinfoManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.ExpertsproofinfoManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<expertsproofinfo> us = new List<expertsproofinfo>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new expertsproofinfo() { GUID = item });
            }
            var r = DB.Instant.ExpertsproofinfoManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.ExpertsproofinfoManager.Where(a => a.GUID == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("公司名称", result.proofcompanyname));
                list.Add(new KeyValuePair<string, string>("公司地址", result.proofcompanyaddr));
                list.Add(new KeyValuePair<string, string>("工程名称", result.proofnenginename));
                list.Add(new KeyValuePair<string, string>("工程地址", result.proofnengineaddr));
                list.Add(new KeyValuePair<string, string>("方案设计单位", result.proofdesigncompany));
                list.Add(new KeyValuePair<string, string>("产品名称", result.proofgoodsname));
                list.Add(new KeyValuePair<string, string>("产品型号", result.proofgoodstype));
                list.Add(new KeyValuePair<string, string>("方案类型", result.prooftype));
                list.Add(new KeyValuePair<string, string>("计划论证时间", MVCTools.DateTimeConvertToString(result.proofplandate)));
                list.Add(new KeyValuePair<string, string>("申请时间", MVCTools.DateTimeConvertToString(result.proofapplicationdate)));
                list.Add(new KeyValuePair<string, string>("联系人", result.prooflinkname));
                list.Add(new KeyValuePair<string, string>("联系电话", result.prooflinktel));
                list.Add(new KeyValuePair<string, string>("邮箱", result.proofemail));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
