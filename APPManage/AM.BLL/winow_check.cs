﻿/**  版本信息模板在安装目录下，可自行修改。
* winow_check.cs
*
* 功 能： N/A
* 类 名： winow_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:21   N/A    初版
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
using Maticsoft.Common;
using AM.Model;
namespace AM.BLL
{
	/// <summary>
	/// winow_check
	/// </summary>
	public partial class winow_checkBLL
	{
		private readonly AM.DAL.winow_checkDAL dal=new AM.DAL.winow_checkDAL();
        public winow_checkBLL()
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
		public bool Add(AM.Model.winow_check model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AM.Model.winow_check model)
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
		public AM.Model.winow_check GetModel(string Guid)
		{
			
			return dal.GetModel(Guid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AM.Model.winow_check GetModelByCache(string Guid)
		{
			
			string CacheKey = "winow_checkModel-" + Guid;
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
				catch{}
			}
			return (AM.Model.winow_check)objModel;
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
		public List<AM.Model.winow_check> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AM.Model.winow_check> DataTableToList(DataTable dt)
		{
			List<AM.Model.winow_check> modelList = new List<AM.Model.winow_check>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AM.Model.winow_check model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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
        public winow_check DataRowToModel(DataRow row)
        {
            return dal.DataRowToModel(row);
        }
        public winow_check GetModelByUserId(string UserId)
        {

            return dal.GetModelByUserId(UserId);
        }
        public bool AddAndCheck(winow_check model)
        {
            winow_check bmodel = GetModelByUserId(model.userid);
            if (bmodel == null)
                return dal.Add(model);
            else
                return false;
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<winow_check> GetListByPage(string strWhere, string orderby, int startIndex, int endIndex, out int count)
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
        public DataTable GetModelDataTable(string guid)
        {
            return dal.GetModelDataTable(guid);
        }
		#endregion  ExtensionMethod
	}
}

