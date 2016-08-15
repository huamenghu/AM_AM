/**  版本信息模板在安装目录下，可自行修改。
* basket_train.cs
*
* 功 能： N/A
* 类 名： basket_train
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/10 10:46:45   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;

using AM.Model;
using AM.DAL;
namespace AM.BLL
{
	/// <summary>
	/// basket_train
	/// </summary>
	public partial class basket_trainBLL
	{
        private readonly basket_trainDAL dal = new basket_trainDAL();
        public basket_trainBLL()
		{}
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
        public bool Add(basket_train model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(basket_train model)
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
        public basket_train GetModel(string Guid)
        {

            return dal.GetModel(Guid);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public basket_train GetModelByCache(string Guid)
        {

            string CacheKey = "basket_trainModel-" + Guid;
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
            return (basket_train)objModel;
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
        public List<basket_train> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<basket_train> DataTableToList(DataTable dt)
        {
            List<basket_train> modelList = new List<basket_train>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                basket_train model;
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
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
		#region  ExtensionMethod
        public basket_train DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }
        public basket_train GetModelByUserId(string UserId)
        {

            return dal.GetModelByUserId(UserId);
        }
        public bool AddAndCheck(basket_train model)
        {
            basket_train bmodel = GetModelByUserId(model.userid);
            if (bmodel == null)
                return dal.Add(model);
            else
                return false;
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<basket_train> GetListByPage(string strWhere, string orderby, int startIndex, int endIndex,out int count)
        {
            DataSet ds = dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
            count =Convert.ToInt32(ds.Tables[1].Rows[0]["count"]);
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
        public Dictionary<string, string> GetColumnInfo(string tableName)
        {
            Dictionary<string, string> dary = new Dictionary<string, string>();
            DataSet ds  = dal.GetColumnInfo(tableName);
            foreach (DataRow item in ds.Tables[0].Rows)
	        {
                dary.Add(item["COLUMN_NAME"].ToString(), item["COLUMN_COMMENT"].ToString());
	        }
            return dary;
        }
		#endregion  ExtensionMethod
	}
}

