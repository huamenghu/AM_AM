using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AM.BLL;

namespace AM.Controllers
{
    public class PermissionController : BaseController
    {
        [AuthFilter]
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult LoadData(string id)
        {
            //组合树
            var list = DataStore.Permission.Where(a => true).Select(a => new
            {
                a.Code,
                a.PCode,
                a.Name,
                a.Sequence
            }).OrderBy(a => a.Sequence);
            List<ZTree> ztree = new List<ZTree>();
            string add = "添加";
            string addicon = "/Content/ZTree/css/zTreeStyle/img/diy/add.gif";
            int i = 99999;

            ztree.Add(new ZTree(i++.ToString(), add, add, null, addicon, i, "add"));

            foreach (var item in list)
            {
                ztree.Add(new ZTree(item.Code, item.Name, item.Name, item.PCode, null, item.Sequence));
                ztree.Add(new ZTree(i++.ToString(), add, item.Name + " 添加", item.Code, addicon, i, "add"));
            }
            //展开结点            
            ztree = ztree.OrderBy(a => a.sort).ToList();
            if (!string.IsNullOrEmpty(id))
            {
                ZTree.ExpandTree(id, ztree);
            }
            return Json(ztree);
        }
        [HttpPost]
        
        public JsonResult Add(FormCollection form)
        {
            var t = new AuthPermission();
            t.OperateTime = DateTime.Now;
            t.Operator = UserName;
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.AuthPermissionManager.Add(t);
            //AddLog(r, EnumLogType.PermissionManager.ToString(), "添加", "AuthPermission", t.Code);
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
            var t = DB.AuthPermissionManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            var r = DB.AuthPermissionManager.Update(t);
            //AddLog(r, EnumLogType.PermissionManager.ToString(), "更新", "AuthPermission", t.Code);
            return Json(r, "text/html");
        }


        [HttpPost]
        public JsonResult FillForm(string id)
        {
            var model = DataStore.Permission.Where(a => a.Code == id).Select(a => new
            {
                a.Code,
                a.Description,
                a.HttpType,
                a.IsAvailable,
                a.IsShow,
                a.Name,
                a.PCode,
                a.Res,
                a.Sequence,
                a.URL
            }).FirstOrDefault();
            return Json(model);
        }

        [HttpPost]
        
        public JsonResult Delete(string id)
        {
            var model = DB.AuthPermissionManager.Find(id);
            var r = DB.AuthPermissionManager.Delete(model);
            //AddLog(r, EnumLogType.PermissionManager.ToString(), "删除", "AuthPermission", null, string.Format("删除主键列表:{0}", id));
            return Json(r, "text/html");
        }
    }
}
