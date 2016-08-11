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
    public class faulttypeController : BaseController
    {
        public ActionResult Index(string id,bool? isPinPai)
        {
            ViewBag.pid = id;
            ViewBag.toolbar = "yes";
            ViewBag.isPinPai = isPinPai;
            return View();
        }
        public JsonResult GetData(string id)
        {
            int total;  //记录总条数                                                                     
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典            
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小                      
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码                      
                if (pageIndex < 1) pageIndex = 1;
                string typename = Request["typename"] == null ? string.Empty : Request["typename"].ToString();
                string description = Request["description"] == null ? string.Empty : Request["description"].ToString();
                var x = DB.Instant.FaultTypeManager.Where(a => true).ToList();
                var data = x.Where(a => 
                    (string.IsNullOrEmpty(typename) ? true : a.typename.IndexOf(typename) > -1)
                    && (string.IsNullOrEmpty(description) ? true : a.description.IndexOf(description) > -1)
                    && (string.IsNullOrEmpty(id) ? string.IsNullOrEmpty(a.pid) : a.pid == id)                   
                    ).Select(a => new
                {
                    a.pid,
                    a.typeid,
                    a.typename,
                    a.sort,
                    a.description,
                });
                total = data.Count();
                var list = data.OrderBy(a => a.typeid).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                if (!string.IsNullOrEmpty(id))
                {
                    var pname = string.Empty;
                    var plist = DB.Instant.FaultTypeManager.First(a => a.typeid == id);
                    if (plist != null)
                    {
                        pname = plist.typename;
                    }
                    var list2 = list.Select(a => new
                    {
                        pid = pname,
                        a.typeid,
                        a.typename,
                        a.sort,
                        a.description,
                    });
                    result.Add("rows", list2);
                }
                else
                {
                    result.Add("rows", list);
                }
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(string id)
        {
            var data = DB.Instant.FaultTypeManager.Where(a => a.typeid == id).ToList().Select(a => new
            {
                a.pid,
                a.typeid,
                a.typename,
                a.sort,
                a.description,
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(string id,string isPinPai, FormCollection form,HttpPostedFileBase typelogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (typelogo != null && typelogo.ContentLength > 1)
            {
                var root = "/fileupload/fault/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(typelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new faulttype();
            MVCTools.SetValueFormToModel(t, form);
            t.typeid = Guid.NewGuid().ToString();
            if (string.IsNullOrEmpty(isPinPai))
            {
                t.isPinPai = false;
            }
            else
            {
                t.isPinPai = true;
            }
            if (string.IsNullOrEmpty(id) == false)
            {
                t.pid = id;
            }

            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.typelogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var r = DB.Instant.FaultTypeManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form,HttpPostedFileBase typelogo)
        {
            var t = DB.Instant.FaultTypeManager.Find(id);
            var x = t.isPinPai;
            var logo = t.typelogo;
            IAOPResult rx = null;
            //上传文件
            if (typelogo != null && typelogo.ContentLength > 1)
            {
                var root = "/fileupload/fault/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(typelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            MVCTools.SetValueFormToModel(t, form);
            t.isPinPai = x;
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.typelogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            else
            {
                t.typelogo = logo;
            }
            var r = DB.Instant.FaultTypeManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<faulttype> us = new List<faulttype>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new faulttype() { typeid = item });
            }
            #region 检查是否有子类或故障对应，有则提示不能删除
            var child = DB.Instant.FaultTypeManager.Where(a => ids.Contains(a.pid)).Any();
            if (child == true)
            {
                return Json(new AOPResult(-1, "存在子类，不允许删除"), "text/html");
            }
            var goods = DB.Instant.FaultManager.Where(a => ids.Contains(a.type1) || ids.Contains(a.type2)).Any();
            if (goods == true)
            {
                return Json(new AOPResult(-1, "类别下存在故障信息，不允许删除"), "text/html");
            }
            #endregion
            var r = DB.Instant.FaultTypeManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.FaultTypeManager.Where(a => a.typeid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("类型名称", result.typename));
                list.Add(new KeyValuePair<string, string>("类型logo",string.Format("<img src='{0}' class='img'/>", result.typelogo)));
                list.Add(new KeyValuePair<string, string>("排序", MVCTools.ConvertToString(result.sort)));
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
