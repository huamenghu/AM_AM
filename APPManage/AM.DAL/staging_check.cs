/**  版本信息模板在安装目录下，可自行修改。
* staging_check.cs
*
* 功 能： N/A
* 类 名： staging_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:20   N/A    初版
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
	/// 数据访问类:staging_check
	/// </summary>
	public partial class staging_checkDAL
	{
        public staging_checkDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from staging_check");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.staging_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into staging_check(");
			strSql.Append("Guid,userid,CreateDate,GCMC,SGDD,SYDW,JLDW,SBMC,AZDW,SBXH,SBBH,SCCJ,CCRQ,ZZXKZ,JYGD,GXJWYBH,GXJWYZK,NJBSBH,NJBSZK,SZZOBBH,SZZOBZK,WSDJBH,WSDJZK,FSYBH,FSYZK,YBKCBH,YBKCZK,GJC30BH,GJC30ZK,GJC5BH,GJC5ZK,GZC1BH,GZC1ZK,GZC2BH,GZC2ZK,SCBH,SCZK,JYJG)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@GCMC,@SGDD,@SYDW,@JLDW,@SBMC,@AZDW,@SBXH,@SBBH,@SCCJ,@CCRQ,@ZZXKZ,@JYGD,@GXJWYBH,@GXJWYZK,@NJBSBH,@NJBSZK,@SZZOBBH,@SZZOBZK,@WSDJBH,@WSDJZK,@FSYBH,@FSYZK,@YBKCBH,@YBKCZK,@GJC30BH,@GJC30ZK,@GJC5BH,@GJC5ZK,@GZC1BH,@GZC1ZK,@GZC2BH,@GZC2ZK,@SCBH,@SCZK,@JYJG)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@JLDW", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@SBBH", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@CCRQ", MySqlDbType.Text),
					new MySqlParameter("@ZZXKZ", MySqlDbType.Text),
					new MySqlParameter("@JYGD", MySqlDbType.Text),
					new MySqlParameter("@GXJWYBH", MySqlDbType.Text),
					new MySqlParameter("@GXJWYZK", MySqlDbType.Text),
					new MySqlParameter("@NJBSBH", MySqlDbType.Text),
					new MySqlParameter("@NJBSZK", MySqlDbType.Text),
					new MySqlParameter("@SZZOBBH", MySqlDbType.Text),
					new MySqlParameter("@SZZOBZK", MySqlDbType.Text),
					new MySqlParameter("@WSDJBH", MySqlDbType.Text),
					new MySqlParameter("@WSDJZK", MySqlDbType.Text),
					new MySqlParameter("@FSYBH", MySqlDbType.Text),
					new MySqlParameter("@FSYZK", MySqlDbType.Text),
					new MySqlParameter("@YBKCBH", MySqlDbType.Text),
					new MySqlParameter("@YBKCZK", MySqlDbType.Text),
					new MySqlParameter("@GJC30BH", MySqlDbType.Text),
					new MySqlParameter("@GJC30ZK", MySqlDbType.Text),
					new MySqlParameter("@GJC5BH", MySqlDbType.Text),
					new MySqlParameter("@GJC5ZK", MySqlDbType.Text),
					new MySqlParameter("@GZC1BH", MySqlDbType.Text),
					new MySqlParameter("@GZC1ZK", MySqlDbType.Text),
					new MySqlParameter("@GZC2BH", MySqlDbType.Text),
					new MySqlParameter("@GZC2ZK", MySqlDbType.Text),
					new MySqlParameter("@SCBH", MySqlDbType.Text),
					new MySqlParameter("@SCZK", MySqlDbType.Text),
					new MySqlParameter("@JYJG", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.GCMC;
			parameters[4].Value = model.SGDD;
			parameters[5].Value = model.SYDW;
			parameters[6].Value = model.JLDW;
			parameters[7].Value = model.SBMC;
			parameters[8].Value = model.AZDW;
			parameters[9].Value = model.SBXH;
			parameters[10].Value = model.SBBH;
			parameters[11].Value = model.SCCJ;
			parameters[12].Value = model.CCRQ;
			parameters[13].Value = model.ZZXKZ;
			parameters[14].Value = model.JYGD;
			parameters[15].Value = model.GXJWYBH;
			parameters[16].Value = model.GXJWYZK;
			parameters[17].Value = model.NJBSBH;
			parameters[18].Value = model.NJBSZK;
			parameters[19].Value = model.SZZOBBH;
			parameters[20].Value = model.SZZOBZK;
			parameters[21].Value = model.WSDJBH;
			parameters[22].Value = model.WSDJZK;
			parameters[23].Value = model.FSYBH;
			parameters[24].Value = model.FSYZK;
			parameters[25].Value = model.YBKCBH;
			parameters[26].Value = model.YBKCZK;
			parameters[27].Value = model.GJC30BH;
			parameters[28].Value = model.GJC30ZK;
			parameters[29].Value = model.GJC5BH;
			parameters[30].Value = model.GJC5ZK;
			parameters[31].Value = model.GZC1BH;
			parameters[32].Value = model.GZC1ZK;
			parameters[33].Value = model.GZC2BH;
			parameters[34].Value = model.GZC2ZK;
			parameters[35].Value = model.SCBH;
			parameters[36].Value = model.SCZK;
			parameters[37].Value = model.JYJG;

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
		public bool Update(AM.Model.staging_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update staging_check set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("GCMC=@GCMC,");
			strSql.Append("SGDD=@SGDD,");
			strSql.Append("SYDW=@SYDW,");
			strSql.Append("JLDW=@JLDW,");
			strSql.Append("SBMC=@SBMC,");
			strSql.Append("AZDW=@AZDW,");
			strSql.Append("SBXH=@SBXH,");
			strSql.Append("SBBH=@SBBH,");
			strSql.Append("SCCJ=@SCCJ,");
			strSql.Append("CCRQ=@CCRQ,");
			strSql.Append("ZZXKZ=@ZZXKZ,");
			strSql.Append("JYGD=@JYGD,");
			strSql.Append("GXJWYBH=@GXJWYBH,");
			strSql.Append("GXJWYZK=@GXJWYZK,");
			strSql.Append("NJBSBH=@NJBSBH,");
			strSql.Append("NJBSZK=@NJBSZK,");
			strSql.Append("SZZOBBH=@SZZOBBH,");
			strSql.Append("SZZOBZK=@SZZOBZK,");
			strSql.Append("WSDJBH=@WSDJBH,");
			strSql.Append("WSDJZK=@WSDJZK,");
			strSql.Append("FSYBH=@FSYBH,");
			strSql.Append("FSYZK=@FSYZK,");
			strSql.Append("YBKCBH=@YBKCBH,");
			strSql.Append("YBKCZK=@YBKCZK,");
			strSql.Append("GJC30BH=@GJC30BH,");
			strSql.Append("GJC30ZK=@GJC30ZK,");
			strSql.Append("GJC5BH=@GJC5BH,");
			strSql.Append("GJC5ZK=@GJC5ZK,");
			strSql.Append("GZC1BH=@GZC1BH,");
			strSql.Append("GZC1ZK=@GZC1ZK,");
			strSql.Append("GZC2BH=@GZC2BH,");
			strSql.Append("GZC2ZK=@GZC2ZK,");
			strSql.Append("SCBH=@SCBH,");
			strSql.Append("SCZK=@SCZK,");
			strSql.Append("JYJG=@JYJG");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@JLDW", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@SBBH", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@CCRQ", MySqlDbType.Text),
					new MySqlParameter("@ZZXKZ", MySqlDbType.Text),
					new MySqlParameter("@JYGD", MySqlDbType.Text),
					new MySqlParameter("@GXJWYBH", MySqlDbType.Text),
					new MySqlParameter("@GXJWYZK", MySqlDbType.Text),
					new MySqlParameter("@NJBSBH", MySqlDbType.Text),
					new MySqlParameter("@NJBSZK", MySqlDbType.Text),
					new MySqlParameter("@SZZOBBH", MySqlDbType.Text),
					new MySqlParameter("@SZZOBZK", MySqlDbType.Text),
					new MySqlParameter("@WSDJBH", MySqlDbType.Text),
					new MySqlParameter("@WSDJZK", MySqlDbType.Text),
					new MySqlParameter("@FSYBH", MySqlDbType.Text),
					new MySqlParameter("@FSYZK", MySqlDbType.Text),
					new MySqlParameter("@YBKCBH", MySqlDbType.Text),
					new MySqlParameter("@YBKCZK", MySqlDbType.Text),
					new MySqlParameter("@GJC30BH", MySqlDbType.Text),
					new MySqlParameter("@GJC30ZK", MySqlDbType.Text),
					new MySqlParameter("@GJC5BH", MySqlDbType.Text),
					new MySqlParameter("@GJC5ZK", MySqlDbType.Text),
					new MySqlParameter("@GZC1BH", MySqlDbType.Text),
					new MySqlParameter("@GZC1ZK", MySqlDbType.Text),
					new MySqlParameter("@GZC2BH", MySqlDbType.Text),
					new MySqlParameter("@GZC2ZK", MySqlDbType.Text),
					new MySqlParameter("@SCBH", MySqlDbType.Text),
					new MySqlParameter("@SCZK", MySqlDbType.Text),
					new MySqlParameter("@JYJG", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.GCMC;
			parameters[3].Value = model.SGDD;
			parameters[4].Value = model.SYDW;
			parameters[5].Value = model.JLDW;
			parameters[6].Value = model.SBMC;
			parameters[7].Value = model.AZDW;
			parameters[8].Value = model.SBXH;
			parameters[9].Value = model.SBBH;
			parameters[10].Value = model.SCCJ;
			parameters[11].Value = model.CCRQ;
			parameters[12].Value = model.ZZXKZ;
			parameters[13].Value = model.JYGD;
			parameters[14].Value = model.GXJWYBH;
			parameters[15].Value = model.GXJWYZK;
			parameters[16].Value = model.NJBSBH;
			parameters[17].Value = model.NJBSZK;
			parameters[18].Value = model.SZZOBBH;
			parameters[19].Value = model.SZZOBZK;
			parameters[20].Value = model.WSDJBH;
			parameters[21].Value = model.WSDJZK;
			parameters[22].Value = model.FSYBH;
			parameters[23].Value = model.FSYZK;
			parameters[24].Value = model.YBKCBH;
			parameters[25].Value = model.YBKCZK;
			parameters[26].Value = model.GJC30BH;
			parameters[27].Value = model.GJC30ZK;
			parameters[28].Value = model.GJC5BH;
			parameters[29].Value = model.GJC5ZK;
			parameters[30].Value = model.GZC1BH;
			parameters[31].Value = model.GZC1ZK;
			parameters[32].Value = model.GZC2BH;
			parameters[33].Value = model.GZC2ZK;
			parameters[34].Value = model.SCBH;
			parameters[35].Value = model.SCZK;
			parameters[36].Value = model.JYJG;
			parameters[37].Value = model.Guid;

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
			strSql.Append("delete from staging_check ");
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
			strSql.Append("delete from staging_check ");
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
		public AM.Model.staging_check GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,GCMC,SGDD,SYDW,JLDW,SBMC,AZDW,SBXH,SBBH,SCCJ,CCRQ,ZZXKZ,JYGD,GXJWYBH,GXJWYZK,NJBSBH,NJBSZK,SZZOBBH,SZZOBZK,WSDJBH,WSDJZK,FSYBH,FSYZK,YBKCBH,YBKCZK,GJC30BH,GJC30ZK,GJC5BH,GJC5ZK,GZC1BH,GZC1ZK,GZC2BH,GZC2ZK,SCBH,SCZK,JYJG from staging_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.staging_check model=new AM.Model.staging_check();
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
		public AM.Model.staging_check DataRowToModel(DataRow row)
		{
			AM.Model.staging_check model=new AM.Model.staging_check();
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
				if(row["JLDW"]!=null)
				{
					model.JLDW=row["JLDW"].ToString();
				}
				if(row["SBMC"]!=null)
				{
					model.SBMC=row["SBMC"].ToString();
				}
				if(row["AZDW"]!=null)
				{
					model.AZDW=row["AZDW"].ToString();
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
				if(row["ZZXKZ"]!=null)
				{
					model.ZZXKZ=row["ZZXKZ"].ToString();
				}
				if(row["JYGD"]!=null)
				{
					model.JYGD=row["JYGD"].ToString();
				}
				if(row["GXJWYBH"]!=null)
				{
					model.GXJWYBH=row["GXJWYBH"].ToString();
				}
				if(row["GXJWYZK"]!=null)
				{
					model.GXJWYZK=row["GXJWYZK"].ToString();
				}
				if(row["NJBSBH"]!=null)
				{
					model.NJBSBH=row["NJBSBH"].ToString();
				}
				if(row["NJBSZK"]!=null)
				{
					model.NJBSZK=row["NJBSZK"].ToString();
				}
				if(row["SZZOBBH"]!=null)
				{
					model.SZZOBBH=row["SZZOBBH"].ToString();
				}
				if(row["SZZOBZK"]!=null)
				{
					model.SZZOBZK=row["SZZOBZK"].ToString();
				}
				if(row["WSDJBH"]!=null)
				{
					model.WSDJBH=row["WSDJBH"].ToString();
				}
				if(row["WSDJZK"]!=null)
				{
					model.WSDJZK=row["WSDJZK"].ToString();
				}
				if(row["FSYBH"]!=null)
				{
					model.FSYBH=row["FSYBH"].ToString();
				}
				if(row["FSYZK"]!=null)
				{
					model.FSYZK=row["FSYZK"].ToString();
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
				if(row["GZC1BH"]!=null)
				{
					model.GZC1BH=row["GZC1BH"].ToString();
				}
				if(row["GZC1ZK"]!=null)
				{
					model.GZC1ZK=row["GZC1ZK"].ToString();
				}
				if(row["GZC2BH"]!=null)
				{
					model.GZC2BH=row["GZC2BH"].ToString();
				}
				if(row["GZC2ZK"]!=null)
				{
					model.GZC2ZK=row["GZC2ZK"].ToString();
				}
				if(row["SCBH"]!=null)
				{
					model.SCBH=row["SCBH"].ToString();
				}
				if(row["SCZK"]!=null)
				{
					model.SCZK=row["SCZK"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,GCMC,SGDD,SYDW,JLDW,SBMC,AZDW,SBXH,SBBH,SCCJ,CCRQ,ZZXKZ,JYGD,GXJWYBH,GXJWYZK,NJBSBH,NJBSZK,SZZOBBH,SZZOBZK,WSDJBH,WSDJZK,FSYBH,FSYZK,YBKCBH,YBKCZK,GJC30BH,GJC30ZK,GJC5BH,GJC5ZK,GZC1BH,GZC1ZK,GZC2BH,GZC2ZK,SCBH,SCZK,JYJG ");
			strSql.Append(" FROM staging_check ");
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
			strSql.Append("select count(1) FROM staging_check ");
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
        public staging_check GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from staging_check ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            staging_check model = new staging_check();
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
            strSql.Append("select * from staging_check ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM staging_check TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM staging_check TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

