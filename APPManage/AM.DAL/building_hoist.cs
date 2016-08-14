/**  版本信息模板在安装目录下，可自行修改。
* building_hoist.cs
*
* 功 能： N/A
* 类 名： building_hoist
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:17   N/A    初版
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
	/// 数据访问类:building_hoist
	/// </summary>
	public partial class building_hoistDAL
	{
        public building_hoistDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from building_hoist");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.building_hoist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into building_hoist(");
			strSql.Append("Guid,userid,CreateDate,GCMC,SYDW,SGDD,JLDW,AZDW,AZFZR,SBMC,SBXH,ZZDW,ZZXKZH,CCBH,AZGZRQ,BABH,EDZZL,DLZL,EDTSSD,FZAQQXS,DZZL,TYSAZGD,ZYDGD,FQDS,DYFQGD,BZJGG,JYLX,YQMC1,XH1,BH1,ZT1,YQMC2,XH2,BH2,ZT2,YQMC3,XH3,BH3,ZT3,YQMC4,XH4,BH4,ZT4,YQMC5,XH5,BH5,ZT5,BZXMBHGS,YBXMBHGS)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@GCMC,@SYDW,@SGDD,@JLDW,@AZDW,@AZFZR,@SBMC,@SBXH,@ZZDW,@ZZXKZH,@CCBH,@AZGZRQ,@BABH,@EDZZL,@DLZL,@EDTSSD,@FZAQQXS,@DZZL,@TYSAZGD,@ZYDGD,@FQDS,@DYFQGD,@BZJGG,@JYLX,@YQMC1,@XH1,@BH1,@ZT1,@YQMC2,@XH2,@BH2,@ZT2,@YQMC3,@XH3,@BH3,@ZT3,@YQMC4,@XH4,@BH4,@ZT4,@YQMC5,@XH5,@BH5,@ZT5,@BZXMBHGS,@YBXMBHGS)");
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
					new MySqlParameter("@ZZXKZH", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@AZGZRQ", MySqlDbType.Text),
					new MySqlParameter("@BABH", MySqlDbType.Text),
					new MySqlParameter("@EDZZL", MySqlDbType.Text),
					new MySqlParameter("@DLZL", MySqlDbType.Text),
					new MySqlParameter("@EDTSSD", MySqlDbType.Text),
					new MySqlParameter("@FZAQQXS", MySqlDbType.Text),
					new MySqlParameter("@DZZL", MySqlDbType.Text),
					new MySqlParameter("@TYSAZGD", MySqlDbType.Text),
					new MySqlParameter("@ZYDGD", MySqlDbType.Text),
					new MySqlParameter("@FQDS", MySqlDbType.Text),
					new MySqlParameter("@DYFQGD", MySqlDbType.Text),
					new MySqlParameter("@BZJGG", MySqlDbType.Text),
					new MySqlParameter("@JYLX", MySqlDbType.Text),
					new MySqlParameter("@YQMC1", MySqlDbType.Text),
					new MySqlParameter("@XH1", MySqlDbType.Text),
					new MySqlParameter("@BH1", MySqlDbType.Text),
					new MySqlParameter("@ZT1", MySqlDbType.Text),
					new MySqlParameter("@YQMC2", MySqlDbType.Text),
					new MySqlParameter("@XH2", MySqlDbType.Text),
					new MySqlParameter("@BH2", MySqlDbType.Text),
					new MySqlParameter("@ZT2", MySqlDbType.Text),
					new MySqlParameter("@YQMC3", MySqlDbType.Text),
					new MySqlParameter("@XH3", MySqlDbType.Text),
					new MySqlParameter("@BH3", MySqlDbType.Text),
					new MySqlParameter("@ZT3", MySqlDbType.Text),
					new MySqlParameter("@YQMC4", MySqlDbType.Text),
					new MySqlParameter("@XH4", MySqlDbType.Text),
					new MySqlParameter("@BH4", MySqlDbType.Text),
					new MySqlParameter("@ZT4", MySqlDbType.Text),
					new MySqlParameter("@YQMC5", MySqlDbType.Text),
					new MySqlParameter("@XH5", MySqlDbType.Text),
					new MySqlParameter("@BH5", MySqlDbType.Text),
					new MySqlParameter("@ZT5", MySqlDbType.Text),
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
			parameters[12].Value = model.ZZXKZH;
			parameters[13].Value = model.CCBH;
			parameters[14].Value = model.AZGZRQ;
			parameters[15].Value = model.BABH;
			parameters[16].Value = model.EDZZL;
			parameters[17].Value = model.DLZL;
			parameters[18].Value = model.EDTSSD;
			parameters[19].Value = model.FZAQQXS;
			parameters[20].Value = model.DZZL;
			parameters[21].Value = model.TYSAZGD;
			parameters[22].Value = model.ZYDGD;
			parameters[23].Value = model.FQDS;
			parameters[24].Value = model.DYFQGD;
			parameters[25].Value = model.BZJGG;
			parameters[26].Value = model.JYLX;
			parameters[27].Value = model.YQMC1;
			parameters[28].Value = model.XH1;
			parameters[29].Value = model.BH1;
			parameters[30].Value = model.ZT1;
			parameters[31].Value = model.YQMC2;
			parameters[32].Value = model.XH2;
			parameters[33].Value = model.BH2;
			parameters[34].Value = model.ZT2;
			parameters[35].Value = model.YQMC3;
			parameters[36].Value = model.XH3;
			parameters[37].Value = model.BH3;
			parameters[38].Value = model.ZT3;
			parameters[39].Value = model.YQMC4;
			parameters[40].Value = model.XH4;
			parameters[41].Value = model.BH4;
			parameters[42].Value = model.ZT4;
			parameters[43].Value = model.YQMC5;
			parameters[44].Value = model.XH5;
			parameters[45].Value = model.BH5;
			parameters[46].Value = model.ZT5;
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
		public bool Update(AM.Model.building_hoist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update building_hoist set ");
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
			strSql.Append("ZZXKZH=@ZZXKZH,");
			strSql.Append("CCBH=@CCBH,");
			strSql.Append("AZGZRQ=@AZGZRQ,");
			strSql.Append("BABH=@BABH,");
			strSql.Append("EDZZL=@EDZZL,");
			strSql.Append("DLZL=@DLZL,");
			strSql.Append("EDTSSD=@EDTSSD,");
			strSql.Append("FZAQQXS=@FZAQQXS,");
			strSql.Append("DZZL=@DZZL,");
			strSql.Append("TYSAZGD=@TYSAZGD,");
			strSql.Append("ZYDGD=@ZYDGD,");
			strSql.Append("FQDS=@FQDS,");
			strSql.Append("DYFQGD=@DYFQGD,");
			strSql.Append("BZJGG=@BZJGG,");
			strSql.Append("JYLX=@JYLX,");
			strSql.Append("YQMC1=@YQMC1,");
			strSql.Append("XH1=@XH1,");
			strSql.Append("BH1=@BH1,");
			strSql.Append("ZT1=@ZT1,");
			strSql.Append("YQMC2=@YQMC2,");
			strSql.Append("XH2=@XH2,");
			strSql.Append("BH2=@BH2,");
			strSql.Append("ZT2=@ZT2,");
			strSql.Append("YQMC3=@YQMC3,");
			strSql.Append("XH3=@XH3,");
			strSql.Append("BH3=@BH3,");
			strSql.Append("ZT3=@ZT3,");
			strSql.Append("YQMC4=@YQMC4,");
			strSql.Append("XH4=@XH4,");
			strSql.Append("BH4=@BH4,");
			strSql.Append("ZT4=@ZT4,");
			strSql.Append("YQMC5=@YQMC5,");
			strSql.Append("XH5=@XH5,");
			strSql.Append("BH5=@BH5,");
			strSql.Append("ZT5=@ZT5,");
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
					new MySqlParameter("@ZZXKZH", MySqlDbType.Text),
					new MySqlParameter("@CCBH", MySqlDbType.Text),
					new MySqlParameter("@AZGZRQ", MySqlDbType.Text),
					new MySqlParameter("@BABH", MySqlDbType.Text),
					new MySqlParameter("@EDZZL", MySqlDbType.Text),
					new MySqlParameter("@DLZL", MySqlDbType.Text),
					new MySqlParameter("@EDTSSD", MySqlDbType.Text),
					new MySqlParameter("@FZAQQXS", MySqlDbType.Text),
					new MySqlParameter("@DZZL", MySqlDbType.Text),
					new MySqlParameter("@TYSAZGD", MySqlDbType.Text),
					new MySqlParameter("@ZYDGD", MySqlDbType.Text),
					new MySqlParameter("@FQDS", MySqlDbType.Text),
					new MySqlParameter("@DYFQGD", MySqlDbType.Text),
					new MySqlParameter("@BZJGG", MySqlDbType.Text),
					new MySqlParameter("@JYLX", MySqlDbType.Text),
					new MySqlParameter("@YQMC1", MySqlDbType.Text),
					new MySqlParameter("@XH1", MySqlDbType.Text),
					new MySqlParameter("@BH1", MySqlDbType.Text),
					new MySqlParameter("@ZT1", MySqlDbType.Text),
					new MySqlParameter("@YQMC2", MySqlDbType.Text),
					new MySqlParameter("@XH2", MySqlDbType.Text),
					new MySqlParameter("@BH2", MySqlDbType.Text),
					new MySqlParameter("@ZT2", MySqlDbType.Text),
					new MySqlParameter("@YQMC3", MySqlDbType.Text),
					new MySqlParameter("@XH3", MySqlDbType.Text),
					new MySqlParameter("@BH3", MySqlDbType.Text),
					new MySqlParameter("@ZT3", MySqlDbType.Text),
					new MySqlParameter("@YQMC4", MySqlDbType.Text),
					new MySqlParameter("@XH4", MySqlDbType.Text),
					new MySqlParameter("@BH4", MySqlDbType.Text),
					new MySqlParameter("@ZT4", MySqlDbType.Text),
					new MySqlParameter("@YQMC5", MySqlDbType.Text),
					new MySqlParameter("@XH5", MySqlDbType.Text),
					new MySqlParameter("@BH5", MySqlDbType.Text),
					new MySqlParameter("@ZT5", MySqlDbType.Text),
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
			parameters[11].Value = model.ZZXKZH;
			parameters[12].Value = model.CCBH;
			parameters[13].Value = model.AZGZRQ;
			parameters[14].Value = model.BABH;
			parameters[15].Value = model.EDZZL;
			parameters[16].Value = model.DLZL;
			parameters[17].Value = model.EDTSSD;
			parameters[18].Value = model.FZAQQXS;
			parameters[19].Value = model.DZZL;
			parameters[20].Value = model.TYSAZGD;
			parameters[21].Value = model.ZYDGD;
			parameters[22].Value = model.FQDS;
			parameters[23].Value = model.DYFQGD;
			parameters[24].Value = model.BZJGG;
			parameters[25].Value = model.JYLX;
			parameters[26].Value = model.YQMC1;
			parameters[27].Value = model.XH1;
			parameters[28].Value = model.BH1;
			parameters[29].Value = model.ZT1;
			parameters[30].Value = model.YQMC2;
			parameters[31].Value = model.XH2;
			parameters[32].Value = model.BH2;
			parameters[33].Value = model.ZT2;
			parameters[34].Value = model.YQMC3;
			parameters[35].Value = model.XH3;
			parameters[36].Value = model.BH3;
			parameters[37].Value = model.ZT3;
			parameters[38].Value = model.YQMC4;
			parameters[39].Value = model.XH4;
			parameters[40].Value = model.BH4;
			parameters[41].Value = model.ZT4;
			parameters[42].Value = model.YQMC5;
			parameters[43].Value = model.XH5;
			parameters[44].Value = model.BH5;
			parameters[45].Value = model.ZT5;
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
			strSql.Append("delete from building_hoist ");
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
			strSql.Append("delete from building_hoist ");
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
		public AM.Model.building_hoist GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,GCMC,SYDW,SGDD,JLDW,AZDW,AZFZR,SBMC,SBXH,ZZDW,ZZXKZH,CCBH,AZGZRQ,BABH,EDZZL,DLZL,EDTSSD,FZAQQXS,DZZL,TYSAZGD,ZYDGD,FQDS,DYFQGD,BZJGG,JYLX,YQMC1,XH1,BH1,ZT1,YQMC2,XH2,BH2,ZT2,YQMC3,XH3,BH3,ZT3,YQMC4,XH4,BH4,ZT4,YQMC5,XH5,BH5,ZT5,BZXMBHGS,YBXMBHGS from building_hoist ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.building_hoist model=new AM.Model.building_hoist();
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
		public AM.Model.building_hoist DataRowToModel(DataRow row)
		{
			AM.Model.building_hoist model=new AM.Model.building_hoist();
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
				if(row["ZZXKZH"]!=null)
				{
					model.ZZXKZH=row["ZZXKZH"].ToString();
				}
				if(row["CCBH"]!=null)
				{
					model.CCBH=row["CCBH"].ToString();
				}
				if(row["AZGZRQ"]!=null)
				{
					model.AZGZRQ=row["AZGZRQ"].ToString();
				}
				if(row["BABH"]!=null)
				{
					model.BABH=row["BABH"].ToString();
				}
				if(row["EDZZL"]!=null)
				{
					model.EDZZL=row["EDZZL"].ToString();
				}
				if(row["DLZL"]!=null)
				{
					model.DLZL=row["DLZL"].ToString();
				}
				if(row["EDTSSD"]!=null)
				{
					model.EDTSSD=row["EDTSSD"].ToString();
				}
				if(row["FZAQQXS"]!=null)
				{
					model.FZAQQXS=row["FZAQQXS"].ToString();
				}
				if(row["DZZL"]!=null)
				{
					model.DZZL=row["DZZL"].ToString();
				}
				if(row["TYSAZGD"]!=null)
				{
					model.TYSAZGD=row["TYSAZGD"].ToString();
				}
				if(row["ZYDGD"]!=null)
				{
					model.ZYDGD=row["ZYDGD"].ToString();
				}
				if(row["FQDS"]!=null)
				{
					model.FQDS=row["FQDS"].ToString();
				}
				if(row["DYFQGD"]!=null)
				{
					model.DYFQGD=row["DYFQGD"].ToString();
				}
				if(row["BZJGG"]!=null)
				{
					model.BZJGG=row["BZJGG"].ToString();
				}
				if(row["JYLX"]!=null)
				{
					model.JYLX=row["JYLX"].ToString();
				}
                if (row.Table.Columns.Contains("YQMC1") && row["YQMC1"] != null)
				{
					model.YQMC1=row["YQMC1"].ToString();
				}
                if (row.Table.Columns.Contains("XH1") && row["XH1"] != null)
				{
					model.XH1=row["XH1"].ToString();
				}
                if (row.Table.Columns.Contains("BH1") && row["BH1"] != null)
				{
					model.BH1=row["BH1"].ToString();
				}
                if (row.Table.Columns.Contains("ZT1") && row["ZT1"] != null)
				{
					model.ZT1=row["ZT1"].ToString();
				}
                if (row.Table.Columns.Contains("YQMC2") && row["YQMC2"] != null)
				{
					model.YQMC2=row["YQMC2"].ToString();
				}
                if (row.Table.Columns.Contains("XH2") && row["XH2"] != null)
				{
					model.XH2=row["XH2"].ToString();
				}
                if (row.Table.Columns.Contains("BH2") && row["BH2"] != null)
				{
					model.BH2=row["BH2"].ToString();
				}
                if (row.Table.Columns.Contains("ZT2") && row["ZT2"] != null)
				{
					model.ZT2=row["ZT2"].ToString();
				}
                if (row.Table.Columns.Contains("YQMC3") && row["YQMC3"] != null)
				{
					model.YQMC3=row["YQMC3"].ToString();
				}
                if (row.Table.Columns.Contains("XH3") && row["XH3"] != null)
				{
					model.XH3=row["XH3"].ToString();
				}
                if (row.Table.Columns.Contains("BH3") && row["BH3"] != null)
				{
					model.BH3=row["BH3"].ToString();
				}
                if (row.Table.Columns.Contains("ZT3") && row["ZT3"] != null)
				{
					model.ZT3=row["ZT3"].ToString();
				}
                if (row.Table.Columns.Contains("YQMC4") && row["YQMC4"] != null)
				{
					model.YQMC4=row["YQMC4"].ToString();
				}
                if (row.Table.Columns.Contains("XH4") && row["XH4"] != null)
				{
					model.XH4=row["XH4"].ToString();
				}
                if (row.Table.Columns.Contains("BH4") && row["BH4"] != null)
				{
					model.BH4=row["BH4"].ToString();
				}
                if (row.Table.Columns.Contains("ZT4") && row["ZT4"] != null)
				{
					model.ZT4=row["ZT4"].ToString();
				}
                if (row.Table.Columns.Contains("YQMC5") && row["YQMC5"] != null)
				{
					model.YQMC5=row["YQMC5"].ToString();
				}
                if (row.Table.Columns.Contains("XH5") && row["XH5"] != null)
				{
					model.XH5=row["XH5"].ToString();
				}
                if (row.Table.Columns.Contains("BH5") && row["BH5"] != null)
				{
					model.BH5=row["BH5"].ToString();
				}
                if (row.Table.Columns.Contains("ZT5") && row["ZT5"] != null)
				{
					model.ZT5=row["ZT5"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,GCMC,SYDW,SGDD,JLDW,AZDW,AZFZR,SBMC,SBXH,ZZDW,ZZXKZH,CCBH,AZGZRQ,BABH,EDZZL,DLZL,EDTSSD,FZAQQXS,DZZL,TYSAZGD,ZYDGD,FQDS,DYFQGD,BZJGG,JYLX,YQMC1,XH1,BH1,ZT1,YQMC2,XH2,BH2,ZT2,YQMC3,XH3,BH3,ZT3,YQMC4,XH4,BH4,ZT4,YQMC5,XH5,BH5,ZT5,BZXMBHGS,YBXMBHGS ");
			strSql.Append(" FROM building_hoist ");
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
			strSql.Append("select count(1) FROM building_hoist ");
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
        public building_hoist GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from building_hoist ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            building_hoist model = new building_hoist();
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
            strSql.Append("select * from building_hoist ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM building_hoist TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM building_hoist TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

