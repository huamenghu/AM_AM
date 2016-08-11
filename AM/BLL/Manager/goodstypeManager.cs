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
    public class GoodsTypeManager : MFXinYEFBase<goodstype>
    {
        //DB db;
        //public GoodsTypeManager(DB db)
        //{
        //    this.db = db;
        //}
        private static List<goodstype> types;
        int index = 0;
        #region 构造器
        private DB manager;
        internal GoodsTypeManager(DB manager)
        {
            this.manager = manager;
        }
        #endregion

        #region 重写父类方法

        public override IAOPResult Add(List<goodstype> list)
        {
            var r = base.Add(list);
            DataStore.Refreshgoodstype();
            return r;
        }

        public override IAOPResult Delete(List<goodstype> list)
        {
            var r = base.Delete(list);
            DataStore.Refreshgoodstype();
            return r;
        }

        public override IAOPResult Update(List<goodstype> list)
        {
            var r = base.Update(list);
            DataStore.Refreshgoodstype();
            return r;
        }

        public List<goodstype> GetAll()
        {
            var r = DB.Instant.GoodsTypeManager.Where(p => true).ToList();
            return r;
            //return DataStore._goodstype;
        }

        public goodstype GetFirst(string id)
        {
            //return DataStore.MType.FirstOrDefault(a => a.Code == id);
            goodstype g = null;
            try
            {
                using (var db = new amEntities())
                {
                    g = db.goodstype.FirstOrDefault(p => p.typeid == id);
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
        public List<goodstype> GetChildList(string typeid)
        {
            if (typeid == null)
            {
                //return DataStore.MType.Where(a => a.Code.Length <= DataStore.EveryLayerLength).ToList();
                return DB.Instant.GoodsTypeManager.Where(a => a.typeid.Length <= DataStore.EveryLayerLength).ToList();
            }
            return DB.Instant.GoodsTypeManager.Where(a => a.typeid.StartsWith(typeid) && a.typeid.Length == typeid.Length + DataStore.EveryLayerLength).ToList();
        }
        /// <summary>
        /// Type/Index  如果没有下级则返回同级类别
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<goodstype> GetChildType(string typeid, out bool exist)
        {
            exist = true;
            if (string.IsNullOrEmpty(typeid))
            {
                return DB.Instant.GoodsTypeManager.Where(a => a.typeid.Length == DataStore.EveryLayerLength).ToList();
            }
            var len = typeid.Length + DataStore.EveryLayerLength;
            var cc = DB.Instant.GoodsTypeManager.Where(a => a.typeid.StartsWith(typeid) && a.typeid.Length == len).ToList();
            if (cc.Count == 0)
            {
                exist = false;
                len = typeid.Length;
                typeid = typeid.Substring(0, typeid.Length - DataStore.EveryLayerLength);
                cc = DB.Instant.GoodsTypeManager.Where(a => a.typeid.StartsWith(typeid) && a.typeid.Length == len).ToList();
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
            // var type = DB.Instant.GoodsTypeManager.FirstOrDefault(a => a.typeid == typeid);
            goodstype type = null;

            using (var db = new amEntities())
            {
                type = db.goodstype.FirstOrDefault(p => p.typeid.Trim().ToLower() == typeid.Trim().ToLower());
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
            List<goodstype> list = new List<goodstype>();
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
        public List<goodstype> GeyGoodsTypeByTypeID(string typeid)
        {
            List<goodstype> list = null;
            try
            {
                using (var db = new amEntities())
                {
                    list = db.goodstype.Where(a => a.typeid == typeid).ToList();
                }
            }
            catch (Exception Exc)
            {

            }
            return list;
        }
    }
}
