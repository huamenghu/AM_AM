using MFXinY.Common;
using AM.BLL;
using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class AuthUserController : BaseController
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
            var t = new AuthUser();
            MVCTools.SetValueFormToModel(t, form);
            t.OperateTime = DateTime.Now;
            t.IsInner = false;
            t.Operator = UserName;
            if (!string.IsNullOrEmpty(form.Get("Password")))
            {
                t.Password = SecurityTools.MD5Encrypt(form.Get("Password"));
            }
            else
            {
                t.Password = SecurityTools.MD5Encrypt(DataStore.DefaultPassword);
            }
            //检查用户名与编号是否有重复
            IAOPResult r = null;
            var check1 = DB.AuthUserManager.Count(a => a.UserName == t.UserName || a.UserNo == t.UserNo);
            if (check1 > 0)
            {
                r = new AOPResult(-1, "用户名或编号重复，请检查");
            }
            else
            {
                r = DB.AuthUserManager.Add(t);
            }
            //AddLog(r, EnumLogType.UserManager.ToString(), "添加", "AuthUser", t.UserName);
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
            IAOPResult r = null;
            var t = DB.AuthUserManager.Find(id);
            var pp = t.Password;
            MVCTools.SetValueFormToModel(t, form);
            t.OperateTime = DateTime.Now;
            t.Operator = UserName;
            if (!string.IsNullOrEmpty(form.Get("Password")))
            {
                if (string.IsNullOrEmpty(form.Get("Password2")))
                {
                    r = new AOPResult(-1, "请输入确认密码！");
                }
                else
                {
                    var isAdmin = DB.AuthUserManager.IsAdministrator(UserName);
                    if (isAdmin)
                    {
                        t.Password = SecurityTools.MD5Encrypt(form.Get("Password"));
                    }
                    else
                    {
                        return Json(new AOPResult(-2, "只有超级管理员可以修改用户密码"), "text/html"); 
                    }
                }
            }
            else
            {
                t.Password = pp;  //设回原密码
            }
            if (r == null)
            {
                r = DB.AuthUserManager.Update(t);
                //AddLog(r, EnumLogType.UserManager.ToString(), "修改", "AuthUser", t.UserName);
            }
            return Json(r, "text/html");
        }

        #region 加载数据列表
        /// <summary>
        /// 加载用户列表
        /// </summary>
        /// <returns></returns>
        public JsonResult LoadData(string id)
        {
            //if (id == "undefined") id = null;
            int total;  //记录总条数
            int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
            int pageIndex = int.Parse(Request["page"].ToString()); //当前页码
            var sort = Request["sort"].ToString();                 //排序字段
            var order = Request["order"].ToString();               //正序还是倒序"asc"或"desc"
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典
            if (pageIndex < 1) pageIndex = 1;

            var list = DB.AuthUserManager.Search(pageIndex, pageSize, out total, sort, order, null, null, UserName, id);
            result.Add("rows", list);
            result.Add("total", total);
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

            var list = DB.AuthUserManager.Search(pageIndex, pageSize, out total, sort, order, keyword, isAvailable, UserName, null);
            result.Add("rows", list);
            result.Add("total", total);
            return Json(result);
        }

        /// <summary>
        /// 填充表单
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public JsonResult FillForm(string id)
        {
            var user = DataStore.User.Where(a => a.UserName == id).Select(a => new
            {
                a.UserName,
                a.UserNo,
                a.RealName,
                a.OperateTime,
                a.IsAvailable,
                a.IsInner,
                a.Sequence,
               
                a.Remark,
                

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
            List<AuthUser> us = new List<AuthUser>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new AuthUser() { UserName = item });
            }
            var r = DB.AuthUserManager.Delete(us);
           // AddLog(r, EnumLogType.UserManager.ToString(), "删除", "AuthUser", null, "删除主键列表：" + id);
            return Json(r, "text/html");
        }
        /// <summary>
        /// 加载角色
        /// </summary>
        /// <returns></returns>
        public JsonResult LoadRole()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典         
            var list = DataStore.Role.Where(a => a.IsAvailable == true && a.Operator == UserName).Select(a => new
            {
                a.RoleName,
                a.Title,
                a.Description
            }).ToList();
            result.Add("rows", list);
            result.Add("total", list.Count);
            return Json(result);
        }
        /// <summary>
        /// 得到角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetRole(string id)
        {
            return Json(DataStore.UserRole.Where(a => a.UserName == id).Select(a => a.RoleName).ToArray());
        }
        /// <summary>
        /// 设置角色对应
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles"></param>
        /// <returns></returns>

        public JsonResult SetRole(string id, string roles)
        {
            var r = DB.AuthUserManager.SetRole(id, roles, UserName);
            //AddLog(r, EnumLogType.UserManager.ToString(), "设置角色", "AuthUserRole", null, string.Format("User:{0} Roles:{1}", id, roles));
            return Json(r, "text/html");
        }
        #endregion

        #region 设置权限
        public JsonResult GetPermission(string id)
        {
            var ztree = DB.AuthUserManager.GetPermissionTree(id, UserName);
            return Json(ztree);
        }

        public JsonResult SetPermission(string id, string ids)
        {
            var r = DB.AuthUserManager.SetPermission(id, ids, UserName);
            //AddLog(r, EnumLogType.RoleManager.ToString(), "设置权限", "AuthUserRole", null, string.Format("Role:{0} Permissions:{1}", id, ids));
            return Json(r, "text/html");
        }
        #endregion

        #region 根据职务查人员列表
         
        public JsonResult GetList(string q)
        {
            var list = DataStore.User.Where(a => (string.IsNullOrEmpty(q) ? true : (a.RealName.IndexOf(q) > -1 || a.UserName.IndexOf(q) > -1))
                && a.IsAvailable == true).Select(a => new
            {
                a.UserName,
                a.UserNo,
                a.Sequence,
                a.RealName,
               
            }).OrderBy(a => a.Sequence);
            return Json(list);
        }
        #endregion
        
        /// <summary>
        /// 根据角色查人
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public JsonResult GetListByRole(string roleName, string q)
        {
            int count = 0;
            var list = DB.AuthUserManager.GetUserByRole(roleName, q, out count);
            return Json(list);
        }
        [OutputCache(Duration = 2000)]
        public JsonResult GetListDBLD(string q)
        {
            return GetListByRole("DBLD", q);
        }
        [OutputCache(Duration = 2000)]
        public JsonResult GetListKJDB(string q)
        {
            return GetListByRole("KJDB", q);
        }
        public JsonResult GetListDBLD_KJDB(string q)
        {
            int count = 0;
            var list = DB.AuthUserManager.GetUserByRole("DBLD", q, out count, "KJDB");
            return Json(list);
        }
        public JsonResult GetTest(string q)
        {
            List<AuthUser> list = new List<AuthUser>();
            list.Add(new AuthUser() { UserName = "1", UserNo = "2", RealName = "3" });
            list.Add(new AuthUser() { UserName = "11", UserNo = "12", RealName = "13" });
            return Json(list);
        }

          
    }
}
