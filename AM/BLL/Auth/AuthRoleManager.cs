using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Dynamic;
using Dao;
using MFXinY.EF;
using MFXinY.Common;
using System.Data.Objects;

namespace AM.BLL
{
    public class AuthRoleManager : MFXinYEFBase<AuthRole>
    {

        public override IAOPResult Add(AuthRole model)
        {
            var r = base.Add(model);
            //刷新静态数据
            DataStore.RefreshRole();
            return r;
        }

        public override IAOPResult Update(AuthRole model)
        {
            var r = base.Update(model);
            //刷新静态数据
            DataStore.RefreshRole();
            return r;
        }
        #region 重写删除方法
        public override IAOPResult Delete(List<AuthRole> list)
        {
            try
            {
                using (var db = new amEntities())
                {                   
                    //先删除userrole表里数据
                    var names = list.Select(a => a.RoleName).ToArray();
                    var isInner = db.AuthRole.Any(a => names.Contains(a.RoleName) && a.IsInner == true);
                    if (isInner == true)
                    {
                        return new AOPResult(-2, "内置角色不允许删除");
                    }
                    var userrole = from a in db.AuthUserRole join b in db.AuthRole on a.RoleName equals b.RoleName where names.Contains(b.RoleName) select a;
                    var relation = from a in db.AuthRelation join b in db.AuthRole on a.RoleName equals b.RoleName where names.Contains(b.RoleName) select a;
                    foreach (var item in userrole)
                    {
                        db.Set<AuthUserRole>().Attach(item);
                        db.Entry<AuthUserRole>(item).State = System.Data.EntityState.Deleted;
                    }
                    foreach (var item in relation)
                    {
                        db.Set<AuthRelation>().Attach(item);
                        db.Entry<AuthRelation>(item).State = System.Data.EntityState.Deleted;
                    }
                    foreach (var item in list)
                    {
                        db.Set<AuthRole>().Attach(item);
                        db.Entry<AuthRole>(item).State = System.Data.EntityState.Deleted;
                    }
                    db.SaveChanges();
                    //刷新静态数据
                    DataStore.RefreshUserRole();
                    DataStore.RefreshRelation();
                    DataStore.RefreshRole();
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
        public IEnumerable Search(int pageIndex, int pageSize, out int total, string sort, string order, string keyword, bool? isAvailable, string userName)
        {
            if (pageIndex < 1) pageIndex = 1;
            var isAdmin = DB.AuthUserManager.IsAdministrator(userName);
            var myList = DataStore.Role.Where(a => (isAdmin == true ? true : (a.Operator == userName)) &&
                (string.IsNullOrEmpty(keyword) ? true : (a.RoleName.IndexOf(keyword) > -1
                || a.Title.IndexOf(keyword) > -1)) &&
               (isAvailable == null ? true : a.IsAvailable == isAvailable))
               .Select(a => new
               {
                   IsAvailable = a.IsAvailable == true ? "正常" : "停用",
                   IsInner = a.IsInner == true ? "是" : "否",
                   a.OperateTime,
                   a.Operator,
                   a.RoleName,
                   a.Sequence,
                   a.Title,
                   a.Description,
                   a.Priority
               });
            total = myList.Count();
            #region 排序
            if (order != "desc")
            {
                switch (sort)
                {
                    case "RoleName":
                        myList = myList.OrderBy(a => a.RoleName);
                        break;
                    case "Title":
                        myList = myList.OrderBy(a => a.Title);
                        break;
                    case "Sequence":
                        myList = myList.OrderBy(a => a.Sequence);
                        break;
                    case "IsInner":
                        myList = myList.OrderBy(a => a.IsInner);
                        break;
                    case "IsAvailable":
                        myList = myList.OrderBy(a => a.IsAvailable);
                        break;
                    case "Description":
                        myList = myList.OrderBy(a => a.Description);
                        break;
                    case "Priority":
                        myList = myList.OrderBy(a => a.Priority);
                        break;
                    default:
                        myList = myList.OrderBy(a => a.Sequence);
                        break;
                }
                var list = myList.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                return list;
            }
            else
            {
                switch (sort)
                {
                    case "RoleName":
                        myList = myList.OrderByDescending(a => a.RoleName);
                        break;
                    case "Title":
                        myList = myList.OrderByDescending(a => a.Title);
                        break;
                    case "Sequence":
                        myList = myList.OrderByDescending(a => a.Sequence);
                        break;
                    case "IsInner":
                        myList = myList.OrderByDescending(a => a.IsInner);
                        break;
                    case "IsAvailable":
                        myList = myList.OrderByDescending(a => a.IsAvailable);
                        break;
                    case "Description":
                        myList = myList.OrderByDescending(a => a.Description);
                        break;
                    case "Priority":
                        myList = myList.OrderByDescending(a => a.Priority);
                        break;
                    default:
                        myList = myList.OrderBy(a => a.Sequence);
                        break;
                }
                var list = myList.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
                return list;
            }
            #endregion
        }
        /// <summary>
        /// 设置用户
        /// </summary>
        /// <param name="id"></param>
        /// <param name="users"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public IAOPResult SetUser(string id, string users, string user)
        {
            try
            {
                var arr = new string[] { };
                if (!string.IsNullOrEmpty(users))
                {
                    arr = users.Split(',');
                }
                using (var db = new amEntities())
                {
                    var ur = db.AuthUserRole.Where(a => a.RoleName == id);
                    var del = ur.Where(a => !arr.Contains(a.UserName));
                    foreach (var item in del)
                    {
                        db.Set<AuthUserRole>().Attach(item);
                        db.Entry<AuthUserRole>(item).State = System.Data.EntityState.Deleted;
                    }
                    foreach (var item in arr)
                    {
                        var aa = ur.FirstOrDefault(a => a.UserName == item);
                        if (aa != null)
                        {
                            aa.Operator = user;
                            aa.OperateTime = DateTime.Now;
                            db.Set<AuthUserRole>().Attach(aa);
                            db.Entry<AuthUserRole>(aa).State = System.Data.EntityState.Modified;
                        }
                        else
                        {
                            AuthUserRole m = new AuthUserRole() { RoleName = id, UserName = item, OperateTime = DateTime.Now, Operator = user };
                            db.Set<AuthUserRole>().Attach(m);
                            db.Entry<AuthUserRole>(m).State = System.Data.EntityState.Added;
                        }
                    }
                    db.SaveChanges();
                    //刷新静态数据
                    DataStore.RefreshUserRole();
                    return new AOPResult(0);
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// 设置权限
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        public IAOPResult SetPermission(string id, string pids, string user)
        {
            try
            {
                var ids = new string[] { };
                if (!string.IsNullOrEmpty(pids))
                {
                    ids = pids.Split(',');
                }
                //using (var db = new amEntities())
                {
                    var ur = DB.AuthRelationManager.Where(a => a.RoleName == id);
                    DB.AuthRelationManager.Delete(a => !ids.Contains(a.PermissionCode));
                    List<AuthRelation> addList = new List<AuthRelation>();
                    List<AuthRelation> updateList = new List<AuthRelation>();

                    foreach (var item in ids)
                    {
                        var aa = ur.FirstOrDefault(a => a.PermissionCode == item);
                        if (aa != null)
                        {
                            aa.Operator = user;
                            aa.OperateTime = DateTime.Now;
                            updateList.Add(aa);
                        }
                        else
                        {
                            AuthRelation m = new AuthRelation() { RoleName = id, PermissionCode = item, OperateTime = DateTime.Now, Operator = user, IsShow = true };
                            addList.Add(m);
                        }
                    }
                    DB.AuthRelationManager.Add(addList);
                    DB.AuthRelationManager.Update(updateList);
                    //db.SaveChanges(SaveOptions.DetectChangesBeforeSave);
                    //刷新静态数据                    
                    DataStore.RefreshRelation();
                    return new AOPResult(0);
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        public List<ZTree> GetPermissionTree(string id, string UserName)
        {
            var isadmin = DB.AuthUserManager.IsAdministrator(UserName);
            var ps1 = from a in DataStore.UserRole.Where(a => a.UserName == UserName) join b in DataStore.Relation on a.RoleName equals b.RoleName select b;
            var ps2 = DataStore.Relation.Where(a => a.RoleName == id);
            var ps = (from a in ps1
                      join b in ps2 on a.PermissionCode equals b.PermissionCode into c
                      from d in c.DefaultIfEmpty()
                      select new { a.PermissionCode, check = d != null });
            if (isadmin == true)
            {
                ps = (from a in DataStore.Permission
                      join b in ps2 on a.Code equals b.PermissionCode into c
                      from d in c.DefaultIfEmpty()
                      select new { PermissionCode = a.Code, check = d != null });
            }
            var list = (from a in DataStore.Permission.Where(a => true)
                        join b in ps on a.Code equals b.PermissionCode
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
    }
}