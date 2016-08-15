/**  版本信息模板在安装目录下，可自行修改。
* safe_lock.cs
*
* 功 能： N/A
* 类 名： safe_lock
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:19   N/A    初版
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
	/// 数据访问类:safe_lock
	/// </summary>
	public partial class safe_lockDAL
	{
        public safe_lockDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from safe_lock");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.safe_lock model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into safe_lock(");
			strSql.Append("Guid,userid,CreateDate,WTDW,YPMC,ZZCS,XHGG,CCBH,JYRQ,JYYJ,JYJL)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@WTDW,@YPMC,@ZZCS,@XHGG,@CCBH,@JYRQ,@JYYJ,@JYJL)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@WTDW", MySqlDbType.Text),
					new MySqlParameter("@YPMC", MySqlDbType.Text),
					new MySqlParameter("@ZZCS", MySqlDbType.Text),
					new MySqlParameter("@XHGG", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@JYRQ", MySqlDbType.Text),
					new MySqlParameter("@JYYJ", MySqlDbType.Text),
					new MySqlParameter("@JYJL", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.WTDW;
			parameters[4].Value = model.YPMC;
			parameters[5].Value = model.ZZCS;
			parameters[6].Value = model.XHGG;
			parameters[7].Value = model.CCBH;
			parameters[8].Value = model.JYRQ;
			parameters[9].Value = model.JYYJ;
			parameters[10].Value = model.JYJL;

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
		public bool Update(AM.Model.safe_lock model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update safe_lock set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("WTDW=@WTDW,");
			strSql.Append("YPMC=@YPMC,");
			strSql.Append("ZZCS=@ZZCS,");
			strSql.Append("XHGG=@XHGG,");
			strSql.Append("CCBH=@CCBH,");
			strSql.Append("JYRQ=@JYRQ,");
			strSql.Append("JYYJ=@JYYJ,");
			strSql.Append("JYJL=@JYJL");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@WTDW", MySqlDbType.Text),
					new MySqlParameter("@YPMC", MySqlDbType.Text),
					new MySqlParameter("@ZZCS", MySqlDbType.Text),
					new MySqlParameter("@XHGG", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@JYRQ", MySqlDbType.Text),
					new MySqlParameter("@JYYJ", MySqlDbType.Text),
					new MySqlParameter("@JYJL", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.WTDW;
			parameters[3].Value = model.YPMC;
			parameters[4].Value = model.ZZCS;
			parameters[5].Value = model.XHGG;
			parameters[6].Value = model.CCBH;
			parameters[7].Value = model.JYRQ;
			parameters[8].Value = model.JYYJ;
			parameters[9].Value = model.JYJL;
			parameters[10].Value = model.Guid;

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
			strSql.Append("delete from safe_lock ");
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
			strSql.Append("delete from safe_lock ");
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
		public AM.Model.safe_lock GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,WTDW,YPMC,ZZCS,XHGG,CCBH,JYRQ,JYYJ,JYJL from safe_lock ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.safe_lock model=new AM.Model.safe_lock();
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
		public AM.Model.safe_lock DataRowToModel(DataRow row)
		{
			AM.Model.safe_lock model=new AM.Model.safe_lock();
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
				if(row["WTDW"]!=null)
				{
					model.WTDW=row["WTDW"].ToString();
				}
				if(row["YPMC"]!=null)
				{
					model.YPMC=row["YPMC"].ToString();
				}
				if(row["ZZCS"]!=null)
				{
					model.ZZCS=row["ZZCS"].ToString();
				}
				if(row["XHGG"]!=null)
				{
					model.XHGG=row["XHGG"].ToString();
				}
				if(row["CCBH"]!=null)
				{
					model.CCBH=row["CCBH"].ToString();
				}
				if(row["JYRQ"]!=null)
				{
					model.JYRQ=row["JYRQ"].ToString();
				}
				if(row["JYYJ"]!=null)
				{
					model.JYYJ=row["JYYJ"].ToString();
				}
				if(row["JYJL"]!=null)
				{
					model.JYJL=row["JYJL"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,WTDW,YPMC,ZZCS,XHGG,CCBH,JYRQ,JYYJ,JYJL ");
			strSql.Append(" FROM safe_lock ");
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
			strSql.Append("select count(1) FROM safe_lock ");
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
		

		#endregion  BasicMethod
		#region  ExtensionMethod
        public safe_lock GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from safe_lock ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            safe_lock model = new safe_lock();
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
            strSql.Append("select * from safe_lock ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM safe_lock TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM safe_lock TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataTable GetModelDataTable(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from safe_lock ");
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

