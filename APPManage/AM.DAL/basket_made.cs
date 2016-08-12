/**  版本信息模板在安装目录下，可自行修改。
* basket_made.cs
*
* 功 能： N/A
* 类 名： basket_made
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 17:55:18   N/A    初版
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
	/// 数据访问类:basket_made
	/// </summary>
	public partial class basket_madeDAL
	{
        public basket_madeDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from basket_made");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.basket_made model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into basket_made(");
			strSql.Append("Guid,userid,CreateDate,qymc,qydz,yb,zzjgdm,lxr,gddh,yddh,dzyx,cz,yyzzzch,jjlx,zczj,gdzc,qyzgzrs,kszzdlrq,sqcpggxh,fddbxm,fddbxb,fddbzgxl,fddbzw,fddbzc,fddbzy,fddbgddh,fddbyddh,fddbzypx,fddbpxsj,fddbzsbh,zlfzrxm,zlfzrxb,zlfzrzgxl,zlfzrzw,zlfzrzc,zlfzrzy,zlfzrgddh,zlfzryddh,zlfzrzypx,zlfzrpxsj,zlfzrzsbh,gzryxh1,gzryxm1,gzryzw1,gzryzc1,gzryfzjg1,gzryxl1,gzryzy1,gzryxh2,gzryxm2,gzryzw2,gzryzc2,gzryfzjg2,gzryxl2,gzryzy2,gzryxh3,gzryxm3,gzryzw3,gzryzc3,gzryfzjg3,gzryxl3,gzryzy3,gzryxh4,gzryxm4,gzryzw4,gzryzc4,gzryfzjg4,gzryxl4,gzryzy4,gzryxh5,gzryxm5,gzryzw5,gzryzc5,gzryfzjg5,gzryxl5,gzryzy5,tzzyryxh1,tzzyryxm1,tzzyrygz1,tzzyryxh2,tzzyryxm2,tzzyrygz2,tzzyryxh3,tzzyryxm3,tzzyrygz3,tzzyryxh4,tzzyryxm4,tzzyrygz4,tzzyryxh5,tzzyryxm5,tzzyrygz5,zgzsfzjg1,zgzszsbh1,zgzsyxq1,zgzsfzjg2,zgzszsbh2,zgzsyxq2,zgzsfzjg3,zgzszsbh3,zgzsyxq3,zgzsfzjg4,zgzszsbh4,zgzsyxq4,zgzsfzjg5,zgzszsbh5,zgzsyxq5,mxxh1,mxsbmc1,mxgg1,mxsl1,mxzzs1,mxxh2,mxsbmc2,mxgg2,mxsl2,mxzzs2,mxxh3,mxsbmc3,mxgg3,mxsl3,mxzzs3,mxxh4,mxsbmc4,mxgg4,mxsl4,mxzzs4,mxxh5,mxsbmc5,mxgg5,mxsl5,mxzzs5,jyylmxxh1,jyylmxmc1,jyylmxgg1,jyylmxsl1,jyylmxyxq1,jyylmxxh2,jyylmxmc2,jyylmxgg2,jyylmxsl2,jyylmxyxq2,jyylmxxh3,jyylmxmc3,jyylmxgg3,jyylmxsl3,jyylmxyxq3,jyylmxxh4,jyylmxmc4,jyylmxgg4,jyylmxsl4,jyylmxyxq4,jyylmxxh5,jyylmxmc5,jyylmxgg5,jyylmxsl5,jyylmxyxq5,yjylnd1,yjylggxh1,yjylcl1,yjylxssr1,yjylbz1,yjylnd2,yjylggxh2,yjylcl2,yjylxssr2,yjylbz2,yjylnd3,yjylggxh3,yjylcl3,yjylxssr3,yjylbz3,yjylnd4,yjylggxh4,yjylcl4,yjylxssr4,yjylbz4,yjylnd5,yjylggxh5,yjylcl5,yjylxssr5,yjylbz5)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@qymc,@qydz,@yb,@zzjgdm,@lxr,@gddh,@yddh,@dzyx,@cz,@yyzzzch,@jjlx,@zczj,@gdzc,@qyzgzrs,@kszzdlrq,@sqcpggxh,@fddbxm,@fddbxb,@fddbzgxl,@fddbzw,@fddbzc,@fddbzy,@fddbgddh,@fddbyddh,@fddbzypx,@fddbpxsj,@fddbzsbh,@zlfzrxm,@zlfzrxb,@zlfzrzgxl,@zlfzrzw,@zlfzrzc,@zlfzrzy,@zlfzrgddh,@zlfzryddh,@zlfzrzypx,@zlfzrpxsj,@zlfzrzsbh,@gzryxh1,@gzryxm1,@gzryzw1,@gzryzc1,@gzryfzjg1,@gzryxl1,@gzryzy1,@gzryxh2,@gzryxm2,@gzryzw2,@gzryzc2,@gzryfzjg2,@gzryxl2,@gzryzy2,@gzryxh3,@gzryxm3,@gzryzw3,@gzryzc3,@gzryfzjg3,@gzryxl3,@gzryzy3,@gzryxh4,@gzryxm4,@gzryzw4,@gzryzc4,@gzryfzjg4,@gzryxl4,@gzryzy4,@gzryxh5,@gzryxm5,@gzryzw5,@gzryzc5,@gzryfzjg5,@gzryxl5,@gzryzy5,@tzzyryxh1,@tzzyryxm1,@tzzyrygz1,@tzzyryxh2,@tzzyryxm2,@tzzyrygz2,@tzzyryxh3,@tzzyryxm3,@tzzyrygz3,@tzzyryxh4,@tzzyryxm4,@tzzyrygz4,@tzzyryxh5,@tzzyryxm5,@tzzyrygz5,@zgzsfzjg1,@zgzszsbh1,@zgzsyxq1,@zgzsfzjg2,@zgzszsbh2,@zgzsyxq2,@zgzsfzjg3,@zgzszsbh3,@zgzsyxq3,@zgzsfzjg4,@zgzszsbh4,@zgzsyxq4,@zgzsfzjg5,@zgzszsbh5,@zgzsyxq5,@mxxh1,@mxsbmc1,@mxgg1,@mxsl1,@mxzzs1,@mxxh2,@mxsbmc2,@mxgg2,@mxsl2,@mxzzs2,@mxxh3,@mxsbmc3,@mxgg3,@mxsl3,@mxzzs3,@mxxh4,@mxsbmc4,@mxgg4,@mxsl4,@mxzzs4,@mxxh5,@mxsbmc5,@mxgg5,@mxsl5,@mxzzs5,@jyylmxxh1,@jyylmxmc1,@jyylmxgg1,@jyylmxsl1,@jyylmxyxq1,@jyylmxxh2,@jyylmxmc2,@jyylmxgg2,@jyylmxsl2,@jyylmxyxq2,@jyylmxxh3,@jyylmxmc3,@jyylmxgg3,@jyylmxsl3,@jyylmxyxq3,@jyylmxxh4,@jyylmxmc4,@jyylmxgg4,@jyylmxsl4,@jyylmxyxq4,@jyylmxxh5,@jyylmxmc5,@jyylmxgg5,@jyylmxsl5,@jyylmxyxq5,@yjylnd1,@yjylggxh1,@yjylcl1,@yjylxssr1,@yjylbz1,@yjylnd2,@yjylggxh2,@yjylcl2,@yjylxssr2,@yjylbz2,@yjylnd3,@yjylggxh3,@yjylcl3,@yjylxssr3,@yjylbz3,@yjylnd4,@yjylggxh4,@yjylcl4,@yjylxssr4,@yjylbz4,@yjylnd5,@yjylggxh5,@yjylcl5,@yjylxssr5,@yjylbz5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@qymc", MySqlDbType.Text),
					new MySqlParameter("@qydz", MySqlDbType.Text),
					new MySqlParameter("@yb", MySqlDbType.Text),
					new MySqlParameter("@zzjgdm", MySqlDbType.Text),
					new MySqlParameter("@lxr", MySqlDbType.Text),
					new MySqlParameter("@gddh", MySqlDbType.Text),
					new MySqlParameter("@yddh", MySqlDbType.Text),
					new MySqlParameter("@dzyx", MySqlDbType.Text),
					new MySqlParameter("@cz", MySqlDbType.Text),
					new MySqlParameter("@yyzzzch", MySqlDbType.Text),
					new MySqlParameter("@jjlx", MySqlDbType.Text),
					new MySqlParameter("@zczj", MySqlDbType.Text),
					new MySqlParameter("@gdzc", MySqlDbType.Text),
					new MySqlParameter("@qyzgzrs", MySqlDbType.Text),
					new MySqlParameter("@kszzdlrq", MySqlDbType.Text),
					new MySqlParameter("@sqcpggxh", MySqlDbType.Text),
					new MySqlParameter("@fddbxm", MySqlDbType.Text),
					new MySqlParameter("@fddbxb", MySqlDbType.Text),
					new MySqlParameter("@fddbzgxl", MySqlDbType.Text),
					new MySqlParameter("@fddbzw", MySqlDbType.Text),
					new MySqlParameter("@fddbzc", MySqlDbType.Text),
					new MySqlParameter("@fddbzy", MySqlDbType.Text),
					new MySqlParameter("@fddbgddh", MySqlDbType.Text),
					new MySqlParameter("@fddbyddh", MySqlDbType.Text),
					new MySqlParameter("@fddbzypx", MySqlDbType.Text),
					new MySqlParameter("@fddbpxsj", MySqlDbType.Text),
					new MySqlParameter("@fddbzsbh", MySqlDbType.Text),
					new MySqlParameter("@zlfzrxm", MySqlDbType.Text),
					new MySqlParameter("@zlfzrxb", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzgxl", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzw", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzc", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzy", MySqlDbType.Text),
					new MySqlParameter("@zlfzrgddh", MySqlDbType.Text),
					new MySqlParameter("@zlfzryddh", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzypx", MySqlDbType.Text),
					new MySqlParameter("@zlfzrpxsj", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzsbh", MySqlDbType.Text),
					new MySqlParameter("@gzryxh1", MySqlDbType.Text),
					new MySqlParameter("@gzryxm1", MySqlDbType.Text),
					new MySqlParameter("@gzryzw1", MySqlDbType.Text),
					new MySqlParameter("@gzryzc1", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg1", MySqlDbType.Text),
					new MySqlParameter("@gzryxl1", MySqlDbType.Text),
					new MySqlParameter("@gzryzy1", MySqlDbType.Text),
					new MySqlParameter("@gzryxh2", MySqlDbType.Text),
					new MySqlParameter("@gzryxm2", MySqlDbType.Text),
					new MySqlParameter("@gzryzw2", MySqlDbType.Text),
					new MySqlParameter("@gzryzc2", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg2", MySqlDbType.Text),
					new MySqlParameter("@gzryxl2", MySqlDbType.Text),
					new MySqlParameter("@gzryzy2", MySqlDbType.Text),
					new MySqlParameter("@gzryxh3", MySqlDbType.Text),
					new MySqlParameter("@gzryxm3", MySqlDbType.Text),
					new MySqlParameter("@gzryzw3", MySqlDbType.Text),
					new MySqlParameter("@gzryzc3", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg3", MySqlDbType.Text),
					new MySqlParameter("@gzryxl3", MySqlDbType.Text),
					new MySqlParameter("@gzryzy3", MySqlDbType.Text),
					new MySqlParameter("@gzryxh4", MySqlDbType.Text),
					new MySqlParameter("@gzryxm4", MySqlDbType.Text),
					new MySqlParameter("@gzryzw4", MySqlDbType.Text),
					new MySqlParameter("@gzryzc4", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg4", MySqlDbType.Text),
					new MySqlParameter("@gzryxl4", MySqlDbType.Text),
					new MySqlParameter("@gzryzy4", MySqlDbType.Text),
					new MySqlParameter("@gzryxh5", MySqlDbType.Text),
					new MySqlParameter("@gzryxm5", MySqlDbType.Text),
					new MySqlParameter("@gzryzw5", MySqlDbType.Text),
					new MySqlParameter("@gzryzc5", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg5", MySqlDbType.Text),
					new MySqlParameter("@gzryxl5", MySqlDbType.Text),
					new MySqlParameter("@gzryzy5", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh1", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm1", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz1", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh2", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm2", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz2", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh3", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm3", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz3", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh4", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm4", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz4", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh5", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm5", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz5", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg1", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh1", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq1", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg2", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh2", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq2", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg3", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh3", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq3", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg4", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh4", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq4", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg5", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh5", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq5", MySqlDbType.Text),
					new MySqlParameter("@mxxh1", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc1", MySqlDbType.Text),
					new MySqlParameter("@mxgg1", MySqlDbType.Text),
					new MySqlParameter("@mxsl1", MySqlDbType.Text),
					new MySqlParameter("@mxzzs1", MySqlDbType.Text),
					new MySqlParameter("@mxxh2", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc2", MySqlDbType.Text),
					new MySqlParameter("@mxgg2", MySqlDbType.Text),
					new MySqlParameter("@mxsl2", MySqlDbType.Text),
					new MySqlParameter("@mxzzs2", MySqlDbType.Text),
					new MySqlParameter("@mxxh3", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc3", MySqlDbType.Text),
					new MySqlParameter("@mxgg3", MySqlDbType.Text),
					new MySqlParameter("@mxsl3", MySqlDbType.Text),
					new MySqlParameter("@mxzzs3", MySqlDbType.Text),
					new MySqlParameter("@mxxh4", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc4", MySqlDbType.Text),
					new MySqlParameter("@mxgg4", MySqlDbType.Text),
					new MySqlParameter("@mxsl4", MySqlDbType.Text),
					new MySqlParameter("@mxzzs4", MySqlDbType.Text),
					new MySqlParameter("@mxxh5", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc5", MySqlDbType.Text),
					new MySqlParameter("@mxgg5", MySqlDbType.Text),
					new MySqlParameter("@mxsl5", MySqlDbType.Text),
					new MySqlParameter("@mxzzs5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq5", MySqlDbType.Text),
					new MySqlParameter("@yjylnd1", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh1", MySqlDbType.Text),
					new MySqlParameter("@yjylcl1", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr1", MySqlDbType.Text),
					new MySqlParameter("@yjylbz1", MySqlDbType.Text),
					new MySqlParameter("@yjylnd2", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh2", MySqlDbType.Text),
					new MySqlParameter("@yjylcl2", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr2", MySqlDbType.Text),
					new MySqlParameter("@yjylbz2", MySqlDbType.Text),
					new MySqlParameter("@yjylnd3", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh3", MySqlDbType.Text),
					new MySqlParameter("@yjylcl3", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr3", MySqlDbType.Text),
					new MySqlParameter("@yjylbz3", MySqlDbType.Text),
					new MySqlParameter("@yjylnd4", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh4", MySqlDbType.Text),
					new MySqlParameter("@yjylcl4", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr4", MySqlDbType.Text),
					new MySqlParameter("@yjylbz4", MySqlDbType.Text),
					new MySqlParameter("@yjylnd5", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh5", MySqlDbType.Text),
					new MySqlParameter("@yjylcl5", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr5", MySqlDbType.Text),
					new MySqlParameter("@yjylbz5", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.qymc;
			parameters[4].Value = model.qydz;
			parameters[5].Value = model.yb;
			parameters[6].Value = model.zzjgdm;
			parameters[7].Value = model.lxr;
			parameters[8].Value = model.gddh;
			parameters[9].Value = model.yddh;
			parameters[10].Value = model.dzyx;
			parameters[11].Value = model.cz;
			parameters[12].Value = model.yyzzzch;
			parameters[13].Value = model.jjlx;
			parameters[14].Value = model.zczj;
			parameters[15].Value = model.gdzc;
			parameters[16].Value = model.qyzgzrs;
			parameters[17].Value = model.kszzdlrq;
			parameters[18].Value = model.sqcpggxh;
			parameters[19].Value = model.fddbxm;
			parameters[20].Value = model.fddbxb;
			parameters[21].Value = model.fddbzgxl;
			parameters[22].Value = model.fddbzw;
			parameters[23].Value = model.fddbzc;
			parameters[24].Value = model.fddbzy;
			parameters[25].Value = model.fddbgddh;
			parameters[26].Value = model.fddbyddh;
			parameters[27].Value = model.fddbzypx;
			parameters[28].Value = model.fddbpxsj;
			parameters[29].Value = model.fddbzsbh;
			parameters[30].Value = model.zlfzrxm;
			parameters[31].Value = model.zlfzrxb;
			parameters[32].Value = model.zlfzrzgxl;
			parameters[33].Value = model.zlfzrzw;
			parameters[34].Value = model.zlfzrzc;
			parameters[35].Value = model.zlfzrzy;
			parameters[36].Value = model.zlfzrgddh;
			parameters[37].Value = model.zlfzryddh;
			parameters[38].Value = model.zlfzrzypx;
			parameters[39].Value = model.zlfzrpxsj;
			parameters[40].Value = model.zlfzrzsbh;
			parameters[41].Value = model.gzryxh1;
			parameters[42].Value = model.gzryxm1;
			parameters[43].Value = model.gzryzw1;
			parameters[44].Value = model.gzryzc1;
			parameters[45].Value = model.gzryfzjg1;
			parameters[46].Value = model.gzryxl1;
			parameters[47].Value = model.gzryzy1;
			parameters[48].Value = model.gzryxh2;
			parameters[49].Value = model.gzryxm2;
			parameters[50].Value = model.gzryzw2;
			parameters[51].Value = model.gzryzc2;
			parameters[52].Value = model.gzryfzjg2;
			parameters[53].Value = model.gzryxl2;
			parameters[54].Value = model.gzryzy2;
			parameters[55].Value = model.gzryxh3;
			parameters[56].Value = model.gzryxm3;
			parameters[57].Value = model.gzryzw3;
			parameters[58].Value = model.gzryzc3;
			parameters[59].Value = model.gzryfzjg3;
			parameters[60].Value = model.gzryxl3;
			parameters[61].Value = model.gzryzy3;
			parameters[62].Value = model.gzryxh4;
			parameters[63].Value = model.gzryxm4;
			parameters[64].Value = model.gzryzw4;
			parameters[65].Value = model.gzryzc4;
			parameters[66].Value = model.gzryfzjg4;
			parameters[67].Value = model.gzryxl4;
			parameters[68].Value = model.gzryzy4;
			parameters[69].Value = model.gzryxh5;
			parameters[70].Value = model.gzryxm5;
			parameters[71].Value = model.gzryzw5;
			parameters[72].Value = model.gzryzc5;
			parameters[73].Value = model.gzryfzjg5;
			parameters[74].Value = model.gzryxl5;
			parameters[75].Value = model.gzryzy5;
			parameters[76].Value = model.tzzyryxh1;
			parameters[77].Value = model.tzzyryxm1;
			parameters[78].Value = model.tzzyrygz1;
			parameters[79].Value = model.tzzyryxh2;
			parameters[80].Value = model.tzzyryxm2;
			parameters[81].Value = model.tzzyrygz2;
			parameters[82].Value = model.tzzyryxh3;
			parameters[83].Value = model.tzzyryxm3;
			parameters[84].Value = model.tzzyrygz3;
			parameters[85].Value = model.tzzyryxh4;
			parameters[86].Value = model.tzzyryxm4;
			parameters[87].Value = model.tzzyrygz4;
			parameters[88].Value = model.tzzyryxh5;
			parameters[89].Value = model.tzzyryxm5;
			parameters[90].Value = model.tzzyrygz5;
			parameters[91].Value = model.zgzsfzjg1;
			parameters[92].Value = model.zgzszsbh1;
			parameters[93].Value = model.zgzsyxq1;
			parameters[94].Value = model.zgzsfzjg2;
			parameters[95].Value = model.zgzszsbh2;
			parameters[96].Value = model.zgzsyxq2;
			parameters[97].Value = model.zgzsfzjg3;
			parameters[98].Value = model.zgzszsbh3;
			parameters[99].Value = model.zgzsyxq3;
			parameters[100].Value = model.zgzsfzjg4;
			parameters[101].Value = model.zgzszsbh4;
			parameters[102].Value = model.zgzsyxq4;
			parameters[103].Value = model.zgzsfzjg5;
			parameters[104].Value = model.zgzszsbh5;
			parameters[105].Value = model.zgzsyxq5;
			parameters[106].Value = model.mxxh1;
			parameters[107].Value = model.mxsbmc1;
			parameters[108].Value = model.mxgg1;
			parameters[109].Value = model.mxsl1;
			parameters[110].Value = model.mxzzs1;
			parameters[111].Value = model.mxxh2;
			parameters[112].Value = model.mxsbmc2;
			parameters[113].Value = model.mxgg2;
			parameters[114].Value = model.mxsl2;
			parameters[115].Value = model.mxzzs2;
			parameters[116].Value = model.mxxh3;
			parameters[117].Value = model.mxsbmc3;
			parameters[118].Value = model.mxgg3;
			parameters[119].Value = model.mxsl3;
			parameters[120].Value = model.mxzzs3;
			parameters[121].Value = model.mxxh4;
			parameters[122].Value = model.mxsbmc4;
			parameters[123].Value = model.mxgg4;
			parameters[124].Value = model.mxsl4;
			parameters[125].Value = model.mxzzs4;
			parameters[126].Value = model.mxxh5;
			parameters[127].Value = model.mxsbmc5;
			parameters[128].Value = model.mxgg5;
			parameters[129].Value = model.mxsl5;
			parameters[130].Value = model.mxzzs5;
			parameters[131].Value = model.jyylmxxh1;
			parameters[132].Value = model.jyylmxmc1;
			parameters[133].Value = model.jyylmxgg1;
			parameters[134].Value = model.jyylmxsl1;
			parameters[135].Value = model.jyylmxyxq1;
			parameters[136].Value = model.jyylmxxh2;
			parameters[137].Value = model.jyylmxmc2;
			parameters[138].Value = model.jyylmxgg2;
			parameters[139].Value = model.jyylmxsl2;
			parameters[140].Value = model.jyylmxyxq2;
			parameters[141].Value = model.jyylmxxh3;
			parameters[142].Value = model.jyylmxmc3;
			parameters[143].Value = model.jyylmxgg3;
			parameters[144].Value = model.jyylmxsl3;
			parameters[145].Value = model.jyylmxyxq3;
			parameters[146].Value = model.jyylmxxh4;
			parameters[147].Value = model.jyylmxmc4;
			parameters[148].Value = model.jyylmxgg4;
			parameters[149].Value = model.jyylmxsl4;
			parameters[150].Value = model.jyylmxyxq4;
			parameters[151].Value = model.jyylmxxh5;
			parameters[152].Value = model.jyylmxmc5;
			parameters[153].Value = model.jyylmxgg5;
			parameters[154].Value = model.jyylmxsl5;
			parameters[155].Value = model.jyylmxyxq5;
			parameters[156].Value = model.yjylnd1;
			parameters[157].Value = model.yjylggxh1;
			parameters[158].Value = model.yjylcl1;
			parameters[159].Value = model.yjylxssr1;
			parameters[160].Value = model.yjylbz1;
			parameters[161].Value = model.yjylnd2;
			parameters[162].Value = model.yjylggxh2;
			parameters[163].Value = model.yjylcl2;
			parameters[164].Value = model.yjylxssr2;
			parameters[165].Value = model.yjylbz2;
			parameters[166].Value = model.yjylnd3;
			parameters[167].Value = model.yjylggxh3;
			parameters[168].Value = model.yjylcl3;
			parameters[169].Value = model.yjylxssr3;
			parameters[170].Value = model.yjylbz3;
			parameters[171].Value = model.yjylnd4;
			parameters[172].Value = model.yjylggxh4;
			parameters[173].Value = model.yjylcl4;
			parameters[174].Value = model.yjylxssr4;
			parameters[175].Value = model.yjylbz4;
			parameters[176].Value = model.yjylnd5;
			parameters[177].Value = model.yjylggxh5;
			parameters[178].Value = model.yjylcl5;
			parameters[179].Value = model.yjylxssr5;
			parameters[180].Value = model.yjylbz5;

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
		public bool Update(AM.Model.basket_made model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update basket_made set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("qymc=@qymc,");
			strSql.Append("qydz=@qydz,");
			strSql.Append("yb=@yb,");
			strSql.Append("zzjgdm=@zzjgdm,");
			strSql.Append("lxr=@lxr,");
			strSql.Append("gddh=@gddh,");
			strSql.Append("yddh=@yddh,");
			strSql.Append("dzyx=@dzyx,");
			strSql.Append("cz=@cz,");
			strSql.Append("yyzzzch=@yyzzzch,");
			strSql.Append("jjlx=@jjlx,");
			strSql.Append("zczj=@zczj,");
			strSql.Append("gdzc=@gdzc,");
			strSql.Append("qyzgzrs=@qyzgzrs,");
			strSql.Append("kszzdlrq=@kszzdlrq,");
			strSql.Append("sqcpggxh=@sqcpggxh,");
			strSql.Append("fddbxm=@fddbxm,");
			strSql.Append("fddbxb=@fddbxb,");
			strSql.Append("fddbzgxl=@fddbzgxl,");
			strSql.Append("fddbzw=@fddbzw,");
			strSql.Append("fddbzc=@fddbzc,");
			strSql.Append("fddbzy=@fddbzy,");
			strSql.Append("fddbgddh=@fddbgddh,");
			strSql.Append("fddbyddh=@fddbyddh,");
			strSql.Append("fddbzypx=@fddbzypx,");
			strSql.Append("fddbpxsj=@fddbpxsj,");
			strSql.Append("fddbzsbh=@fddbzsbh,");
			strSql.Append("zlfzrxm=@zlfzrxm,");
			strSql.Append("zlfzrxb=@zlfzrxb,");
			strSql.Append("zlfzrzgxl=@zlfzrzgxl,");
			strSql.Append("zlfzrzw=@zlfzrzw,");
			strSql.Append("zlfzrzc=@zlfzrzc,");
			strSql.Append("zlfzrzy=@zlfzrzy,");
			strSql.Append("zlfzrgddh=@zlfzrgddh,");
			strSql.Append("zlfzryddh=@zlfzryddh,");
			strSql.Append("zlfzrzypx=@zlfzrzypx,");
			strSql.Append("zlfzrpxsj=@zlfzrpxsj,");
			strSql.Append("zlfzrzsbh=@zlfzrzsbh,");
			strSql.Append("gzryxh1=@gzryxh1,");
			strSql.Append("gzryxm1=@gzryxm1,");
			strSql.Append("gzryzw1=@gzryzw1,");
			strSql.Append("gzryzc1=@gzryzc1,");
			strSql.Append("gzryfzjg1=@gzryfzjg1,");
			strSql.Append("gzryxl1=@gzryxl1,");
			strSql.Append("gzryzy1=@gzryzy1,");
			strSql.Append("gzryxh2=@gzryxh2,");
			strSql.Append("gzryxm2=@gzryxm2,");
			strSql.Append("gzryzw2=@gzryzw2,");
			strSql.Append("gzryzc2=@gzryzc2,");
			strSql.Append("gzryfzjg2=@gzryfzjg2,");
			strSql.Append("gzryxl2=@gzryxl2,");
			strSql.Append("gzryzy2=@gzryzy2,");
			strSql.Append("gzryxh3=@gzryxh3,");
			strSql.Append("gzryxm3=@gzryxm3,");
			strSql.Append("gzryzw3=@gzryzw3,");
			strSql.Append("gzryzc3=@gzryzc3,");
			strSql.Append("gzryfzjg3=@gzryfzjg3,");
			strSql.Append("gzryxl3=@gzryxl3,");
			strSql.Append("gzryzy3=@gzryzy3,");
			strSql.Append("gzryxh4=@gzryxh4,");
			strSql.Append("gzryxm4=@gzryxm4,");
			strSql.Append("gzryzw4=@gzryzw4,");
			strSql.Append("gzryzc4=@gzryzc4,");
			strSql.Append("gzryfzjg4=@gzryfzjg4,");
			strSql.Append("gzryxl4=@gzryxl4,");
			strSql.Append("gzryzy4=@gzryzy4,");
			strSql.Append("gzryxh5=@gzryxh5,");
			strSql.Append("gzryxm5=@gzryxm5,");
			strSql.Append("gzryzw5=@gzryzw5,");
			strSql.Append("gzryzc5=@gzryzc5,");
			strSql.Append("gzryfzjg5=@gzryfzjg5,");
			strSql.Append("gzryxl5=@gzryxl5,");
			strSql.Append("gzryzy5=@gzryzy5,");
			strSql.Append("tzzyryxh1=@tzzyryxh1,");
			strSql.Append("tzzyryxm1=@tzzyryxm1,");
			strSql.Append("tzzyrygz1=@tzzyrygz1,");
			strSql.Append("tzzyryxh2=@tzzyryxh2,");
			strSql.Append("tzzyryxm2=@tzzyryxm2,");
			strSql.Append("tzzyrygz2=@tzzyrygz2,");
			strSql.Append("tzzyryxh3=@tzzyryxh3,");
			strSql.Append("tzzyryxm3=@tzzyryxm3,");
			strSql.Append("tzzyrygz3=@tzzyrygz3,");
			strSql.Append("tzzyryxh4=@tzzyryxh4,");
			strSql.Append("tzzyryxm4=@tzzyryxm4,");
			strSql.Append("tzzyrygz4=@tzzyrygz4,");
			strSql.Append("tzzyryxh5=@tzzyryxh5,");
			strSql.Append("tzzyryxm5=@tzzyryxm5,");
			strSql.Append("tzzyrygz5=@tzzyrygz5,");
			strSql.Append("zgzsfzjg1=@zgzsfzjg1,");
			strSql.Append("zgzszsbh1=@zgzszsbh1,");
			strSql.Append("zgzsyxq1=@zgzsyxq1,");
			strSql.Append("zgzsfzjg2=@zgzsfzjg2,");
			strSql.Append("zgzszsbh2=@zgzszsbh2,");
			strSql.Append("zgzsyxq2=@zgzsyxq2,");
			strSql.Append("zgzsfzjg3=@zgzsfzjg3,");
			strSql.Append("zgzszsbh3=@zgzszsbh3,");
			strSql.Append("zgzsyxq3=@zgzsyxq3,");
			strSql.Append("zgzsfzjg4=@zgzsfzjg4,");
			strSql.Append("zgzszsbh4=@zgzszsbh4,");
			strSql.Append("zgzsyxq4=@zgzsyxq4,");
			strSql.Append("zgzsfzjg5=@zgzsfzjg5,");
			strSql.Append("zgzszsbh5=@zgzszsbh5,");
			strSql.Append("zgzsyxq5=@zgzsyxq5,");
			strSql.Append("mxxh1=@mxxh1,");
			strSql.Append("mxsbmc1=@mxsbmc1,");
			strSql.Append("mxgg1=@mxgg1,");
			strSql.Append("mxsl1=@mxsl1,");
			strSql.Append("mxzzs1=@mxzzs1,");
			strSql.Append("mxxh2=@mxxh2,");
			strSql.Append("mxsbmc2=@mxsbmc2,");
			strSql.Append("mxgg2=@mxgg2,");
			strSql.Append("mxsl2=@mxsl2,");
			strSql.Append("mxzzs2=@mxzzs2,");
			strSql.Append("mxxh3=@mxxh3,");
			strSql.Append("mxsbmc3=@mxsbmc3,");
			strSql.Append("mxgg3=@mxgg3,");
			strSql.Append("mxsl3=@mxsl3,");
			strSql.Append("mxzzs3=@mxzzs3,");
			strSql.Append("mxxh4=@mxxh4,");
			strSql.Append("mxsbmc4=@mxsbmc4,");
			strSql.Append("mxgg4=@mxgg4,");
			strSql.Append("mxsl4=@mxsl4,");
			strSql.Append("mxzzs4=@mxzzs4,");
			strSql.Append("mxxh5=@mxxh5,");
			strSql.Append("mxsbmc5=@mxsbmc5,");
			strSql.Append("mxgg5=@mxgg5,");
			strSql.Append("mxsl5=@mxsl5,");
			strSql.Append("mxzzs5=@mxzzs5,");
			strSql.Append("jyylmxxh1=@jyylmxxh1,");
			strSql.Append("jyylmxmc1=@jyylmxmc1,");
			strSql.Append("jyylmxgg1=@jyylmxgg1,");
			strSql.Append("jyylmxsl1=@jyylmxsl1,");
			strSql.Append("jyylmxyxq1=@jyylmxyxq1,");
			strSql.Append("jyylmxxh2=@jyylmxxh2,");
			strSql.Append("jyylmxmc2=@jyylmxmc2,");
			strSql.Append("jyylmxgg2=@jyylmxgg2,");
			strSql.Append("jyylmxsl2=@jyylmxsl2,");
			strSql.Append("jyylmxyxq2=@jyylmxyxq2,");
			strSql.Append("jyylmxxh3=@jyylmxxh3,");
			strSql.Append("jyylmxmc3=@jyylmxmc3,");
			strSql.Append("jyylmxgg3=@jyylmxgg3,");
			strSql.Append("jyylmxsl3=@jyylmxsl3,");
			strSql.Append("jyylmxyxq3=@jyylmxyxq3,");
			strSql.Append("jyylmxxh4=@jyylmxxh4,");
			strSql.Append("jyylmxmc4=@jyylmxmc4,");
			strSql.Append("jyylmxgg4=@jyylmxgg4,");
			strSql.Append("jyylmxsl4=@jyylmxsl4,");
			strSql.Append("jyylmxyxq4=@jyylmxyxq4,");
			strSql.Append("jyylmxxh5=@jyylmxxh5,");
			strSql.Append("jyylmxmc5=@jyylmxmc5,");
			strSql.Append("jyylmxgg5=@jyylmxgg5,");
			strSql.Append("jyylmxsl5=@jyylmxsl5,");
			strSql.Append("jyylmxyxq5=@jyylmxyxq5,");
			strSql.Append("yjylnd1=@yjylnd1,");
			strSql.Append("yjylggxh1=@yjylggxh1,");
			strSql.Append("yjylcl1=@yjylcl1,");
			strSql.Append("yjylxssr1=@yjylxssr1,");
			strSql.Append("yjylbz1=@yjylbz1,");
			strSql.Append("yjylnd2=@yjylnd2,");
			strSql.Append("yjylggxh2=@yjylggxh2,");
			strSql.Append("yjylcl2=@yjylcl2,");
			strSql.Append("yjylxssr2=@yjylxssr2,");
			strSql.Append("yjylbz2=@yjylbz2,");
			strSql.Append("yjylnd3=@yjylnd3,");
			strSql.Append("yjylggxh3=@yjylggxh3,");
			strSql.Append("yjylcl3=@yjylcl3,");
			strSql.Append("yjylxssr3=@yjylxssr3,");
			strSql.Append("yjylbz3=@yjylbz3,");
			strSql.Append("yjylnd4=@yjylnd4,");
			strSql.Append("yjylggxh4=@yjylggxh4,");
			strSql.Append("yjylcl4=@yjylcl4,");
			strSql.Append("yjylxssr4=@yjylxssr4,");
			strSql.Append("yjylbz4=@yjylbz4,");
			strSql.Append("yjylnd5=@yjylnd5,");
			strSql.Append("yjylggxh5=@yjylggxh5,");
			strSql.Append("yjylcl5=@yjylcl5,");
			strSql.Append("yjylxssr5=@yjylxssr5,");
			strSql.Append("yjylbz5=@yjylbz5");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@qymc", MySqlDbType.Text),
					new MySqlParameter("@qydz", MySqlDbType.Text),
					new MySqlParameter("@yb", MySqlDbType.Text),
					new MySqlParameter("@zzjgdm", MySqlDbType.Text),
					new MySqlParameter("@lxr", MySqlDbType.Text),
					new MySqlParameter("@gddh", MySqlDbType.Text),
					new MySqlParameter("@yddh", MySqlDbType.Text),
					new MySqlParameter("@dzyx", MySqlDbType.Text),
					new MySqlParameter("@cz", MySqlDbType.Text),
					new MySqlParameter("@yyzzzch", MySqlDbType.Text),
					new MySqlParameter("@jjlx", MySqlDbType.Text),
					new MySqlParameter("@zczj", MySqlDbType.Text),
					new MySqlParameter("@gdzc", MySqlDbType.Text),
					new MySqlParameter("@qyzgzrs", MySqlDbType.Text),
					new MySqlParameter("@kszzdlrq", MySqlDbType.Text),
					new MySqlParameter("@sqcpggxh", MySqlDbType.Text),
					new MySqlParameter("@fddbxm", MySqlDbType.Text),
					new MySqlParameter("@fddbxb", MySqlDbType.Text),
					new MySqlParameter("@fddbzgxl", MySqlDbType.Text),
					new MySqlParameter("@fddbzw", MySqlDbType.Text),
					new MySqlParameter("@fddbzc", MySqlDbType.Text),
					new MySqlParameter("@fddbzy", MySqlDbType.Text),
					new MySqlParameter("@fddbgddh", MySqlDbType.Text),
					new MySqlParameter("@fddbyddh", MySqlDbType.Text),
					new MySqlParameter("@fddbzypx", MySqlDbType.Text),
					new MySqlParameter("@fddbpxsj", MySqlDbType.Text),
					new MySqlParameter("@fddbzsbh", MySqlDbType.Text),
					new MySqlParameter("@zlfzrxm", MySqlDbType.Text),
					new MySqlParameter("@zlfzrxb", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzgxl", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzw", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzc", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzy", MySqlDbType.Text),
					new MySqlParameter("@zlfzrgddh", MySqlDbType.Text),
					new MySqlParameter("@zlfzryddh", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzypx", MySqlDbType.Text),
					new MySqlParameter("@zlfzrpxsj", MySqlDbType.Text),
					new MySqlParameter("@zlfzrzsbh", MySqlDbType.Text),
					new MySqlParameter("@gzryxh1", MySqlDbType.Text),
					new MySqlParameter("@gzryxm1", MySqlDbType.Text),
					new MySqlParameter("@gzryzw1", MySqlDbType.Text),
					new MySqlParameter("@gzryzc1", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg1", MySqlDbType.Text),
					new MySqlParameter("@gzryxl1", MySqlDbType.Text),
					new MySqlParameter("@gzryzy1", MySqlDbType.Text),
					new MySqlParameter("@gzryxh2", MySqlDbType.Text),
					new MySqlParameter("@gzryxm2", MySqlDbType.Text),
					new MySqlParameter("@gzryzw2", MySqlDbType.Text),
					new MySqlParameter("@gzryzc2", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg2", MySqlDbType.Text),
					new MySqlParameter("@gzryxl2", MySqlDbType.Text),
					new MySqlParameter("@gzryzy2", MySqlDbType.Text),
					new MySqlParameter("@gzryxh3", MySqlDbType.Text),
					new MySqlParameter("@gzryxm3", MySqlDbType.Text),
					new MySqlParameter("@gzryzw3", MySqlDbType.Text),
					new MySqlParameter("@gzryzc3", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg3", MySqlDbType.Text),
					new MySqlParameter("@gzryxl3", MySqlDbType.Text),
					new MySqlParameter("@gzryzy3", MySqlDbType.Text),
					new MySqlParameter("@gzryxh4", MySqlDbType.Text),
					new MySqlParameter("@gzryxm4", MySqlDbType.Text),
					new MySqlParameter("@gzryzw4", MySqlDbType.Text),
					new MySqlParameter("@gzryzc4", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg4", MySqlDbType.Text),
					new MySqlParameter("@gzryxl4", MySqlDbType.Text),
					new MySqlParameter("@gzryzy4", MySqlDbType.Text),
					new MySqlParameter("@gzryxh5", MySqlDbType.Text),
					new MySqlParameter("@gzryxm5", MySqlDbType.Text),
					new MySqlParameter("@gzryzw5", MySqlDbType.Text),
					new MySqlParameter("@gzryzc5", MySqlDbType.Text),
					new MySqlParameter("@gzryfzjg5", MySqlDbType.Text),
					new MySqlParameter("@gzryxl5", MySqlDbType.Text),
					new MySqlParameter("@gzryzy5", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh1", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm1", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz1", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh2", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm2", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz2", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh3", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm3", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz3", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh4", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm4", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz4", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxh5", MySqlDbType.Text),
					new MySqlParameter("@tzzyryxm5", MySqlDbType.Text),
					new MySqlParameter("@tzzyrygz5", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg1", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh1", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq1", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg2", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh2", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq2", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg3", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh3", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq3", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg4", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh4", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq4", MySqlDbType.Text),
					new MySqlParameter("@zgzsfzjg5", MySqlDbType.Text),
					new MySqlParameter("@zgzszsbh5", MySqlDbType.Text),
					new MySqlParameter("@zgzsyxq5", MySqlDbType.Text),
					new MySqlParameter("@mxxh1", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc1", MySqlDbType.Text),
					new MySqlParameter("@mxgg1", MySqlDbType.Text),
					new MySqlParameter("@mxsl1", MySqlDbType.Text),
					new MySqlParameter("@mxzzs1", MySqlDbType.Text),
					new MySqlParameter("@mxxh2", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc2", MySqlDbType.Text),
					new MySqlParameter("@mxgg2", MySqlDbType.Text),
					new MySqlParameter("@mxsl2", MySqlDbType.Text),
					new MySqlParameter("@mxzzs2", MySqlDbType.Text),
					new MySqlParameter("@mxxh3", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc3", MySqlDbType.Text),
					new MySqlParameter("@mxgg3", MySqlDbType.Text),
					new MySqlParameter("@mxsl3", MySqlDbType.Text),
					new MySqlParameter("@mxzzs3", MySqlDbType.Text),
					new MySqlParameter("@mxxh4", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc4", MySqlDbType.Text),
					new MySqlParameter("@mxgg4", MySqlDbType.Text),
					new MySqlParameter("@mxsl4", MySqlDbType.Text),
					new MySqlParameter("@mxzzs4", MySqlDbType.Text),
					new MySqlParameter("@mxxh5", MySqlDbType.Text),
					new MySqlParameter("@mxsbmc5", MySqlDbType.Text),
					new MySqlParameter("@mxgg5", MySqlDbType.Text),
					new MySqlParameter("@mxsl5", MySqlDbType.Text),
					new MySqlParameter("@mxzzs5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq1", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq2", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq3", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq4", MySqlDbType.Text),
					new MySqlParameter("@jyylmxxh5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxmc5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxgg5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxsl5", MySqlDbType.Text),
					new MySqlParameter("@jyylmxyxq5", MySqlDbType.Text),
					new MySqlParameter("@yjylnd1", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh1", MySqlDbType.Text),
					new MySqlParameter("@yjylcl1", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr1", MySqlDbType.Text),
					new MySqlParameter("@yjylbz1", MySqlDbType.Text),
					new MySqlParameter("@yjylnd2", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh2", MySqlDbType.Text),
					new MySqlParameter("@yjylcl2", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr2", MySqlDbType.Text),
					new MySqlParameter("@yjylbz2", MySqlDbType.Text),
					new MySqlParameter("@yjylnd3", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh3", MySqlDbType.Text),
					new MySqlParameter("@yjylcl3", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr3", MySqlDbType.Text),
					new MySqlParameter("@yjylbz3", MySqlDbType.Text),
					new MySqlParameter("@yjylnd4", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh4", MySqlDbType.Text),
					new MySqlParameter("@yjylcl4", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr4", MySqlDbType.Text),
					new MySqlParameter("@yjylbz4", MySqlDbType.Text),
					new MySqlParameter("@yjylnd5", MySqlDbType.Text),
					new MySqlParameter("@yjylggxh5", MySqlDbType.Text),
					new MySqlParameter("@yjylcl5", MySqlDbType.Text),
					new MySqlParameter("@yjylxssr5", MySqlDbType.Text),
					new MySqlParameter("@yjylbz5", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.qymc;
			parameters[3].Value = model.qydz;
			parameters[4].Value = model.yb;
			parameters[5].Value = model.zzjgdm;
			parameters[6].Value = model.lxr;
			parameters[7].Value = model.gddh;
			parameters[8].Value = model.yddh;
			parameters[9].Value = model.dzyx;
			parameters[10].Value = model.cz;
			parameters[11].Value = model.yyzzzch;
			parameters[12].Value = model.jjlx;
			parameters[13].Value = model.zczj;
			parameters[14].Value = model.gdzc;
			parameters[15].Value = model.qyzgzrs;
			parameters[16].Value = model.kszzdlrq;
			parameters[17].Value = model.sqcpggxh;
			parameters[18].Value = model.fddbxm;
			parameters[19].Value = model.fddbxb;
			parameters[20].Value = model.fddbzgxl;
			parameters[21].Value = model.fddbzw;
			parameters[22].Value = model.fddbzc;
			parameters[23].Value = model.fddbzy;
			parameters[24].Value = model.fddbgddh;
			parameters[25].Value = model.fddbyddh;
			parameters[26].Value = model.fddbzypx;
			parameters[27].Value = model.fddbpxsj;
			parameters[28].Value = model.fddbzsbh;
			parameters[29].Value = model.zlfzrxm;
			parameters[30].Value = model.zlfzrxb;
			parameters[31].Value = model.zlfzrzgxl;
			parameters[32].Value = model.zlfzrzw;
			parameters[33].Value = model.zlfzrzc;
			parameters[34].Value = model.zlfzrzy;
			parameters[35].Value = model.zlfzrgddh;
			parameters[36].Value = model.zlfzryddh;
			parameters[37].Value = model.zlfzrzypx;
			parameters[38].Value = model.zlfzrpxsj;
			parameters[39].Value = model.zlfzrzsbh;
			parameters[40].Value = model.gzryxh1;
			parameters[41].Value = model.gzryxm1;
			parameters[42].Value = model.gzryzw1;
			parameters[43].Value = model.gzryzc1;
			parameters[44].Value = model.gzryfzjg1;
			parameters[45].Value = model.gzryxl1;
			parameters[46].Value = model.gzryzy1;
			parameters[47].Value = model.gzryxh2;
			parameters[48].Value = model.gzryxm2;
			parameters[49].Value = model.gzryzw2;
			parameters[50].Value = model.gzryzc2;
			parameters[51].Value = model.gzryfzjg2;
			parameters[52].Value = model.gzryxl2;
			parameters[53].Value = model.gzryzy2;
			parameters[54].Value = model.gzryxh3;
			parameters[55].Value = model.gzryxm3;
			parameters[56].Value = model.gzryzw3;
			parameters[57].Value = model.gzryzc3;
			parameters[58].Value = model.gzryfzjg3;
			parameters[59].Value = model.gzryxl3;
			parameters[60].Value = model.gzryzy3;
			parameters[61].Value = model.gzryxh4;
			parameters[62].Value = model.gzryxm4;
			parameters[63].Value = model.gzryzw4;
			parameters[64].Value = model.gzryzc4;
			parameters[65].Value = model.gzryfzjg4;
			parameters[66].Value = model.gzryxl4;
			parameters[67].Value = model.gzryzy4;
			parameters[68].Value = model.gzryxh5;
			parameters[69].Value = model.gzryxm5;
			parameters[70].Value = model.gzryzw5;
			parameters[71].Value = model.gzryzc5;
			parameters[72].Value = model.gzryfzjg5;
			parameters[73].Value = model.gzryxl5;
			parameters[74].Value = model.gzryzy5;
			parameters[75].Value = model.tzzyryxh1;
			parameters[76].Value = model.tzzyryxm1;
			parameters[77].Value = model.tzzyrygz1;
			parameters[78].Value = model.tzzyryxh2;
			parameters[79].Value = model.tzzyryxm2;
			parameters[80].Value = model.tzzyrygz2;
			parameters[81].Value = model.tzzyryxh3;
			parameters[82].Value = model.tzzyryxm3;
			parameters[83].Value = model.tzzyrygz3;
			parameters[84].Value = model.tzzyryxh4;
			parameters[85].Value = model.tzzyryxm4;
			parameters[86].Value = model.tzzyrygz4;
			parameters[87].Value = model.tzzyryxh5;
			parameters[88].Value = model.tzzyryxm5;
			parameters[89].Value = model.tzzyrygz5;
			parameters[90].Value = model.zgzsfzjg1;
			parameters[91].Value = model.zgzszsbh1;
			parameters[92].Value = model.zgzsyxq1;
			parameters[93].Value = model.zgzsfzjg2;
			parameters[94].Value = model.zgzszsbh2;
			parameters[95].Value = model.zgzsyxq2;
			parameters[96].Value = model.zgzsfzjg3;
			parameters[97].Value = model.zgzszsbh3;
			parameters[98].Value = model.zgzsyxq3;
			parameters[99].Value = model.zgzsfzjg4;
			parameters[100].Value = model.zgzszsbh4;
			parameters[101].Value = model.zgzsyxq4;
			parameters[102].Value = model.zgzsfzjg5;
			parameters[103].Value = model.zgzszsbh5;
			parameters[104].Value = model.zgzsyxq5;
			parameters[105].Value = model.mxxh1;
			parameters[106].Value = model.mxsbmc1;
			parameters[107].Value = model.mxgg1;
			parameters[108].Value = model.mxsl1;
			parameters[109].Value = model.mxzzs1;
			parameters[110].Value = model.mxxh2;
			parameters[111].Value = model.mxsbmc2;
			parameters[112].Value = model.mxgg2;
			parameters[113].Value = model.mxsl2;
			parameters[114].Value = model.mxzzs2;
			parameters[115].Value = model.mxxh3;
			parameters[116].Value = model.mxsbmc3;
			parameters[117].Value = model.mxgg3;
			parameters[118].Value = model.mxsl3;
			parameters[119].Value = model.mxzzs3;
			parameters[120].Value = model.mxxh4;
			parameters[121].Value = model.mxsbmc4;
			parameters[122].Value = model.mxgg4;
			parameters[123].Value = model.mxsl4;
			parameters[124].Value = model.mxzzs4;
			parameters[125].Value = model.mxxh5;
			parameters[126].Value = model.mxsbmc5;
			parameters[127].Value = model.mxgg5;
			parameters[128].Value = model.mxsl5;
			parameters[129].Value = model.mxzzs5;
			parameters[130].Value = model.jyylmxxh1;
			parameters[131].Value = model.jyylmxmc1;
			parameters[132].Value = model.jyylmxgg1;
			parameters[133].Value = model.jyylmxsl1;
			parameters[134].Value = model.jyylmxyxq1;
			parameters[135].Value = model.jyylmxxh2;
			parameters[136].Value = model.jyylmxmc2;
			parameters[137].Value = model.jyylmxgg2;
			parameters[138].Value = model.jyylmxsl2;
			parameters[139].Value = model.jyylmxyxq2;
			parameters[140].Value = model.jyylmxxh3;
			parameters[141].Value = model.jyylmxmc3;
			parameters[142].Value = model.jyylmxgg3;
			parameters[143].Value = model.jyylmxsl3;
			parameters[144].Value = model.jyylmxyxq3;
			parameters[145].Value = model.jyylmxxh4;
			parameters[146].Value = model.jyylmxmc4;
			parameters[147].Value = model.jyylmxgg4;
			parameters[148].Value = model.jyylmxsl4;
			parameters[149].Value = model.jyylmxyxq4;
			parameters[150].Value = model.jyylmxxh5;
			parameters[151].Value = model.jyylmxmc5;
			parameters[152].Value = model.jyylmxgg5;
			parameters[153].Value = model.jyylmxsl5;
			parameters[154].Value = model.jyylmxyxq5;
			parameters[155].Value = model.yjylnd1;
			parameters[156].Value = model.yjylggxh1;
			parameters[157].Value = model.yjylcl1;
			parameters[158].Value = model.yjylxssr1;
			parameters[159].Value = model.yjylbz1;
			parameters[160].Value = model.yjylnd2;
			parameters[161].Value = model.yjylggxh2;
			parameters[162].Value = model.yjylcl2;
			parameters[163].Value = model.yjylxssr2;
			parameters[164].Value = model.yjylbz2;
			parameters[165].Value = model.yjylnd3;
			parameters[166].Value = model.yjylggxh3;
			parameters[167].Value = model.yjylcl3;
			parameters[168].Value = model.yjylxssr3;
			parameters[169].Value = model.yjylbz3;
			parameters[170].Value = model.yjylnd4;
			parameters[171].Value = model.yjylggxh4;
			parameters[172].Value = model.yjylcl4;
			parameters[173].Value = model.yjylxssr4;
			parameters[174].Value = model.yjylbz4;
			parameters[175].Value = model.yjylnd5;
			parameters[176].Value = model.yjylggxh5;
			parameters[177].Value = model.yjylcl5;
			parameters[178].Value = model.yjylxssr5;
			parameters[179].Value = model.yjylbz5;
			parameters[180].Value = model.Guid;

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
			strSql.Append("delete from basket_made ");
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
			strSql.Append("delete from basket_made ");
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
		public AM.Model.basket_made GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,qymc,qydz,yb,zzjgdm,lxr,gddh,yddh,dzyx,cz,yyzzzch,jjlx,zczj,gdzc,qyzgzrs,kszzdlrq,sqcpggxh,fddbxm,fddbxb,fddbzgxl,fddbzw,fddbzc,fddbzy,fddbgddh,fddbyddh,fddbzypx,fddbpxsj,fddbzsbh,zlfzrxm,zlfzrxb,zlfzrzgxl,zlfzrzw,zlfzrzc,zlfzrzy,zlfzrgddh,zlfzryddh,zlfzrzypx,zlfzrpxsj,zlfzrzsbh,gzryxh1,gzryxm1,gzryzw1,gzryzc1,gzryfzjg1,gzryxl1,gzryzy1,gzryxh2,gzryxm2,gzryzw2,gzryzc2,gzryfzjg2,gzryxl2,gzryzy2,gzryxh3,gzryxm3,gzryzw3,gzryzc3,gzryfzjg3,gzryxl3,gzryzy3,gzryxh4,gzryxm4,gzryzw4,gzryzc4,gzryfzjg4,gzryxl4,gzryzy4,gzryxh5,gzryxm5,gzryzw5,gzryzc5,gzryfzjg5,gzryxl5,gzryzy5,tzzyryxh1,tzzyryxm1,tzzyrygz1,tzzyryxh2,tzzyryxm2,tzzyrygz2,tzzyryxh3,tzzyryxm3,tzzyrygz3,tzzyryxh4,tzzyryxm4,tzzyrygz4,tzzyryxh5,tzzyryxm5,tzzyrygz5,zgzsfzjg1,zgzszsbh1,zgzsyxq1,zgzsfzjg2,zgzszsbh2,zgzsyxq2,zgzsfzjg3,zgzszsbh3,zgzsyxq3,zgzsfzjg4,zgzszsbh4,zgzsyxq4,zgzsfzjg5,zgzszsbh5,zgzsyxq5,mxxh1,mxsbmc1,mxgg1,mxsl1,mxzzs1,mxxh2,mxsbmc2,mxgg2,mxsl2,mxzzs2,mxxh3,mxsbmc3,mxgg3,mxsl3,mxzzs3,mxxh4,mxsbmc4,mxgg4,mxsl4,mxzzs4,mxxh5,mxsbmc5,mxgg5,mxsl5,mxzzs5,jyylmxxh1,jyylmxmc1,jyylmxgg1,jyylmxsl1,jyylmxyxq1,jyylmxxh2,jyylmxmc2,jyylmxgg2,jyylmxsl2,jyylmxyxq2,jyylmxxh3,jyylmxmc3,jyylmxgg3,jyylmxsl3,jyylmxyxq3,jyylmxxh4,jyylmxmc4,jyylmxgg4,jyylmxsl4,jyylmxyxq4,jyylmxxh5,jyylmxmc5,jyylmxgg5,jyylmxsl5,jyylmxyxq5,yjylnd1,yjylggxh1,yjylcl1,yjylxssr1,yjylbz1,yjylnd2,yjylggxh2,yjylcl2,yjylxssr2,yjylbz2,yjylnd3,yjylggxh3,yjylcl3,yjylxssr3,yjylbz3,yjylnd4,yjylggxh4,yjylcl4,yjylxssr4,yjylbz4,yjylnd5,yjylggxh5,yjylcl5,yjylxssr5,yjylbz5 from basket_made ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.basket_made model=new AM.Model.basket_made();
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
		public AM.Model.basket_made DataRowToModel(DataRow row)
		{
			AM.Model.basket_made model=new AM.Model.basket_made();
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
				if(row["qymc"]!=null)
				{
					model.qymc=row["qymc"].ToString();
				}
				if(row["qydz"]!=null)
				{
					model.qydz=row["qydz"].ToString();
				}
				if(row["yb"]!=null)
				{
					model.yb=row["yb"].ToString();
				}
				if(row["zzjgdm"]!=null)
				{
					model.zzjgdm=row["zzjgdm"].ToString();
				}
				if(row["lxr"]!=null)
				{
					model.lxr=row["lxr"].ToString();
				}
				if(row["gddh"]!=null)
				{
					model.gddh=row["gddh"].ToString();
				}
				if(row["yddh"]!=null)
				{
					model.yddh=row["yddh"].ToString();
				}
				if(row["dzyx"]!=null)
				{
					model.dzyx=row["dzyx"].ToString();
				}
				if(row["cz"]!=null)
				{
					model.cz=row["cz"].ToString();
				}
				if(row["yyzzzch"]!=null)
				{
					model.yyzzzch=row["yyzzzch"].ToString();
				}
				if(row["jjlx"]!=null)
				{
					model.jjlx=row["jjlx"].ToString();
				}
				if(row["zczj"]!=null)
				{
					model.zczj=row["zczj"].ToString();
				}
				if(row["gdzc"]!=null)
				{
					model.gdzc=row["gdzc"].ToString();
				}
				if(row["qyzgzrs"]!=null)
				{
					model.qyzgzrs=row["qyzgzrs"].ToString();
				}
				if(row["kszzdlrq"]!=null)
				{
					model.kszzdlrq=row["kszzdlrq"].ToString();
				}
				if(row["sqcpggxh"]!=null)
				{
					model.sqcpggxh=row["sqcpggxh"].ToString();
				}
				if(row["fddbxm"]!=null)
				{
					model.fddbxm=row["fddbxm"].ToString();
				}
				if(row["fddbxb"]!=null)
				{
					model.fddbxb=row["fddbxb"].ToString();
				}
				if(row["fddbzgxl"]!=null)
				{
					model.fddbzgxl=row["fddbzgxl"].ToString();
				}
				if(row["fddbzw"]!=null)
				{
					model.fddbzw=row["fddbzw"].ToString();
				}
				if(row["fddbzc"]!=null)
				{
					model.fddbzc=row["fddbzc"].ToString();
				}
				if(row["fddbzy"]!=null)
				{
					model.fddbzy=row["fddbzy"].ToString();
				}
				if(row["fddbgddh"]!=null)
				{
					model.fddbgddh=row["fddbgddh"].ToString();
				}
				if(row["fddbyddh"]!=null)
				{
					model.fddbyddh=row["fddbyddh"].ToString();
				}
				if(row["fddbzypx"]!=null)
				{
					model.fddbzypx=row["fddbzypx"].ToString();
				}
				if(row["fddbpxsj"]!=null)
				{
					model.fddbpxsj=row["fddbpxsj"].ToString();
				}
				if(row["fddbzsbh"]!=null)
				{
					model.fddbzsbh=row["fddbzsbh"].ToString();
				}
				if(row["zlfzrxm"]!=null)
				{
					model.zlfzrxm=row["zlfzrxm"].ToString();
				}
				if(row["zlfzrxb"]!=null)
				{
					model.zlfzrxb=row["zlfzrxb"].ToString();
				}
				if(row["zlfzrzgxl"]!=null)
				{
					model.zlfzrzgxl=row["zlfzrzgxl"].ToString();
				}
				if(row["zlfzrzw"]!=null)
				{
					model.zlfzrzw=row["zlfzrzw"].ToString();
				}
				if(row["zlfzrzc"]!=null)
				{
					model.zlfzrzc=row["zlfzrzc"].ToString();
				}
				if(row["zlfzrzy"]!=null)
				{
					model.zlfzrzy=row["zlfzrzy"].ToString();
				}
				if(row["zlfzrgddh"]!=null)
				{
					model.zlfzrgddh=row["zlfzrgddh"].ToString();
				}
				if(row["zlfzryddh"]!=null)
				{
					model.zlfzryddh=row["zlfzryddh"].ToString();
				}
				if(row["zlfzrzypx"]!=null)
				{
					model.zlfzrzypx=row["zlfzrzypx"].ToString();
				}
				if(row["zlfzrpxsj"]!=null)
				{
					model.zlfzrpxsj=row["zlfzrpxsj"].ToString();
				}
				if(row["zlfzrzsbh"]!=null)
				{
					model.zlfzrzsbh=row["zlfzrzsbh"].ToString();
				}
				if(row["gzryxh1"]!=null)
				{
					model.gzryxh1=row["gzryxh1"].ToString();
				}
				if(row["gzryxm1"]!=null)
				{
					model.gzryxm1=row["gzryxm1"].ToString();
				}
				if(row["gzryzw1"]!=null)
				{
					model.gzryzw1=row["gzryzw1"].ToString();
				}
				if(row["gzryzc1"]!=null)
				{
					model.gzryzc1=row["gzryzc1"].ToString();
				}
				if(row["gzryfzjg1"]!=null)
				{
					model.gzryfzjg1=row["gzryfzjg1"].ToString();
				}
				if(row["gzryxl1"]!=null)
				{
					model.gzryxl1=row["gzryxl1"].ToString();
				}
				if(row["gzryzy1"]!=null)
				{
					model.gzryzy1=row["gzryzy1"].ToString();
				}
				if(row["gzryxh2"]!=null)
				{
					model.gzryxh2=row["gzryxh2"].ToString();
				}
				if(row["gzryxm2"]!=null)
				{
					model.gzryxm2=row["gzryxm2"].ToString();
				}
				if(row["gzryzw2"]!=null)
				{
					model.gzryzw2=row["gzryzw2"].ToString();
				}
				if(row["gzryzc2"]!=null)
				{
					model.gzryzc2=row["gzryzc2"].ToString();
				}
				if(row["gzryfzjg2"]!=null)
				{
					model.gzryfzjg2=row["gzryfzjg2"].ToString();
				}
				if(row["gzryxl2"]!=null)
				{
					model.gzryxl2=row["gzryxl2"].ToString();
				}
				if(row["gzryzy2"]!=null)
				{
					model.gzryzy2=row["gzryzy2"].ToString();
				}
				if(row["gzryxh3"]!=null)
				{
					model.gzryxh3=row["gzryxh3"].ToString();
				}
				if(row["gzryxm3"]!=null)
				{
					model.gzryxm3=row["gzryxm3"].ToString();
				}
				if(row["gzryzw3"]!=null)
				{
					model.gzryzw3=row["gzryzw3"].ToString();
				}
				if(row["gzryzc3"]!=null)
				{
					model.gzryzc3=row["gzryzc3"].ToString();
				}
				if(row["gzryfzjg3"]!=null)
				{
					model.gzryfzjg3=row["gzryfzjg3"].ToString();
				}
				if(row["gzryxl3"]!=null)
				{
					model.gzryxl3=row["gzryxl3"].ToString();
				}
				if(row["gzryzy3"]!=null)
				{
					model.gzryzy3=row["gzryzy3"].ToString();
				}
				if(row["gzryxh4"]!=null)
				{
					model.gzryxh4=row["gzryxh4"].ToString();
				}
				if(row["gzryxm4"]!=null)
				{
					model.gzryxm4=row["gzryxm4"].ToString();
				}
				if(row["gzryzw4"]!=null)
				{
					model.gzryzw4=row["gzryzw4"].ToString();
				}
				if(row["gzryzc4"]!=null)
				{
					model.gzryzc4=row["gzryzc4"].ToString();
				}
				if(row["gzryfzjg4"]!=null)
				{
					model.gzryfzjg4=row["gzryfzjg4"].ToString();
				}
				if(row["gzryxl4"]!=null)
				{
					model.gzryxl4=row["gzryxl4"].ToString();
				}
				if(row["gzryzy4"]!=null)
				{
					model.gzryzy4=row["gzryzy4"].ToString();
				}
				if(row["gzryxh5"]!=null)
				{
					model.gzryxh5=row["gzryxh5"].ToString();
				}
				if(row["gzryxm5"]!=null)
				{
					model.gzryxm5=row["gzryxm5"].ToString();
				}
				if(row["gzryzw5"]!=null)
				{
					model.gzryzw5=row["gzryzw5"].ToString();
				}
				if(row["gzryzc5"]!=null)
				{
					model.gzryzc5=row["gzryzc5"].ToString();
				}
				if(row["gzryfzjg5"]!=null)
				{
					model.gzryfzjg5=row["gzryfzjg5"].ToString();
				}
				if(row["gzryxl5"]!=null)
				{
					model.gzryxl5=row["gzryxl5"].ToString();
				}
				if(row["gzryzy5"]!=null)
				{
					model.gzryzy5=row["gzryzy5"].ToString();
				}
				if(row["tzzyryxh1"]!=null)
				{
					model.tzzyryxh1=row["tzzyryxh1"].ToString();
				}
				if(row["tzzyryxm1"]!=null)
				{
					model.tzzyryxm1=row["tzzyryxm1"].ToString();
				}
				if(row["tzzyrygz1"]!=null)
				{
					model.tzzyrygz1=row["tzzyrygz1"].ToString();
				}
				if(row["tzzyryxh2"]!=null)
				{
					model.tzzyryxh2=row["tzzyryxh2"].ToString();
				}
				if(row["tzzyryxm2"]!=null)
				{
					model.tzzyryxm2=row["tzzyryxm2"].ToString();
				}
				if(row["tzzyrygz2"]!=null)
				{
					model.tzzyrygz2=row["tzzyrygz2"].ToString();
				}
				if(row["tzzyryxh3"]!=null)
				{
					model.tzzyryxh3=row["tzzyryxh3"].ToString();
				}
				if(row["tzzyryxm3"]!=null)
				{
					model.tzzyryxm3=row["tzzyryxm3"].ToString();
				}
				if(row["tzzyrygz3"]!=null)
				{
					model.tzzyrygz3=row["tzzyrygz3"].ToString();
				}
				if(row["tzzyryxh4"]!=null)
				{
					model.tzzyryxh4=row["tzzyryxh4"].ToString();
				}
				if(row["tzzyryxm4"]!=null)
				{
					model.tzzyryxm4=row["tzzyryxm4"].ToString();
				}
				if(row["tzzyrygz4"]!=null)
				{
					model.tzzyrygz4=row["tzzyrygz4"].ToString();
				}
				if(row["tzzyryxh5"]!=null)
				{
					model.tzzyryxh5=row["tzzyryxh5"].ToString();
				}
				if(row["tzzyryxm5"]!=null)
				{
					model.tzzyryxm5=row["tzzyryxm5"].ToString();
				}
				if(row["tzzyrygz5"]!=null)
				{
					model.tzzyrygz5=row["tzzyrygz5"].ToString();
				}
				if(row["zgzsfzjg1"]!=null)
				{
					model.zgzsfzjg1=row["zgzsfzjg1"].ToString();
				}
				if(row["zgzszsbh1"]!=null)
				{
					model.zgzszsbh1=row["zgzszsbh1"].ToString();
				}
				if(row["zgzsyxq1"]!=null)
				{
					model.zgzsyxq1=row["zgzsyxq1"].ToString();
				}
				if(row["zgzsfzjg2"]!=null)
				{
					model.zgzsfzjg2=row["zgzsfzjg2"].ToString();
				}
				if(row["zgzszsbh2"]!=null)
				{
					model.zgzszsbh2=row["zgzszsbh2"].ToString();
				}
				if(row["zgzsyxq2"]!=null)
				{
					model.zgzsyxq2=row["zgzsyxq2"].ToString();
				}
				if(row["zgzsfzjg3"]!=null)
				{
					model.zgzsfzjg3=row["zgzsfzjg3"].ToString();
				}
				if(row["zgzszsbh3"]!=null)
				{
					model.zgzszsbh3=row["zgzszsbh3"].ToString();
				}
				if(row["zgzsyxq3"]!=null)
				{
					model.zgzsyxq3=row["zgzsyxq3"].ToString();
				}
				if(row["zgzsfzjg4"]!=null)
				{
					model.zgzsfzjg4=row["zgzsfzjg4"].ToString();
				}
				if(row["zgzszsbh4"]!=null)
				{
					model.zgzszsbh4=row["zgzszsbh4"].ToString();
				}
				if(row["zgzsyxq4"]!=null)
				{
					model.zgzsyxq4=row["zgzsyxq4"].ToString();
				}
				if(row["zgzsfzjg5"]!=null)
				{
					model.zgzsfzjg5=row["zgzsfzjg5"].ToString();
				}
				if(row["zgzszsbh5"]!=null)
				{
					model.zgzszsbh5=row["zgzszsbh5"].ToString();
				}
				if(row["zgzsyxq5"]!=null)
				{
					model.zgzsyxq5=row["zgzsyxq5"].ToString();
				}
				if(row["mxxh1"]!=null)
				{
					model.mxxh1=row["mxxh1"].ToString();
				}
				if(row["mxsbmc1"]!=null)
				{
					model.mxsbmc1=row["mxsbmc1"].ToString();
				}
				if(row["mxgg1"]!=null)
				{
					model.mxgg1=row["mxgg1"].ToString();
				}
				if(row["mxsl1"]!=null)
				{
					model.mxsl1=row["mxsl1"].ToString();
				}
				if(row["mxzzs1"]!=null)
				{
					model.mxzzs1=row["mxzzs1"].ToString();
				}
				if(row["mxxh2"]!=null)
				{
					model.mxxh2=row["mxxh2"].ToString();
				}
				if(row["mxsbmc2"]!=null)
				{
					model.mxsbmc2=row["mxsbmc2"].ToString();
				}
				if(row["mxgg2"]!=null)
				{
					model.mxgg2=row["mxgg2"].ToString();
				}
				if(row["mxsl2"]!=null)
				{
					model.mxsl2=row["mxsl2"].ToString();
				}
				if(row["mxzzs2"]!=null)
				{
					model.mxzzs2=row["mxzzs2"].ToString();
				}
				if(row["mxxh3"]!=null)
				{
					model.mxxh3=row["mxxh3"].ToString();
				}
				if(row["mxsbmc3"]!=null)
				{
					model.mxsbmc3=row["mxsbmc3"].ToString();
				}
				if(row["mxgg3"]!=null)
				{
					model.mxgg3=row["mxgg3"].ToString();
				}
				if(row["mxsl3"]!=null)
				{
					model.mxsl3=row["mxsl3"].ToString();
				}
				if(row["mxzzs3"]!=null)
				{
					model.mxzzs3=row["mxzzs3"].ToString();
				}
				if(row["mxxh4"]!=null)
				{
					model.mxxh4=row["mxxh4"].ToString();
				}
				if(row["mxsbmc4"]!=null)
				{
					model.mxsbmc4=row["mxsbmc4"].ToString();
				}
				if(row["mxgg4"]!=null)
				{
					model.mxgg4=row["mxgg4"].ToString();
				}
				if(row["mxsl4"]!=null)
				{
					model.mxsl4=row["mxsl4"].ToString();
				}
				if(row["mxzzs4"]!=null)
				{
					model.mxzzs4=row["mxzzs4"].ToString();
				}
				if(row["mxxh5"]!=null)
				{
					model.mxxh5=row["mxxh5"].ToString();
				}
				if(row["mxsbmc5"]!=null)
				{
					model.mxsbmc5=row["mxsbmc5"].ToString();
				}
				if(row["mxgg5"]!=null)
				{
					model.mxgg5=row["mxgg5"].ToString();
				}
				if(row["mxsl5"]!=null)
				{
					model.mxsl5=row["mxsl5"].ToString();
				}
				if(row["mxzzs5"]!=null)
				{
					model.mxzzs5=row["mxzzs5"].ToString();
				}
				if(row["jyylmxxh1"]!=null)
				{
					model.jyylmxxh1=row["jyylmxxh1"].ToString();
				}
				if(row["jyylmxmc1"]!=null)
				{
					model.jyylmxmc1=row["jyylmxmc1"].ToString();
				}
				if(row["jyylmxgg1"]!=null)
				{
					model.jyylmxgg1=row["jyylmxgg1"].ToString();
				}
				if(row["jyylmxsl1"]!=null)
				{
					model.jyylmxsl1=row["jyylmxsl1"].ToString();
				}
				if(row["jyylmxyxq1"]!=null)
				{
					model.jyylmxyxq1=row["jyylmxyxq1"].ToString();
				}
				if(row["jyylmxxh2"]!=null)
				{
					model.jyylmxxh2=row["jyylmxxh2"].ToString();
				}
				if(row["jyylmxmc2"]!=null)
				{
					model.jyylmxmc2=row["jyylmxmc2"].ToString();
				}
				if(row["jyylmxgg2"]!=null)
				{
					model.jyylmxgg2=row["jyylmxgg2"].ToString();
				}
				if(row["jyylmxsl2"]!=null)
				{
					model.jyylmxsl2=row["jyylmxsl2"].ToString();
				}
				if(row["jyylmxyxq2"]!=null)
				{
					model.jyylmxyxq2=row["jyylmxyxq2"].ToString();
				}
				if(row["jyylmxxh3"]!=null)
				{
					model.jyylmxxh3=row["jyylmxxh3"].ToString();
				}
				if(row["jyylmxmc3"]!=null)
				{
					model.jyylmxmc3=row["jyylmxmc3"].ToString();
				}
				if(row["jyylmxgg3"]!=null)
				{
					model.jyylmxgg3=row["jyylmxgg3"].ToString();
				}
				if(row["jyylmxsl3"]!=null)
				{
					model.jyylmxsl3=row["jyylmxsl3"].ToString();
				}
				if(row["jyylmxyxq3"]!=null)
				{
					model.jyylmxyxq3=row["jyylmxyxq3"].ToString();
				}
				if(row["jyylmxxh4"]!=null)
				{
					model.jyylmxxh4=row["jyylmxxh4"].ToString();
				}
				if(row["jyylmxmc4"]!=null)
				{
					model.jyylmxmc4=row["jyylmxmc4"].ToString();
				}
				if(row["jyylmxgg4"]!=null)
				{
					model.jyylmxgg4=row["jyylmxgg4"].ToString();
				}
				if(row["jyylmxsl4"]!=null)
				{
					model.jyylmxsl4=row["jyylmxsl4"].ToString();
				}
				if(row["jyylmxyxq4"]!=null)
				{
					model.jyylmxyxq4=row["jyylmxyxq4"].ToString();
				}
				if(row["jyylmxxh5"]!=null)
				{
					model.jyylmxxh5=row["jyylmxxh5"].ToString();
				}
				if(row["jyylmxmc5"]!=null)
				{
					model.jyylmxmc5=row["jyylmxmc5"].ToString();
				}
				if(row["jyylmxgg5"]!=null)
				{
					model.jyylmxgg5=row["jyylmxgg5"].ToString();
				}
				if(row["jyylmxsl5"]!=null)
				{
					model.jyylmxsl5=row["jyylmxsl5"].ToString();
				}
				if(row["jyylmxyxq5"]!=null)
				{
					model.jyylmxyxq5=row["jyylmxyxq5"].ToString();
				}
				if(row["yjylnd1"]!=null)
				{
					model.yjylnd1=row["yjylnd1"].ToString();
				}
				if(row["yjylggxh1"]!=null)
				{
					model.yjylggxh1=row["yjylggxh1"].ToString();
				}
				if(row["yjylcl1"]!=null)
				{
					model.yjylcl1=row["yjylcl1"].ToString();
				}
				if(row["yjylxssr1"]!=null)
				{
					model.yjylxssr1=row["yjylxssr1"].ToString();
				}
				if(row["yjylbz1"]!=null)
				{
					model.yjylbz1=row["yjylbz1"].ToString();
				}
				if(row["yjylnd2"]!=null)
				{
					model.yjylnd2=row["yjylnd2"].ToString();
				}
				if(row["yjylggxh2"]!=null)
				{
					model.yjylggxh2=row["yjylggxh2"].ToString();
				}
				if(row["yjylcl2"]!=null)
				{
					model.yjylcl2=row["yjylcl2"].ToString();
				}
				if(row["yjylxssr2"]!=null)
				{
					model.yjylxssr2=row["yjylxssr2"].ToString();
				}
				if(row["yjylbz2"]!=null)
				{
					model.yjylbz2=row["yjylbz2"].ToString();
				}
				if(row["yjylnd3"]!=null)
				{
					model.yjylnd3=row["yjylnd3"].ToString();
				}
				if(row["yjylggxh3"]!=null)
				{
					model.yjylggxh3=row["yjylggxh3"].ToString();
				}
				if(row["yjylcl3"]!=null)
				{
					model.yjylcl3=row["yjylcl3"].ToString();
				}
				if(row["yjylxssr3"]!=null)
				{
					model.yjylxssr3=row["yjylxssr3"].ToString();
				}
				if(row["yjylbz3"]!=null)
				{
					model.yjylbz3=row["yjylbz3"].ToString();
				}
				if(row["yjylnd4"]!=null)
				{
					model.yjylnd4=row["yjylnd4"].ToString();
				}
				if(row["yjylggxh4"]!=null)
				{
					model.yjylggxh4=row["yjylggxh4"].ToString();
				}
				if(row["yjylcl4"]!=null)
				{
					model.yjylcl4=row["yjylcl4"].ToString();
				}
				if(row["yjylxssr4"]!=null)
				{
					model.yjylxssr4=row["yjylxssr4"].ToString();
				}
				if(row["yjylbz4"]!=null)
				{
					model.yjylbz4=row["yjylbz4"].ToString();
				}
				if(row["yjylnd5"]!=null)
				{
					model.yjylnd5=row["yjylnd5"].ToString();
				}
				if(row["yjylggxh5"]!=null)
				{
					model.yjylggxh5=row["yjylggxh5"].ToString();
				}
				if(row["yjylcl5"]!=null)
				{
					model.yjylcl5=row["yjylcl5"].ToString();
				}
				if(row["yjylxssr5"]!=null)
				{
					model.yjylxssr5=row["yjylxssr5"].ToString();
				}
				if(row["yjylbz5"]!=null)
				{
					model.yjylbz5=row["yjylbz5"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,qymc,qydz,yb,zzjgdm,lxr,gddh,yddh,dzyx,cz,yyzzzch,jjlx,zczj,gdzc,qyzgzrs,kszzdlrq,sqcpggxh,fddbxm,fddbxb,fddbzgxl,fddbzw,fddbzc,fddbzy,fddbgddh,fddbyddh,fddbzypx,fddbpxsj,fddbzsbh,zlfzrxm,zlfzrxb,zlfzrzgxl,zlfzrzw,zlfzrzc,zlfzrzy,zlfzrgddh,zlfzryddh,zlfzrzypx,zlfzrpxsj,zlfzrzsbh,gzryxh1,gzryxm1,gzryzw1,gzryzc1,gzryfzjg1,gzryxl1,gzryzy1,gzryxh2,gzryxm2,gzryzw2,gzryzc2,gzryfzjg2,gzryxl2,gzryzy2,gzryxh3,gzryxm3,gzryzw3,gzryzc3,gzryfzjg3,gzryxl3,gzryzy3,gzryxh4,gzryxm4,gzryzw4,gzryzc4,gzryfzjg4,gzryxl4,gzryzy4,gzryxh5,gzryxm5,gzryzw5,gzryzc5,gzryfzjg5,gzryxl5,gzryzy5,tzzyryxh1,tzzyryxm1,tzzyrygz1,tzzyryxh2,tzzyryxm2,tzzyrygz2,tzzyryxh3,tzzyryxm3,tzzyrygz3,tzzyryxh4,tzzyryxm4,tzzyrygz4,tzzyryxh5,tzzyryxm5,tzzyrygz5,zgzsfzjg1,zgzszsbh1,zgzsyxq1,zgzsfzjg2,zgzszsbh2,zgzsyxq2,zgzsfzjg3,zgzszsbh3,zgzsyxq3,zgzsfzjg4,zgzszsbh4,zgzsyxq4,zgzsfzjg5,zgzszsbh5,zgzsyxq5,mxxh1,mxsbmc1,mxgg1,mxsl1,mxzzs1,mxxh2,mxsbmc2,mxgg2,mxsl2,mxzzs2,mxxh3,mxsbmc3,mxgg3,mxsl3,mxzzs3,mxxh4,mxsbmc4,mxgg4,mxsl4,mxzzs4,mxxh5,mxsbmc5,mxgg5,mxsl5,mxzzs5,jyylmxxh1,jyylmxmc1,jyylmxgg1,jyylmxsl1,jyylmxyxq1,jyylmxxh2,jyylmxmc2,jyylmxgg2,jyylmxsl2,jyylmxyxq2,jyylmxxh3,jyylmxmc3,jyylmxgg3,jyylmxsl3,jyylmxyxq3,jyylmxxh4,jyylmxmc4,jyylmxgg4,jyylmxsl4,jyylmxyxq4,jyylmxxh5,jyylmxmc5,jyylmxgg5,jyylmxsl5,jyylmxyxq5,yjylnd1,yjylggxh1,yjylcl1,yjylxssr1,yjylbz1,yjylnd2,yjylggxh2,yjylcl2,yjylxssr2,yjylbz2,yjylnd3,yjylggxh3,yjylcl3,yjylxssr3,yjylbz3,yjylnd4,yjylggxh4,yjylcl4,yjylxssr4,yjylbz4,yjylnd5,yjylggxh5,yjylcl5,yjylxssr5,yjylbz5 ");
			strSql.Append(" FROM basket_made ");
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
			strSql.Append("select count(1) FROM basket_made ");
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
        public basket_made GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_made ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            basket_made model = new basket_made();
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
            strSql.Append("select * from basket_made ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM basket_made TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM basket_made TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
	}
}

