/**  版本信息模板在安装目录下，可自行修改。
* xsweit_check.cs
*
* 功 能： N/A
* 类 名： xsweit_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:22   N/A    初版
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
	/// 数据访问类:xsweit_check
	/// </summary>
	public partial class xsweit_checkDAL
	{
        public xsweit_checkDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from xsweit_check");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.xsweit_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into xsweit_check(");
			strSql.Append("Guid,userid,CreateDate,CPMC,GGXH,WTDW,LXR,SCDW,LXDH,CPBH,WTRQ,DWDZ,WTJYYQ,JYYJ,JYFY,YQWCRQ,PHWCXM)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@CPMC,@GGXH,@WTDW,@LXR,@SCDW,@LXDH,@CPBH,@WTRQ,@DWDZ,@WTJYYQ,@JYYJ,@JYFY,@YQWCRQ,@PHWCXM)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@CPMC", MySqlDbType.Text),
					new MySqlParameter("@GGXH", MySqlDbType.Text),
					new MySqlParameter("@WTDW", MySqlDbType.Text),
					new MySqlParameter("@LXR", MySqlDbType.Text),
					new MySqlParameter("@SCDW", MySqlDbType.Text),
					new MySqlParameter("@LXDH", MySqlDbType.Text),
					new MySqlParameter("@CPBH", MySqlDbType.Text),
					new MySqlParameter("@WTRQ", MySqlDbType.Text),
					new MySqlParameter("@DWDZ", MySqlDbType.Text),
					new MySqlParameter("@WTJYYQ", MySqlDbType.Text),
					new MySqlParameter("@JYYJ", MySqlDbType.Text),
					new MySqlParameter("@JYFY", MySqlDbType.Text),
					new MySqlParameter("@YQWCRQ", MySqlDbType.Text),
					new MySqlParameter("@PHWCXM", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.CPMC;
			parameters[4].Value = model.GGXH;
			parameters[5].Value = model.WTDW;
			parameters[6].Value = model.LXR;
			parameters[7].Value = model.SCDW;
			parameters[8].Value = model.LXDH;
			parameters[9].Value = model.CPBH;
			parameters[10].Value = model.WTRQ;
			parameters[11].Value = model.DWDZ;
			parameters[12].Value = model.WTJYYQ;
			parameters[13].Value = model.JYYJ;
			parameters[14].Value = model.JYFY;
			parameters[15].Value = model.YQWCRQ;
			parameters[16].Value = model.PHWCXM;

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
		public bool Update(AM.Model.xsweit_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update xsweit_check set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("CPMC=@CPMC,");
			strSql.Append("GGXH=@GGXH,");
			strSql.Append("WTDW=@WTDW,");
			strSql.Append("LXR=@LXR,");
			strSql.Append("SCDW=@SCDW,");
			strSql.Append("LXDH=@LXDH,");
			strSql.Append("CPBH=@CPBH,");
			strSql.Append("WTRQ=@WTRQ,");
			strSql.Append("DWDZ=@DWDZ,");
			strSql.Append("WTJYYQ=@WTJYYQ,");
			strSql.Append("JYYJ=@JYYJ,");
			strSql.Append("JYFY=@JYFY,");
			strSql.Append("YQWCRQ=@YQWCRQ,");
			strSql.Append("PHWCXM=@PHWCXM");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@CPMC", MySqlDbType.Text),
					new MySqlParameter("@GGXH", MySqlDbType.Text),
					new MySqlParameter("@WTDW", MySqlDbType.Text),
					new MySqlParameter("@LXR", MySqlDbType.Text),
					new MySqlParameter("@SCDW", MySqlDbType.Text),
					new MySqlParameter("@LXDH", MySqlDbType.Text),
					new MySqlParameter("@CPBH", MySqlDbType.Text),
					new MySqlParameter("@WTRQ", MySqlDbType.Text),
					new MySqlParameter("@DWDZ", MySqlDbType.Text),
					new MySqlParameter("@WTJYYQ", MySqlDbType.Text),
					new MySqlParameter("@JYYJ", MySqlDbType.Text),
					new MySqlParameter("@JYFY", MySqlDbType.Text),
					new MySqlParameter("@YQWCRQ", MySqlDbType.Text),
					new MySqlParameter("@PHWCXM", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.CPMC;
			parameters[3].Value = model.GGXH;
			parameters[4].Value = model.WTDW;
			parameters[5].Value = model.LXR;
			parameters[6].Value = model.SCDW;
			parameters[7].Value = model.LXDH;
			parameters[8].Value = model.CPBH;
			parameters[9].Value = model.WTRQ;
			parameters[10].Value = model.DWDZ;
			parameters[11].Value = model.WTJYYQ;
			parameters[12].Value = model.JYYJ;
			parameters[13].Value = model.JYFY;
			parameters[14].Value = model.YQWCRQ;
			parameters[15].Value = model.PHWCXM;
			parameters[16].Value = model.Guid;

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
			strSql.Append("delete from xsweit_check ");
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
			strSql.Append("delete from xsweit_check ");
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
		public AM.Model.xsweit_check GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,CPMC,GGXH,WTDW,LXR,SCDW,LXDH,CPBH,WTRQ,DWDZ,WTJYYQ,JYYJ,JYFY,YQWCRQ,PHWCXM from xsweit_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.xsweit_check model=new AM.Model.xsweit_check();
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
		public AM.Model.xsweit_check DataRowToModel(DataRow row)
		{
			AM.Model.xsweit_check model=new AM.Model.xsweit_check();
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
				if(row["CPMC"]!=null)
				{
					model.CPMC=row["CPMC"].ToString();
				}
				if(row["GGXH"]!=null)
				{
					model.GGXH=row["GGXH"].ToString();
				}
				if(row["WTDW"]!=null)
				{
					model.WTDW=row["WTDW"].ToString();
				}
				if(row["LXR"]!=null)
				{
					model.LXR=row["LXR"].ToString();
				}
				if(row["SCDW"]!=null)
				{
					model.SCDW=row["SCDW"].ToString();
				}
				if(row["LXDH"]!=null)
				{
					model.LXDH=row["LXDH"].ToString();
				}
				if(row["CPBH"]!=null)
				{
					model.CPBH=row["CPBH"].ToString();
				}
				if(row["WTRQ"]!=null)
				{
					model.WTRQ=row["WTRQ"].ToString();
				}
				if(row["DWDZ"]!=null)
				{
					model.DWDZ=row["DWDZ"].ToString();
				}
				if(row["WTJYYQ"]!=null)
				{
					model.WTJYYQ=row["WTJYYQ"].ToString();
				}
				if(row["JYYJ"]!=null)
				{
					model.JYYJ=row["JYYJ"].ToString();
				}
				if(row["JYFY"]!=null)
				{
					model.JYFY=row["JYFY"].ToString();
				}
				if(row["YQWCRQ"]!=null)
				{
					model.YQWCRQ=row["YQWCRQ"].ToString();
				}
				if(row["PHWCXM"]!=null)
				{
					model.PHWCXM=row["PHWCXM"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,CPMC,GGXH,WTDW,LXR,SCDW,LXDH,CPBH,WTRQ,DWDZ,WTJYYQ,JYYJ,JYFY,YQWCRQ,PHWCXM ");
			strSql.Append(" FROM xsweit_check ");
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
			strSql.Append("select count(1) FROM xsweit_check ");
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
        public xsweit_check GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from xsweit_check ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            xsweit_check model = new xsweit_check();
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
            strSql.Append("select * from xsweit_check ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM xsweit_check TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM xsweit_check TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataTable GetModelDataTable(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from xsweit_check ");
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

