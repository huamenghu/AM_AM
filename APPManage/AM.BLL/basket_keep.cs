using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using AM.Model;
namespace AM.BLL
{
    /// <summary>
    /// basket_keep
    /// </summary>
    public partial class basket_keepBLL
    {
        private readonly AM.DAL.basket_keepDAL dal = new AM.DAL.basket_keepDAL();
        public basket_keepBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Guid)
        {
            return dal.Exists(Guid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(AM.Model.basket_keep model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(AM.Model.basket_keep model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Guid)
        {

            return dal.Delete(Guid);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public AM.Model.basket_keep GetModel(string Guid)
        {

            return dal.GetModel(Guid);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public AM.Model.basket_keep GetModelByCache(string Guid)
        {

            string CacheKey = "basket_keepModel-" + Guid;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Guid);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (AM.Model.basket_keep)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<AM.Model.basket_keep> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<AM.Model.basket_keep> DataTableToList(DataTable dt)
        {
            List<AM.Model.basket_keep> modelList = new List<AM.Model.basket_keep>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                AM.Model.basket_keep model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public basket_keep DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }
        public basket_keep GetModelByUserId(string UserId)
        {

            return dal.GetModelByUserId(UserId);
        }
        public bool AddAndCheck(basket_keep model)
        {
            basket_keep bmodel = GetModelByUserId(model.userid);
            if (bmodel == null)
                return dal.Add(model);
            else
                return false;
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<basket_keep> GetListByPage(string strWhere, string orderby, int startIndex, int endIndex, out int count)
        {
            DataSet ds = dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
            count = Convert.ToInt32(ds.Tables[1].Rows[0]["count"]);
            return DataTableToList(ds.Tables[0]); ;
        }
        public DataSet GetDataByGuidList(string Guidlist)
        {
            return dal.GetDataByGuidList(Guidlist);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Guidlist)
        {
            return dal.DeleteList(Guidlist);
        }
        #endregion  ExtensionMethod
    }
}

