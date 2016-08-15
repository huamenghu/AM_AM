/**  版本信息模板在安装目录下，可自行修改。
* basket_check.cs
*
* 功 能： N/A
* 类 名： basket_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 17:55:15   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
using AM.Model;//Please add references
namespace AM.DAL
{
	/// <summary>
	/// 数据访问类:basket_check
	/// </summary>
	public partial class basket_checkDAL
	{
        public basket_checkDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from basket_check");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.basket_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into basket_check(");
			strSql.Append("Guid,userid,CreateDate,cpmc,ggxh,ypbh,ypsl,scrq,jylx,wtdw,scdw,jydd,jysj,jyyj,jyjl,bz)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@cpmc,@ggxh,@ypbh,@ypsl,@scrq,@jylx,@wtdw,@scdw,@jydd,@jysj,@jyyj,@jyjl,@bz)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@cpmc", MySqlDbType.VarChar,255),
					new MySqlParameter("@ggxh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ypbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ypsl", MySqlDbType.VarChar,255),
					new MySqlParameter("@scrq", MySqlDbType.VarChar,255),
					new MySqlParameter("@jylx", MySqlDbType.VarChar,255),
					new MySqlParameter("@wtdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@scdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@jydd", MySqlDbType.VarChar,255),
					new MySqlParameter("@jysj", MySqlDbType.VarChar,255),
					new MySqlParameter("@jyyj", MySqlDbType.VarChar,255),
					new MySqlParameter("@jyjl", MySqlDbType.VarChar,255),
					new MySqlParameter("@bz", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.cpmc;
			parameters[4].Value = model.ggxh;
			parameters[5].Value = model.ypbh;
			parameters[6].Value = model.ypsl;
			parameters[7].Value = model.scrq;
			parameters[8].Value = model.jylx;
			parameters[9].Value = model.wtdw;
			parameters[10].Value = model.scdw;
			parameters[11].Value = model.jydd;
			parameters[12].Value = model.jysj;
			parameters[13].Value = model.jyyj;
			parameters[14].Value = model.jyjl;
			parameters[15].Value = model.bz;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AM.Model.basket_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update basket_check set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("cpmc=@cpmc,");
			strSql.Append("ggxh=@ggxh,");
			strSql.Append("ypbh=@ypbh,");
			strSql.Append("ypsl=@ypsl,");
			strSql.Append("scrq=@scrq,");
			strSql.Append("jylx=@jylx,");
			strSql.Append("wtdw=@wtdw,");
			strSql.Append("scdw=@scdw,");
			strSql.Append("jydd=@jydd,");
			strSql.Append("jysj=@jysj,");
			strSql.Append("jyyj=@jyyj,");
			strSql.Append("jyjl=@jyjl,");
			strSql.Append("bz=@bz");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@cpmc", MySqlDbType.VarChar,255),
					new MySqlParameter("@ggxh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ypbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ypsl", MySqlDbType.VarChar,255),
					new MySqlParameter("@scrq", MySqlDbType.VarChar,255),
					new MySqlParameter("@jylx", MySqlDbType.VarChar,255),
					new MySqlParameter("@wtdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@scdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@jydd", MySqlDbType.VarChar,255),
					new MySqlParameter("@jysj", MySqlDbType.VarChar,255),
					new MySqlParameter("@jyyj", MySqlDbType.VarChar,255),
					new MySqlParameter("@jyjl", MySqlDbType.VarChar,255),
					new MySqlParameter("@bz", MySqlDbType.VarChar,255),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.cpmc;
			parameters[3].Value = model.ggxh;
			parameters[4].Value = model.ypbh;
			parameters[5].Value = model.ypsl;
			parameters[6].Value = model.scrq;
			parameters[7].Value = model.jylx;
			parameters[8].Value = model.wtdw;
			parameters[9].Value = model.scdw;
			parameters[10].Value = model.jydd;
			parameters[11].Value = model.jysj;
			parameters[12].Value = model.jyyj;
			parameters[13].Value = model.jyjl;
			parameters[14].Value = model.bz;
			parameters[15].Value = model.Guid;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from basket_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Guidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from basket_check ");
			strSql.Append(" where Guid in ("+Guidlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AM.Model.basket_check GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,cpmc,ggxh,ypbh,ypsl,scrq,jylx,wtdw,scdw,jydd,jysj,jyyj,jyjl,bz from basket_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.basket_check model=new AM.Model.basket_check();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AM.Model.basket_check DataRowToModel(DataRow row)
		{
			AM.Model.basket_check model=new AM.Model.basket_check();
			if (row != null)
			{
				if(row["Guid"]!=null)
				{
					model.Guid=row["Guid"].ToString();
				}
				if(row["userid"]!=null)
				{
					model.userid=row["userid"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["cpmc"]!=null)
				{
					model.cpmc=row["cpmc"].ToString();
				}
				if(row["ggxh"]!=null)
				{
					model.ggxh=row["ggxh"].ToString();
				}
				if(row["ypbh"]!=null)
				{
					model.ypbh=row["ypbh"].ToString();
				}
				if(row["ypsl"]!=null)
				{
					model.ypsl=row["ypsl"].ToString();
				}
				if(row["scrq"]!=null)
				{
					model.scrq=row["scrq"].ToString();
				}
				if(row["jylx"]!=null)
				{
					model.jylx=row["jylx"].ToString();
				}
				if(row["wtdw"]!=null)
				{
					model.wtdw=row["wtdw"].ToString();
				}
				if(row["scdw"]!=null)
				{
					model.scdw=row["scdw"].ToString();
				}
				if(row["jydd"]!=null)
				{
					model.jydd=row["jydd"].ToString();
				}
				if(row["jysj"]!=null)
				{
					model.jysj=row["jysj"].ToString();
				}
				if(row["jyyj"]!=null)
				{
					model.jyyj=row["jyyj"].ToString();
				}
				if(row["jyjl"]!=null)
				{
					model.jyjl=row["jyjl"].ToString();
				}
				if(row["bz"]!=null)
				{
					model.bz=row["bz"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,cpmc,ggxh,ypbh,ypsl,scrq,jylx,wtdw,scdw,jydd,jysj,jyyj,jyjl,bz ");
			strSql.Append(" FROM basket_check ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM basket_check ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}


		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "basket_check";
			parameters[1].Value = "Guid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public basket_check GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_check ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            basket_check model = new basket_check();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public DataSet GetDataByGuidList(string Guidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_check ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM basket_check TT  ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }

            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by TT." + orderby);
            }
            else
            {
                strSql.Append("order by TT.Guid desc");
            }
            strSql.AppendFormat(" LIMIT {0} , {1} ", startIndex, endIndex);
            strSql.Append(";SELECT count(Guid) as count FROM basket_check TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataTable GetModelDataTable(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_check ");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
            parameters[0].Value = Guid;

            AM.Model.basket_check model = new AM.Model.basket_check();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            return ds.Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

