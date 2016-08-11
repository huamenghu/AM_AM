using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFXinY.EF;
using MFXinY.Common;
using System.Collections;
using Dao;
using System.Threading.Tasks;

namespace AM.BLL
{
    public class AuthUserManager : MFXinYEFBase<AuthUser>
    {
        #region 重写添加，删除方法
        public override IAOPResult Add(AuthUser model)
        {
            var r = base.Add(model);
            //刷新静态数据
            //Task t=new Task(new Action( {
            DataStore.RefreshUser();

            return r;
        }
        public override IAOPResult Update(AuthUser model)
        {
            var r = base.Update(model);
            //刷新静态数据
            DataStore.RefreshUser();
            return r;
        }
        public override IAOPResult Delete(List<AuthUser> list)
        {
            try
            {
                using (var db = new amEntities())
                {
                    //先删除userrole表里数据，用户权限对应表，安监三汇报、领导三汇报、
                    var usernames = list.Select(a => a.UserName).ToArray();
                    //是否是内置用户
                    if (db.AuthUser.Any(a => usernames.Contains(a.UserName) && a.IsInner == true))
                    {
                        return new AOPResult(-1, "内置用户不允许删除");
                    }
                    var userrole = from a in db.AuthUserRole join b in db.AuthUser on a.UserName equals b.UserName where usernames.Contains(b.UserName) select a;
                    var userPer = from a in db.AuthUserPermission join b in db.AuthUser on a.UserName equals b.UserName where usernames.Contains(b.UserName) select a;

                    foreach (var item in userrole)
                    {
                        db.Set<AuthUserRole>().Attach(item);
                        db.Entry<AuthUserRole>(item).State = System.Data.EntityState.Deleted;
                    }
                    foreach (var item in userPer)
                    {
                        db.Set<AuthUserPermission>().Attach(item);
                        db.Entry<AuthUserPermission>(item).State = System.Data.EntityState.Deleted;
                    }

                    foreach (var item in list)
                    {
                        db.Set<AuthUser>().Attach(item);
                        db.Entry<AuthUser>(item).State = System.Data.EntityState.Deleted;
                    }
                    db.SaveChanges();
                    //刷新静态数据
                    DataStore.RefreshUserRole();
                    DataStore.RefreshUser();
                    return new AOPResult(0);
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        #endregion
        /// <summary>
        /// 验证用户名 密码是否正确
        /// </summary>
        /// <param name="userName">用户名或编号</param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IAOPResult ValidUser(string userName, string password, out string uName)
        {
            uName = userName;
            var user = DataStore.User.FirstOrDefault(a => a.UserName == userName);
            if (user == null)
            {
                user = DataStore.User.FirstOrDefault(a => a.UserNo == userName);
                if (user != null)
                {
                    uName = user.UserName;
                }
            }
            if (user != null)
            {
                if (user.IsAvailable == false)
                {
                    return new AOPResult(-1, "该用户已经停用！");
                }
                if (user.Password != null && user.Password.ToUpper() == SecurityTools.MD5Encrypt(password).ToUpper())
                {
                    return new AOPResult(0, "登录成功");
                }
                else
                {
                    return new AOPResult(-2, "用户名(用户编号)或密码错误！");
                }
            }
            else
            {
                return new AOPResult(-2, "用户名(用户编号)或密码错误！");
            }
        }

        /// <summary>
        /// 搜索查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="keyword"></param>
        /// <param name="isAvailable"></param>
        /// <returns></returns>
        public IEnumerable Search(int pageIndex, int pageSize, out int total, string sort, string order, string keyword, bool? isAvailable, string userName, string department)
        {
            if (pageIndex < 1) pageIndex = 1;
            var isAdmin = IsAdministrator(userName);

            var users = DataStore.User.Where(a =>
                (string.IsNullOrEmpty(keyword) ? true : (a.UserName.IndexOf(keyword) > -1
                 || (a.RealName == null ? false : a.RealName.IndexOf(keyword) > -1))) &&
               (isAvailable == null ? true : a.IsAvailable == isAvailable))
               .Select(a => new
               {
                   IsAvailable = a.IsAvailable == true ? "正常" : "停用",
                   IsInner = a.IsInner == true ? "是" : "否",
                   a.OperateTime,
                   a.Operator,
                   a.RealName,
                   a.Sequence,
                   a.UserName,
                   a.UserNo,
                   a.Remark,
               }).OrderBy(a => a.Sequence);
            total = users.Count();
            #region 排序
            if (order != "desc")
            {
                switch (sort)
                {
                    case "RealName":
                        users = users.OrderBy(a => a.RealName);
                        break;
                    case "UserName":
                        users = users.OrderBy(a => a.UserName);
                        break;
                    case "Sequence":
                        users = users.OrderBy(a => a.Sequence);
                        break;
                    case "IsInner":
                        users = users.OrderBy(a => a.IsInner);
                        break;
                    case "IsAvailable":
                        users = users.OrderBy(a => a.IsAvailable);
                        break;
                    case "UserNo":
                        users = users.OrderBy(a => a.UserNo);
                        break;

                    default:
                        users = users.OrderBy(a => a.Sequence);
                        break;
                }
                var list = users.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                return list;
            }
            else
            {
                switch (sort)
                {
                    case "RealName":
                        users = users.OrderByDescending(a => a.RealName);
                        break;
                    case "UserName":
                        users = users.OrderByDescending(a => a.UserName);
                        break;
                    case "Sequence":
                        users = users.OrderByDescending(a => a.Sequence);
                        break;
                    case "IsInner":
                        users = users.OrderByDescending(a => a.IsInner);
                        break;
                    case "IsAvailable":
                        users = users.OrderByDescending(a => a.IsAvailable);
                        break;
                    case "UserNo":
                        users = users.OrderByDescending(a => a.UserNo);
                        break;

                    default:
                        users = users.OrderByDescending(a => a.Sequence);
                        break;
                }
                var list = users.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                return list;
            }
            #endregion
        }

        /// <summary>
        /// 是否超级管理员
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsAdministrator(string userName)
        {
            var count = DataStore.UserRole.Count(a => a.UserName == userName && a.RoleName == DataStore.AdminRole);
            return count > 0;
        }

        /// <summary>
        /// 给用户设置角色
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles"></param>
        /// <returns></returns>
        public IAOPResult SetRole(string username, string roles, string user)
        {
            try
            {
                var arr = new string[] { };
                if (!string.IsNullOrEmpty(roles))
                {
                    arr = roles.Split(',');
                }
                using (var db = new amEntities())
                {
                    var ur = db.AuthUserRole.Where(a => a.UserName == username);
                    var del = ur.Where(a => !arr.Contains(a.RoleName));
                    foreach (var item in del)
                    {
                        db.Set<AuthUserRole>().Attach(item);
                        db.Entry<AuthUserRole>(item).State = System.Data.EntityState.Deleted;
                    }
                    foreach (var item in arr)
                    {
                        var aa = ur.FirstOrDefault(a => a.RoleName == item);
                        if (aa != null)
                        {
                            aa.Operator = user;
                            aa.OperateTime = DateTime.Now;
                            db.Set<AuthUserRole>().Attach(aa);
                            db.Entry<AuthUserRole>(aa).State = System.Data.EntityState.Modified;
                        }
                        else
                        {
                            AuthUserRole m = new AuthUserRole() { RoleName = item, UserName = username, OperateTime = DateTime.Now, Operator = user };
                            db.Set<AuthUserRole>().Attach(m);
                            db.Entry<AuthUserRole>(m).State = System.Data.EntityState.Added;
                        }
                    }
                    db.SaveChanges();
                    //刷新静态数据
                    DataStore.RefreshUserRole();
                    DataStore.RefreshUser();
                    return new AOPResult(0);
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        public string GetUserRoleName(string username)
        {
            var result = string.Empty;
            var roleName = DataStore.UserRole.Where(a => a.UserName == username).Select(a => a.RoleName).ToList();
            if (roleName.Any())
            {
                result = roleName.Aggregate((a, b) => a + "," + b);
            }
            return result;
        }

        #region 设置权限
        public List<ZTree> GetPermissionTree(string id, string UserName)
        {
            //1.求这个用户  角色对应的权限 及 用户对应的权限的和
            var p1 = from a in DataStore.UserRole.Where(a => a.UserName == id) join b in DataStore.Relation on a.RoleName equals b.RoleName select b.PermissionCode;
            var p2 = DataStore.UserPermission.Where(a => a.UserName == id).Select(a => a.PCode);
            var pp = p1.ToList();
            pp.AddRange(p2.ToList());
            pp = pp.Distinct().ToList();

            var ps = from a in DataStore.Permission
                     join b in pp on a.Code equals b into c
                     from cc in c.DefaultIfEmpty()
                     select new
                     {
                         a.Code,
                         check = cc != null
                     };

            var list = (from a in DataStore.Permission.Where(a => true)
                        join b in ps on a.Code equals b.Code
                        select new
                        {
                            a.Code,
                            a.PCode,
                            a.Name,
                            a.Sequence,
                            b.check
                        }).OrderBy(a => a.Sequence);
            List<ZTree> ztree = new List<ZTree>();

            foreach (var item in list)
            {
                ztree.Add(new ZTree(item.Code, item.Name, item.Name, item.PCode, null, item.Sequence, null, null, item.check));
            }
            //展开结点            
            ztree = ztree.OrderBy(a => a.sort).ToList();
            var extree = ztree.Where(a => a.@checked == true);
            foreach (var item in extree)
            {
                ZTree.ExpandTree(item.id, ztree);
            }
            return ztree;
        }
        public IAOPResult SetPermission(string id, string pids, string user)
        {
            try
            {
                var ids = new string[] { };
                if (!string.IsNullOrEmpty(pids))
                {
                    ids = pids.Split(',');
                }
                using (var db = new amEntities())
                {
                    var ur = db.AuthUserPermission.Where(a => a.UserName == id);
                    var del = ur.Where(a => !ids.Contains(a.PCode));
                    foreach (var item in del)
                    {
                        db.Set<AuthUserPermission>().Attach(item);
                        db.Entry<AuthUserPermission>(item).State = System.Data.EntityState.Deleted;
                    }
                    foreach (var item in ids)
                    {
                        var aa = ur.FirstOrDefault(a => a.PCode == item);
                        if (aa != null)
                        {
                            db.Set<AuthUserPermission>().Attach(aa);
                            db.Entry<AuthUserPermission>(aa).State = System.Data.EntityState.Modified;
                        }
                        else
                        {
                            AuthUserPermission m = new AuthUserPermission() { PCode = item, UserName = id };
                            db.Set<AuthUserPermission>().Attach(m);
                            db.Entry<AuthUserPermission>(m).State = System.Data.EntityState.Added;
                        }
                    }
                    db.SaveChanges();
                    //刷新静态数据          
                    DataStore.RefreshUserPermission();
                    return new AOPResult(0);
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        #endregion

        public IEnumerable GetUserByRole(string roleName, string q, out int count, string roleName2 = null)
        {
            var list = (from aa in DataStore.User.Where(a => (string.IsNullOrEmpty(q) ? true : (a.RealName.IndexOf(q) > -1 || a.UserName.IndexOf(q) > -1))
                   && a.IsAvailable == true)
                        join b in DataStore.UserRole.Where(a => roleName2 == null ? a.RoleName == roleName : (a.RoleName == roleName || a.RoleName == roleName2)) on aa.UserName equals b.UserName
                        select new
                        {
                            aa.UserName,
                            aa.UserNo,
                            aa.Sequence,
                            aa.RealName,

                        }).OrderBy(a => a.Sequence);
            count = list.Count();
            return list;
        }
    }
}