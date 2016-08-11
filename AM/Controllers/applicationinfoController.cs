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
    public class applicationinfoController : BaseController
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

                string applicompanyname = Request["applicompanyname"] == null ? string.Empty : Request["applicompanyname"].ToString();
                string applilinktel = Request["applilinktel"] == null ? string.Empty : Request["applilinktel"].ToString();
                string appliorganizationcode = Request["appliorganizationcode"] == null ? string.Empty : Request["appliorganizationcode"].ToString();
                string appliqualificationtypeid = Request["appliqualificationtypeid"] == null ? string.Empty : Request["appliqualificationtypeid"].ToString();
                string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

                var data = from a in DB.Instant.ApplicationinfoManager.Where(a => (string.IsNullOrEmpty(applicompanyname) ? true : a.applicompanyname.IndexOf(applicompanyname) > -1)
                     && (string.IsNullOrEmpty(applilinktel) ? true : a.applilinktel.IndexOf(applilinktel) > -1)
                     && (string.IsNullOrEmpty(appliorganizationcode) ? true : a.appliorganizationcode.IndexOf(appliorganizationcode) > -1)
                     && (string.IsNullOrEmpty(appliqualificationtypeid) ? true : a.appliqualificationtypeid.IndexOf(appliqualificationtypeid) > -1)
                     && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1))
                           join b in DB.Instant.QualificationTypeManager.Where(a => true) on a.appliqualificationtypeid equals b.typeid
                           select new
                       {
                           a.GUID,
                           a.applilinkname,
                           a.applilinktel,
                           a.applicompanyname,
                           appliqualificationtypeid = b.typename,
                           ispay = a.ispay == true ? "已支付" : "未支付",
                           state = string.IsNullOrEmpty(a.state) ? "未处理" : a.state,
                       };
                total = data.Count();
                var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(String id)
        {
            var data = DB.Instant.ApplicationinfoManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.applicompanyname,
                a.applicompanyaddr,
                a.applibusinessregistnumber,
                a.appliorganizationcode,
                a.appliregistercapital,
                a.appliemployer,
                appliregistrationdate = a.appliregistrationdate == null ? "" : a.appliregistrationdate.Value.ToString("yyyy-MM-dd"),
                a.applieconomytype,
                a.appliqualificationtypeid,
                a.applilinkname,
                a.applilinktel,
                a.appliemail,
                a.ispay,
                a.state
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new applicationinfo();
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
            var r = DB.Instant.ApplicationinfoManager.Add(t);
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
            var t = DB.Instant.ApplicationinfoManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.ApplicationinfoManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<applicationinfo> us = new List<applicationinfo>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new applicationinfo() { GUID = item });
            }
            var r = DB.Instant.ApplicationinfoManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.ApplicationinfoManager.Where(a => a.GUID == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("单位名称", result.applicompanyname));
                list.Add(new KeyValuePair<string, string>("单位地址", result.applicompanyaddr));
                list.Add(new KeyValuePair<string, string>("营业执照号", result.applibusinessregistnumber));
                list.Add(new KeyValuePair<string, string>("组织机构代码", result.appliorganizationcode));
                list.Add(new KeyValuePair<string, string>("注册资金", result.appliregistercapital));
                list.Add(new KeyValuePair<string, string>("工作单位", result.appliemployer));
                list.Add(new KeyValuePair<string, string>("注册日期", result.appliregistrationdate == null ? "" : result.appliregistrationdate.Value.ToString("yyyy年MM月dd日")));
                list.Add(new KeyValuePair<string, string>("经济类型", result.applieconomytype));
                list.Add(new KeyValuePair<string, string>("资质类别", result.appliqualificationtypeid));
                list.Add(new KeyValuePair<string, string>("联系人", result.applilinkname));
                list.Add(new KeyValuePair<string, string>("联系电话", result.applilinktel));
                list.Add(new KeyValuePair<string, string>("邮箱", result.appliemail));
                list.Add(new KeyValuePair<string, string>("状态", result.state));
                list.Add(new KeyValuePair<string, string>("是否支付", result.ispay == true ? "已支付" : "未支付"));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
