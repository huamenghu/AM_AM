using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFXinY.EF;
using System.Collections;
using Dao;
using MFXinY.Common;
using System.Data.Entity;
using Model;
using System.Text;

namespace AM.BLL
{
    public class FaultTypeManager : MFXinYEFBase<faulttype>
    {
        //DB db;
        //public faulttypeManager(DB db)
        //{
        //    this.db = db;
        //}
        private static List<faulttype> types;
        int index = 0;
        #region 构造器
        private DB manager;
        internal FaultTypeManager(DB manager)
        {
            this.manager = manager;
        }
        #endregion

        #region 重写父类方法

        public override IAOPResult Add(faulttype model)
        {
            //if (string.IsNullOrEmpty(model.SimpleName))
            //{ model.SimpleName = model.Name; }
            var r = base.Add(model);
            //if (r.IsSuccess)
            //{
            //    DataStore.RefreshMType();
            //}
            return r;
        }

        public override IAOPResult Delete(faulttype obj)
        {
            try
            {
                using (var db = new amEntities())
                {
                    var id = obj.typeid;
                    var t = db.faulttype.FirstOrDefault(a => a.typeid == id);
                    if (t != null)
                    {
                        //判断是否有子类别
                        var count = db.faulttype.Count(a => a.typeid.StartsWith(id));
                        if (count > 1)
                        {
                            return new AOPResult(-1, "其下存在子类别，请先删除子类别！");
                        }
                        //判断是否有信息，如果没有信息，则先删除对应表
                        //var m = db.Message.Count(a => a.TypeCode == id);
                        //if (m > 0)
                        //{
                        //    return new AOPResult(-2, string.Format("其下共有{0}条信息，不能删除", m));
                        //}
                        //var list = db.TypeFieldRelation.Where(a => a.typeid == id);
                        //foreach (var item in list)
                        //{
                        //    db.DeleteObject(item);
                        //}
                        //db.DeleteObject(t);
                    }
                    else
                    {
                        return new AOPResult(-1, "没有找到要删除的对象");
                    }
                    db.SaveChanges();
                    //  DataStore.RefreshMType();
                    List<faulttype> gt = new List<faulttype>();
                    using (var am = new amEntities())
                    {
                        // DataStore.RefreshMType();
                        gt = am.faulttype.Where(a => a.Isshow == true).Select(a => new { a.typeid, a.typename, a.sort }).ToList().Select(a => new faulttype() { typeid = a.typeid, typename = a.typename, sort = a.sort }).ToList();
                    }
                    return new AOPResult(0);
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        public override IAOPResult Update(List<faulttype> list)
        {
            var r = base.Update(list);
            List<faulttype> gt = new List<faulttype>();
            using (var db = new amEntities())
            {
                // DataStore.RefreshMType();
                gt = db.faulttype.Where(a => a.Isshow == true).Select(a => new { a.typeid, a.typename, a.sort }).ToList().Select(a => new faulttype() { typeid = a.typeid, typename = a.typename, sort = a.sort }).ToList();
            }
            return r;
        }

        public List<faulttype> GetAll()
        {
            var r = DB.Instant.FaultTypeManager.Where(p => true).ToList();
            return r;
            //return DataStore._faulttype;
        }

        public faulttype GetFirst(string id)
        {
            //return DataStore.MType.FirstOrDefault(a => a.Code == id);
            faulttype g = null;
            try
            {
                using (var db = new amEntities())
                {
                    g = db.faulttype.FirstOrDefault(p => p.typeid == id);
                }
            }
            catch (Exception exc)
            {

            }
            return g;
        }
        #endregion
        /// <summary>
        /// 得到当前类别的名字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetName(string id)
        {
            if (id == null)
                return null;
            var model = GetFirst(id);
            if (model != null)
                return model.typename;
            return null;
        }

        /// <summary>
        /// 由父ID获得子类别集合
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<faulttype> GetChildList(string typeid)
        {
            if (typeid == null)
            {
                //return DataStore.MType.Where(a => a.Code.Length <= DataStore.EveryLayerLength).ToList();
                return DB.Instant.FaultTypeManager.Where(a => a.typeid.Length <= DataStore.EveryLayerLength).ToList();
            }
            return DB.Instant.FaultTypeManager.Where(a => a.typeid.StartsWith(typeid) && a.typeid.Length == typeid.Length + DataStore.EveryLayerLength).ToList();
        }
        /// <summary>
        /// Type/Index  如果没有下级则返回同级类别
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<faulttype> GetChildType(string typeid, out bool exist)
        {
            exist = true;
            if (string.IsNullOrEmpty(typeid))
            {
                return DB.Instant.FaultTypeManager.Where(a => a.typeid.Length == DataStore.EveryLayerLength).ToList();
            }
            var len = typeid.Length + DataStore.EveryLayerLength;
            var cc = DB.Instant.FaultTypeManager.Where(a => a.typeid.StartsWith(typeid) && a.typeid.Length == len).ToList();
            if (cc.Count == 0)
            {
                exist = false;
                len = typeid.Length;
                typeid = typeid.Substring(0, typeid.Length - DataStore.EveryLayerLength);
                cc = DB.Instant.FaultTypeManager.Where(a => a.typeid.StartsWith(typeid) && a.typeid.Length == len).ToList();
            }
            return cc;
        }

        /// <summary>
        /// 得到当前类别及各上层类别的名字组合
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string GetTypeString(string typeid)
        {
            //var types = DataStore.MType;

            List<string> list = new List<string>();
            // var type = DB.Instant.faulttypeManager.FirstOrDefault(a => a.typeid == typeid);
            faulttype type = null;

            using (var db = new amEntities())
            {
                type = db.faulttype.FirstOrDefault(p => p.typeid.Trim().ToLower() == typeid.Trim().ToLower());
            }

            if (type != null)
            {
                list.Add(type.typename);
            }
            while (type.typeid.Length > DataStore.EveryLayerLength)
            {
                type = types.FirstOrDefault(a => a.typeid == type.typeid.Substring(0, type.typeid.Length - DataStore.EveryLayerLength));
                if (type != null)
                {
                    list.Add(type.typename);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                sb.Append(list[i]);
                if (i > 0)
                {
                    sb.Append(" - ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 是否有下级
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsHasChild(string typeid)
        {
            if (typeid == null)
                return false;
            //if (DataStore.MType.Count(a => a.typeid.StartsWith(typeid)) > 1)
            //{
            //    return true;
            //}
            List<faulttype> list = new List<faulttype>();
            if (list.Count(a => a.typeid.StartsWith(typeid)) > 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 根据typeid获取商城全部两级分类
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public List<faulttype> GeyfaulttypeByTypeID(string typeid)
        {
            List<faulttype> list = null;
            try
            {
                using (var db = new amEntities())
                {
                    list = db.faulttype.Where(a => a.typeid == typeid).ToList();
                }
            }
            catch (Exception Exc)
            {

            }
            return list;
        }
    }
}
