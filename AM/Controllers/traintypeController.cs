﻿using Dao;
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
    public class traintypeController : BaseController
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
                string typename = Request["typename"] == null ? string.Empty : Request["typename"].ToString();

                var data = DB.Instant.TrainTypeManager.Where(a => (string.IsNullOrEmpty(typename) ? true : a.typename.IndexOf(typename) > -1)
                    ).Select(a => new
                {
                    a.typeid,
                    a.typename,
                    a.sort,
                    a.description,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.typeid).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(string id)
        {
            var data = DB.Instant.TrainTypeManager.Where(a => a.typeid == id).ToList().Select(a => new
            {
                a.typeid,
                a.typename,
                a.sort,
                a.description,
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new traintype();
            MVCTools.SetValueFormToModel(t, form);
            t.typeid = Guid.NewGuid().ToString();
            var r = DB.Instant.TrainTypeManager.Add(t);
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
            var t = DB.Instant.TrainTypeManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.Instant.TrainTypeManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<traintype> us = new List<traintype>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new traintype() { typeid = item });
            }
            #region 检查是否有子类或商品对应，有则提示不能删除
            
            var goods = DB.Instant.TrainManager.Where(a => ids.Contains(a.traintypeid)).Any();
            if (goods == true)
            {
                return Json(new AOPResult(-1, "类别下存在培训申请信息，不允许删除"), "text/html");
            }
            #endregion
            var r = DB.Instant.TrainTypeManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.TrainTypeManager.Where(a => a.typeid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("类别名", result.typename));
                list.Add(new KeyValuePair<string, string>("排序", result.sort.ToString()));
                list.Add(new KeyValuePair<string, string>("描述", result.description));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}
