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
    public class goodstypeController : BaseController
    {
        public ActionResult Index(string id,bool? isPinPai)
        {
            ViewBag.pid = id;
            ViewBag.toolbar = "yes";
            ViewBag.isPinPai = isPinPai;
            return View();
        }
        public JsonResult GetData(string id,bool? isPinPai)
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

                var data = DB.Instant.GoodsTypeManager.Where(a => (string.IsNullOrEmpty(typename) ? true : a.typename.IndexOf(typename) > -1)
                    && (string.IsNullOrEmpty(description) ? true : a.description.IndexOf(description) > -1)
                    && (string.IsNullOrEmpty(id) ? string.IsNullOrEmpty(a.pid) : a.pid == id)
                    && (isPinPai==null ? true : a.isPinPai == isPinPai)
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
                    var plist = DB.Instant.GoodsTypeManager.First(a => a.typeid == id);
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
            var data = DB.Instant.GoodsTypeManager.Where(a => a.typeid == id).ToList().Select(a => new
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
        public JsonResult Add(string id, string isPinPai, FormCollection form, HttpPostedFileBase typelogo, HttpPostedFileBase typeadimgurl)
        {
            IAOPResult rx = null;
            IAOPResult rx2 = null;
            //上传文件
            if (typelogo != null && typelogo.ContentLength > 1)
            {
                var root = "/fileupload/goodstype/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(typelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            if (typeadimgurl != null && typeadimgurl.ContentLength > 1)
            {
                var root = "/fileupload/ad/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx2 = MVCTools.UploadFile(typeadimgurl, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new goodstype();
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
            if (rx2 != null)
            {
                if (rx2.IsSuccess)
                {
                    t.typeadimgurl = rx2.ResultDescription;
                }
                else
                {
                    return Json(rx2, "text/html");
                }
            }
            var r = DB.Instant.GoodsTypeManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form, HttpPostedFileBase typelogo, HttpPostedFileBase typeadimgurl)
        {
            var t = DB.Instant.GoodsTypeManager.Find(id);
            var x = t.isPinPai;
            var logo = t.typelogo;
            var adimgurl = t.typeadimgurl;
            IAOPResult rx = null;
            IAOPResult rx2 = null;
            //上传文件
            if (typelogo != null && typelogo.ContentLength > 1)
            {
                var root = "/fileupload/goodstype/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(typelogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            if (typeadimgurl != null && typeadimgurl.ContentLength > 1)
            {
                var root = "/fileupload/ad/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx2 = MVCTools.UploadFile(typeadimgurl, root, 2, fileName, true, DataStore.ImgageTtpe);
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
            if (rx2 != null)
            {
                if (rx2.IsSuccess)
                {
                    t.typeadimgurl = rx2.ResultDescription;
                }
                else
                {
                    return Json(rx2, "text/html");
                }
            }
            else
            {
                t.typeadimgurl = adimgurl;
            }
            var r = DB.Instant.GoodsTypeManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<goodstype> us = new List<goodstype>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new goodstype() { typeid = item });
            }
            #region 检查是否有子类或商品对应，有则提示不能删除
            var child = DB.Instant.GoodsTypeManager.Where(a => ids.Contains(a.pid)).Any();
            if (child == true)
            {
                return Json(new AOPResult(-1, "存在子类，不允许删除"),"text/html");
            }
            var goods = DB.Instant.GoodsManager.Where(a => ids.Contains(a.goodstype) || ids.Contains(a.goodsType2) || ids.Contains(a.goodsPinPai)).Any();
            if (goods == true)
            {
                return Json(new AOPResult(-1, "类别下存在商品，不允许删除"), "text/html");
            }
            #endregion
            var r = DB.Instant.GoodsTypeManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.GoodsTypeManager.Where(a => a.typeid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("类型名称", result.typename));
                list.Add(new KeyValuePair<string, string>("排序", MVCTools.ConvertToString(result.sort)));
                list.Add(new KeyValuePair<string, string>("类型logo",string.Format("<img src='{0}' class='img'/>", result.typelogo)));
                list.Add(new KeyValuePair<string, string>("类别广告", string.Format("<img src='{0}' class='img'/>", result.typeadimgurl)));
               
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
