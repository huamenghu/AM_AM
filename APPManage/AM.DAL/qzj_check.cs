/**  版本信息模板在安装目录下，可自行修改。
* qzj_check.cs
*
* 功 能： N/A
* 类 名： qzj_check
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
	/// 数据访问类:qzj_check
	/// </summary>
	public partial class qzj_checkDAL
	{
        public qzj_checkDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from qzj_check");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.qzj_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into qzj_check(");
			strSql.Append("Guid,userid,CreateDate,WTDW,WTRQ,SYDW,WTLXRDH,GCMC,AZFZRDH,SGDD,AZRQ,AZDW,BABH,SCCJ,GGXH,SBMC,CCBH,JLDW,JYSFZDS,JYSAZGD,JYSL,JYLB,JYYJ,WTDWJSZL,FWLX,NYR,JCFY)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@WTDW,@WTRQ,@SYDW,@WTLXRDH,@GCMC,@AZFZRDH,@SGDD,@AZRQ,@AZDW,@BABH,@SCCJ,@GGXH,@SBMC,@CCBH,@JLDW,@JYSFZDS,@JYSAZGD,@JYSL,@JYLB,@JYYJ,@WTDWJSZL,@FWLX,@NYR,@JCFY)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@WTDW", MySqlDbType.Text),
					new MySqlParameter("@WTRQ", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@WTLXRDH", MySqlDbType.Text),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@AZFZRDH", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@AZRQ", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@BABH", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@GGXH", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@JLDW", MySqlDbType.Text),
					new MySqlParameter("@JYSFZDS", MySqlDbType.Text),
					new MySqlParameter("@JYSAZGD", MySqlDbType.Text),
					new MySqlParameter("@JYSL", MySqlDbType.Text),
					new MySqlParameter("@JYLB", MySqlDbType.Text),
					new MySqlParameter("@JYYJ", MySqlDbType.Text),
					new MySqlParameter("@WTDWJSZL", MySqlDbType.Text),
					new MySqlParameter("@FWLX", MySqlDbType.Text),
					new MySqlParameter("@NYR", MySqlDbType.Text),
					new MySqlParameter("@JCFY", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.WTDW;
			parameters[4].Value = model.WTRQ;
			parameters[5].Value = model.SYDW;
			parameters[6].Value = model.WTLXRDH;
			parameters[7].Value = model.GCMC;
			parameters[8].Value = model.AZFZRDH;
			parameters[9].Value = model.SGDD;
			parameters[10].Value = model.AZRQ;
			parameters[11].Value = model.AZDW;
			parameters[12].Value = model.BABH;
			parameters[13].Value = model.SCCJ;
			parameters[14].Value = model.GGXH;
			parameters[15].Value = model.SBMC;
			parameters[16].Value = model.CCBH;
			parameters[17].Value = model.JLDW;
			parameters[18].Value = model.JYSFZDS;
			parameters[19].Value = model.JYSAZGD;
			parameters[20].Value = model.JYSL;
			parameters[21].Value = model.JYLB;
			parameters[22].Value = model.JYYJ;
			parameters[23].Value = model.WTDWJSZL;
			parameters[24].Value = model.FWLX;
			parameters[25].Value = model.NYR;
			parameters[26].Value = model.JCFY;

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
		public bool Update(AM.Model.qzj_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update qzj_check set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("WTDW=@WTDW,");
			strSql.Append("WTRQ=@WTRQ,");
			strSql.Append("SYDW=@SYDW,");
			strSql.Append("WTLXRDH=@WTLXRDH,");
			strSql.Append("GCMC=@GCMC,");
			strSql.Append("AZFZRDH=@AZFZRDH,");
			strSql.Append("SGDD=@SGDD,");
			strSql.Append("AZRQ=@AZRQ,");
			strSql.Append("AZDW=@AZDW,");
			strSql.Append("BABH=@BABH,");
			strSql.Append("SCCJ=@SCCJ,");
			strSql.Append("GGXH=@GGXH,");
			strSql.Append("SBMC=@SBMC,");
			strSql.Append("CCBH=@CCBH,");
			strSql.Append("JLDW=@JLDW,");
			strSql.Append("JYSFZDS=@JYSFZDS,");
			strSql.Append("JYSAZGD=@JYSAZGD,");
			strSql.Append("JYSL=@JYSL,");
			strSql.Append("JYLB=@JYLB,");
			strSql.Append("JYYJ=@JYYJ,");
			strSql.Append("WTDWJSZL=@WTDWJSZL,");
			strSql.Append("FWLX=@FWLX,");
			strSql.Append("NYR=@NYR,");
			strSql.Append("JCFY=@JCFY");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@WTDW", MySqlDbType.Text),
					new MySqlParameter("@WTRQ", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@WTLXRDH", MySqlDbType.Text),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@AZFZRDH", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@AZRQ", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@BABH", MySqlDbType.Text),
					new MySqlParameter("@SCCJ", MySqlDbType.Text),
					new MySqlParameter("@GGXH", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@JLDW", MySqlDbType.Text),
					new MySqlParameter("@JYSFZDS", MySqlDbType.Text),
					new MySqlParameter("@JYSAZGD", MySqlDbType.Text),
					new MySqlParameter("@JYSL", MySqlDbType.Text),
					new MySqlParameter("@JYLB", MySqlDbType.Text),
					new MySqlParameter("@JYYJ", MySqlDbType.Text),
					new MySqlParameter("@WTDWJSZL", MySqlDbType.Text),
					new MySqlParameter("@FWLX", MySqlDbType.Text),
					new MySqlParameter("@NYR", MySqlDbType.Text),
					new MySqlParameter("@JCFY", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.WTDW;
			parameters[3].Value = model.WTRQ;
			parameters[4].Value = model.SYDW;
			parameters[5].Value = model.WTLXRDH;
			parameters[6].Value = model.GCMC;
			parameters[7].Value = model.AZFZRDH;
			parameters[8].Value = model.SGDD;
			parameters[9].Value = model.AZRQ;
			parameters[10].Value = model.AZDW;
			parameters[11].Value = model.BABH;
			parameters[12].Value = model.SCCJ;
			parameters[13].Value = model.GGXH;
			parameters[14].Value = model.SBMC;
			parameters[15].Value = model.CCBH;
			parameters[16].Value = model.JLDW;
			parameters[17].Value = model.JYSFZDS;
			parameters[18].Value = model.JYSAZGD;
			parameters[19].Value = model.JYSL;
			parameters[20].Value = model.JYLB;
			parameters[21].Value = model.JYYJ;
			parameters[22].Value = model.WTDWJSZL;
			parameters[23].Value = model.FWLX;
			parameters[24].Value = model.NYR;
			parameters[25].Value = model.JCFY;
			parameters[26].Value = model.Guid;

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
			strSql.Append("delete from qzj_check ");
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
			strSql.Append("delete from qzj_check ");
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
		public AM.Model.qzj_check GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,WTDW,WTRQ,SYDW,WTLXRDH,GCMC,AZFZRDH,SGDD,AZRQ,AZDW,BABH,SCCJ,GGXH,SBMC,CCBH,JLDW,JYSFZDS,JYSAZGD,JYSL,JYLB,JYYJ,WTDWJSZL,FWLX,NYR,JCFY from qzj_check ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.qzj_check model=new AM.Model.qzj_check();
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
		public AM.Model.qzj_check DataRowToModel(DataRow row)
		{
			AM.Model.qzj_check model=new AM.Model.qzj_check();
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
				if(row["WTRQ"]!=null)
				{
					model.WTRQ=row["WTRQ"].ToString();
				}
				if(row["SYDW"]!=null)
				{
					model.SYDW=row["SYDW"].ToString();
				}
				if(row["WTLXRDH"]!=null)
				{
					model.WTLXRDH=row["WTLXRDH"].ToString();
				}
				if(row["GCMC"]!=null)
				{
					model.GCMC=row["GCMC"].ToString();
				}
				if(row["AZFZRDH"]!=null)
				{
					model.AZFZRDH=row["AZFZRDH"].ToString();
				}
				if(row["SGDD"]!=null)
				{
					model.SGDD=row["SGDD"].ToString();
				}
				if(row["AZRQ"]!=null)
				{
					model.AZRQ=row["AZRQ"].ToString();
				}
				if(row["AZDW"]!=null)
				{
					model.AZDW=row["AZDW"].ToString();
				}
				if(row["BABH"]!=null)
				{
					model.BABH=row["BABH"].ToString();
				}
				if(row["SCCJ"]!=null)
				{
					model.SCCJ=row["SCCJ"].ToString();
				}
				if(row["GGXH"]!=null)
				{
					model.GGXH=row["GGXH"].ToString();
				}
				if(row["SBMC"]!=null)
				{
					model.SBMC=row["SBMC"].ToString();
				}
				if(row["CCBH"]!=null)
				{
					model.CCBH=row["CCBH"].ToString();
				}
				if(row["JLDW"]!=null)
				{
					model.JLDW=row["JLDW"].ToString();
				}
				if(row["JYSFZDS"]!=null)
				{
					model.JYSFZDS=row["JYSFZDS"].ToString();
				}
				if(row["JYSAZGD"]!=null)
				{
					model.JYSAZGD=row["JYSAZGD"].ToString();
				}
				if(row["JYSL"]!=null)
				{
					model.JYSL=row["JYSL"].ToString();
				}
				if(row["JYLB"]!=null)
				{
					model.JYLB=row["JYLB"].ToString();
				}
				if(row["JYYJ"]!=null)
				{
					model.JYYJ=row["JYYJ"].ToString();
				}
				if(row["WTDWJSZL"]!=null)
				{
					model.WTDWJSZL=row["WTDWJSZL"].ToString();
				}
				if(row["FWLX"]!=null)
				{
					model.FWLX=row["FWLX"].ToString();
				}
				if(row["NYR"]!=null)
				{
					model.NYR=row["NYR"].ToString();
				}
				if(row["JCFY"]!=null)
				{
					model.JCFY=row["JCFY"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,WTDW,WTRQ,SYDW,WTLXRDH,GCMC,AZFZRDH,SGDD,AZRQ,AZDW,BABH,SCCJ,GGXH,SBMC,CCBH,JLDW,JYSFZDS,JYSAZGD,JYSL,JYLB,JYYJ,WTDWJSZL,FWLX,NYR,JCFY ");
			strSql.Append(" FROM qzj_check ");
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
			strSql.Append("select count(1) FROM qzj_check ");
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
        public qzj_check GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from qzj_check ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            qzj_check model = new qzj_check();
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
            strSql.Append("select * from qzj_check ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM qzj_check TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM qzj_check TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

