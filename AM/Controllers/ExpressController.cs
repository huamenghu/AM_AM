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
    public class ExpressController : BaseController
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

                string name = Request["name"] == null ? string.Empty : Request["name"].ToString();
                string code = Request["code"] == null ? string.Empty : Request["code"].ToString();


                var data = from a in DB.ExpressCode.Where(a => (string.IsNullOrEmpty(name) ? true : a.Name.IndexOf(name) > -1)
                     && (string.IsNullOrEmpty(code) ? true : a.Code.IndexOf(code) > -1))

                           select new
                       {
                           a.Code,
                           a.Name,
                           a.Sort
                       };
                total = data.Count();
                var list = data.OrderBy(a => a.Sort).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(string id)
        {
            var data = DB.ExpressCode.Where(a => a.Code == id).ToList().Select(a => new
            {
                a.Code,
                a.Name,
                a.Sort
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new expresscode();
            MVCTools.SetValueFormToModel(t, form);
            var f = DB.ExpressCode.First(a => a.Code == t.Code);
            if (f != null)
            {
                return Json(new AOPResult(-2,"快递编号有重复，请检查"), "text/html");
            }

            var r = DB.ExpressCode.Add(t);
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
            var t = DB.ExpressCode.Find(id);
            var code = t.Code;
            MVCTools.SetValueFormToModel(t, form);
            if (code != t.Code)
            {
                return Json("快递编号不能修改，你可以删除此项，再重新添加新的", "text/html");
            }
            var r = DB.ExpressCode.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<expresscode> us = new List<expresscode>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new expresscode() { Code = item });
            }
            var r = DB.ExpressCode.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.ExpressCode.Where(a => a.Code == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("快递名称", result.Name));
                list.Add(new KeyValuePair<string, string>("快递编码", result.Code));
                list.Add(new KeyValuePair<string, string>("排序", MVCTools.ConvertToString(result.Sort)));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
