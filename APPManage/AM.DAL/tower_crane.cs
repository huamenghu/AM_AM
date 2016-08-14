/**  版本信息模板在安装目录下，可自行修改。
* tower_crane.cs
*
* 功 能： N/A
* 类 名： tower_crane
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
	/// 数据访问类:tower_crane
	/// </summary>
	public partial class tower_craneDAL
	{
        public tower_craneDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tower_crane");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.tower_crane model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tower_crane(");
			strSql.Append("Guid,userid,CreateDate,GCMC,SYDW,SGDD,JLDW,AZDW,AZFZR,SBMC,SBXH,ZZDW,AZGZRQ,CCBH,ZZXKZBH,CCRQ,BABH,ZDEDQZL,EDLJ,XCZDBFSD,BZJGGSL,JYSAZGD,ZDFD,YXDLGD,AZFZDS,DYDFQGD,JYLB,ZYSBMC1,ZYSBXH1,ZYSBBH1,ZYSBZT1,ZYSBMC2,ZYSBXH2,ZYSBBH2,ZYSBZT2,ZYSBMC3,ZYSBXH3,ZYSBBH3,ZYSBZT3,ZYSBMC4,ZYSBXH4,ZYSBBH4,ZYSBZT4,ZYSBMC5,ZYSBXH5,ZYSBBH5,ZYSBZT5,BZXMBHGS,YBXMBHGS)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@GCMC,@SYDW,@SGDD,@JLDW,@AZDW,@AZFZR,@SBMC,@SBXH,@ZZDW,@AZGZRQ,@CCBH,@ZZXKZBH,@CCRQ,@BABH,@ZDEDQZL,@EDLJ,@XCZDBFSD,@BZJGGSL,@JYSAZGD,@ZDFD,@YXDLGD,@AZFZDS,@DYDFQGD,@JYLB,@ZYSBMC1,@ZYSBXH1,@ZYSBBH1,@ZYSBZT1,@ZYSBMC2,@ZYSBXH2,@ZYSBBH2,@ZYSBZT2,@ZYSBMC3,@ZYSBXH3,@ZYSBBH3,@ZYSBZT3,@ZYSBMC4,@ZYSBXH4,@ZYSBBH4,@ZYSBZT4,@ZYSBMC5,@ZYSBXH5,@ZYSBBH5,@ZYSBZT5,@BZXMBHGS,@YBXMBHGS)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@JLDW", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@AZFZR", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@ZZDW", MySqlDbType.Text),
					new MySqlParameter("@AZGZRQ", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@ZZXKZBH", MySqlDbType.Text),
					new MySqlParameter("@CCRQ", MySqlDbType.Text),
					new MySqlParameter("@BABH", MySqlDbType.Text),
					new MySqlParameter("@ZDEDQZL", MySqlDbType.Text),
					new MySqlParameter("@EDLJ", MySqlDbType.Text),
					new MySqlParameter("@XCZDBFSD", MySqlDbType.Text),
					new MySqlParameter("@BZJGGSL", MySqlDbType.Text),
					new MySqlParameter("@JYSAZGD", MySqlDbType.Text),
					new MySqlParameter("@ZDFD", MySqlDbType.Text),
					new MySqlParameter("@YXDLGD", MySqlDbType.Text),
					new MySqlParameter("@AZFZDS", MySqlDbType.Text),
					new MySqlParameter("@DYDFQGD", MySqlDbType.Text),
					new MySqlParameter("@JYLB", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC5", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH5", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH5", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT5", MySqlDbType.Text),
					new MySqlParameter("@BZXMBHGS", MySqlDbType.Text),
					new MySqlParameter("@YBXMBHGS", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.GCMC;
			parameters[4].Value = model.SYDW;
			parameters[5].Value = model.SGDD;
			parameters[6].Value = model.JLDW;
			parameters[7].Value = model.AZDW;
			parameters[8].Value = model.AZFZR;
			parameters[9].Value = model.SBMC;
			parameters[10].Value = model.SBXH;
			parameters[11].Value = model.ZZDW;
			parameters[12].Value = model.AZGZRQ;
			parameters[13].Value = model.CCBH;
			parameters[14].Value = model.ZZXKZBH;
			parameters[15].Value = model.CCRQ;
			parameters[16].Value = model.BABH;
			parameters[17].Value = model.ZDEDQZL;
			parameters[18].Value = model.EDLJ;
			parameters[19].Value = model.XCZDBFSD;
			parameters[20].Value = model.BZJGGSL;
			parameters[21].Value = model.JYSAZGD;
			parameters[22].Value = model.ZDFD;
			parameters[23].Value = model.YXDLGD;
			parameters[24].Value = model.AZFZDS;
			parameters[25].Value = model.DYDFQGD;
			parameters[26].Value = model.JYLB;
			parameters[27].Value = model.ZYSBMC1;
			parameters[28].Value = model.ZYSBXH1;
			parameters[29].Value = model.ZYSBBH1;
			parameters[30].Value = model.ZYSBZT1;
			parameters[31].Value = model.ZYSBMC2;
			parameters[32].Value = model.ZYSBXH2;
			parameters[33].Value = model.ZYSBBH2;
			parameters[34].Value = model.ZYSBZT2;
			parameters[35].Value = model.ZYSBMC3;
			parameters[36].Value = model.ZYSBXH3;
			parameters[37].Value = model.ZYSBBH3;
			parameters[38].Value = model.ZYSBZT3;
			parameters[39].Value = model.ZYSBMC4;
			parameters[40].Value = model.ZYSBXH4;
			parameters[41].Value = model.ZYSBBH4;
			parameters[42].Value = model.ZYSBZT4;
			parameters[43].Value = model.ZYSBMC5;
			parameters[44].Value = model.ZYSBXH5;
			parameters[45].Value = model.ZYSBBH5;
			parameters[46].Value = model.ZYSBZT5;
			parameters[47].Value = model.BZXMBHGS;
			parameters[48].Value = model.YBXMBHGS;

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
		public bool Update(AM.Model.tower_crane model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tower_crane set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("GCMC=@GCMC,");
			strSql.Append("SYDW=@SYDW,");
			strSql.Append("SGDD=@SGDD,");
			strSql.Append("JLDW=@JLDW,");
			strSql.Append("AZDW=@AZDW,");
			strSql.Append("AZFZR=@AZFZR,");
			strSql.Append("SBMC=@SBMC,");
			strSql.Append("SBXH=@SBXH,");
			strSql.Append("ZZDW=@ZZDW,");
			strSql.Append("AZGZRQ=@AZGZRQ,");
			strSql.Append("CCBH=@CCBH,");
			strSql.Append("ZZXKZBH=@ZZXKZBH,");
			strSql.Append("CCRQ=@CCRQ,");
			strSql.Append("BABH=@BABH,");
			strSql.Append("ZDEDQZL=@ZDEDQZL,");
			strSql.Append("EDLJ=@EDLJ,");
			strSql.Append("XCZDBFSD=@XCZDBFSD,");
			strSql.Append("BZJGGSL=@BZJGGSL,");
			strSql.Append("JYSAZGD=@JYSAZGD,");
			strSql.Append("ZDFD=@ZDFD,");
			strSql.Append("YXDLGD=@YXDLGD,");
			strSql.Append("AZFZDS=@AZFZDS,");
			strSql.Append("DYDFQGD=@DYDFQGD,");
			strSql.Append("JYLB=@JYLB,");
			strSql.Append("ZYSBMC1=@ZYSBMC1,");
			strSql.Append("ZYSBXH1=@ZYSBXH1,");
			strSql.Append("ZYSBBH1=@ZYSBBH1,");
			strSql.Append("ZYSBZT1=@ZYSBZT1,");
			strSql.Append("ZYSBMC2=@ZYSBMC2,");
			strSql.Append("ZYSBXH2=@ZYSBXH2,");
			strSql.Append("ZYSBBH2=@ZYSBBH2,");
			strSql.Append("ZYSBZT2=@ZYSBZT2,");
			strSql.Append("ZYSBMC3=@ZYSBMC3,");
			strSql.Append("ZYSBXH3=@ZYSBXH3,");
			strSql.Append("ZYSBBH3=@ZYSBBH3,");
			strSql.Append("ZYSBZT3=@ZYSBZT3,");
			strSql.Append("ZYSBMC4=@ZYSBMC4,");
			strSql.Append("ZYSBXH4=@ZYSBXH4,");
			strSql.Append("ZYSBBH4=@ZYSBBH4,");
			strSql.Append("ZYSBZT4=@ZYSBZT4,");
			strSql.Append("ZYSBMC5=@ZYSBMC5,");
			strSql.Append("ZYSBXH5=@ZYSBXH5,");
			strSql.Append("ZYSBBH5=@ZYSBBH5,");
			strSql.Append("ZYSBZT5=@ZYSBZT5,");
			strSql.Append("BZXMBHGS=@BZXMBHGS,");
			strSql.Append("YBXMBHGS=@YBXMBHGS");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@SYDW", MySqlDbType.Text),
					new MySqlParameter("@SGDD", MySqlDbType.Text),
					new MySqlParameter("@JLDW", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@AZFZR", MySqlDbType.Text),
					new MySqlParameter("@SBMC", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@ZZDW", MySqlDbType.Text),
					new MySqlParameter("@AZGZRQ", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@ZZXKZBH", MySqlDbType.Text),
					new MySqlParameter("@CCRQ", MySqlDbType.Text),
					new MySqlParameter("@BABH", MySqlDbType.Text),
					new MySqlParameter("@ZDEDQZL", MySqlDbType.Text),
					new MySqlParameter("@EDLJ", MySqlDbType.Text),
					new MySqlParameter("@XCZDBFSD", MySqlDbType.Text),
					new MySqlParameter("@BZJGGSL", MySqlDbType.Text),
					new MySqlParameter("@JYSAZGD", MySqlDbType.Text),
					new MySqlParameter("@ZDFD", MySqlDbType.Text),
					new MySqlParameter("@YXDLGD", MySqlDbType.Text),
					new MySqlParameter("@AZFZDS", MySqlDbType.Text),
					new MySqlParameter("@DYDFQGD", MySqlDbType.Text),
					new MySqlParameter("@JYLB", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT1", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT2", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT3", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT4", MySqlDbType.Text),
					new MySqlParameter("@ZYSBMC5", MySqlDbType.Text),
					new MySqlParameter("@ZYSBXH5", MySqlDbType.Text),
					new MySqlParameter("@ZYSBBH5", MySqlDbType.Text),
					new MySqlParameter("@ZYSBZT5", MySqlDbType.Text),
					new MySqlParameter("@BZXMBHGS", MySqlDbType.Text),
					new MySqlParameter("@YBXMBHGS", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.GCMC;
			parameters[3].Value = model.SYDW;
			parameters[4].Value = model.SGDD;
			parameters[5].Value = model.JLDW;
			parameters[6].Value = model.AZDW;
			parameters[7].Value = model.AZFZR;
			parameters[8].Value = model.SBMC;
			parameters[9].Value = model.SBXH;
			parameters[10].Value = model.ZZDW;
			parameters[11].Value = model.AZGZRQ;
			parameters[12].Value = model.CCBH;
			parameters[13].Value = model.ZZXKZBH;
			parameters[14].Value = model.CCRQ;
			parameters[15].Value = model.BABH;
			parameters[16].Value = model.ZDEDQZL;
			parameters[17].Value = model.EDLJ;
			parameters[18].Value = model.XCZDBFSD;
			parameters[19].Value = model.BZJGGSL;
			parameters[20].Value = model.JYSAZGD;
			parameters[21].Value = model.ZDFD;
			parameters[22].Value = model.YXDLGD;
			parameters[23].Value = model.AZFZDS;
			parameters[24].Value = model.DYDFQGD;
			parameters[25].Value = model.JYLB;
			parameters[26].Value = model.ZYSBMC1;
			parameters[27].Value = model.ZYSBXH1;
			parameters[28].Value = model.ZYSBBH1;
			parameters[29].Value = model.ZYSBZT1;
			parameters[30].Value = model.ZYSBMC2;
			parameters[31].Value = model.ZYSBXH2;
			parameters[32].Value = model.ZYSBBH2;
			parameters[33].Value = model.ZYSBZT2;
			parameters[34].Value = model.ZYSBMC3;
			parameters[35].Value = model.ZYSBXH3;
			parameters[36].Value = model.ZYSBBH3;
			parameters[37].Value = model.ZYSBZT3;
			parameters[38].Value = model.ZYSBMC4;
			parameters[39].Value = model.ZYSBXH4;
			parameters[40].Value = model.ZYSBBH4;
			parameters[41].Value = model.ZYSBZT4;
			parameters[42].Value = model.ZYSBMC5;
			parameters[43].Value = model.ZYSBXH5;
			parameters[44].Value = model.ZYSBBH5;
			parameters[45].Value = model.ZYSBZT5;
			parameters[46].Value = model.BZXMBHGS;
			parameters[47].Value = model.YBXMBHGS;
			parameters[48].Value = model.Guid;

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
			strSql.Append("delete from tower_crane ");
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
			strSql.Append("delete from tower_crane ");
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
		public AM.Model.tower_crane GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,GCMC,SYDW,SGDD,JLDW,AZDW,AZFZR,SBMC,SBXH,ZZDW,AZGZRQ,CCBH,ZZXKZBH,CCRQ,BABH,ZDEDQZL,EDLJ,XCZDBFSD,BZJGGSL,JYSAZGD,ZDFD,YXDLGD,AZFZDS,DYDFQGD,JYLB,ZYSBMC1,ZYSBXH1,ZYSBBH1,ZYSBZT1,ZYSBMC2,ZYSBXH2,ZYSBBH2,ZYSBZT2,ZYSBMC3,ZYSBXH3,ZYSBBH3,ZYSBZT3,ZYSBMC4,ZYSBXH4,ZYSBBH4,ZYSBZT4,ZYSBMC5,ZYSBXH5,ZYSBBH5,ZYSBZT5,BZXMBHGS,YBXMBHGS from tower_crane ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.tower_crane model=new AM.Model.tower_crane();
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
		public AM.Model.tower_crane DataRowToModel(DataRow row)
		{
			AM.Model.tower_crane model=new AM.Model.tower_crane();
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
				if(row["SYDW"]!=null)
				{
					model.SYDW=row["SYDW"].ToString();
				}
				if(row["SGDD"]!=null)
				{
					model.SGDD=row["SGDD"].ToString();
				}
				if(row["JLDW"]!=null)
				{
					model.JLDW=row["JLDW"].ToString();
				}
				if(row["AZDW"]!=null)
				{
					model.AZDW=row["AZDW"].ToString();
				}
				if(row["AZFZR"]!=null)
				{
					model.AZFZR=row["AZFZR"].ToString();
				}
				if(row["SBMC"]!=null)
				{
					model.SBMC=row["SBMC"].ToString();
				}
				if(row["SBXH"]!=null)
				{
					model.SBXH=row["SBXH"].ToString();
				}
				if(row["ZZDW"]!=null)
				{
					model.ZZDW=row["ZZDW"].ToString();
				}
				if(row["AZGZRQ"]!=null)
				{
					model.AZGZRQ=row["AZGZRQ"].ToString();
				}
				if(row["CCBH"]!=null)
				{
					model.CCBH=row["CCBH"].ToString();
				}
				if(row["ZZXKZBH"]!=null)
				{
					model.ZZXKZBH=row["ZZXKZBH"].ToString();
				}
				if(row["CCRQ"]!=null)
				{
					model.CCRQ=row["CCRQ"].ToString();
				}
				if(row["BABH"]!=null)
				{
					model.BABH=row["BABH"].ToString();
				}
				if(row["ZDEDQZL"]!=null)
				{
					model.ZDEDQZL=row["ZDEDQZL"].ToString();
				}
				if(row["EDLJ"]!=null)
				{
					model.EDLJ=row["EDLJ"].ToString();
				}
				if(row["XCZDBFSD"]!=null)
				{
					model.XCZDBFSD=row["XCZDBFSD"].ToString();
				}
				if(row["BZJGGSL"]!=null)
				{
					model.BZJGGSL=row["BZJGGSL"].ToString();
				}
				if(row["JYSAZGD"]!=null)
				{
					model.JYSAZGD=row["JYSAZGD"].ToString();
				}
				if(row["ZDFD"]!=null)
				{
					model.ZDFD=row["ZDFD"].ToString();
				}
				if(row["YXDLGD"]!=null)
				{
					model.YXDLGD=row["YXDLGD"].ToString();
				}
				if(row["AZFZDS"]!=null)
				{
					model.AZFZDS=row["AZFZDS"].ToString();
				}
				if(row["DYDFQGD"]!=null)
				{
					model.DYDFQGD=row["DYDFQGD"].ToString();
				}
				if(row["JYLB"]!=null)
				{
					model.JYLB=row["JYLB"].ToString();
				}
				if(row["ZYSBMC1"]!=null)
				{
					model.ZYSBMC1=row["ZYSBMC1"].ToString();
				}
				if(row["ZYSBXH1"]!=null)
				{
					model.ZYSBXH1=row["ZYSBXH1"].ToString();
				}
				if(row["ZYSBBH1"]!=null)
				{
					model.ZYSBBH1=row["ZYSBBH1"].ToString();
				}
				if(row["ZYSBZT1"]!=null)
				{
					model.ZYSBZT1=row["ZYSBZT1"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBMC2") && row["ZYSBMC2"] != null)
				{
					model.ZYSBMC2=row["ZYSBMC2"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBXH2") && row["ZYSBXH2"] != null)
				{
					model.ZYSBXH2=row["ZYSBXH2"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBBH2") && row["ZYSBBH2"] != null)
				{
					model.ZYSBBH2=row["ZYSBBH2"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBZT2") && row["ZYSBZT2"] != null)
				{
					model.ZYSBZT2=row["ZYSBZT2"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBMC3") && row["ZYSBMC3"] != null)
				{
					model.ZYSBMC3=row["ZYSBMC3"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBXH3") && row["ZYSBXH3"] != null)
				{
					model.ZYSBXH3=row["ZYSBXH3"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBBH3") && row["ZYSBBH3"] != null)
				{
					model.ZYSBBH3=row["ZYSBBH3"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBZT3") && row["ZYSBZT3"] != null)
				{
					model.ZYSBZT3=row["ZYSBZT3"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBMC4") && row["ZYSBMC4"] != null)
				{
					model.ZYSBMC4=row["ZYSBMC4"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBXH4") && row["ZYSBXH4"] != null)
				{
					model.ZYSBXH4=row["ZYSBXH4"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBBH4") && row["ZYSBBH4"] != null)
				{
					model.ZYSBBH4=row["ZYSBBH4"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBZT4") && row["ZYSBZT4"] != null)
				{
					model.ZYSBZT4=row["ZYSBZT4"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBMC5") && row["ZYSBMC5"] != null)
				{
					model.ZYSBMC5=row["ZYSBMC5"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBXH5") && row["ZYSBXH5"] != null)
				{
					model.ZYSBXH5=row["ZYSBXH5"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBBH5") && row["ZYSBBH5"] != null)
				{
					model.ZYSBBH5=row["ZYSBBH5"].ToString();
				}
                if (row.Table.Columns.Contains("ZYSBZT5") && row["ZYSBZT5"] != null)
				{
					model.ZYSBZT5=row["ZYSBZT5"].ToString();
				}
				if(row["BZXMBHGS"]!=null)
				{
					model.BZXMBHGS=row["BZXMBHGS"].ToString();
				}
				if(row["YBXMBHGS"]!=null)
				{
					model.YBXMBHGS=row["YBXMBHGS"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,GCMC,SYDW,SGDD,JLDW,AZDW,AZFZR,SBMC,SBXH,ZZDW,AZGZRQ,CCBH,ZZXKZBH,CCRQ,BABH,ZDEDQZL,EDLJ,XCZDBFSD,BZJGGSL,JYSAZGD,ZDFD,YXDLGD,AZFZDS,DYDFQGD,JYLB,ZYSBMC1,ZYSBXH1,ZYSBBH1,ZYSBZT1,ZYSBMC2,ZYSBXH2,ZYSBBH2,ZYSBZT2,ZYSBMC3,ZYSBXH3,ZYSBBH3,ZYSBZT3,ZYSBMC4,ZYSBXH4,ZYSBBH4,ZYSBZT4,ZYSBMC5,ZYSBXH5,ZYSBBH5,ZYSBZT5,BZXMBHGS,YBXMBHGS ");
			strSql.Append(" FROM tower_crane ");
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
			strSql.Append("select count(1) FROM tower_crane ");
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
        public tower_crane GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tower_crane ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            tower_crane model = new tower_crane();
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
            strSql.Append("select * from tower_crane ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM tower_crane TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM tower_crane TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

