using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MFXinY.EF;
using Dao;
using MFXinY.Common;
using System.Data;
namespace AM.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthPermissionManager : MFXinYEFBase<AuthPermission>
    { 
        /// <summary>
        /// 重写添加方法，自动赋值Code
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public override IAOPResult Add(AuthPermission model)
        {
            try
            {
                var p = Find(model.PCode);                 
                var pcode = p == null ? string.Empty : p.Code;
                var curPermissionNo = Where(a => a.Code.Length == DataStore.EveryLayerLength).Max(a => a.Code);
                var curPermissionNo2 = Where(a => a.Code.StartsWith(pcode) && (a.Code.Length == pcode.Length + DataStore.EveryLayerLength)).Max(a => a.Code);
                var code = MVCTools.GetAutoCode(pcode, curPermissionNo, curPermissionNo2);
                model.Code = code;

                DataBase.Set<AuthPermission>().Attach(model);
                DataBase.Entry<AuthPermission>(model).State = EntityState.Added;
                DataBase.SaveChanges();
                DataBase.Entry<AuthPermission>(model).State = EntityState.Detached;
                //刷新静态数据
                DataStore.RefreshPermission();
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                if (model != null)
                    DataBase.Entry<AuthPermission>(model).State = EntityState.Detached;
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public override IAOPResult Update(AuthPermission model)
        {
            var r = base.Update(model);
            //刷新静态数据
            DataStore.RefreshPermission();
            return r;
        }
        /// <summary>
        /// 删除权限时，同时删除权限角色对应表
        /// </summary>
        /// <param name="objID"></param>
        /// <returns></returns>
        public override IAOPResult Delete(AuthPermission t)
        {
            try
            {
                if (t != null)
                {
                    //判断是否有子权限                            
                    if (DataStore.Permission.Count(a => a.PCode == t.Code) > 0)
                    {
                        return new AOPResult(-1, "其下存在子权限，请先删除子权限！");
                    }
                    var list = DB.AuthRelationManager.Delete(a => a.PermissionCode == t.Code);
                    var list2 = DB.AuthUserPermission.Delete(a => a.PCode == t.Code);
                    
                    var r = base.Delete(t);
                    //刷新静态数据
                    DataStore.RefreshPermission();
                    return r;
                }
                else
                {
                    return new AOPResult(-1, "没有找到要删除的对象");
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        public List<AuthPermission> GetPermissions(string username)
        {
            var isAdmin = DB.AuthUserManager.IsAdministrator(username);
            if (isAdmin == true)
            {
                var list = DataStore.Permission;
                return list;
            }
            else
            {
                var p1 = from a in DataStore.UserRole.Where(a => a.UserName == username) join b in DataStore.Relation on a.RoleName equals b.RoleName select b.PermissionCode;
                var p2 = DataStore.UserPermission.Where(a => a.UserName == username).Select(a => a.PCode);
                var pp = p1.ToList();
                pp.AddRange(p2.ToList());
                pp = pp.Distinct().ToList();
                var query = from c in DataStore.Permission.Where(a => a.IsShow == true && a.IsAvailable == true)
                            join a in pp on c.Code equals a
                            select new { c.Code, c.Name, c.PCode, c.URL, c.Sequence, c.IsAvailable, c.IsShow, c.Res };
                return query.Distinct().ToList().Select(a => new AuthPermission()
                {
                    Code = a.Code,
                    Name = a.Name,
                    PCode = a.PCode,
                    URL = a.URL,
                    Sequence = a.Sequence,
                    IsAvailable = a.IsAvailable,
                    IsShow = a.IsShow,
                    Res = a.Res
                }).ToList();
            }
        }
    }
}
