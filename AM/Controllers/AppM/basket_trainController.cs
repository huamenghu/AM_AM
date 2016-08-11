using Dao;
using AM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using MFXinY.Common;
using System.Data;
using AM.Model;
namespace AM.Controllers
{
    public class basket_trainController : BaseController
    {
        basket_trainBLL btBLL = new basket_trainBLL();
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult GetData()
        //{
        //    int total;  //记录总条数
        //    Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典
        //    try
        //    {
        //        int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
        //        int pageIndex = int.Parse(Request["page"].ToString()); //当前页码
        //        if (pageIndex < 1) pageIndex = 1;
        //        string trainname = Request["trainname"] == null ? string.Empty : Request["trainname"].ToString();
        //        string traintel = Request["traintel"] == null ? string.Empty : Request["traintel"].ToString();
        //        string trainID = Request["trainID"] == null ? string.Empty : Request["trainID"].ToString();
        //        string traintypeid = Request["traintypeid"] == null ? string.Empty : Request["traintypeid"].ToString();
        //        string state = Request["state"] == null ? string.Empty : Request["state"].ToString();

        //        var data = from a in DB.Instant.TrainManager.Where(a => (string.IsNullOrEmpty(trainname) ? true : a.trainname.IndexOf(trainname) > -1)
        //             && (string.IsNullOrEmpty(traintel) ? true : a.traintel.IndexOf(traintel) > -1)
        //             && (string.IsNullOrEmpty(trainID) ? true : a.trainID.IndexOf(trainID) > -1)
        //             && (string.IsNullOrEmpty(traintypeid) ? true : a.traintypeid.IndexOf(traintypeid) > -1)
        //             && (string.IsNullOrEmpty(state) ? true : a.state.IndexOf(state) > -1))
        //                   join b in DB.Instant.TrainTypeManager.Where(a => true) on a.traintypeid equals b.typeid
        //                   select new
        //                   {
        //                       a.GUID,
        //                       a.trainname,
        //                       a.trainlinkname,
        //                       a.traintel,
        //                       traintypeid = b.typename,
        //                       ispay = a.ispay == true ? "已支付" : "未支付",
        //                       state = string.IsNullOrEmpty(a.state) ? "未处理" : a.state,
        //                   };
        //        total = data.Count();
        //        var list = data.OrderBy(a => a.GUID).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();//Skip跳过  
        //        result.Add("rows", list);
        //        result.Add("total", total);
        //        return Json(result);
        //    }
        //    catch { return Json(""); }
        //}

        public JsonResult GetData()
        {
           

            int total;  //记录总条数
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码
                if (pageIndex < 1) pageIndex = 1;
                string trainname = Request["trainname"] == null ? string.Empty : Request["trainname"].ToString();
                //string traintel = Request["traintel"] == null ? string.Empty : Request["traintel"].ToString();
                //string trainID = Request["trainID"] == null ? string.Empty : Request["trainID"].ToString();
                //string traintypeid = Request["traintypeid"] == null ? string.Empty : Request["traintypeid"].ToString();
                //string state = Request["state"] == null ? string.Empty : Request["state"].ToString();
                var whereStr = string.Empty;
                if (!string.IsNullOrEmpty(trainname))
                {
                    whereStr = " xm like '%"+trainname+"%' ";
                }
                int count = 0;
                var list = btBLL.GetListByPage(whereStr, string.Empty, (pageIndex - 1) * pageSize, (pageIndex - 1) * pageSize + pageSize, out count);

                result.Add("rows", list);
                result.Add("total", count);
                return Json(result);
            }
            catch { return Json(""); }
        }


        public JsonResult FillForm(String id)
        {
            var data = btBLL.GetModel(id);
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new basket_train();
            MVCTools.SetValueFormToModel(t, form);
            t.Guid =Guid.NewGuid().ToString();
            t.userid = "admin";
            t.CreateDate = DateTime.Now;
            t.userid = UserName;

            AOPResult r = new AOPResult(0, (btBLL.Add(t).ToString()));
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
            var t = btBLL.GetModel(id);
            MVCTools.SetValueFormToModel(t, form);
            AOPResult r = new AOPResult(0,(btBLL.Update(t).ToString()));
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            AOPResult r = new AOPResult(0, (btBLL.Delete(id).ToString()));
            return Json(r, "text/html");
        }

        #endregion

        public JsonResult ViewResult(string id)
        {
            var result = btBLL.GetModel(id);
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("姓名", result.xm));
                list.Add(new KeyValuePair<string, string>("性别", result.xb));
                list.Add(new KeyValuePair<string, string>("文化程度", result.whcd));
                list.Add(new KeyValuePair<string, string>("联系电话", result.lxdh));
                list.Add(new KeyValuePair<string, string>("专业工龄", result.zygl));
                list.Add(new KeyValuePair<string, string>("身体状况", result.stzk));
                list.Add(new KeyValuePair<string, string>("身份证号", result.sfzh));
                list.Add(new KeyValuePair<string, string>("工作单位", result.gzdw));
                list.Add(new KeyValuePair<string, string>("邮政编码", result.yb));
                list.Add(new KeyValuePair<string, string>("本人签字", result.brqz));
                list.Add(new KeyValuePair<string, string>("培训点", result.pxd));
                list.Add(new KeyValuePair<string, string>("工作经历", result.gzjl));
                list.Add(new KeyValuePair<string, string>("所在单位意见", result.szdwyj));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
    }
}