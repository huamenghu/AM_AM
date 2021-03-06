﻿/**  版本信息模板在安装目录下，可自行修改。
* wt_check.cs
*
* 功 能： N/A
* 类 名： wt_check
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
	/// 数据访问类:wt_check
	/// </summary>
	public partial class wt_checkDAL
	{
        public wt_checkDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from wt_check");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.wt_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wt_check(");
			strSql.Append("Guid,userid,CreateDate,WTDWMC,WTDWDZ,LXR,LXDH,GCMC,GCDZ,SGDW,SGDZ,JYNR,JYSL,SCCJ,SBBH,SBXH,AZGD,QT,QBGFS,BGTD)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@WTDWMC,@WTDWDZ,@LXR,@LXDH,@GCMC,@GCDZ,@SGDW,@SGDZ,@JYNR,@JYSL,@SCCJ,@SBBH,@SBXH,@AZGD,@QT,@QBGFS,@BGTD)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@WTDWMC", MySqlDbType.Text),
					new MySqlParameter("@WTDWDZ", MySqlDbType.Text),
					new MySqlParameter("@LXR", MySqlDbType.Text),
					new MySqlParameter("@LXDH", MySqlDbType.Text),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@GCDZ", MySqlDbType.Text),
					new MySqlParameter("@SGDW", MySqlDbType.Text),
					new MySqlParameter("@SGDZ", MySqlDbType.Text),
					new MySqlParameter("@JYNR", MySqlDbType.Text),
					new MySqlParameter("@JYSL", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@SBBH", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@AZGD", MySqlDbType.Text),
					new MySqlParameter("@QT", MySqlDbType.Text),
					new MySqlParameter("@QBGFS", MySqlDbType.Text),
					new MySqlParameter("@BGTD", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.WTDWMC;
			parameters[4].Value = model.WTDWDZ;
			parameters[5].Value = model.LXR;
			parameters[6].Value = model.LXDH;
			parameters[7].Value = model.GCMC;
			parameters[8].Value = model.GCDZ;
			parameters[9].Value = model.SGDW;
			parameters[10].Value = model.SGDZ;
			parameters[11].Value = model.JYNR;
			parameters[12].Value = model.JYSL;
			parameters[13].Value = model.SCCJ;
			parameters[14].Value = model.SBBH;
			parameters[15].Value = model.SBXH;
			parameters[16].Value = model.AZGD;
			parameters[17].Value = model.QT;
			parameters[18].Value = model.QBGFS;
			parameters[19].Value = model.BGTD;

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
		public bool Update(AM.Model.wt_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wt_check set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("WTDWMC=@WTDWMC,");
			strSql.Append("WTDWDZ=@WTDWDZ,");
			strSql.Append("LXR=@LXR,");
			strSql.Append("LXDH=@LXDH,");
			strSql.Append("GCMC=@GCMC,");
			strSql.Append("GCDZ=@GCDZ,");
			strSql.Append("SGDW=@SGDW,");
			strSql.Append("SGDZ=@SGDZ,");
			strSql.Append("JYNR=@JYNR,");
			strSql.Append("JYSL=@JYSL,");
			strSql.Append("SCCJ=@SCCJ,");
			strSql.Append("SBBH=@SBBH,");
			strSql.Append("SBXH=@SBXH,");
			strSql.Append("AZGD=@AZGD,");
			strSql.Append("QT=@QT,");
			strSql.Append("QBGFS=@QBGFS,");
			strSql.Append("BGTD=@BGTD");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@WTDWMC", MySqlDbType.Text),
					new MySqlParameter("@WTDWDZ", MySqlDbType.Text),
					new MySqlParameter("@LXR", MySqlDbType.Text),
					new MySqlParameter("@LXDH", MySqlDbType.Text),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@GCDZ", MySqlDbType.Text),
					new MySqlParameter("@SGDW", MySqlDbType.Text),
					new MySqlParameter("@SGDZ", MySqlDbType.Text),
					new MySqlParameter("@JYNR", MySqlDbType.Text),
					new MySqlParameter("@JYSL", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@SBBH", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@AZGD", MySqlDbType.Text),
					new MySqlParameter("@QT", MySqlDbType.Text),
					new MySqlParameter("@QBGFS", MySqlDbType.Text),
					new MySqlParameter("@BGTD", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.WTDWMC;
			parameters[3].Value = model.WTDWDZ;
			parameters[4].Value = model.LXR;
			parameters[5].Value = model.LXDH;
			parameters[6].Value = model.GCMC;
			parameters[7].Value = model.GCDZ;
			parameters[8].Value = model.SGDW;
			parameters[9].Value = model.SGDZ;
			parameters[10].Value = model.JYNR;
			parameters[11].Value = model.JYSL;
			parameters[12].Value = model.SCCJ;
			parameters[13].Value = model.SBBH;
			parameters[14].Value = model.SBXH;
			parameters[15].Value = model.AZGD;
			parameters[16].Value = model.QT;
			parameters[17].Value = model.QBGFS;
			parameters[18].Value = model.BGTD;
			parameters[19].Value = model.Guid;

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
			strSql.Append("delete from wt_check ");
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
			strSql.Append("delete from wt_check ");
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
		public AM.Model.wt_check GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,WTDWMC,WTDWDZ,LXR,LXDH,GCMC,GCDZ,SGDW,SGDZ,JYNR,JYSL,SCCJ,SBBH,SBXH,AZGD,QT,QBGFS,BGTD from wt_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.wt_check model=new AM.Model.wt_check();
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
		public AM.Model.wt_check DataRowToModel(DataRow row)
		{
			AM.Model.wt_check model=new AM.Model.wt_check();
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
				if(row["WTDWMC"]!=null)
				{
					model.WTDWMC=row["WTDWMC"].ToString();
				}
				if(row["WTDWDZ"]!=null)
				{
					model.WTDWDZ=row["WTDWDZ"].ToString();
				}
				if(row["LXR"]!=null)
				{
					model.LXR=row["LXR"].ToString();
				}
				if(row["LXDH"]!=null)
				{
					model.LXDH=row["LXDH"].ToString();
				}
				if(row["GCMC"]!=null)
				{
					model.GCMC=row["GCMC"].ToString();
				}
				if(row["GCDZ"]!=null)
				{
					model.GCDZ=row["GCDZ"].ToString();
				}
				if(row["SGDW"]!=null)
				{
					model.SGDW=row["SGDW"].ToString();
				}
				if(row["SGDZ"]!=null)
				{
					model.SGDZ=row["SGDZ"].ToString();
				}
				if(row["JYNR"]!=null)
				{
					model.JYNR=row["JYNR"].ToString();
				}
				if(row["JYSL"]!=null)
				{
					model.JYSL=row["JYSL"].ToString();
				}
				if(row["SCCJ"]!=null)
				{
					model.SCCJ=row["SCCJ"].ToString();
				}
				if(row["SBBH"]!=null)
				{
					model.SBBH=row["SBBH"].ToString();
				}
				if(row["SBXH"]!=null)
				{
					model.SBXH=row["SBXH"].ToString();
				}
				if(row["AZGD"]!=null)
				{
					model.AZGD=row["AZGD"].ToString();
				}
				if(row["QT"]!=null)
				{
					model.QT=row["QT"].ToString();
				}
				if(row["QBGFS"]!=null)
				{
					model.QBGFS=row["QBGFS"].ToString();
				}
				if(row["BGTD"]!=null)
				{
					model.BGTD=row["BGTD"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,WTDWMC,WTDWDZ,LXR,LXDH,GCMC,GCDZ,SGDW,SGDZ,JYNR,JYSL,SCCJ,SBBH,SBXH,AZGD,QT,QBGFS,BGTD ");
			strSql.Append(" FROM wt_check ");
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
			strSql.Append("select count(1) FROM wt_check ");
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
        public wt_check GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from wt_check ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            wt_check model = new wt_check();
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
            strSql.Append("select * from wt_check ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM wt_check TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM wt_check TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataTable GetModelDataTable(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from wt_check ");
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

