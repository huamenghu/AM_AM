/**  版本信息模板在安装目录下，可自行修改。
* basket_install.cs
*
* 功 能： N/A
* 类 名： basket_install
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
	/// 数据访问类:basket_install
	/// </summary>
	public partial class basket_installDAL
	{
        public basket_installDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from basket_install");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.basket_install model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into basket_install(");
			strSql.Append("Guid,userid,CreateDate,gcmc,sgdd,sydw,jldw,sbmc,azdw,sbxh,sbbh,sccj,aqsbh,tzsbsczzxkz,cqbh,ccrq,jygd,szzobbh,szzobyqzk,wsdjbh,wsdjyqzk,szwybbh,szwybyqzk,scbh,scyqzk,gzcbh,gzcyqzk,szjdcbh,szjdcyqzk,fsybh,fsyyqzk,ybkcbh,ybkcyqzk,gjc30mbh,gjc30mzxkz,gjc5mbh,gjc5mzxkz,bzxmbhgs,ybxmbhgs)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@gcmc,@sgdd,@sydw,@jldw,@sbmc,@azdw,@sbxh,@sbbh,@sccj,@aqsbh,@tzsbsczzxkz,@cqbh,@ccrq,@jygd,@szzobbh,@szzobyqzk,@wsdjbh,@wsdjyqzk,@szwybbh,@szwybyqzk,@scbh,@scyqzk,@gzcbh,@gzcyqzk,@szjdcbh,@szjdcyqzk,@fsybh,@fsyyqzk,@ybkcbh,@ybkcyqzk,@gjc30mbh,@gjc30mzxkz,@gjc5mbh,@gjc5mzxkz,@bzxmbhgs,@ybxmbhgs)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@gcmc", MySqlDbType.VarChar,255),
					new MySqlParameter("@sgdd", MySqlDbType.VarChar,255),
					new MySqlParameter("@sydw", MySqlDbType.VarChar,255),
					new MySqlParameter("@jldw", MySqlDbType.VarChar,255),
					new MySqlParameter("@sbmc", MySqlDbType.VarChar,255),
					new MySqlParameter("@azdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@sbxh", MySqlDbType.VarChar,255),
					new MySqlParameter("@sbbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@sccj", MySqlDbType.VarChar,255),
					new MySqlParameter("@aqsbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@tzsbsczzxkz", MySqlDbType.VarChar,255),
					new MySqlParameter("@cqbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ccrq", MySqlDbType.VarChar,255),
					new MySqlParameter("@jygd", MySqlDbType.VarChar,255),
					new MySqlParameter("@szzobbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@szzobyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@wsdjbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@wsdjyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@szwybbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@szwybyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@scbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@scyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzcbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzcyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@szjdcbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@szjdcyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@fsybh", MySqlDbType.VarChar,255),
					new MySqlParameter("@fsyyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@ybkcbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ybkcyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc30mbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc30mzxkz", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc5mbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc5mzxkz", MySqlDbType.VarChar,255),
					new MySqlParameter("@bzxmbhgs", MySqlDbType.VarChar,255),
					new MySqlParameter("@ybxmbhgs", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.gcmc;
			parameters[4].Value = model.sgdd;
			parameters[5].Value = model.sydw;
			parameters[6].Value = model.jldw;
			parameters[7].Value = model.sbmc;
			parameters[8].Value = model.azdw;
			parameters[9].Value = model.sbxh;
			parameters[10].Value = model.sbbh;
			parameters[11].Value = model.sccj;
			parameters[12].Value = model.aqsbh;
			parameters[13].Value = model.tzsbsczzxkz;
			parameters[14].Value = model.cqbh;
			parameters[15].Value = model.ccrq;
			parameters[16].Value = model.jygd;
			parameters[17].Value = model.szzobbh;
			parameters[18].Value = model.szzobyqzk;
			parameters[19].Value = model.wsdjbh;
			parameters[20].Value = model.wsdjyqzk;
			parameters[21].Value = model.szwybbh;
			parameters[22].Value = model.szwybyqzk;
			parameters[23].Value = model.scbh;
			parameters[24].Value = model.scyqzk;
			parameters[25].Value = model.gzcbh;
			parameters[26].Value = model.gzcyqzk;
			parameters[27].Value = model.szjdcbh;
			parameters[28].Value = model.szjdcyqzk;
			parameters[29].Value = model.fsybh;
			parameters[30].Value = model.fsyyqzk;
			parameters[31].Value = model.ybkcbh;
			parameters[32].Value = model.ybkcyqzk;
			parameters[33].Value = model.gjc30mbh;
			parameters[34].Value = model.gjc30mzxkz;
			parameters[35].Value = model.gjc5mbh;
			parameters[36].Value = model.gjc5mzxkz;
			parameters[37].Value = model.bzxmbhgs;
			parameters[38].Value = model.ybxmbhgs;

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
		public bool Update(AM.Model.basket_install model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update basket_install set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("gcmc=@gcmc,");
			strSql.Append("sgdd=@sgdd,");
			strSql.Append("sydw=@sydw,");
			strSql.Append("jldw=@jldw,");
			strSql.Append("sbmc=@sbmc,");
			strSql.Append("azdw=@azdw,");
			strSql.Append("sbxh=@sbxh,");
			strSql.Append("sbbh=@sbbh,");
			strSql.Append("sccj=@sccj,");
			strSql.Append("aqsbh=@aqsbh,");
			strSql.Append("tzsbsczzxkz=@tzsbsczzxkz,");
			strSql.Append("cqbh=@cqbh,");
			strSql.Append("ccrq=@ccrq,");
			strSql.Append("jygd=@jygd,");
			strSql.Append("szzobbh=@szzobbh,");
			strSql.Append("szzobyqzk=@szzobyqzk,");
			strSql.Append("wsdjbh=@wsdjbh,");
			strSql.Append("wsdjyqzk=@wsdjyqzk,");
			strSql.Append("szwybbh=@szwybbh,");
			strSql.Append("szwybyqzk=@szwybyqzk,");
			strSql.Append("scbh=@scbh,");
			strSql.Append("scyqzk=@scyqzk,");
			strSql.Append("gzcbh=@gzcbh,");
			strSql.Append("gzcyqzk=@gzcyqzk,");
			strSql.Append("szjdcbh=@szjdcbh,");
			strSql.Append("szjdcyqzk=@szjdcyqzk,");
			strSql.Append("fsybh=@fsybh,");
			strSql.Append("fsyyqzk=@fsyyqzk,");
			strSql.Append("ybkcbh=@ybkcbh,");
			strSql.Append("ybkcyqzk=@ybkcyqzk,");
			strSql.Append("gjc30mbh=@gjc30mbh,");
			strSql.Append("gjc30mzxkz=@gjc30mzxkz,");
			strSql.Append("gjc5mbh=@gjc5mbh,");
			strSql.Append("gjc5mzxkz=@gjc5mzxkz,");
			strSql.Append("bzxmbhgs=@bzxmbhgs,");
			strSql.Append("ybxmbhgs=@ybxmbhgs");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@gcmc", MySqlDbType.VarChar,255),
					new MySqlParameter("@sgdd", MySqlDbType.VarChar,255),
					new MySqlParameter("@sydw", MySqlDbType.VarChar,255),
					new MySqlParameter("@jldw", MySqlDbType.VarChar,255),
					new MySqlParameter("@sbmc", MySqlDbType.VarChar,255),
					new MySqlParameter("@azdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@sbxh", MySqlDbType.VarChar,255),
					new MySqlParameter("@sbbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@sccj", MySqlDbType.VarChar,255),
					new MySqlParameter("@aqsbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@tzsbsczzxkz", MySqlDbType.VarChar,255),
					new MySqlParameter("@cqbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ccrq", MySqlDbType.VarChar,255),
					new MySqlParameter("@jygd", MySqlDbType.VarChar,255),
					new MySqlParameter("@szzobbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@szzobyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@wsdjbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@wsdjyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@szwybbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@szwybyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@scbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@scyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzcbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzcyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@szjdcbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@szjdcyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@fsybh", MySqlDbType.VarChar,255),
					new MySqlParameter("@fsyyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@ybkcbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@ybkcyqzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc30mbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc30mzxkz", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc5mbh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gjc5mzxkz", MySqlDbType.VarChar,255),
					new MySqlParameter("@bzxmbhgs", MySqlDbType.VarChar,255),
					new MySqlParameter("@ybxmbhgs", MySqlDbType.VarChar,255),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.gcmc;
			parameters[3].Value = model.sgdd;
			parameters[4].Value = model.sydw;
			parameters[5].Value = model.jldw;
			parameters[6].Value = model.sbmc;
			parameters[7].Value = model.azdw;
			parameters[8].Value = model.sbxh;
			parameters[9].Value = model.sbbh;
			parameters[10].Value = model.sccj;
			parameters[11].Value = model.aqsbh;
			parameters[12].Value = model.tzsbsczzxkz;
			parameters[13].Value = model.cqbh;
			parameters[14].Value = model.ccrq;
			parameters[15].Value = model.jygd;
			parameters[16].Value = model.szzobbh;
			parameters[17].Value = model.szzobyqzk;
			parameters[18].Value = model.wsdjbh;
			parameters[19].Value = model.wsdjyqzk;
			parameters[20].Value = model.szwybbh;
			parameters[21].Value = model.szwybyqzk;
			parameters[22].Value = model.scbh;
			parameters[23].Value = model.scyqzk;
			parameters[24].Value = model.gzcbh;
			parameters[25].Value = model.gzcyqzk;
			parameters[26].Value = model.szjdcbh;
			parameters[27].Value = model.szjdcyqzk;
			parameters[28].Value = model.fsybh;
			parameters[29].Value = model.fsyyqzk;
			parameters[30].Value = model.ybkcbh;
			parameters[31].Value = model.ybkcyqzk;
			parameters[32].Value = model.gjc30mbh;
			parameters[33].Value = model.gjc30mzxkz;
			parameters[34].Value = model.gjc5mbh;
			parameters[35].Value = model.gjc5mzxkz;
			parameters[36].Value = model.bzxmbhgs;
			parameters[37].Value = model.ybxmbhgs;
			parameters[38].Value = model.Guid;

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
			strSql.Append("delete from basket_install ");
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
			strSql.Append("delete from basket_install ");
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
		public AM.Model.basket_install GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,gcmc,sgdd,sydw,jldw,sbmc,azdw,sbxh,sbbh,sccj,aqsbh,tzsbsczzxkz,cqbh,ccrq,jygd,szzobbh,szzobyqzk,wsdjbh,wsdjyqzk,szwybbh,szwybyqzk,scbh,scyqzk,gzcbh,gzcyqzk,szjdcbh,szjdcyqzk,fsybh,fsyyqzk,ybkcbh,ybkcyqzk,gjc30mbh,gjc30mzxkz,gjc5mbh,gjc5mzxkz,bzxmbhgs,ybxmbhgs from basket_install ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.basket_install model=new AM.Model.basket_install();
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
		public AM.Model.basket_install DataRowToModel(DataRow row)
		{
			AM.Model.basket_install model=new AM.Model.basket_install();
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
				if(row["gcmc"]!=null)
				{
					model.gcmc=row["gcmc"].ToString();
				}
				if(row["sgdd"]!=null)
				{
					model.sgdd=row["sgdd"].ToString();
				}
				if(row["sydw"]!=null)
				{
					model.sydw=row["sydw"].ToString();
				}
				if(row["jldw"]!=null)
				{
					model.jldw=row["jldw"].ToString();
				}
				if(row["sbmc"]!=null)
				{
					model.sbmc=row["sbmc"].ToString();
				}
				if(row["azdw"]!=null)
				{
					model.azdw=row["azdw"].ToString();
				}
				if(row["sbxh"]!=null)
				{
					model.sbxh=row["sbxh"].ToString();
				}
				if(row["sbbh"]!=null)
				{
					model.sbbh=row["sbbh"].ToString();
				}
				if(row["sccj"]!=null)
				{
					model.sccj=row["sccj"].ToString();
				}
				if(row["aqsbh"]!=null)
				{
					model.aqsbh=row["aqsbh"].ToString();
				}
				if(row["tzsbsczzxkz"]!=null)
				{
					model.tzsbsczzxkz=row["tzsbsczzxkz"].ToString();
				}
				if(row["cqbh"]!=null)
				{
					model.cqbh=row["cqbh"].ToString();
				}
				if(row["ccrq"]!=null)
				{
					model.ccrq=row["ccrq"].ToString();
				}
				if(row["jygd"]!=null)
				{
					model.jygd=row["jygd"].ToString();
				}
				if(row["szzobbh"]!=null)
				{
					model.szzobbh=row["szzobbh"].ToString();
				}
				if(row["szzobyqzk"]!=null)
				{
					model.szzobyqzk=row["szzobyqzk"].ToString();
				}
				if(row["wsdjbh"]!=null)
				{
					model.wsdjbh=row["wsdjbh"].ToString();
				}
				if(row["wsdjyqzk"]!=null)
				{
					model.wsdjyqzk=row["wsdjyqzk"].ToString();
				}
				if(row["szwybbh"]!=null)
				{
					model.szwybbh=row["szwybbh"].ToString();
				}
				if(row["szwybyqzk"]!=null)
				{
					model.szwybyqzk=row["szwybyqzk"].ToString();
				}
				if(row["scbh"]!=null)
				{
					model.scbh=row["scbh"].ToString();
				}
				if(row["scyqzk"]!=null)
				{
					model.scyqzk=row["scyqzk"].ToString();
				}
				if(row["gzcbh"]!=null)
				{
					model.gzcbh=row["gzcbh"].ToString();
				}
				if(row["gzcyqzk"]!=null)
				{
					model.gzcyqzk=row["gzcyqzk"].ToString();
				}
				if(row["szjdcbh"]!=null)
				{
					model.szjdcbh=row["szjdcbh"].ToString();
				}
				if(row["szjdcyqzk"]!=null)
				{
					model.szjdcyqzk=row["szjdcyqzk"].ToString();
				}
				if(row["fsybh"]!=null)
				{
					model.fsybh=row["fsybh"].ToString();
				}
				if(row["fsyyqzk"]!=null)
				{
					model.fsyyqzk=row["fsyyqzk"].ToString();
				}
				if(row["ybkcbh"]!=null)
				{
					model.ybkcbh=row["ybkcbh"].ToString();
				}
				if(row["ybkcyqzk"]!=null)
				{
					model.ybkcyqzk=row["ybkcyqzk"].ToString();
				}
				if(row["gjc30mbh"]!=null)
				{
					model.gjc30mbh=row["gjc30mbh"].ToString();
				}
				if(row["gjc30mzxkz"]!=null)
				{
					model.gjc30mzxkz=row["gjc30mzxkz"].ToString();
				}
				if(row["gjc5mbh"]!=null)
				{
					model.gjc5mbh=row["gjc5mbh"].ToString();
				}
				if(row["gjc5mzxkz"]!=null)
				{
					model.gjc5mzxkz=row["gjc5mzxkz"].ToString();
				}
				if(row["bzxmbhgs"]!=null)
				{
					model.bzxmbhgs=row["bzxmbhgs"].ToString();
				}
				if(row["ybxmbhgs"]!=null)
				{
					model.ybxmbhgs=row["ybxmbhgs"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,gcmc,sgdd,sydw,jldw,sbmc,azdw,sbxh,sbbh,sccj,aqsbh,tzsbsczzxkz,cqbh,ccrq,jygd,szzobbh,szzobyqzk,wsdjbh,wsdjyqzk,szwybbh,szwybyqzk,scbh,scyqzk,gzcbh,gzcyqzk,szjdcbh,szjdcyqzk,fsybh,fsyyqzk,ybkcbh,ybkcyqzk,gjc30mbh,gjc30mzxkz,gjc5mbh,gjc5mzxkz,bzxmbhgs,ybxmbhgs ");
			strSql.Append(" FROM basket_install ");
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
			strSql.Append("select count(1) FROM basket_install ");
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
			parameters[0].Value = "basket_install";
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
        public basket_install GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_install ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            basket_install model = new basket_install();
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
            strSql.Append("select * from basket_install ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM basket_install TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM basket_install TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataTable GetModelDataTable(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_install ");
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

