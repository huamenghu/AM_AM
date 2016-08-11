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
    public class testingController : BaseController
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
                string testinglinkname = Request["testinglinkname"] == null ? string.Empty : Request["testinglinkname"].ToString();
                string testingtel = Request["testingtel"] == null ? string.Empty : Request["testingtel"].ToString();
                string testingcontent = Request["testingcontent"] == null ? string.Empty : Request["testingcontent"].ToString();
                string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

                var data = DB.Instant.TestingManager.Where(a => (string.IsNullOrEmpty(testinglinkname) ? true : a.testinglinkname.IndexOf(testinglinkname) > -1)
                    && (string.IsNullOrEmpty(testingtel) ? true : a.testingtel.IndexOf(testingtel) > -1)
                    && (string.IsNullOrEmpty(testingcontent) ? true : a.testingcontent.IndexOf(testingcontent) > -1)
                    && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1)
                    ).Select(a => new
                {
                    a.GUID,
                    a.testinglinkname,
                    a.testingtel,
                    a.testingcontent,
                    ispay = a.ispay == true ? "已支付" : "未支付",
                    state = string.IsNullOrEmpty(a.state) ? "未处理" : a.state,
                });
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
            var data = DB.Instant.TestingManager.Where(a => a.GUID == id).ToList().Select(a => new
            {
                a.GUID,
                a.testingclientcompanyname,
                a.testingclientcompanyaddr,
                a.testinglinkname,
                a.testingtel,
                a.testingengineeringname,
                a.testingengineeringaddr,
                a.testingbuildercompany,
                a.testingconstructioncompany,
                a.testingcontent,
                a.testingsize,
                a.testingepitome,
                a.testingmanufacturer,
                a.testingequipmentnumber,
                a.testingequipmenttype,
                a.testingmountheight,
                a.testingother,
                a.testingtheway,
                a.testingmailing,
                a.ispay,
                a.state
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new testing();
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
            var r = DB.Instant.TestingManager.Add(t);
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
            var t = DB.Instant.TestingManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.TestingManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<testing> us = new List<testing>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new testing() { GUID = item });
            }
            var r = DB.Instant.TestingManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.TestingManager.Where(a => a.GUID == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("委托单位名称", result.testingclientcompanyname));
                list.Add(new KeyValuePair<string, string>("委托单位地址", result.testingclientcompanyaddr));
                list.Add(new KeyValuePair<string, string>("联系人姓名", result.testinglinkname));
                list.Add(new KeyValuePair<string, string>("联系人电话", result.testingtel));
                list.Add(new KeyValuePair<string, string>("工程名称", result.testingengineeringname));
                list.Add(new KeyValuePair<string, string>("工程地址", result.testingengineeringaddr));
                list.Add(new KeyValuePair<string, string>("安装单位", result.testingbuildercompany));
                list.Add(new KeyValuePair<string, string>("施工单位", result.testingconstructioncompany));
                list.Add(new KeyValuePair<string, string>("检测内容", result.testingcontent));
                list.Add(new KeyValuePair<string, string>("检测数量", MVCTools.ConvertToString(result.testingsize)));
                list.Add(new KeyValuePair<string, string>("检验设备概括", result.testingepitome));
                list.Add(new KeyValuePair<string, string>("生产厂家", result.testingmanufacturer));
                list.Add(new KeyValuePair<string, string>("设备编号", result.testingequipmentnumber));
                list.Add(new KeyValuePair<string, string>("设备型号", result.testingequipmenttype));
                list.Add(new KeyValuePair<string, string>("安装高度", result.testingmountheight));
                list.Add(new KeyValuePair<string, string>("其他", result.testingother));
                list.Add(new KeyValuePair<string, string>("取报告方式", result.testingtheway));
                list.Add(new KeyValuePair<string, string>("报告投递至", result.testingmailing));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
