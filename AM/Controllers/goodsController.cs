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
    public class goodsController : BaseController
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

                string goodsname = Request["goodsname"] == null ? string.Empty : Request["goodsname"].ToString();
                string goodstype = Request["goodstype"] == null ? string.Empty : Request["goodstype"].ToString();
                string goodsType2 = Request["goodsType2"] == null ? string.Empty : Request["goodsType2"].ToString();
                string goodsPinPai = Request["goodsPinPai"] == null ? string.Empty : Request["goodsPinPai"].ToString();
                var istj0 = Request["istj"] == null ? string.Empty : Request["istj"].ToString();
                bool? istj=null;
                if(string.IsNullOrEmpty(istj0)==false){
                    istj=Convert.ToBoolean(istj0);
                }

                var tjs = DB.Instant.RecommendedManager.Where(a => true).ToList();
                var tjids = tjs.Select(a => a.recommendedgoods).ToList();
                var types = DB.Instant.GoodsTypeManager.Where(a => true).Select(a => new { a.typeid, a.typename }).ToList();
                var data = DB.Instant.GoodsManager.Where(a => (string.IsNullOrEmpty(goodsname) ? true : a.goodsname.IndexOf(goodsname) > -1)
                    && (string.IsNullOrEmpty(goodstype) ? true : a.goodstype.IndexOf(goodstype) > -1)
                     && (string.IsNullOrEmpty(goodsType2) ? true : a.goodsType2.IndexOf(goodsType2) > -1)
                      && (string.IsNullOrEmpty(goodsPinPai) ? true : a.goodsPinPai.IndexOf(goodsPinPai) > -1)
                      && (istj==null ? true : (istj==true?tjids.Contains(a.goodsid):!tjids.Contains(a.goodsid)))
                    ).Select(a => new
                {
                    a.goodsid,
                    a.goodsname,
                    a.goodsprice,
                    a.goodstype,
                    a.goodscount,
                    a.goodsType2,
                    a.goodsPinPai,
                    a.goodsdiscountprice,
                    a.goodslogo
                }).OrderBy(a => a.goodsid);
                total = data.Count();


                var skip = pageSize * (pageIndex - 1);
                var list0 = data.Skip(skip).Take(pageSize).ToList();
                var list = list0.Select(a => new
                {
                    a.goodsid,
                    a.goodsname,
                    a.goodsprice,
                    goodstype = (types.FirstOrDefault(t => t.typeid == a.goodstype) == null ? string.Empty : types.FirstOrDefault(t => t.typeid == a.goodstype).typename),
                    goodsType2 = (types.FirstOrDefault(t => t.typeid == a.goodsType2) == null ? string.Empty : types.FirstOrDefault(t => t.typeid == a.goodsType2).typename),
                    goodsPinPai = (types.FirstOrDefault(t => t.typeid == a.goodsPinPai) == null ? string.Empty : types.FirstOrDefault(t => t.typeid == a.goodsPinPai).typename),
                    a.goodscount,
                    a.goodsdiscountprice,
                    a.goodslogo,
                    istj = (tjs.FirstOrDefault(t => t.recommendedgoods == a.goodsid) != null) == true ? "是" : "否"
                });
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(String id)
        {
            var istj = DB.Instant.RecommendedManager.Where(a => true).Any(a => a.recommendedgoods == id);
            var data = DB.Instant.GoodsManager.Where(a => a.goodsid == id).ToList().Select(a => new
            {
                a.goodsid,
                a.goodsname,
                a.goodsprice,
                a.goodstype,
                a.goodscount,
                a.goodscontent,
                a.goodsdiscountprice,
                a.goodsType2,
                a.goodsPinPai,
                istj = istj
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Add(FormCollection form, HttpPostedFileBase goodslogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (goodslogo != null && goodslogo.ContentLength > 1)
            {
                var root = "/fileupload/goods/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(goodslogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            var t = new goods();
            MVCTools.SetValueFormToModel(t, form);
            t.goodsid = Guid.NewGuid().ToString();
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.goodslogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var istj = form.Get("istj");
            if (string.IsNullOrEmpty(istj) == false)
            {
                if (Convert.ToBoolean(istj))
                {
                    var tj = new recommended()
                    {
                        recommendedgoods = t.goodsid,
                        recommendedid = Guid.NewGuid().ToString(),
                        recommendedtype = "Index"
                    };
                    DB.Instant.RecommendedManager.Add(tj);
                }
            }
            t.goodsdiscountprice = t.goodsprice;
            var r = DB.Instant.GoodsManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Update(string id, FormCollection form, HttpPostedFileBase goodslogo)
        {
            var t = DB.Instant.GoodsManager.Find(id);
            var logo = t.goodslogo;
            IAOPResult rx = null;
            //上传文件
            if (goodslogo != null && goodslogo.ContentLength > 1)
            {
                var root = "/fileupload/goods/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(goodslogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            MVCTools.SetValueFormToModel(t, form);
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.goodslogo = rx.ResultDescription;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            else
            {
                t.goodslogo = logo;
            }
            var istj = form.Get("istj");
            if (string.IsNullOrEmpty(istj) == false)
            {
                var any = DB.Instant.RecommendedManager.First(a => a.recommendedgoods == t.goodsid);
                if (Convert.ToBoolean(istj))
                {
                    if (any == null)
                    {
                        var tj = new recommended()
                        {
                            recommendedgoods = t.goodsid,
                            recommendedid = Guid.NewGuid().ToString(),
                            recommendedtype = "Index"
                        };
                        DB.Instant.RecommendedManager.Add(tj);
                    }
                }
                else if (any != null)
                {
                    DB.Instant.RecommendedManager.Delete(any);
                }
            }
            t.goodsdiscountprice = t.goodsprice;
            var r = DB.Instant.GoodsManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<goods> us = new List<goods>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new goods() { goodsid = item });
            }
            DB.Instant.RecommendedManager.Delete(a => ids.Contains(a.recommendedgoods));
            var r = DB.Instant.GoodsManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.GoodsManager.Where(a => a.goodsid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            var types = DB.Instant.GoodsTypeManager.Where(a => true).Select(a => new { a.typeid, a.typename }).ToList();
            if (result != null)
            {
                var goodstype = string.Empty;
                var goodstype2 = string.Empty;
                var goodsPinPai = string.Empty;

                var t1 = types.FirstOrDefault(t => t.typeid == result.goodstype);
                var t2 = types.FirstOrDefault(t => t.typeid == result.goodsType2);
                var t3 = types.FirstOrDefault(t => t.typeid == result.goodsPinPai);
                if (t1 != null) goodstype = t1.typename;
                if (t2 != null) goodstype2 = t2.typename;
                if (t3 != null) goodsPinPai = t3.typename;
                list.Add(new KeyValuePair<string, string>("商品名称", result.goodsname));
                list.Add(new KeyValuePair<string, string>("品牌", goodsPinPai));
                list.Add(new KeyValuePair<string, string>("一级类别", goodstype));
                list.Add(new KeyValuePair<string, string>("二级类别", goodstype2));
                list.Add(new KeyValuePair<string, string>("价格", MVCTools.ConvertToString(result.goodsprice) + "元"));
                list.Add(new KeyValuePair<string, string>("折后价格", MVCTools.ConvertToString(result.goodsdiscountprice + "元")));
                list.Add(new KeyValuePair<string, string>("商品数量", MVCTools.ConvertToString(result.goodscount)));
                //list.Add(new KeyValuePair<string, string>("商品logo", result.goodslogo));
                //list.Add(new KeyValuePair<string, string>("描述", result.goodscontent));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            StringBuilder sb = new StringBuilder();
            sb.Append(r);
            sb.AppendFormat("<div class='divlogo'>商品Logo：<img src='{0}' class='logo' /><div>", result.goodslogo);
            sb.AppendFormat("<div>商品描述：{0}</div>", result.goodscontent);
            return Json(sb.ToString());
        }
    }
}
