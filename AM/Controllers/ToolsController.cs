using AM.BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AM.Controllers
{
    public class ToolsController : Controller
    {
        #region 测试
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region 培训工种 下拉
        public JsonResult GetTrainType()
        {
            var list = DB.Instant.TrainTypeManager.Where(a => true).Select(a => new
            {
                ID = a.typeid,
                Name = a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetTrainType2()
        {
            var list = DB.Instant.TrainTypeManager.Where(a => true).Select(a => new
            {
                ID = a.typeid,
                Name = a.typename
            }).ToList();
            list.Insert(0, new { ID = "", Name = "不限" });
            return Json(list);
        }
        #endregion

        #region 资质类别 下拉
        public JsonResult GetQualificationType()
        {
            var list = DB.Instant.QualificationTypeManager.Where(a => true).Select(a => new
            {
                ID = a.typeid,
                Name = a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetQualificationType2()
        {
            var list = DB.Instant.QualificationTypeManager.Where(a => true).Select(a => new
            {
                ID = a.typeid,
                Name = a.typename
            }).ToList();
            list.Insert(0, new { ID = "", Name = "不限" });
            return Json(list);
        }
        #endregion

        #region 处理状态
        public JsonResult GetState()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("未处理", "未处理"));
            list.Add(new KeyValuePair<string, string>("已处理", "已处理"));

            return Json(list.Select(a => new { Key = a.Key, Value = a.Value }));
        }
        public JsonResult GetState2()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("", "不限"));
            list.Add(new KeyValuePair<string, string>("未处理", "未处理"));
            list.Add(new KeyValuePair<string, string>("已处理", "已处理"));

            return Json(list.Select(a => new { Key = a.Key, Value = a.Value }));
        }
        #endregion

        #region 商品类别
        public JsonResult GetGoodsType()
        {
            var list = DB.Instant.GoodsTypeManager.Where(a => string.IsNullOrEmpty(a.pid)).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetGoodsType_()
        {
            var list = DB.Instant.GoodsTypeManager.Where(a => string.IsNullOrEmpty(a.pid)).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            list.Insert(0, new { typeid = string.Empty, typename = "不限" });
            return Json(list);
        }

        public JsonResult GetGoodsType2(string id)
        {
            var list = DB.Instant.GoodsTypeManager.Where(a => a.pid == id && a.isPinPai != true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetGoodsType2_(string id)
        {
            var list = DB.Instant.GoodsTypeManager.Where(a => a.pid == id && a.isPinPai != true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            list.Insert(0, new { typeid = string.Empty, typename = "不限" });
            return Json(list);
        }

        public JsonResult GetGoodsPinPai(string id)
        {
            var list = DB.Instant.GoodsTypeManager.Where(a => a.pid == id && a.isPinPai == true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetGoodsPinPai_(string id)
        {
            var list = DB.Instant.GoodsTypeManager.Where(a => a.pid == id && a.isPinPai == true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            list.Insert(0, new { typeid = string.Empty, typename = "不限" });
            return Json(list);
        }
        #endregion

        #region 故障类别
        public JsonResult GetFaultType()
        {
            var list = DB.Instant.FaultTypeManager.Where(a => string.IsNullOrEmpty(a.pid)).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetFaultType_()
        {
            var list = DB.Instant.FaultTypeManager.Where(a => string.IsNullOrEmpty(a.pid)).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            list.Insert(0, new { typeid = string.Empty, typename = "不限" });
            return Json(list);
        }

        public JsonResult GetFaultType2(string id)
        {
            var list = DB.Instant.FaultTypeManager.Where(a => a.pid == id && a.isPinPai != true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetFaultType2_(string id)
        {
            var list = DB.Instant.FaultTypeManager.Where(a => a.pid == id && a.isPinPai != true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            list.Insert(0, new { typeid = string.Empty, typename = "不限" });
            return Json(list);
        }
         
        #endregion

        #region 新闻类别
        public JsonResult GetNewsType()
        {
            var list = DB.Instant.NewsTypeManager.Where(a => true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            return Json(list);
        }
        public JsonResult GetNewsType_()
        {
            var list = DB.Instant.NewsTypeManager.Where(a => true).Select(a => new
            {
                a.typeid,
                a.typename
            }).ToList();
            list.Insert(0, new { typeid = string.Empty, typename = "不限" });
            return Json(list);
        }       

        #endregion

        public ActionResult TestE()
        {
           // var r = DB.Express.Search("210997814810", "baishihuitong");
           //var serializer = new JavaScriptSerializer();
           //var ret = serializer.Deserialize<KuaiDi100>(r);
           //var x = Json( r);
            var log = DB.log;
            if (log.IsInfoEnabled)
            {
                string msg = "提示：" + "success:2331" ;

                log.Info(msg);
            }
            return View();
        }


    }
}
