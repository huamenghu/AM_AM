using AM.BLL;
using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class RoleController : BaseController
    {
        [AuthFilter]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加对象
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        
        public JsonResult Add(FormCollection form)
        {
            var t = new AuthRole();
            MVCTools.SetValueFormToModel(t, form);
            t.OperateTime = DateTime.Now;
            t.IsInner = false;
            t.Operator = UserName;
            var r = DB.AuthRoleManager.Add(t);
            //AddLog(r, EnumLogType.RoleManager.ToString(), "添加", "AuthRole", t.RoleName);
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
            var t = DB.AuthRoleManager.Find(id);
            var isInner = t.IsInner;
            MVCTools.SetValueFormToModel(t, form);
            t.OperateTime = DateTime.Now;
            t.Operator = UserName;
            t.IsInner = isInner;
            var r = DB.AuthRoleManager.Update(t);
            //AddLog(r, EnumLogType.RoleManager.ToString(), "修改", "AuthRole", t.RoleName);
            return Json(r, "text/html");
        }
        #region 加载数据列表
        /// <summary>
        /// 加载用户列表
        /// </summary>
        /// <returns></returns>
        public JsonResult LoadData()
        {
            int total;  //记录总条数
            int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
            int pageIndex = int.Parse(Request["page"].ToString()); //当前页码
            if (pageIndex < 1) pageIndex = 1;
            var sort = "Sequence";//Request["sort"].ToString();                 //排序字段
            var order = Request["order"].ToString();               //正序还是倒序"asc"或"desc"
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典

            var list = DB.AuthRoleManager.Search(pageIndex, pageSize, out total, sort, order, null, null, UserName);
            result.Add("rows", list);
            result.Add("total", total);
            return Json(result);
        }

        public JsonResult LoadUser()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典   
            var isAdmin = DB.AuthUserManager.IsAdministrator(UserName);
            var list = DataStore.User.Where(a => a.IsAvailable == true && (isAdmin == true ? true : (a.Operator == UserName || a.UserName == UserName))).Select(a => new
            {
                a.UserName,
                a.UserNo,
                a.Sequence,
               
                a.RealName
            }).OrderBy(a=>a.Sequence).ToList();
            result.Add("rows", list);
            result.Add("total", list.Count);
            return Json(result);
        }
        #endregion

        #region 查询
        /// <summary>
        /// 搜索查询用户
        /// </summary>
        /// <param name="form">查询表单</param>
        /// <returns></returns>
        
        public JsonResult Search(FormCollection form)
        {
            int total;  //记录总条数
            int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
            int pageIndex = int.Parse(Request["page"].ToString()); //当前页码
            var sort = Request["sort"].ToString();                 //排序字段
            var order = Request["order"].ToString();               //正序还是倒序"asc"或"desc"
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典
            string keyword = form.Get("Keyword").Trim().ToString();
            string available = form.Get("IsAvailable");
            bool? isAvailable = null;
            if (!string.IsNullOrEmpty(available))
            {
                isAvailable = Convert.ToBoolean(available);
            }

            var list = DB.AuthRoleManager.Search(pageIndex, pageSize, out total, sort, order, keyword, isAvailable, UserName);
            result.Add("rows", list);
            result.Add("total", total);
            return Json(result);
        }
        #endregion

        #region
        /// <summary>
        /// 填充表单
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public JsonResult FillForm(string id)
        {
            var user = DataStore.Role.Where(a => a.RoleName == id).Select(a => new
            {
                a.RoleName,
                a.Description,
                a.Priority,
                a.Title,
                a.OperateTime,
                a.IsAvailable,
                a.IsInner,
                a.Sequence
            }).FirstOrDefault();
            return Json(user);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        
        public JsonResult Delete(string id)
        {
            List<AuthRole> us = new List<AuthRole>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new AuthRole() { RoleName = item });
            }
            var r = DB.AuthRoleManager.Delete(us);
            //AddLog(r, EnumLogType.RoleManager.ToString(), "删除", "AuthRole", null, "删除主键列表：" + id);
            return Json(r, "text/html");
        }
        #endregion
        /// <summary>
        /// 得到角色对应的用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetUser(string id)
        {
            return Json(DataStore.UserRole.Where(a => a.RoleName == id).Select(a => a.UserName).ToArray());
        }
        /// <summary>
        /// 设置角色对应
        /// </summary>
        /// <param name="id"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        
        public JsonResult SetUser(string id, string users)
        {
            var r = DB.AuthRoleManager.SetUser(id, users, UserName);
            //AddLog(r, EnumLogType.RoleManager.ToString(), "设置对应用户", "AuthUserRole", null, string.Format("Role:{0} Users:{1}", id, users));
            return Json(r, "text/html");
        }

        public JsonResult GetPermission(string id)
        {
            var ztree = DB.AuthRoleManager.GetPermissionTree(id, UserName);
            return Json(ztree);
        }
        
        public JsonResult SetPermission(string id, string ids)
        {
            var r = DB.AuthRoleManager.SetPermission(id, ids, UserName);
            //AddLog(r, EnumLogType.RoleManager.ToString(), "设置权限", "AuthUserRole", null, string.Format("Role:{0} Permissions:{1}", id, ids));
            return Json(r, "text/html");
        }
    }
}
