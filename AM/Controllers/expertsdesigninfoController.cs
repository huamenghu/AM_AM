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
    public class expertsdesigninfoController : BaseController
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

                string designcompanyname = Request["designcompanyname"] == null ? string.Empty : Request["designcompanyname"].ToString();
                string designlinkname = Request["designlinkname"] == null ? string.Empty : Request["designlinkname"].ToString();
                string designlinktel = Request["designlinktel"] == null ? string.Empty : Request["designlinktel"].ToString();
                string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

                var data = DB.Instant.ExpertsdesigninfoManager.Where(a => (string.IsNullOrEmpty(designcompanyname) ? true : a.designcompanyname.IndexOf(designcompanyname) > -1)
                    && (string.IsNullOrEmpty(designlinkname) ? true : a.designlinkname.IndexOf(designlinkname) > -1)
                    && (string.IsNullOrEmpty(designlinktel) ? true : a.designlinktel.IndexOf(designlinktel) > -1)
                     && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1)
                    ).Select(a => new
                {
                    a.GUID,
                    a.designlinkname,
                    a.designlinktel,
                    a.designcompanyname,
                    a.designapplicationdate,
                    ispay = a.ispay == true ? "已支付" : "未支付",
                    a.state,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.GUID,
                    a.designlinkname,
                    a.designlinktel,
                    a.designcompanyname,
                    designapplicationdate = MVCTools.DateTimeConvertToString(a.designapplicationdate),
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
            var data = DB.Instant.ExpertsdesigninfoManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.designcompanyname,
                a.designcompanyaddr,
                a.designenginename,
                a.designengineaddr,
                a.designgoodsname,
                a.designgoodstype,
                a.designtechnologyrequest,
                designcompletedate = MVCTools.DateTimeConvertToString(a.designcompletedate),
                designapplicationdate = MVCTools.DateTimeConvertToString(a.designapplicationdate),
                a.designlinkname,
                a.designlinktel,
                a.designemail,
                a.ispay,
                a.state
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new expertsdesigninfo();
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
            var r = DB.Instant.ExpertsdesigninfoManager.Add(t);
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
            var t = DB.Instant.ExpertsdesigninfoManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.ExpertsdesigninfoManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<expertsdesigninfo> us = new List<expertsdesigninfo>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new expertsdesigninfo() { GUID = item });
            }
            var r = DB.Instant.ExpertsdesigninfoManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.ExpertsdesigninfoManager.Where(a => a.GUID == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("公司名称", result.designcompanyname));
                list.Add(new KeyValuePair<string, string>("公司地址", result.designcompanyaddr));
                list.Add(new KeyValuePair<string, string>("工程名称", result.designenginename));
                list.Add(new KeyValuePair<string, string>("工程地址", result.designengineaddr));
                list.Add(new KeyValuePair<string, string>("产品名称", result.designgoodsname));
                list.Add(new KeyValuePair<string, string>("产品型号", result.designgoodstype));
                list.Add(new KeyValuePair<string, string>("技术要求", result.designtechnologyrequest));
                list.Add(new KeyValuePair<string, string>("完成时间", MVCTools.DateTimeConvertToString(result.designcompletedate)));
                list.Add(new KeyValuePair<string, string>("申请时间", MVCTools.DateTimeConvertToString(result.designapplicationdate, "yyyy-MM-dd")));
                list.Add(new KeyValuePair<string, string>("联系人", result.designlinkname));
                list.Add(new KeyValuePair<string, string>("联系电话", result.designlinktel));
                list.Add(new KeyValuePair<string, string>("邮箱", result.designemail));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
