/**  版本信息模板在安装目录下，可自行修改。
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
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
using AM.Model;//Please add references
namespace AM.DAL
{
	/// <summary>
	/// 数据访问类:winow_check
	/// </summary>
	public partial class winow_checkDAL
	{
        public winow_checkDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from winow_check");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.winow_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into winow_check(");
			strSql.Append("Guid,userid,CreateDate,GCMC,SGDD,SYDW,AZDW,SBMC,AZFZR,SBXH,SBBH,SCCJ,CCRQ,JYGD,JYLB,DZCSYBH,DZCSYZK,SZZOBBH,SZZOBZK,JMSJJBH,JMSJJZK,SZWYBBH,SZWYBZK,DZMBBH,DZMBZK,FSJBH,FSJZK,WSDJBH,WSDJZK,YBKCBH,YBKCZK,GJC30BH,GJC30ZK,GJC5BH,GJC5ZK,JYJG)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@GCMC,@SGDD,@SYDW,@AZDW,@SBMC,@AZFZR,@SBXH,@SBBH,@SCCJ,@CCRQ,@JYGD,@JYLB,@DZCSYBH,@DZCSYZK,@SZZOBBH,@SZZOBZK,@JMSJJBH,@JMSJJZK,@SZWYBBH,@SZWYBZK,@DZMBBH,@DZMBZK,@FSJBH,@FSJZK,@WSDJBH,@WSDJZK,@YBKCBH,@YBKCZK,@GJC30BH,@GJC30ZK,@GJC5BH,@GJC5ZK,@JYJG)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@AZFZR", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@SBBH", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@CCRQ", MySqlDbType.Text),
					new MySqlParameter("@JYGD", MySqlDbType.Text),
					new MySqlParameter("@JYLB", MySqlDbType.Text),
					new MySqlParameter("@DZCSYBH", MySqlDbType.Text),
					new MySqlParameter("@DZCSYZK", MySqlDbType.Text),
					new MySqlParameter("@SZZOBBH", MySqlDbType.Text),
					new MySqlParameter("@SZZOBZK", MySqlDbType.Text),
					new MySqlParameter("@JMSJJBH", MySqlDbType.Text),
					new MySqlParameter("@JMSJJZK", MySqlDbType.Text),
					new MySqlParameter("@SZWYBBH", MySqlDbType.Text),
					new MySqlParameter("@SZWYBZK", MySqlDbType.Text),
					new MySqlParameter("@DZMBBH", MySqlDbType.Text),
					new MySqlParameter("@DZMBZK", MySqlDbType.Text),
					new MySqlParameter("@FSJBH", MySqlDbType.Text),
					new MySqlParameter("@FSJZK", MySqlDbType.Text),
					new MySqlParameter("@WSDJBH", MySqlDbType.Text),
					new MySqlParameter("@WSDJZK", MySqlDbType.Text),
					new MySqlParameter("@YBKCBH", MySqlDbType.Text),
					new MySqlParameter("@YBKCZK", MySqlDbType.Text),
					new MySqlParameter("@GJC30BH", MySqlDbType.Text),
					new MySqlParameter("@GJC30ZK", MySqlDbType.Text),
					new MySqlParameter("@GJC5BH", MySqlDbType.Text),
					new MySqlParameter("@GJC5ZK", MySqlDbType.Text),
					new MySqlParameter("@JYJG", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.GCMC;
			parameters[4].Value = model.SGDD;
			parameters[5].Value = model.SYDW;
			parameters[6].Value = model.AZDW;
			parameters[7].Value = model.SBMC;
			parameters[8].Value = model.AZFZR;
			parameters[9].Value = model.SBXH;
			parameters[10].Value = model.SBBH;
			parameters[11].Value = model.SCCJ;
			parameters[12].Value = model.CCRQ;
			parameters[13].Value = model.JYGD;
			parameters[14].Value = model.JYLB;
			parameters[15].Value = model.DZCSYBH;
			parameters[16].Value = model.DZCSYZK;
			parameters[17].Value = model.SZZOBBH;
			parameters[18].Value = model.SZZOBZK;
			parameters[19].Value = model.JMSJJBH;
			parameters[20].Value = model.JMSJJZK;
			parameters[21].Value = model.SZWYBBH;
			parameters[22].Value = model.SZWYBZK;
			parameters[23].Value = model.DZMBBH;
			parameters[24].Value = model.DZMBZK;
			parameters[25].Value = model.FSJBH;
			parameters[26].Value = model.FSJZK;
			parameters[27].Value = model.WSDJBH;
			parameters[28].Value = model.WSDJZK;
			parameters[29].Value = model.YBKCBH;
			parameters[30].Value = model.YBKCZK;
			parameters[31].Value = model.GJC30BH;
			parameters[32].Value = model.GJC30ZK;
			parameters[33].Value = model.GJC5BH;
			parameters[34].Value = model.GJC5ZK;
			parameters[35].Value = model.JYJG;

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
		public bool Update(AM.Model.winow_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update winow_check set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("GCMC=@GCMC,");
			strSql.Append("SGDD=@SGDD,");
			strSql.Append("SYDW=@SYDW,");
			strSql.Append("AZDW=@AZDW,");
			strSql.Append("SBMC=@SBMC,");
			strSql.Append("AZFZR=@AZFZR,");
			strSql.Append("SBXH=@SBXH,");
			strSql.Append("SBBH=@SBBH,");
			strSql.Append("SCCJ=@SCCJ,");
			strSql.Append("CCRQ=@CCRQ,");
			strSql.Append("JYGD=@JYGD,");
			strSql.Append("JYLB=@JYLB,");
			strSql.Append("DZCSYBH=@DZCSYBH,");
			strSql.Append("DZCSYZK=@DZCSYZK,");
			strSql.Append("SZZOBBH=@SZZOBBH,");
			strSql.Append("SZZOBZK=@SZZOBZK,");
			strSql.Append("JMSJJBH=@JMSJJBH,");
			strSql.Append("JMSJJZK=@JMSJJZK,");
			strSql.Append("SZWYBBH=@SZWYBBH,");
			strSql.Append("SZWYBZK=@SZWYBZK,");
			strSql.Append("DZMBBH=@DZMBBH,");
			strSql.Append("DZMBZK=@DZMBZK,");
			strSql.Append("FSJBH=@FSJBH,");
			strSql.Append("FSJZK=@FSJZK,");
			strSql.Append("WSDJBH=@WSDJBH,");
			strSql.Append("WSDJZK=@WSDJZK,");
			strSql.Append("YBKCBH=@YBKCBH,");
			strSql.Append("YBKCZK=@YBKCZK,");
			strSql.Append("GJC30BH=@GJC30BH,");
			strSql.Append("GJC30ZK=@GJC30ZK,");
			strSql.Append("GJC5BH=@GJC5BH,");
			strSql.Append("GJC5ZK=@GJC5ZK,");
			strSql.Append("JYJG=@JYJG");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@AZFZR", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@SBBH", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@CCRQ", MySqlDbType.Text),
					new MySqlParameter("@JYGD", MySqlDbType.Text),
					new MySqlParameter("@JYLB", MySqlDbType.Text),
					new MySqlParameter("@DZCSYBH", MySqlDbType.Text),
					new MySqlParameter("@DZCSYZK", MySqlDbType.Text),
					new MySqlParameter("@SZZOBBH", MySqlDbType.Text),
					new MySqlParameter("@SZZOBZK", MySqlDbType.Text),
					new MySqlParameter("@JMSJJBH", MySqlDbType.Text),
					new MySqlParameter("@JMSJJZK", MySqlDbType.Text),
					new MySqlParameter("@SZWYBBH", MySqlDbType.Text),
					new MySqlParameter("@SZWYBZK", MySqlDbType.Text),
					new MySqlParameter("@DZMBBH", MySqlDbType.Text),
					new MySqlParameter("@DZMBZK", MySqlDbType.Text),
					new MySqlParameter("@FSJBH", MySqlDbType.Text),
					new MySqlParameter("@FSJZK", MySqlDbType.Text),
					new MySqlParameter("@WSDJBH", MySqlDbType.Text),
					new MySqlParameter("@WSDJZK", MySqlDbType.Text),
					new MySqlParameter("@YBKCBH", MySqlDbType.Text),
					new MySqlParameter("@YBKCZK", MySqlDbType.Text),
					new MySqlParameter("@GJC30BH", MySqlDbType.Text),
					new MySqlParameter("@GJC30ZK", MySqlDbType.Text),
					new MySqlParameter("@GJC5BH", MySqlDbType.Text),
					new MySqlParameter("@GJC5ZK", MySqlDbType.Text),
					new MySqlParameter("@JYJG", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.GCMC;
			parameters[3].Value = model.SGDD;
			parameters[4].Value = model.SYDW;
			parameters[5].Value = model.AZDW;
			parameters[6].Value = model.SBMC;
			parameters[7].Value = model.AZFZR;
			parameters[8].Value = model.SBXH;
			parameters[9].Value = model.SBBH;
			parameters[10].Value = model.SCCJ;
			parameters[11].Value = model.CCRQ;
			parameters[12].Value = model.JYGD;
			parameters[13].Value = model.JYLB;
			parameters[14].Value = model.DZCSYBH;
			parameters[15].Value = model.DZCSYZK;
			parameters[16].Value = model.SZZOBBH;
			parameters[17].Value = model.SZZOBZK;
			parameters[18].Value = model.JMSJJBH;
			parameters[19].Value = model.JMSJJZK;
			parameters[20].Value = model.SZWYBBH;
			parameters[21].Value = model.SZWYBZK;
			parameters[22].Value = model.DZMBBH;
			parameters[23].Value = model.DZMBZK;
			parameters[24].Value = model.FSJBH;
			parameters[25].Value = model.FSJZK;
			parameters[26].Value = model.WSDJBH;
			parameters[27].Value = model.WSDJZK;
			parameters[28].Value = model.YBKCBH;
			parameters[29].Value = model.YBKCZK;
			parameters[30].Value = model.GJC30BH;
			parameters[31].Value = model.GJC30ZK;
			parameters[32].Value = model.GJC5BH;
			parameters[33].Value = model.GJC5ZK;
			parameters[34].Value = model.JYJG;
			parameters[35].Value = model.Guid;

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
			strSql.Append("delete from winow_check ");
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
			strSql.Append("delete from winow_check ");
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
		public AM.Model.winow_check GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,GCMC,SGDD,SYDW,AZDW,SBMC,AZFZR,SBXH,SBBH,SCCJ,CCRQ,JYGD,JYLB,DZCSYBH,DZCSYZK,SZZOBBH,SZZOBZK,JMSJJBH,JMSJJZK,SZWYBBH,SZWYBZK,DZMBBH,DZMBZK,FSJBH,FSJZK,WSDJBH,WSDJZK,YBKCBH,YBKCZK,GJC30BH,GJC30ZK,GJC5BH,GJC5ZK,JYJG from winow_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.winow_check model=new AM.Model.winow_check();
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
		public AM.Model.winow_check DataRowToModel(DataRow row)
		{
			AM.Model.winow_check model=new AM.Model.winow_check();
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
				if(row["GCMC"]!=null)
				{
					model.GCMC=row["GCMC"].ToString();
				}
				if(row["SGDD"]!=null)
				{
					model.SGDD=row["SGDD"].ToString();
				}
				if(row["SYDW"]!=null)
				{
					model.SYDW=row["SYDW"].ToString();
				}
				if(row["AZDW"]!=null)
				{
					model.AZDW=row["AZDW"].ToString();
				}
				if(row["SBMC"]!=null)
				{
					model.SBMC=row["SBMC"].ToString();
				}
				if(row["AZFZR"]!=null)
				{
					model.AZFZR=row["AZFZR"].ToString();
				}
				if(row["SBXH"]!=null)
				{
					model.SBXH=row["SBXH"].ToString();
				}
				if(row["SBBH"]!=null)
				{
					model.SBBH=row["SBBH"].ToString();
				}
				if(row["SCCJ"]!=null)
				{
					model.SCCJ=row["SCCJ"].ToString();
				}
				if(row["CCRQ"]!=null)
				{
					model.CCRQ=row["CCRQ"].ToString();
				}
				if(row["JYGD"]!=null)
				{
					model.JYGD=row["JYGD"].ToString();
				}
				if(row["JYLB"]!=null)
				{
					model.JYLB=row["JYLB"].ToString();
				}
				if(row["DZCSYBH"]!=null)
				{
					model.DZCSYBH=row["DZCSYBH"].ToString();
				}
				if(row["DZCSYZK"]!=null)
				{
					model.DZCSYZK=row["DZCSYZK"].ToString();
				}
				if(row["SZZOBBH"]!=null)
				{
					model.SZZOBBH=row["SZZOBBH"].ToString();
				}
				if(row["SZZOBZK"]!=null)
				{
					model.SZZOBZK=row["SZZOBZK"].ToString();
				}
				if(row["JMSJJBH"]!=null)
				{
					model.JMSJJBH=row["JMSJJBH"].ToString();
				}
				if(row["JMSJJZK"]!=null)
				{
					model.JMSJJZK=row["JMSJJZK"].ToString();
				}
				if(row["SZWYBBH"]!=null)
				{
					model.SZWYBBH=row["SZWYBBH"].ToString();
				}
				if(row["SZWYBZK"]!=null)
				{
					model.SZWYBZK=row["SZWYBZK"].ToString();
				}
				if(row["DZMBBH"]!=null)
				{
					model.DZMBBH=row["DZMBBH"].ToString();
				}
				if(row["DZMBZK"]!=null)
				{
					model.DZMBZK=row["DZMBZK"].ToString();
				}
				if(row["FSJBH"]!=null)
				{
					model.FSJBH=row["FSJBH"].ToString();
				}
				if(row["FSJZK"]!=null)
				{
					model.FSJZK=row["FSJZK"].ToString();
				}
				if(row["WSDJBH"]!=null)
				{
					model.WSDJBH=row["WSDJBH"].ToString();
				}
				if(row["WSDJZK"]!=null)
				{
					model.WSDJZK=row["WSDJZK"].ToString();
				}
				if(row["YBKCBH"]!=null)
				{
					model.YBKCBH=row["YBKCBH"].ToString();
				}
				if(row["YBKCZK"]!=null)
				{
					model.YBKCZK=row["YBKCZK"].ToString();
				}
				if(row["GJC30BH"]!=null)
				{
					model.GJC30BH=row["GJC30BH"].ToString();
				}
				if(row["GJC30ZK"]!=null)
				{
					model.GJC30ZK=row["GJC30ZK"].ToString();
				}
				if(row["GJC5BH"]!=null)
				{
					model.GJC5BH=row["GJC5BH"].ToString();
				}
				if(row["GJC5ZK"]!=null)
				{
					model.GJC5ZK=row["GJC5ZK"].ToString();
				}
				if(row["JYJG"]!=null)
				{
					model.JYJG=row["JYJG"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,GCMC,SGDD,SYDW,AZDW,SBMC,AZFZR,SBXH,SBBH,SCCJ,CCRQ,JYGD,JYLB,DZCSYBH,DZCSYZK,SZZOBBH,SZZOBZK,JMSJJBH,JMSJJZK,SZWYBBH,SZWYBZK,DZMBBH,DZMBZK,FSJBH,FSJZK,WSDJBH,WSDJZK,YBKCBH,YBKCZK,GJC30BH,GJC30ZK,GJC5BH,GJC5ZK,JYJG ");
			strSql.Append(" FROM winow_check ");
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
			strSql.Append("select count(1) FROM winow_check ");
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
        public winow_check GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from winow_check ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            winow_check model = new winow_check();
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
            strSql.Append("select * from winow_check ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM winow_check TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM winow_check TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataTable GetModelDataTable(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from winow_check ");
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

