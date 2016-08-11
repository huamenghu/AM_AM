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
    public class newsController : BaseController
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
                string newstitle = Request["newstitle"] == null ? string.Empty : Request["newstitle"].ToString();
                string newstype = Request["newstype"] == null ? string.Empty : Request["newstype"].ToString();

                var data = DB.Instant.NewsManager.Where(a => (string.IsNullOrEmpty(newstitle) ? true : a.newstitle.IndexOf(newstitle) > -1)
                    && (string.IsNullOrEmpty(newstype) ? true : a.newstype == newstype)).Select(a => new
                {
                    a.newsid,
                    a.newstitle,
                    a.newssummary,
                    a.newsdate,
                    a.newsistj,
                    a.newstype
                });
                total = data.Count();
                var list = data.OrderByDescending(a => a.newsdate).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.newsid,
                    a.newstitle,
                    a.newssummary,
                    newsdate = a.newsdate.ToString("yyyy-MM-dd"),
                    newsistj = a.newsistj == true ? "是" : "否",
                    newstype = DataStore.NewsType.FirstOrDefault(t => t.typeid == a.newstype) == null ? "" : DataStore.NewsType.FirstOrDefault(t => t.typeid == a.newstype).typename
                });
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(String id)
        {
            var data = DB.Instant.NewsManager.Where(a => a.newsid == id).ToList().Select(a => new
            {
                a.newsid,
                a.newstitle,
                //a.newslogo,
                a.newssummary,
                newsdate = a.newsdate.ToString("yyyy-MM-dd"),
                a.newscontent,
                a.newsistj,
                a.newstype
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Add(FormCollection form, HttpPostedFileBase newslogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (newslogo != null && newslogo.ContentLength > 1)
            {
                var root = "/fileupload/news/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(newslogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new news();
            MVCTools.SetValueFormToModel(t, form);
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.newslogo = rx.ResultDescription;
                    t.newsislogo = true;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            t.newsid = Guid.NewGuid().ToString();
            var r = DB.Instant.NewsManager.Add(t);
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
        public JsonResult Update(string id, FormCollection form, HttpPostedFileBase newslogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (newslogo != null && newslogo.ContentLength > 1)
            {
                var root = "/fileupload/news/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(newslogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }
            var t = DB.Instant.NewsManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            if (rx != null)
            {
                if (rx.IsSuccess)
                {
                    t.newslogo = rx.ResultDescription;
                    t.newsislogo = true;
                }
                else
                {
                    return Json(rx, "text/html");
                }
            }
            var r = DB.Instant.NewsManager.Update(t);
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<news> us = new List<news>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new news() { newsid = item });
            }
            var r = DB.Instant.NewsManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.NewsManager.Where(a => a.newsid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                var newstype = DataStore.NewsType.FirstOrDefault(a => a.typeid == result.newstype);
                list.Add(new KeyValuePair<string, string>("新闻标题", result.newstitle));            
                list.Add(new KeyValuePair<string, string>("新闻类别", newstype == null ? "" : newstype.typename));
                list.Add(new KeyValuePair<string, string>("发布日期", result.newsdate.ToString("yyyy-MM-dd")));
                list.Add(new KeyValuePair<string, string>("预览图", string.Format("<img src='{0}' class='img'/>", result.newslogo)));
                list.Add(new KeyValuePair<string, string>("新闻简介", result.newssummary));
            }
            else
            {
            }
            var r = MVCTools.BuildViewString(list);
            var x = string.Format("{0}<div>新闻内容：{1}</div>", r, result.newscontent);
            return Json(x);
        }
    }
}
