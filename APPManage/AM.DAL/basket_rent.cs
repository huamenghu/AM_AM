/**  版本信息模板在安装目录下，可自行修改。
* basket_rent.cs
*
* 功 能： N/A
* 类 名： basket_rent
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:15   N/A    初版
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
	/// 数据访问类:basket_rent
	/// </summary>
	public partial class basket_rentDAL
	{
        public basket_rentDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from basket_rent");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.basket_rent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into basket_rent(");
			strSql.Append("Guid,userid,CreateDate,QYQYMC,QYQYDZ,QYYB,QYZZJGDM,QYLXR,QYGDDH,QYYDDH,QYDZYX,QYCZ,QYYYZZZCH,QYZCRQ,QYYYZZDJJG,QYJJLX,QYZCZJ,QYGDZC,QYCSDLYWRS,QYQYZGZRS,QYCZYDLSL,QYKSCSDLYWRQ,QYQYJJ,QYFRXM,QYFRXB,QYFRZGXL,QYFRZW,QYFRZC,QYFRZY,QYFRGDDH,QYFRYDDH,QYFRPX,QYFRPXSJ,QYFRPXHGZSBH,QYJLXM,QYJLXB,QYJLZGXL,QYJLZW,QYJLZC,QYJLZY,QYJLGDDH,QYJLYDDH,QYJLPX,QYJLPXSJ,QYJLPXHGZSBH,QYJSXM,QYJSXB,QYJSZGXL,QYJSZW,QYJSZC,QYJSZY,QYJSGDDH,QYJSYDDH,QYJSPX,QYJSPXSJ,QYJSPXHGZSBH,GLRYXH1,GLRYXM1,GLRYZW1,GLRYZC1,GLRYXL1,GLRYZY1,GLRYSFZHM1,GLRYXH2,GLRYXM2,GLRYZW2,GLRYZC2,GLRYXL2,GLRYZY2,GLRYSFZHM2,GLRYXH3,GLRYXM3,GLRYZW3,GLRYZC3,GLRYXL3,GLRYZY3,GLRYSFZHM3,GLRYXH4,GLRYXM4,GLRYZW4,GLRYZC4,GLRYXL4,GLRYZY4,GLRYSFZHM4,GLRYXH5,GLRYXM5,GLRYZW5,GLRYZC5,GLRYXL5,GLRYZY5,GLRYSFZHM5,JSGRXH1,JSGRXM1,JSGRGZ1,JSGRXH2,JSGRXM2,JSGRGZ2,JSGRXH3,JSGRXM3,JSGRGZ3,JSGRXH4,JSGRXM4,JSGRGZ4,JSGRXH5,JSGRXM5,JSGRGZ5,ZGZSFZJG1,ZGZSZSBH1,ZGZSYXQ1,ZGZSFZJG2,ZGZSZSBH2,ZGZSYXQ2,ZGZSFZJG3,ZGZSZSBH3,ZGZSYXQ3,ZGZSFZJG4,ZGZSZSBH4,ZGZSYXQ4,ZGZSFZJG5,ZGZSZSBH5,ZGZSYXQ5,WXJCSBXUH1,WXJCSBMC1,WXJCSBXH1,WXJCSBSL1,WXJCSBBZ1,WXJCSBXUH2,WXJCSBMC2,WXJCSBXH2,WXJCSBSL2,WXJCSBBZ2,WXJCSBXUH3,WXJCSBMC3,WXJCSBXH3,WXJCSBSL3,WXJCSBBZ3,WXJCSBXUH4,WXJCSBMC4,WXJCSBXH4,WXJCSBSL4,WXJCSBBZ4,WXJCSBXUH5,WXJCSBMC5,WXJCSBXH5,WXJCSBSL5,WXJCSBBZ5,GCYJXH1,GCYJGCXMMC1,GCYJZLDLTS1,GCYJZJZE1,GCYJKJGSJ1,GCYJBZ1,GCYJXH2,GCYJGCXMMC2,GCYJZLDLTS2,GCYJZJZE2,GCYJKJGSJ2,GCYJBZ2,GCYJXH3,GCYJGCXMMC3,GCYJZLDLTS3,GCYJZJZE3,GCYJKJGSJ3,GCYJBZ3,GCYJXH4,GCYJGCXMMC4,GCYJZLDLTS4,GCYJZJZE4,GCYJKJGSJ4,GCYJBZ4,GCYJXH5,GCYJGCXMMC5,GCYJZLDLTS5,GCYJZJZE5,GCYJKJGSJ5,GCYJBZ5,CZDLXUH1,CZDLXH1,CZDLMC1,CZDLCCRQ1,CZDLDLZZCJ1,CZDLSL1,CZDLXUH2,CZDLXH2,CZDLMC2,CZDLCCRQ2,CZDLDLZZCJ2,CZDLSL2,CZDLXUH3,CZDLXH3,CZDLMC3,CZDLCCRQ3,CZDLDLZZCJ3,CZDLSL3,CZDLXUH4,CZDLXH4,CZDLMC4,CZDLCCRQ4,CZDLDLZZCJ4,CZDLSL4,CZDLXUH5,CZDLXH5,CZDLMC5,CZDLCCRQ5,CZDLDLZZCJ5,CZDLSL5)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@QYQYMC,@QYQYDZ,@QYYB,@QYZZJGDM,@QYLXR,@QYGDDH,@QYYDDH,@QYDZYX,@QYCZ,@QYYYZZZCH,@QYZCRQ,@QYYYZZDJJG,@QYJJLX,@QYZCZJ,@QYGDZC,@QYCSDLYWRS,@QYQYZGZRS,@QYCZYDLSL,@QYKSCSDLYWRQ,@QYQYJJ,@QYFRXM,@QYFRXB,@QYFRZGXL,@QYFRZW,@QYFRZC,@QYFRZY,@QYFRGDDH,@QYFRYDDH,@QYFRPX,@QYFRPXSJ,@QYFRPXHGZSBH,@QYJLXM,@QYJLXB,@QYJLZGXL,@QYJLZW,@QYJLZC,@QYJLZY,@QYJLGDDH,@QYJLYDDH,@QYJLPX,@QYJLPXSJ,@QYJLPXHGZSBH,@QYJSXM,@QYJSXB,@QYJSZGXL,@QYJSZW,@QYJSZC,@QYJSZY,@QYJSGDDH,@QYJSYDDH,@QYJSPX,@QYJSPXSJ,@QYJSPXHGZSBH,@GLRYXH1,@GLRYXM1,@GLRYZW1,@GLRYZC1,@GLRYXL1,@GLRYZY1,@GLRYSFZHM1,@GLRYXH2,@GLRYXM2,@GLRYZW2,@GLRYZC2,@GLRYXL2,@GLRYZY2,@GLRYSFZHM2,@GLRYXH3,@GLRYXM3,@GLRYZW3,@GLRYZC3,@GLRYXL3,@GLRYZY3,@GLRYSFZHM3,@GLRYXH4,@GLRYXM4,@GLRYZW4,@GLRYZC4,@GLRYXL4,@GLRYZY4,@GLRYSFZHM4,@GLRYXH5,@GLRYXM5,@GLRYZW5,@GLRYZC5,@GLRYXL5,@GLRYZY5,@GLRYSFZHM5,@JSGRXH1,@JSGRXM1,@JSGRGZ1,@JSGRXH2,@JSGRXM2,@JSGRGZ2,@JSGRXH3,@JSGRXM3,@JSGRGZ3,@JSGRXH4,@JSGRXM4,@JSGRGZ4,@JSGRXH5,@JSGRXM5,@JSGRGZ5,@ZGZSFZJG1,@ZGZSZSBH1,@ZGZSYXQ1,@ZGZSFZJG2,@ZGZSZSBH2,@ZGZSYXQ2,@ZGZSFZJG3,@ZGZSZSBH3,@ZGZSYXQ3,@ZGZSFZJG4,@ZGZSZSBH4,@ZGZSYXQ4,@ZGZSFZJG5,@ZGZSZSBH5,@ZGZSYXQ5,@WXJCSBXUH1,@WXJCSBMC1,@WXJCSBXH1,@WXJCSBSL1,@WXJCSBBZ1,@WXJCSBXUH2,@WXJCSBMC2,@WXJCSBXH2,@WXJCSBSL2,@WXJCSBBZ2,@WXJCSBXUH3,@WXJCSBMC3,@WXJCSBXH3,@WXJCSBSL3,@WXJCSBBZ3,@WXJCSBXUH4,@WXJCSBMC4,@WXJCSBXH4,@WXJCSBSL4,@WXJCSBBZ4,@WXJCSBXUH5,@WXJCSBMC5,@WXJCSBXH5,@WXJCSBSL5,@WXJCSBBZ5,@GCYJXH1,@GCYJGCXMMC1,@GCYJZLDLTS1,@GCYJZJZE1,@GCYJKJGSJ1,@GCYJBZ1,@GCYJXH2,@GCYJGCXMMC2,@GCYJZLDLTS2,@GCYJZJZE2,@GCYJKJGSJ2,@GCYJBZ2,@GCYJXH3,@GCYJGCXMMC3,@GCYJZLDLTS3,@GCYJZJZE3,@GCYJKJGSJ3,@GCYJBZ3,@GCYJXH4,@GCYJGCXMMC4,@GCYJZLDLTS4,@GCYJZJZE4,@GCYJKJGSJ4,@GCYJBZ4,@GCYJXH5,@GCYJGCXMMC5,@GCYJZLDLTS5,@GCYJZJZE5,@GCYJKJGSJ5,@GCYJBZ5,@CZDLXUH1,@CZDLXH1,@CZDLMC1,@CZDLCCRQ1,@CZDLDLZZCJ1,@CZDLSL1,@CZDLXUH2,@CZDLXH2,@CZDLMC2,@CZDLCCRQ2,@CZDLDLZZCJ2,@CZDLSL2,@CZDLXUH3,@CZDLXH3,@CZDLMC3,@CZDLCCRQ3,@CZDLDLZZCJ3,@CZDLSL3,@CZDLXUH4,@CZDLXH4,@CZDLMC4,@CZDLCCRQ4,@CZDLDLZZCJ4,@CZDLSL4,@CZDLXUH5,@CZDLXH5,@CZDLMC5,@CZDLCCRQ5,@CZDLDLZZCJ5,@CZDLSL5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@QYQYMC", MySqlDbType.Text),
					new MySqlParameter("@QYQYDZ", MySqlDbType.Text),
					new MySqlParameter("@QYYB", MySqlDbType.Text),
					new MySqlParameter("@QYZZJGDM", MySqlDbType.Text),
					new MySqlParameter("@QYLXR", MySqlDbType.Text),
					new MySqlParameter("@QYGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYDZYX", MySqlDbType.Text),
					new MySqlParameter("@QYCZ", MySqlDbType.Text),
					new MySqlParameter("@QYYYZZZCH", MySqlDbType.Text),
					new MySqlParameter("@QYZCRQ", MySqlDbType.Text),
					new MySqlParameter("@QYYYZZDJJG", MySqlDbType.Text),
					new MySqlParameter("@QYJJLX", MySqlDbType.Text),
					new MySqlParameter("@QYZCZJ", MySqlDbType.Text),
					new MySqlParameter("@QYGDZC", MySqlDbType.Text),
					new MySqlParameter("@QYCSDLYWRS", MySqlDbType.Text),
					new MySqlParameter("@QYQYZGZRS", MySqlDbType.Text),
					new MySqlParameter("@QYCZYDLSL", MySqlDbType.Text),
					new MySqlParameter("@QYKSCSDLYWRQ", MySqlDbType.Text),
					new MySqlParameter("@QYQYJJ", MySqlDbType.Text),
					new MySqlParameter("@QYFRXM", MySqlDbType.Text),
					new MySqlParameter("@QYFRXB", MySqlDbType.Text),
					new MySqlParameter("@QYFRZGXL", MySqlDbType.Text),
					new MySqlParameter("@QYFRZW", MySqlDbType.Text),
					new MySqlParameter("@QYFRZC", MySqlDbType.Text),
					new MySqlParameter("@QYFRZY", MySqlDbType.Text),
					new MySqlParameter("@QYFRGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYFRYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYFRPX", MySqlDbType.Text),
					new MySqlParameter("@QYFRPXSJ", MySqlDbType.Text),
					new MySqlParameter("@QYFRPXHGZSBH", MySqlDbType.Text),
					new MySqlParameter("@QYJLXM", MySqlDbType.Text),
					new MySqlParameter("@QYJLXB", MySqlDbType.Text),
					new MySqlParameter("@QYJLZGXL", MySqlDbType.Text),
					new MySqlParameter("@QYJLZW", MySqlDbType.Text),
					new MySqlParameter("@QYJLZC", MySqlDbType.Text),
					new MySqlParameter("@QYJLZY", MySqlDbType.Text),
					new MySqlParameter("@QYJLGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJLYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJLPX", MySqlDbType.Text),
					new MySqlParameter("@QYJLPXSJ", MySqlDbType.Text),
					new MySqlParameter("@QYJLPXHGZSBH", MySqlDbType.Text),
					new MySqlParameter("@QYJSXM", MySqlDbType.Text),
					new MySqlParameter("@QYJSXB", MySqlDbType.Text),
					new MySqlParameter("@QYJSZGXL", MySqlDbType.Text),
					new MySqlParameter("@QYJSZW", MySqlDbType.Text),
					new MySqlParameter("@QYJSZC", MySqlDbType.Text),
					new MySqlParameter("@QYJSZY", MySqlDbType.Text),
					new MySqlParameter("@QYJSGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJSYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJSPX", MySqlDbType.Text),
					new MySqlParameter("@QYJSPXSJ", MySqlDbType.Text),
					new MySqlParameter("@QYJSPXHGZSBH", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH1", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM1", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW1", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC1", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL1", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY1", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM1", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH2", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM2", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW2", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC2", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL2", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY2", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM2", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH3", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM3", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW3", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC3", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL3", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY3", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM3", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH4", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM4", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW4", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC4", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL4", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY4", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM4", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH5", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM5", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW5", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC5", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL5", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY5", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM5", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH1", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM1", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ1", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH2", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM2", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ2", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH3", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM3", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ3", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH4", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM4", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ4", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH5", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM5", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ5", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG1", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH1", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ1", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG2", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH2", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ2", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG3", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH3", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ3", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG4", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH4", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ4", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG5", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH5", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ5", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH1", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC1", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS1", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE1", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ1", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ1", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH2", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC2", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS2", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE2", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ2", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ2", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH3", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC3", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS3", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE3", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ3", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ3", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH4", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC4", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS4", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE4", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ4", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ4", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH5", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC5", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS5", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE5", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ5", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ5", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH1", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH1", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC1", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ1", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ1", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL1", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH2", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH2", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC2", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ2", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ2", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL2", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH3", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH3", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC3", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ3", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ3", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL3", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH4", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH4", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC4", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ4", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ4", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL4", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH5", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH5", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC5", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ5", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ5", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL5", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.QYQYMC;
			parameters[4].Value = model.QYQYDZ;
			parameters[5].Value = model.QYYB;
			parameters[6].Value = model.QYZZJGDM;
			parameters[7].Value = model.QYLXR;
			parameters[8].Value = model.QYGDDH;
			parameters[9].Value = model.QYYDDH;
			parameters[10].Value = model.QYDZYX;
			parameters[11].Value = model.QYCZ;
			parameters[12].Value = model.QYYYZZZCH;
			parameters[13].Value = model.QYZCRQ;
			parameters[14].Value = model.QYYYZZDJJG;
			parameters[15].Value = model.QYJJLX;
			parameters[16].Value = model.QYZCZJ;
			parameters[17].Value = model.QYGDZC;
			parameters[18].Value = model.QYCSDLYWRS;
			parameters[19].Value = model.QYQYZGZRS;
			parameters[20].Value = model.QYCZYDLSL;
			parameters[21].Value = model.QYKSCSDLYWRQ;
			parameters[22].Value = model.QYQYJJ;
			parameters[23].Value = model.QYFRXM;
			parameters[24].Value = model.QYFRXB;
			parameters[25].Value = model.QYFRZGXL;
			parameters[26].Value = model.QYFRZW;
			parameters[27].Value = model.QYFRZC;
			parameters[28].Value = model.QYFRZY;
			parameters[29].Value = model.QYFRGDDH;
			parameters[30].Value = model.QYFRYDDH;
			parameters[31].Value = model.QYFRPX;
			parameters[32].Value = model.QYFRPXSJ;
			parameters[33].Value = model.QYFRPXHGZSBH;
			parameters[34].Value = model.QYJLXM;
			parameters[35].Value = model.QYJLXB;
			parameters[36].Value = model.QYJLZGXL;
			parameters[37].Value = model.QYJLZW;
			parameters[38].Value = model.QYJLZC;
			parameters[39].Value = model.QYJLZY;
			parameters[40].Value = model.QYJLGDDH;
			parameters[41].Value = model.QYJLYDDH;
			parameters[42].Value = model.QYJLPX;
			parameters[43].Value = model.QYJLPXSJ;
			parameters[44].Value = model.QYJLPXHGZSBH;
			parameters[45].Value = model.QYJSXM;
			parameters[46].Value = model.QYJSXB;
			parameters[47].Value = model.QYJSZGXL;
			parameters[48].Value = model.QYJSZW;
			parameters[49].Value = model.QYJSZC;
			parameters[50].Value = model.QYJSZY;
			parameters[51].Value = model.QYJSGDDH;
			parameters[52].Value = model.QYJSYDDH;
			parameters[53].Value = model.QYJSPX;
			parameters[54].Value = model.QYJSPXSJ;
			parameters[55].Value = model.QYJSPXHGZSBH;
			parameters[56].Value = model.GLRYXH1;
			parameters[57].Value = model.GLRYXM1;
			parameters[58].Value = model.GLRYZW1;
			parameters[59].Value = model.GLRYZC1;
			parameters[60].Value = model.GLRYXL1;
			parameters[61].Value = model.GLRYZY1;
			parameters[62].Value = model.GLRYSFZHM1;
			parameters[63].Value = model.GLRYXH2;
			parameters[64].Value = model.GLRYXM2;
			parameters[65].Value = model.GLRYZW2;
			parameters[66].Value = model.GLRYZC2;
			parameters[67].Value = model.GLRYXL2;
			parameters[68].Value = model.GLRYZY2;
			parameters[69].Value = model.GLRYSFZHM2;
			parameters[70].Value = model.GLRYXH3;
			parameters[71].Value = model.GLRYXM3;
			parameters[72].Value = model.GLRYZW3;
			parameters[73].Value = model.GLRYZC3;
			parameters[74].Value = model.GLRYXL3;
			parameters[75].Value = model.GLRYZY3;
			parameters[76].Value = model.GLRYSFZHM3;
			parameters[77].Value = model.GLRYXH4;
			parameters[78].Value = model.GLRYXM4;
			parameters[79].Value = model.GLRYZW4;
			parameters[80].Value = model.GLRYZC4;
			parameters[81].Value = model.GLRYXL4;
			parameters[82].Value = model.GLRYZY4;
			parameters[83].Value = model.GLRYSFZHM4;
			parameters[84].Value = model.GLRYXH5;
			parameters[85].Value = model.GLRYXM5;
			parameters[86].Value = model.GLRYZW5;
			parameters[87].Value = model.GLRYZC5;
			parameters[88].Value = model.GLRYXL5;
			parameters[89].Value = model.GLRYZY5;
			parameters[90].Value = model.GLRYSFZHM5;
			parameters[91].Value = model.JSGRXH1;
			parameters[92].Value = model.JSGRXM1;
			parameters[93].Value = model.JSGRGZ1;
			parameters[94].Value = model.JSGRXH2;
			parameters[95].Value = model.JSGRXM2;
			parameters[96].Value = model.JSGRGZ2;
			parameters[97].Value = model.JSGRXH3;
			parameters[98].Value = model.JSGRXM3;
			parameters[99].Value = model.JSGRGZ3;
			parameters[100].Value = model.JSGRXH4;
			parameters[101].Value = model.JSGRXM4;
			parameters[102].Value = model.JSGRGZ4;
			parameters[103].Value = model.JSGRXH5;
			parameters[104].Value = model.JSGRXM5;
			parameters[105].Value = model.JSGRGZ5;
			parameters[106].Value = model.ZGZSFZJG1;
			parameters[107].Value = model.ZGZSZSBH1;
			parameters[108].Value = model.ZGZSYXQ1;
			parameters[109].Value = model.ZGZSFZJG2;
			parameters[110].Value = model.ZGZSZSBH2;
			parameters[111].Value = model.ZGZSYXQ2;
			parameters[112].Value = model.ZGZSFZJG3;
			parameters[113].Value = model.ZGZSZSBH3;
			parameters[114].Value = model.ZGZSYXQ3;
			parameters[115].Value = model.ZGZSFZJG4;
			parameters[116].Value = model.ZGZSZSBH4;
			parameters[117].Value = model.ZGZSYXQ4;
			parameters[118].Value = model.ZGZSFZJG5;
			parameters[119].Value = model.ZGZSZSBH5;
			parameters[120].Value = model.ZGZSYXQ5;
			parameters[121].Value = model.WXJCSBXUH1;
			parameters[122].Value = model.WXJCSBMC1;
			parameters[123].Value = model.WXJCSBXH1;
			parameters[124].Value = model.WXJCSBSL1;
			parameters[125].Value = model.WXJCSBBZ1;
			parameters[126].Value = model.WXJCSBXUH2;
			parameters[127].Value = model.WXJCSBMC2;
			parameters[128].Value = model.WXJCSBXH2;
			parameters[129].Value = model.WXJCSBSL2;
			parameters[130].Value = model.WXJCSBBZ2;
			parameters[131].Value = model.WXJCSBXUH3;
			parameters[132].Value = model.WXJCSBMC3;
			parameters[133].Value = model.WXJCSBXH3;
			parameters[134].Value = model.WXJCSBSL3;
			parameters[135].Value = model.WXJCSBBZ3;
			parameters[136].Value = model.WXJCSBXUH4;
			parameters[137].Value = model.WXJCSBMC4;
			parameters[138].Value = model.WXJCSBXH4;
			parameters[139].Value = model.WXJCSBSL4;
			parameters[140].Value = model.WXJCSBBZ4;
			parameters[141].Value = model.WXJCSBXUH5;
			parameters[142].Value = model.WXJCSBMC5;
			parameters[143].Value = model.WXJCSBXH5;
			parameters[144].Value = model.WXJCSBSL5;
			parameters[145].Value = model.WXJCSBBZ5;
			parameters[146].Value = model.GCYJXH1;
			parameters[147].Value = model.GCYJGCXMMC1;
			parameters[148].Value = model.GCYJZLDLTS1;
			parameters[149].Value = model.GCYJZJZE1;
			parameters[150].Value = model.GCYJKJGSJ1;
			parameters[151].Value = model.GCYJBZ1;
			parameters[152].Value = model.GCYJXH2;
			parameters[153].Value = model.GCYJGCXMMC2;
			parameters[154].Value = model.GCYJZLDLTS2;
			parameters[155].Value = model.GCYJZJZE2;
			parameters[156].Value = model.GCYJKJGSJ2;
			parameters[157].Value = model.GCYJBZ2;
			parameters[158].Value = model.GCYJXH3;
			parameters[159].Value = model.GCYJGCXMMC3;
			parameters[160].Value = model.GCYJZLDLTS3;
			parameters[161].Value = model.GCYJZJZE3;
			parameters[162].Value = model.GCYJKJGSJ3;
			parameters[163].Value = model.GCYJBZ3;
			parameters[164].Value = model.GCYJXH4;
			parameters[165].Value = model.GCYJGCXMMC4;
			parameters[166].Value = model.GCYJZLDLTS4;
			parameters[167].Value = model.GCYJZJZE4;
			parameters[168].Value = model.GCYJKJGSJ4;
			parameters[169].Value = model.GCYJBZ4;
			parameters[170].Value = model.GCYJXH5;
			parameters[171].Value = model.GCYJGCXMMC5;
			parameters[172].Value = model.GCYJZLDLTS5;
			parameters[173].Value = model.GCYJZJZE5;
			parameters[174].Value = model.GCYJKJGSJ5;
			parameters[175].Value = model.GCYJBZ5;
			parameters[176].Value = model.CZDLXUH1;
			parameters[177].Value = model.CZDLXH1;
			parameters[178].Value = model.CZDLMC1;
			parameters[179].Value = model.CZDLCCRQ1;
			parameters[180].Value = model.CZDLDLZZCJ1;
			parameters[181].Value = model.CZDLSL1;
			parameters[182].Value = model.CZDLXUH2;
			parameters[183].Value = model.CZDLXH2;
			parameters[184].Value = model.CZDLMC2;
			parameters[185].Value = model.CZDLCCRQ2;
			parameters[186].Value = model.CZDLDLZZCJ2;
			parameters[187].Value = model.CZDLSL2;
			parameters[188].Value = model.CZDLXUH3;
			parameters[189].Value = model.CZDLXH3;
			parameters[190].Value = model.CZDLMC3;
			parameters[191].Value = model.CZDLCCRQ3;
			parameters[192].Value = model.CZDLDLZZCJ3;
			parameters[193].Value = model.CZDLSL3;
			parameters[194].Value = model.CZDLXUH4;
			parameters[195].Value = model.CZDLXH4;
			parameters[196].Value = model.CZDLMC4;
			parameters[197].Value = model.CZDLCCRQ4;
			parameters[198].Value = model.CZDLDLZZCJ4;
			parameters[199].Value = model.CZDLSL4;
			parameters[200].Value = model.CZDLXUH5;
			parameters[201].Value = model.CZDLXH5;
			parameters[202].Value = model.CZDLMC5;
			parameters[203].Value = model.CZDLCCRQ5;
			parameters[204].Value = model.CZDLDLZZCJ5;
			parameters[205].Value = model.CZDLSL5;

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
		public bool Update(AM.Model.basket_rent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update basket_rent set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("QYQYMC=@QYQYMC,");
			strSql.Append("QYQYDZ=@QYQYDZ,");
			strSql.Append("QYYB=@QYYB,");
			strSql.Append("QYZZJGDM=@QYZZJGDM,");
			strSql.Append("QYLXR=@QYLXR,");
			strSql.Append("QYGDDH=@QYGDDH,");
			strSql.Append("QYYDDH=@QYYDDH,");
			strSql.Append("QYDZYX=@QYDZYX,");
			strSql.Append("QYCZ=@QYCZ,");
			strSql.Append("QYYYZZZCH=@QYYYZZZCH,");
			strSql.Append("QYZCRQ=@QYZCRQ,");
			strSql.Append("QYYYZZDJJG=@QYYYZZDJJG,");
			strSql.Append("QYJJLX=@QYJJLX,");
			strSql.Append("QYZCZJ=@QYZCZJ,");
			strSql.Append("QYGDZC=@QYGDZC,");
			strSql.Append("QYCSDLYWRS=@QYCSDLYWRS,");
			strSql.Append("QYQYZGZRS=@QYQYZGZRS,");
			strSql.Append("QYCZYDLSL=@QYCZYDLSL,");
			strSql.Append("QYKSCSDLYWRQ=@QYKSCSDLYWRQ,");
			strSql.Append("QYQYJJ=@QYQYJJ,");
			strSql.Append("QYFRXM=@QYFRXM,");
			strSql.Append("QYFRXB=@QYFRXB,");
			strSql.Append("QYFRZGXL=@QYFRZGXL,");
			strSql.Append("QYFRZW=@QYFRZW,");
			strSql.Append("QYFRZC=@QYFRZC,");
			strSql.Append("QYFRZY=@QYFRZY,");
			strSql.Append("QYFRGDDH=@QYFRGDDH,");
			strSql.Append("QYFRYDDH=@QYFRYDDH,");
			strSql.Append("QYFRPX=@QYFRPX,");
			strSql.Append("QYFRPXSJ=@QYFRPXSJ,");
			strSql.Append("QYFRPXHGZSBH=@QYFRPXHGZSBH,");
			strSql.Append("QYJLXM=@QYJLXM,");
			strSql.Append("QYJLXB=@QYJLXB,");
			strSql.Append("QYJLZGXL=@QYJLZGXL,");
			strSql.Append("QYJLZW=@QYJLZW,");
			strSql.Append("QYJLZC=@QYJLZC,");
			strSql.Append("QYJLZY=@QYJLZY,");
			strSql.Append("QYJLGDDH=@QYJLGDDH,");
			strSql.Append("QYJLYDDH=@QYJLYDDH,");
			strSql.Append("QYJLPX=@QYJLPX,");
			strSql.Append("QYJLPXSJ=@QYJLPXSJ,");
			strSql.Append("QYJLPXHGZSBH=@QYJLPXHGZSBH,");
			strSql.Append("QYJSXM=@QYJSXM,");
			strSql.Append("QYJSXB=@QYJSXB,");
			strSql.Append("QYJSZGXL=@QYJSZGXL,");
			strSql.Append("QYJSZW=@QYJSZW,");
			strSql.Append("QYJSZC=@QYJSZC,");
			strSql.Append("QYJSZY=@QYJSZY,");
			strSql.Append("QYJSGDDH=@QYJSGDDH,");
			strSql.Append("QYJSYDDH=@QYJSYDDH,");
			strSql.Append("QYJSPX=@QYJSPX,");
			strSql.Append("QYJSPXSJ=@QYJSPXSJ,");
			strSql.Append("QYJSPXHGZSBH=@QYJSPXHGZSBH,");
			strSql.Append("GLRYXH1=@GLRYXH1,");
			strSql.Append("GLRYXM1=@GLRYXM1,");
			strSql.Append("GLRYZW1=@GLRYZW1,");
			strSql.Append("GLRYZC1=@GLRYZC1,");
			strSql.Append("GLRYXL1=@GLRYXL1,");
			strSql.Append("GLRYZY1=@GLRYZY1,");
			strSql.Append("GLRYSFZHM1=@GLRYSFZHM1,");
			strSql.Append("GLRYXH2=@GLRYXH2,");
			strSql.Append("GLRYXM2=@GLRYXM2,");
			strSql.Append("GLRYZW2=@GLRYZW2,");
			strSql.Append("GLRYZC2=@GLRYZC2,");
			strSql.Append("GLRYXL2=@GLRYXL2,");
			strSql.Append("GLRYZY2=@GLRYZY2,");
			strSql.Append("GLRYSFZHM2=@GLRYSFZHM2,");
			strSql.Append("GLRYXH3=@GLRYXH3,");
			strSql.Append("GLRYXM3=@GLRYXM3,");
			strSql.Append("GLRYZW3=@GLRYZW3,");
			strSql.Append("GLRYZC3=@GLRYZC3,");
			strSql.Append("GLRYXL3=@GLRYXL3,");
			strSql.Append("GLRYZY3=@GLRYZY3,");
			strSql.Append("GLRYSFZHM3=@GLRYSFZHM3,");
			strSql.Append("GLRYXH4=@GLRYXH4,");
			strSql.Append("GLRYXM4=@GLRYXM4,");
			strSql.Append("GLRYZW4=@GLRYZW4,");
			strSql.Append("GLRYZC4=@GLRYZC4,");
			strSql.Append("GLRYXL4=@GLRYXL4,");
			strSql.Append("GLRYZY4=@GLRYZY4,");
			strSql.Append("GLRYSFZHM4=@GLRYSFZHM4,");
			strSql.Append("GLRYXH5=@GLRYXH5,");
			strSql.Append("GLRYXM5=@GLRYXM5,");
			strSql.Append("GLRYZW5=@GLRYZW5,");
			strSql.Append("GLRYZC5=@GLRYZC5,");
			strSql.Append("GLRYXL5=@GLRYXL5,");
			strSql.Append("GLRYZY5=@GLRYZY5,");
			strSql.Append("GLRYSFZHM5=@GLRYSFZHM5,");
			strSql.Append("JSGRXH1=@JSGRXH1,");
			strSql.Append("JSGRXM1=@JSGRXM1,");
			strSql.Append("JSGRGZ1=@JSGRGZ1,");
			strSql.Append("JSGRXH2=@JSGRXH2,");
			strSql.Append("JSGRXM2=@JSGRXM2,");
			strSql.Append("JSGRGZ2=@JSGRGZ2,");
			strSql.Append("JSGRXH3=@JSGRXH3,");
			strSql.Append("JSGRXM3=@JSGRXM3,");
			strSql.Append("JSGRGZ3=@JSGRGZ3,");
			strSql.Append("JSGRXH4=@JSGRXH4,");
			strSql.Append("JSGRXM4=@JSGRXM4,");
			strSql.Append("JSGRGZ4=@JSGRGZ4,");
			strSql.Append("JSGRXH5=@JSGRXH5,");
			strSql.Append("JSGRXM5=@JSGRXM5,");
			strSql.Append("JSGRGZ5=@JSGRGZ5,");
			strSql.Append("ZGZSFZJG1=@ZGZSFZJG1,");
			strSql.Append("ZGZSZSBH1=@ZGZSZSBH1,");
			strSql.Append("ZGZSYXQ1=@ZGZSYXQ1,");
			strSql.Append("ZGZSFZJG2=@ZGZSFZJG2,");
			strSql.Append("ZGZSZSBH2=@ZGZSZSBH2,");
			strSql.Append("ZGZSYXQ2=@ZGZSYXQ2,");
			strSql.Append("ZGZSFZJG3=@ZGZSFZJG3,");
			strSql.Append("ZGZSZSBH3=@ZGZSZSBH3,");
			strSql.Append("ZGZSYXQ3=@ZGZSYXQ3,");
			strSql.Append("ZGZSFZJG4=@ZGZSFZJG4,");
			strSql.Append("ZGZSZSBH4=@ZGZSZSBH4,");
			strSql.Append("ZGZSYXQ4=@ZGZSYXQ4,");
			strSql.Append("ZGZSFZJG5=@ZGZSFZJG5,");
			strSql.Append("ZGZSZSBH5=@ZGZSZSBH5,");
			strSql.Append("ZGZSYXQ5=@ZGZSYXQ5,");
			strSql.Append("WXJCSBXUH1=@WXJCSBXUH1,");
			strSql.Append("WXJCSBMC1=@WXJCSBMC1,");
			strSql.Append("WXJCSBXH1=@WXJCSBXH1,");
			strSql.Append("WXJCSBSL1=@WXJCSBSL1,");
			strSql.Append("WXJCSBBZ1=@WXJCSBBZ1,");
			strSql.Append("WXJCSBXUH2=@WXJCSBXUH2,");
			strSql.Append("WXJCSBMC2=@WXJCSBMC2,");
			strSql.Append("WXJCSBXH2=@WXJCSBXH2,");
			strSql.Append("WXJCSBSL2=@WXJCSBSL2,");
			strSql.Append("WXJCSBBZ2=@WXJCSBBZ2,");
			strSql.Append("WXJCSBXUH3=@WXJCSBXUH3,");
			strSql.Append("WXJCSBMC3=@WXJCSBMC3,");
			strSql.Append("WXJCSBXH3=@WXJCSBXH3,");
			strSql.Append("WXJCSBSL3=@WXJCSBSL3,");
			strSql.Append("WXJCSBBZ3=@WXJCSBBZ3,");
			strSql.Append("WXJCSBXUH4=@WXJCSBXUH4,");
			strSql.Append("WXJCSBMC4=@WXJCSBMC4,");
			strSql.Append("WXJCSBXH4=@WXJCSBXH4,");
			strSql.Append("WXJCSBSL4=@WXJCSBSL4,");
			strSql.Append("WXJCSBBZ4=@WXJCSBBZ4,");
			strSql.Append("WXJCSBXUH5=@WXJCSBXUH5,");
			strSql.Append("WXJCSBMC5=@WXJCSBMC5,");
			strSql.Append("WXJCSBXH5=@WXJCSBXH5,");
			strSql.Append("WXJCSBSL5=@WXJCSBSL5,");
			strSql.Append("WXJCSBBZ5=@WXJCSBBZ5,");
			strSql.Append("GCYJXH1=@GCYJXH1,");
			strSql.Append("GCYJGCXMMC1=@GCYJGCXMMC1,");
			strSql.Append("GCYJZLDLTS1=@GCYJZLDLTS1,");
			strSql.Append("GCYJZJZE1=@GCYJZJZE1,");
			strSql.Append("GCYJKJGSJ1=@GCYJKJGSJ1,");
			strSql.Append("GCYJBZ1=@GCYJBZ1,");
			strSql.Append("GCYJXH2=@GCYJXH2,");
			strSql.Append("GCYJGCXMMC2=@GCYJGCXMMC2,");
			strSql.Append("GCYJZLDLTS2=@GCYJZLDLTS2,");
			strSql.Append("GCYJZJZE2=@GCYJZJZE2,");
			strSql.Append("GCYJKJGSJ2=@GCYJKJGSJ2,");
			strSql.Append("GCYJBZ2=@GCYJBZ2,");
			strSql.Append("GCYJXH3=@GCYJXH3,");
			strSql.Append("GCYJGCXMMC3=@GCYJGCXMMC3,");
			strSql.Append("GCYJZLDLTS3=@GCYJZLDLTS3,");
			strSql.Append("GCYJZJZE3=@GCYJZJZE3,");
			strSql.Append("GCYJKJGSJ3=@GCYJKJGSJ3,");
			strSql.Append("GCYJBZ3=@GCYJBZ3,");
			strSql.Append("GCYJXH4=@GCYJXH4,");
			strSql.Append("GCYJGCXMMC4=@GCYJGCXMMC4,");
			strSql.Append("GCYJZLDLTS4=@GCYJZLDLTS4,");
			strSql.Append("GCYJZJZE4=@GCYJZJZE4,");
			strSql.Append("GCYJKJGSJ4=@GCYJKJGSJ4,");
			strSql.Append("GCYJBZ4=@GCYJBZ4,");
			strSql.Append("GCYJXH5=@GCYJXH5,");
			strSql.Append("GCYJGCXMMC5=@GCYJGCXMMC5,");
			strSql.Append("GCYJZLDLTS5=@GCYJZLDLTS5,");
			strSql.Append("GCYJZJZE5=@GCYJZJZE5,");
			strSql.Append("GCYJKJGSJ5=@GCYJKJGSJ5,");
			strSql.Append("GCYJBZ5=@GCYJBZ5,");
			strSql.Append("CZDLXUH1=@CZDLXUH1,");
			strSql.Append("CZDLXH1=@CZDLXH1,");
			strSql.Append("CZDLMC1=@CZDLMC1,");
			strSql.Append("CZDLCCRQ1=@CZDLCCRQ1,");
			strSql.Append("CZDLDLZZCJ1=@CZDLDLZZCJ1,");
			strSql.Append("CZDLSL1=@CZDLSL1,");
			strSql.Append("CZDLXUH2=@CZDLXUH2,");
			strSql.Append("CZDLXH2=@CZDLXH2,");
			strSql.Append("CZDLMC2=@CZDLMC2,");
			strSql.Append("CZDLCCRQ2=@CZDLCCRQ2,");
			strSql.Append("CZDLDLZZCJ2=@CZDLDLZZCJ2,");
			strSql.Append("CZDLSL2=@CZDLSL2,");
			strSql.Append("CZDLXUH3=@CZDLXUH3,");
			strSql.Append("CZDLXH3=@CZDLXH3,");
			strSql.Append("CZDLMC3=@CZDLMC3,");
			strSql.Append("CZDLCCRQ3=@CZDLCCRQ3,");
			strSql.Append("CZDLDLZZCJ3=@CZDLDLZZCJ3,");
			strSql.Append("CZDLSL3=@CZDLSL3,");
			strSql.Append("CZDLXUH4=@CZDLXUH4,");
			strSql.Append("CZDLXH4=@CZDLXH4,");
			strSql.Append("CZDLMC4=@CZDLMC4,");
			strSql.Append("CZDLCCRQ4=@CZDLCCRQ4,");
			strSql.Append("CZDLDLZZCJ4=@CZDLDLZZCJ4,");
			strSql.Append("CZDLSL4=@CZDLSL4,");
			strSql.Append("CZDLXUH5=@CZDLXUH5,");
			strSql.Append("CZDLXH5=@CZDLXH5,");
			strSql.Append("CZDLMC5=@CZDLMC5,");
			strSql.Append("CZDLCCRQ5=@CZDLCCRQ5,");
			strSql.Append("CZDLDLZZCJ5=@CZDLDLZZCJ5,");
			strSql.Append("CZDLSL5=@CZDLSL5");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@QYQYMC", MySqlDbType.Text),
					new MySqlParameter("@QYQYDZ", MySqlDbType.Text),
					new MySqlParameter("@QYYB", MySqlDbType.Text),
					new MySqlParameter("@QYZZJGDM", MySqlDbType.Text),
					new MySqlParameter("@QYLXR", MySqlDbType.Text),
					new MySqlParameter("@QYGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYDZYX", MySqlDbType.Text),
					new MySqlParameter("@QYCZ", MySqlDbType.Text),
					new MySqlParameter("@QYYYZZZCH", MySqlDbType.Text),
					new MySqlParameter("@QYZCRQ", MySqlDbType.Text),
					new MySqlParameter("@QYYYZZDJJG", MySqlDbType.Text),
					new MySqlParameter("@QYJJLX", MySqlDbType.Text),
					new MySqlParameter("@QYZCZJ", MySqlDbType.Text),
					new MySqlParameter("@QYGDZC", MySqlDbType.Text),
					new MySqlParameter("@QYCSDLYWRS", MySqlDbType.Text),
					new MySqlParameter("@QYQYZGZRS", MySqlDbType.Text),
					new MySqlParameter("@QYCZYDLSL", MySqlDbType.Text),
					new MySqlParameter("@QYKSCSDLYWRQ", MySqlDbType.Text),
					new MySqlParameter("@QYQYJJ", MySqlDbType.Text),
					new MySqlParameter("@QYFRXM", MySqlDbType.Text),
					new MySqlParameter("@QYFRXB", MySqlDbType.Text),
					new MySqlParameter("@QYFRZGXL", MySqlDbType.Text),
					new MySqlParameter("@QYFRZW", MySqlDbType.Text),
					new MySqlParameter("@QYFRZC", MySqlDbType.Text),
					new MySqlParameter("@QYFRZY", MySqlDbType.Text),
					new MySqlParameter("@QYFRGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYFRYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYFRPX", MySqlDbType.Text),
					new MySqlParameter("@QYFRPXSJ", MySqlDbType.Text),
					new MySqlParameter("@QYFRPXHGZSBH", MySqlDbType.Text),
					new MySqlParameter("@QYJLXM", MySqlDbType.Text),
					new MySqlParameter("@QYJLXB", MySqlDbType.Text),
					new MySqlParameter("@QYJLZGXL", MySqlDbType.Text),
					new MySqlParameter("@QYJLZW", MySqlDbType.Text),
					new MySqlParameter("@QYJLZC", MySqlDbType.Text),
					new MySqlParameter("@QYJLZY", MySqlDbType.Text),
					new MySqlParameter("@QYJLGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJLYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJLPX", MySqlDbType.Text),
					new MySqlParameter("@QYJLPXSJ", MySqlDbType.Text),
					new MySqlParameter("@QYJLPXHGZSBH", MySqlDbType.Text),
					new MySqlParameter("@QYJSXM", MySqlDbType.Text),
					new MySqlParameter("@QYJSXB", MySqlDbType.Text),
					new MySqlParameter("@QYJSZGXL", MySqlDbType.Text),
					new MySqlParameter("@QYJSZW", MySqlDbType.Text),
					new MySqlParameter("@QYJSZC", MySqlDbType.Text),
					new MySqlParameter("@QYJSZY", MySqlDbType.Text),
					new MySqlParameter("@QYJSGDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJSYDDH", MySqlDbType.Text),
					new MySqlParameter("@QYJSPX", MySqlDbType.Text),
					new MySqlParameter("@QYJSPXSJ", MySqlDbType.Text),
					new MySqlParameter("@QYJSPXHGZSBH", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH1", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM1", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW1", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC1", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL1", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY1", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM1", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH2", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM2", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW2", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC2", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL2", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY2", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM2", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH3", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM3", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW3", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC3", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL3", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY3", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM3", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH4", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM4", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW4", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC4", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL4", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY4", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM4", MySqlDbType.Text),
					new MySqlParameter("@GLRYXH5", MySqlDbType.Text),
					new MySqlParameter("@GLRYXM5", MySqlDbType.Text),
					new MySqlParameter("@GLRYZW5", MySqlDbType.Text),
					new MySqlParameter("@GLRYZC5", MySqlDbType.Text),
					new MySqlParameter("@GLRYXL5", MySqlDbType.Text),
					new MySqlParameter("@GLRYZY5", MySqlDbType.Text),
					new MySqlParameter("@GLRYSFZHM5", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH1", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM1", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ1", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH2", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM2", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ2", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH3", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM3", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ3", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH4", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM4", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ4", MySqlDbType.Text),
					new MySqlParameter("@JSGRXH5", MySqlDbType.Text),
					new MySqlParameter("@JSGRXM5", MySqlDbType.Text),
					new MySqlParameter("@JSGRGZ5", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG1", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH1", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ1", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG2", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH2", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ2", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG3", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH3", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ3", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG4", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH4", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ4", MySqlDbType.Text),
					new MySqlParameter("@ZGZSFZJG5", MySqlDbType.Text),
					new MySqlParameter("@ZGZSZSBH5", MySqlDbType.Text),
					new MySqlParameter("@ZGZSYXQ5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ1", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ2", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ3", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ4", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXUH5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBMC5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBXH5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBSL5", MySqlDbType.Text),
					new MySqlParameter("@WXJCSBBZ5", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH1", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC1", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS1", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE1", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ1", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ1", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH2", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC2", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS2", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE2", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ2", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ2", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH3", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC3", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS3", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE3", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ3", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ3", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH4", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC4", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS4", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE4", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ4", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ4", MySqlDbType.Text),
					new MySqlParameter("@GCYJXH5", MySqlDbType.Text),
					new MySqlParameter("@GCYJGCXMMC5", MySqlDbType.Text),
					new MySqlParameter("@GCYJZLDLTS5", MySqlDbType.Text),
					new MySqlParameter("@GCYJZJZE5", MySqlDbType.Text),
					new MySqlParameter("@GCYJKJGSJ5", MySqlDbType.Text),
					new MySqlParameter("@GCYJBZ5", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH1", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH1", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC1", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ1", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ1", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL1", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH2", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH2", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC2", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ2", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ2", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL2", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH3", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH3", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC3", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ3", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ3", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL3", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH4", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH4", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC4", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ4", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ4", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL4", MySqlDbType.Text),
					new MySqlParameter("@CZDLXUH5", MySqlDbType.Text),
					new MySqlParameter("@CZDLXH5", MySqlDbType.Text),
					new MySqlParameter("@CZDLMC5", MySqlDbType.Text),
					new MySqlParameter("@CZDLCCRQ5", MySqlDbType.Text),
					new MySqlParameter("@CZDLDLZZCJ5", MySqlDbType.Text),
					new MySqlParameter("@CZDLSL5", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.QYQYMC;
			parameters[3].Value = model.QYQYDZ;
			parameters[4].Value = model.QYYB;
			parameters[5].Value = model.QYZZJGDM;
			parameters[6].Value = model.QYLXR;
			parameters[7].Value = model.QYGDDH;
			parameters[8].Value = model.QYYDDH;
			parameters[9].Value = model.QYDZYX;
			parameters[10].Value = model.QYCZ;
			parameters[11].Value = model.QYYYZZZCH;
			parameters[12].Value = model.QYZCRQ;
			parameters[13].Value = model.QYYYZZDJJG;
			parameters[14].Value = model.QYJJLX;
			parameters[15].Value = model.QYZCZJ;
			parameters[16].Value = model.QYGDZC;
			parameters[17].Value = model.QYCSDLYWRS;
			parameters[18].Value = model.QYQYZGZRS;
			parameters[19].Value = model.QYCZYDLSL;
			parameters[20].Value = model.QYKSCSDLYWRQ;
			parameters[21].Value = model.QYQYJJ;
			parameters[22].Value = model.QYFRXM;
			parameters[23].Value = model.QYFRXB;
			parameters[24].Value = model.QYFRZGXL;
			parameters[25].Value = model.QYFRZW;
			parameters[26].Value = model.QYFRZC;
			parameters[27].Value = model.QYFRZY;
			parameters[28].Value = model.QYFRGDDH;
			parameters[29].Value = model.QYFRYDDH;
			parameters[30].Value = model.QYFRPX;
			parameters[31].Value = model.QYFRPXSJ;
			parameters[32].Value = model.QYFRPXHGZSBH;
			parameters[33].Value = model.QYJLXM;
			parameters[34].Value = model.QYJLXB;
			parameters[35].Value = model.QYJLZGXL;
			parameters[36].Value = model.QYJLZW;
			parameters[37].Value = model.QYJLZC;
			parameters[38].Value = model.QYJLZY;
			parameters[39].Value = model.QYJLGDDH;
			parameters[40].Value = model.QYJLYDDH;
			parameters[41].Value = model.QYJLPX;
			parameters[42].Value = model.QYJLPXSJ;
			parameters[43].Value = model.QYJLPXHGZSBH;
			parameters[44].Value = model.QYJSXM;
			parameters[45].Value = model.QYJSXB;
			parameters[46].Value = model.QYJSZGXL;
			parameters[47].Value = model.QYJSZW;
			parameters[48].Value = model.QYJSZC;
			parameters[49].Value = model.QYJSZY;
			parameters[50].Value = model.QYJSGDDH;
			parameters[51].Value = model.QYJSYDDH;
			parameters[52].Value = model.QYJSPX;
			parameters[53].Value = model.QYJSPXSJ;
			parameters[54].Value = model.QYJSPXHGZSBH;
			parameters[55].Value = model.GLRYXH1;
			parameters[56].Value = model.GLRYXM1;
			parameters[57].Value = model.GLRYZW1;
			parameters[58].Value = model.GLRYZC1;
			parameters[59].Value = model.GLRYXL1;
			parameters[60].Value = model.GLRYZY1;
			parameters[61].Value = model.GLRYSFZHM1;
			parameters[62].Value = model.GLRYXH2;
			parameters[63].Value = model.GLRYXM2;
			parameters[64].Value = model.GLRYZW2;
			parameters[65].Value = model.GLRYZC2;
			parameters[66].Value = model.GLRYXL2;
			parameters[67].Value = model.GLRYZY2;
			parameters[68].Value = model.GLRYSFZHM2;
			parameters[69].Value = model.GLRYXH3;
			parameters[70].Value = model.GLRYXM3;
			parameters[71].Value = model.GLRYZW3;
			parameters[72].Value = model.GLRYZC3;
			parameters[73].Value = model.GLRYXL3;
			parameters[74].Value = model.GLRYZY3;
			parameters[75].Value = model.GLRYSFZHM3;
			parameters[76].Value = model.GLRYXH4;
			parameters[77].Value = model.GLRYXM4;
			parameters[78].Value = model.GLRYZW4;
			parameters[79].Value = model.GLRYZC4;
			parameters[80].Value = model.GLRYXL4;
			parameters[81].Value = model.GLRYZY4;
			parameters[82].Value = model.GLRYSFZHM4;
			parameters[83].Value = model.GLRYXH5;
			parameters[84].Value = model.GLRYXM5;
			parameters[85].Value = model.GLRYZW5;
			parameters[86].Value = model.GLRYZC5;
			parameters[87].Value = model.GLRYXL5;
			parameters[88].Value = model.GLRYZY5;
			parameters[89].Value = model.GLRYSFZHM5;
			parameters[90].Value = model.JSGRXH1;
			parameters[91].Value = model.JSGRXM1;
			parameters[92].Value = model.JSGRGZ1;
			parameters[93].Value = model.JSGRXH2;
			parameters[94].Value = model.JSGRXM2;
			parameters[95].Value = model.JSGRGZ2;
			parameters[96].Value = model.JSGRXH3;
			parameters[97].Value = model.JSGRXM3;
			parameters[98].Value = model.JSGRGZ3;
			parameters[99].Value = model.JSGRXH4;
			parameters[100].Value = model.JSGRXM4;
			parameters[101].Value = model.JSGRGZ4;
			parameters[102].Value = model.JSGRXH5;
			parameters[103].Value = model.JSGRXM5;
			parameters[104].Value = model.JSGRGZ5;
			parameters[105].Value = model.ZGZSFZJG1;
			parameters[106].Value = model.ZGZSZSBH1;
			parameters[107].Value = model.ZGZSYXQ1;
			parameters[108].Value = model.ZGZSFZJG2;
			parameters[109].Value = model.ZGZSZSBH2;
			parameters[110].Value = model.ZGZSYXQ2;
			parameters[111].Value = model.ZGZSFZJG3;
			parameters[112].Value = model.ZGZSZSBH3;
			parameters[113].Value = model.ZGZSYXQ3;
			parameters[114].Value = model.ZGZSFZJG4;
			parameters[115].Value = model.ZGZSZSBH4;
			parameters[116].Value = model.ZGZSYXQ4;
			parameters[117].Value = model.ZGZSFZJG5;
			parameters[118].Value = model.ZGZSZSBH5;
			parameters[119].Value = model.ZGZSYXQ5;
			parameters[120].Value = model.WXJCSBXUH1;
			parameters[121].Value = model.WXJCSBMC1;
			parameters[122].Value = model.WXJCSBXH1;
			parameters[123].Value = model.WXJCSBSL1;
			parameters[124].Value = model.WXJCSBBZ1;
			parameters[125].Value = model.WXJCSBXUH2;
			parameters[126].Value = model.WXJCSBMC2;
			parameters[127].Value = model.WXJCSBXH2;
			parameters[128].Value = model.WXJCSBSL2;
			parameters[129].Value = model.WXJCSBBZ2;
			parameters[130].Value = model.WXJCSBXUH3;
			parameters[131].Value = model.WXJCSBMC3;
			parameters[132].Value = model.WXJCSBXH3;
			parameters[133].Value = model.WXJCSBSL3;
			parameters[134].Value = model.WXJCSBBZ3;
			parameters[135].Value = model.WXJCSBXUH4;
			parameters[136].Value = model.WXJCSBMC4;
			parameters[137].Value = model.WXJCSBXH4;
			parameters[138].Value = model.WXJCSBSL4;
			parameters[139].Value = model.WXJCSBBZ4;
			parameters[140].Value = model.WXJCSBXUH5;
			parameters[141].Value = model.WXJCSBMC5;
			parameters[142].Value = model.WXJCSBXH5;
			parameters[143].Value = model.WXJCSBSL5;
			parameters[144].Value = model.WXJCSBBZ5;
			parameters[145].Value = model.GCYJXH1;
			parameters[146].Value = model.GCYJGCXMMC1;
			parameters[147].Value = model.GCYJZLDLTS1;
			parameters[148].Value = model.GCYJZJZE1;
			parameters[149].Value = model.GCYJKJGSJ1;
			parameters[150].Value = model.GCYJBZ1;
			parameters[151].Value = model.GCYJXH2;
			parameters[152].Value = model.GCYJGCXMMC2;
			parameters[153].Value = model.GCYJZLDLTS2;
			parameters[154].Value = model.GCYJZJZE2;
			parameters[155].Value = model.GCYJKJGSJ2;
			parameters[156].Value = model.GCYJBZ2;
			parameters[157].Value = model.GCYJXH3;
			parameters[158].Value = model.GCYJGCXMMC3;
			parameters[159].Value = model.GCYJZLDLTS3;
			parameters[160].Value = model.GCYJZJZE3;
			parameters[161].Value = model.GCYJKJGSJ3;
			parameters[162].Value = model.GCYJBZ3;
			parameters[163].Value = model.GCYJXH4;
			parameters[164].Value = model.GCYJGCXMMC4;
			parameters[165].Value = model.GCYJZLDLTS4;
			parameters[166].Value = model.GCYJZJZE4;
			parameters[167].Value = model.GCYJKJGSJ4;
			parameters[168].Value = model.GCYJBZ4;
			parameters[169].Value = model.GCYJXH5;
			parameters[170].Value = model.GCYJGCXMMC5;
			parameters[171].Value = model.GCYJZLDLTS5;
			parameters[172].Value = model.GCYJZJZE5;
			parameters[173].Value = model.GCYJKJGSJ5;
			parameters[174].Value = model.GCYJBZ5;
			parameters[175].Value = model.CZDLXUH1;
			parameters[176].Value = model.CZDLXH1;
			parameters[177].Value = model.CZDLMC1;
			parameters[178].Value = model.CZDLCCRQ1;
			parameters[179].Value = model.CZDLDLZZCJ1;
			parameters[180].Value = model.CZDLSL1;
			parameters[181].Value = model.CZDLXUH2;
			parameters[182].Value = model.CZDLXH2;
			parameters[183].Value = model.CZDLMC2;
			parameters[184].Value = model.CZDLCCRQ2;
			parameters[185].Value = model.CZDLDLZZCJ2;
			parameters[186].Value = model.CZDLSL2;
			parameters[187].Value = model.CZDLXUH3;
			parameters[188].Value = model.CZDLXH3;
			parameters[189].Value = model.CZDLMC3;
			parameters[190].Value = model.CZDLCCRQ3;
			parameters[191].Value = model.CZDLDLZZCJ3;
			parameters[192].Value = model.CZDLSL3;
			parameters[193].Value = model.CZDLXUH4;
			parameters[194].Value = model.CZDLXH4;
			parameters[195].Value = model.CZDLMC4;
			parameters[196].Value = model.CZDLCCRQ4;
			parameters[197].Value = model.CZDLDLZZCJ4;
			parameters[198].Value = model.CZDLSL4;
			parameters[199].Value = model.CZDLXUH5;
			parameters[200].Value = model.CZDLXH5;
			parameters[201].Value = model.CZDLMC5;
			parameters[202].Value = model.CZDLCCRQ5;
			parameters[203].Value = model.CZDLDLZZCJ5;
			parameters[204].Value = model.CZDLSL5;
			parameters[205].Value = model.Guid;

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
			strSql.Append("delete from basket_rent ");
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
			strSql.Append("delete from basket_rent ");
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
		public AM.Model.basket_rent GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,QYQYMC,QYQYDZ,QYYB,QYZZJGDM,QYLXR,QYGDDH,QYYDDH,QYDZYX,QYCZ,QYYYZZZCH,QYZCRQ,QYYYZZDJJG,QYJJLX,QYZCZJ,QYGDZC,QYCSDLYWRS,QYQYZGZRS,QYCZYDLSL,QYKSCSDLYWRQ,QYQYJJ,QYFRXM,QYFRXB,QYFRZGXL,QYFRZW,QYFRZC,QYFRZY,QYFRGDDH,QYFRYDDH,QYFRPX,QYFRPXSJ,QYFRPXHGZSBH,QYJLXM,QYJLXB,QYJLZGXL,QYJLZW,QYJLZC,QYJLZY,QYJLGDDH,QYJLYDDH,QYJLPX,QYJLPXSJ,QYJLPXHGZSBH,QYJSXM,QYJSXB,QYJSZGXL,QYJSZW,QYJSZC,QYJSZY,QYJSGDDH,QYJSYDDH,QYJSPX,QYJSPXSJ,QYJSPXHGZSBH,GLRYXH1,GLRYXM1,GLRYZW1,GLRYZC1,GLRYXL1,GLRYZY1,GLRYSFZHM1,GLRYXH2,GLRYXM2,GLRYZW2,GLRYZC2,GLRYXL2,GLRYZY2,GLRYSFZHM2,GLRYXH3,GLRYXM3,GLRYZW3,GLRYZC3,GLRYXL3,GLRYZY3,GLRYSFZHM3,GLRYXH4,GLRYXM4,GLRYZW4,GLRYZC4,GLRYXL4,GLRYZY4,GLRYSFZHM4,GLRYXH5,GLRYXM5,GLRYZW5,GLRYZC5,GLRYXL5,GLRYZY5,GLRYSFZHM5,JSGRXH1,JSGRXM1,JSGRGZ1,JSGRXH2,JSGRXM2,JSGRGZ2,JSGRXH3,JSGRXM3,JSGRGZ3,JSGRXH4,JSGRXM4,JSGRGZ4,JSGRXH5,JSGRXM5,JSGRGZ5,ZGZSFZJG1,ZGZSZSBH1,ZGZSYXQ1,ZGZSFZJG2,ZGZSZSBH2,ZGZSYXQ2,ZGZSFZJG3,ZGZSZSBH3,ZGZSYXQ3,ZGZSFZJG4,ZGZSZSBH4,ZGZSYXQ4,ZGZSFZJG5,ZGZSZSBH5,ZGZSYXQ5,WXJCSBXUH1,WXJCSBMC1,WXJCSBXH1,WXJCSBSL1,WXJCSBBZ1,WXJCSBXUH2,WXJCSBMC2,WXJCSBXH2,WXJCSBSL2,WXJCSBBZ2,WXJCSBXUH3,WXJCSBMC3,WXJCSBXH3,WXJCSBSL3,WXJCSBBZ3,WXJCSBXUH4,WXJCSBMC4,WXJCSBXH4,WXJCSBSL4,WXJCSBBZ4,WXJCSBXUH5,WXJCSBMC5,WXJCSBXH5,WXJCSBSL5,WXJCSBBZ5,GCYJXH1,GCYJGCXMMC1,GCYJZLDLTS1,GCYJZJZE1,GCYJKJGSJ1,GCYJBZ1,GCYJXH2,GCYJGCXMMC2,GCYJZLDLTS2,GCYJZJZE2,GCYJKJGSJ2,GCYJBZ2,GCYJXH3,GCYJGCXMMC3,GCYJZLDLTS3,GCYJZJZE3,GCYJKJGSJ3,GCYJBZ3,GCYJXH4,GCYJGCXMMC4,GCYJZLDLTS4,GCYJZJZE4,GCYJKJGSJ4,GCYJBZ4,GCYJXH5,GCYJGCXMMC5,GCYJZLDLTS5,GCYJZJZE5,GCYJKJGSJ5,GCYJBZ5,CZDLXUH1,CZDLXH1,CZDLMC1,CZDLCCRQ1,CZDLDLZZCJ1,CZDLSL1,CZDLXUH2,CZDLXH2,CZDLMC2,CZDLCCRQ2,CZDLDLZZCJ2,CZDLSL2,CZDLXUH3,CZDLXH3,CZDLMC3,CZDLCCRQ3,CZDLDLZZCJ3,CZDLSL3,CZDLXUH4,CZDLXH4,CZDLMC4,CZDLCCRQ4,CZDLDLZZCJ4,CZDLSL4,CZDLXUH5,CZDLXH5,CZDLMC5,CZDLCCRQ5,CZDLDLZZCJ5,CZDLSL5 from basket_rent ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.basket_rent model=new AM.Model.basket_rent();
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
		public AM.Model.basket_rent DataRowToModel(DataRow row)
		{
			AM.Model.basket_rent model=new AM.Model.basket_rent();
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
				if(row["QYQYMC"]!=null)
				{
					model.QYQYMC=row["QYQYMC"].ToString();
				}
				if(row["QYQYDZ"]!=null)
				{
					model.QYQYDZ=row["QYQYDZ"].ToString();
				}
				if(row["QYYB"]!=null)
				{
					model.QYYB=row["QYYB"].ToString();
				}
				if(row["QYZZJGDM"]!=null)
				{
					model.QYZZJGDM=row["QYZZJGDM"].ToString();
				}
				if(row["QYLXR"]!=null)
				{
					model.QYLXR=row["QYLXR"].ToString();
				}
				if(row["QYGDDH"]!=null)
				{
					model.QYGDDH=row["QYGDDH"].ToString();
				}
				if(row["QYYDDH"]!=null)
				{
					model.QYYDDH=row["QYYDDH"].ToString();
				}
				if(row["QYDZYX"]!=null)
				{
					model.QYDZYX=row["QYDZYX"].ToString();
				}
				if(row["QYCZ"]!=null)
				{
					model.QYCZ=row["QYCZ"].ToString();
				}
				if(row["QYYYZZZCH"]!=null)
				{
					model.QYYYZZZCH=row["QYYYZZZCH"].ToString();
				}
				if(row["QYZCRQ"]!=null)
				{
					model.QYZCRQ=row["QYZCRQ"].ToString();
				}
				if(row["QYYYZZDJJG"]!=null)
				{
					model.QYYYZZDJJG=row["QYYYZZDJJG"].ToString();
				}
				if(row["QYJJLX"]!=null)
				{
					model.QYJJLX=row["QYJJLX"].ToString();
				}
				if(row["QYZCZJ"]!=null)
				{
					model.QYZCZJ=row["QYZCZJ"].ToString();
				}
				if(row["QYGDZC"]!=null)
				{
					model.QYGDZC=row["QYGDZC"].ToString();
				}
				if(row["QYCSDLYWRS"]!=null)
				{
					model.QYCSDLYWRS=row["QYCSDLYWRS"].ToString();
				}
				if(row["QYQYZGZRS"]!=null)
				{
					model.QYQYZGZRS=row["QYQYZGZRS"].ToString();
				}
				if(row["QYCZYDLSL"]!=null)
				{
					model.QYCZYDLSL=row["QYCZYDLSL"].ToString();
				}
				if(row["QYKSCSDLYWRQ"]!=null)
				{
					model.QYKSCSDLYWRQ=row["QYKSCSDLYWRQ"].ToString();
				}
				if(row["QYQYJJ"]!=null)
				{
					model.QYQYJJ=row["QYQYJJ"].ToString();
				}
				if(row["QYFRXM"]!=null)
				{
					model.QYFRXM=row["QYFRXM"].ToString();
				}
				if(row["QYFRXB"]!=null)
				{
					model.QYFRXB=row["QYFRXB"].ToString();
				}
				if(row["QYFRZGXL"]!=null)
				{
					model.QYFRZGXL=row["QYFRZGXL"].ToString();
				}
				if(row["QYFRZW"]!=null)
				{
					model.QYFRZW=row["QYFRZW"].ToString();
				}
				if(row["QYFRZC"]!=null)
				{
					model.QYFRZC=row["QYFRZC"].ToString();
				}
				if(row["QYFRZY"]!=null)
				{
					model.QYFRZY=row["QYFRZY"].ToString();
				}
				if(row["QYFRGDDH"]!=null)
				{
					model.QYFRGDDH=row["QYFRGDDH"].ToString();
				}
				if(row["QYFRYDDH"]!=null)
				{
					model.QYFRYDDH=row["QYFRYDDH"].ToString();
				}
				if(row["QYFRPX"]!=null)
				{
					model.QYFRPX=row["QYFRPX"].ToString();
				}
				if(row["QYFRPXSJ"]!=null)
				{
					model.QYFRPXSJ=row["QYFRPXSJ"].ToString();
				}
				if(row["QYFRPXHGZSBH"]!=null)
				{
					model.QYFRPXHGZSBH=row["QYFRPXHGZSBH"].ToString();
				}
				if(row["QYJLXM"]!=null)
				{
					model.QYJLXM=row["QYJLXM"].ToString();
				}
				if(row["QYJLXB"]!=null)
				{
					model.QYJLXB=row["QYJLXB"].ToString();
				}
				if(row["QYJLZGXL"]!=null)
				{
					model.QYJLZGXL=row["QYJLZGXL"].ToString();
				}
				if(row["QYJLZW"]!=null)
				{
					model.QYJLZW=row["QYJLZW"].ToString();
				}
				if(row["QYJLZC"]!=null)
				{
					model.QYJLZC=row["QYJLZC"].ToString();
				}
				if(row["QYJLZY"]!=null)
				{
					model.QYJLZY=row["QYJLZY"].ToString();
				}
				if(row["QYJLGDDH"]!=null)
				{
					model.QYJLGDDH=row["QYJLGDDH"].ToString();
				}
				if(row["QYJLYDDH"]!=null)
				{
					model.QYJLYDDH=row["QYJLYDDH"].ToString();
				}
				if(row["QYJLPX"]!=null)
				{
					model.QYJLPX=row["QYJLPX"].ToString();
				}
				if(row["QYJLPXSJ"]!=null)
				{
					model.QYJLPXSJ=row["QYJLPXSJ"].ToString();
				}
				if(row["QYJLPXHGZSBH"]!=null)
				{
					model.QYJLPXHGZSBH=row["QYJLPXHGZSBH"].ToString();
				}
				if(row["QYJSXM"]!=null)
				{
					model.QYJSXM=row["QYJSXM"].ToString();
				}
				if(row["QYJSXB"]!=null)
				{
					model.QYJSXB=row["QYJSXB"].ToString();
				}
				if(row["QYJSZGXL"]!=null)
				{
					model.QYJSZGXL=row["QYJSZGXL"].ToString();
				}
				if(row["QYJSZW"]!=null)
				{
					model.QYJSZW=row["QYJSZW"].ToString();
				}
				if(row["QYJSZC"]!=null)
				{
					model.QYJSZC=row["QYJSZC"].ToString();
				}
				if(row["QYJSZY"]!=null)
				{
					model.QYJSZY=row["QYJSZY"].ToString();
				}
				if(row["QYJSGDDH"]!=null)
				{
					model.QYJSGDDH=row["QYJSGDDH"].ToString();
				}
				if(row["QYJSYDDH"]!=null)
				{
					model.QYJSYDDH=row["QYJSYDDH"].ToString();
				}
				if(row["QYJSPX"]!=null)
				{
					model.QYJSPX=row["QYJSPX"].ToString();
				}
				if(row["QYJSPXSJ"]!=null)
				{
					model.QYJSPXSJ=row["QYJSPXSJ"].ToString();
				}
				if(row["QYJSPXHGZSBH"]!=null)
				{
					model.QYJSPXHGZSBH=row["QYJSPXHGZSBH"].ToString();
				}
				if(row["GLRYXH1"]!=null)
				{
					model.GLRYXH1=row["GLRYXH1"].ToString();
				}
				if(row["GLRYXM1"]!=null)
				{
					model.GLRYXM1=row["GLRYXM1"].ToString();
				}
				if(row["GLRYZW1"]!=null)
				{
					model.GLRYZW1=row["GLRYZW1"].ToString();
				}
				if(row["GLRYZC1"]!=null)
				{
					model.GLRYZC1=row["GLRYZC1"].ToString();
				}
				if(row["GLRYXL1"]!=null)
				{
					model.GLRYXL1=row["GLRYXL1"].ToString();
				}
				if(row["GLRYZY1"]!=null)
				{
					model.GLRYZY1=row["GLRYZY1"].ToString();
				}
				if(row["GLRYSFZHM1"]!=null)
				{
					model.GLRYSFZHM1=row["GLRYSFZHM1"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXH2") && row["GLRYXH2"] != null)
				{
					model.GLRYXH2=row["GLRYXH2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXM2") && row["GLRYXM2"] != null)
				{
					model.GLRYXM2=row["GLRYXM2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZW2") && row["GLRYZW2"] != null)
				{
					model.GLRYZW2=row["GLRYZW2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZC2") && row["GLRYZC2"] != null)
				{
					model.GLRYZC2=row["GLRYZC2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXL2") && row["GLRYXL2"] != null)
				{
					model.GLRYXL2=row["GLRYXL2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZY2") && row["GLRYZY2"] != null)
				{
					model.GLRYZY2=row["GLRYZY2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYSFZHM2") && row["GLRYSFZHM2"] != null)
				{
					model.GLRYSFZHM2=row["GLRYSFZHM2"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXH3") && row["GLRYXH3"] != null)
				{
					model.GLRYXH3=row["GLRYXH3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXM3") && row["GLRYXM3"] != null)
				{
					model.GLRYXM3=row["GLRYXM3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZW3") && row["GLRYZW3"] != null)
				{
					model.GLRYZW3=row["GLRYZW3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZC3") && row["GLRYZC3"] != null)
				{
					model.GLRYZC3=row["GLRYZC3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXL3") && row["GLRYXL3"] != null)
				{
					model.GLRYXL3=row["GLRYXL3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZY3") && row["GLRYZY3"] != null)
				{
					model.GLRYZY3=row["GLRYZY3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYSFZHM3") && row["GLRYSFZHM3"] != null)
				{
					model.GLRYSFZHM3=row["GLRYSFZHM3"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXH4") && row["GLRYXH4"] != null)
				{
					model.GLRYXH4=row["GLRYXH4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXM4") && row["GLRYXM4"] != null)
				{
					model.GLRYXM4=row["GLRYXM4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZW4") && row["GLRYZW4"] != null)
				{
					model.GLRYZW4=row["GLRYZW4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZC4") && row["GLRYZC4"] != null)
				{
					model.GLRYZC4=row["GLRYZC4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXL4") && row["GLRYXL4"] != null)
				{
					model.GLRYXL4=row["GLRYXL4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZY4") && row["GLRYZY4"] != null)
				{
					model.GLRYZY4=row["GLRYZY4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYSFZHM4") && row["GLRYSFZHM4"] != null)
				{
					model.GLRYSFZHM4=row["GLRYSFZHM4"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXH5") && row["GLRYXH5"] != null)
				{
					model.GLRYXH5=row["GLRYXH5"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXM5") && row["GLRYXM5"] != null)
				{
					model.GLRYXM5=row["GLRYXM5"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZW5") && row["GLRYZW5"] != null)
				{
					model.GLRYZW5=row["GLRYZW5"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZC5") && row["GLRYZC5"] != null)
				{
					model.GLRYZC5=row["GLRYZC5"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYXL5") && row["GLRYXL5"] != null)
				{
					model.GLRYXL5=row["GLRYXL5"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYZY5") && row["GLRYZY5"] != null)
				{
					model.GLRYZY5=row["GLRYZY5"].ToString();
				}
                if (row.Table.Columns.Contains("GLRYSFZHM5") && row["GLRYSFZHM5"] != null)
				{
					model.GLRYSFZHM5=row["GLRYSFZHM5"].ToString();
				}
				if(row["JSGRXH1"]!=null)
				{
					model.JSGRXH1=row["JSGRXH1"].ToString();
				}
				if(row["JSGRXM1"]!=null)
				{
					model.JSGRXM1=row["JSGRXM1"].ToString();
				}
				if(row["JSGRGZ1"]!=null)
				{
					model.JSGRGZ1=row["JSGRGZ1"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXH2") && row["JSGRXH2"] != null)
				{
					model.JSGRXH2=row["JSGRXH2"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXM2") && row["JSGRXM2"] != null)
				{
					model.JSGRXM2=row["JSGRXM2"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRGZ2") && row["JSGRGZ2"] != null)
				{
					model.JSGRGZ2=row["JSGRGZ2"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXH3") && row["JSGRXH3"] != null)
				{
					model.JSGRXH3=row["JSGRXH3"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXM3") && row["JSGRXM3"] != null)
				{
					model.JSGRXM3=row["JSGRXM3"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRGZ3") && row["JSGRGZ3"] != null)
				{
					model.JSGRGZ3=row["JSGRGZ3"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXH4") && row["JSGRXH4"] != null)
				{
					model.JSGRXH4=row["JSGRXH4"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXM4") && row["JSGRXM4"] != null)
				{
					model.JSGRXM4=row["JSGRXM4"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRGZ4") && row["JSGRGZ4"] != null)
				{
					model.JSGRGZ4=row["JSGRGZ4"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXH5") && row["JSGRXH5"] != null)
				{
					model.JSGRXH5=row["JSGRXH5"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRXM5") && row["JSGRXM5"] != null)
				{
					model.JSGRXM5=row["JSGRXM5"].ToString();
				}
                if (row.Table.Columns.Contains("JSGRGZ5") && row["JSGRGZ5"] != null)
				{
					model.JSGRGZ5=row["JSGRGZ5"].ToString();
				}
				if(row["ZGZSFZJG1"]!=null)
				{
					model.ZGZSFZJG1=row["ZGZSFZJG1"].ToString();
				}
				if(row["ZGZSZSBH1"]!=null)
				{
					model.ZGZSZSBH1=row["ZGZSZSBH1"].ToString();
				}
				if(row["ZGZSYXQ1"]!=null)
				{
					model.ZGZSYXQ1=row["ZGZSYXQ1"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSFZJG2") && row["ZGZSFZJG2"] != null)
				{
					model.ZGZSFZJG2=row["ZGZSFZJG2"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSZSBH2") && row["ZGZSZSBH2"] != null)
				{
					model.ZGZSZSBH2=row["ZGZSZSBH2"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSYXQ2") && row["ZGZSYXQ2"] != null)
				{
					model.ZGZSYXQ2=row["ZGZSYXQ2"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSFZJG3") && row["ZGZSFZJG3"] != null)
				{
					model.ZGZSFZJG3=row["ZGZSFZJG3"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSZSBH3") && row["ZGZSZSBH3"] != null)
				{
					model.ZGZSZSBH3=row["ZGZSZSBH3"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSYXQ3") && row["ZGZSYXQ3"] != null)
				{
					model.ZGZSYXQ3=row["ZGZSYXQ3"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSFZJG4") && row["ZGZSFZJG4"] != null)
				{
					model.ZGZSFZJG4=row["ZGZSFZJG4"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSZSBH4") && row["ZGZSZSBH4"] != null)
				{
					model.ZGZSZSBH4=row["ZGZSZSBH4"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSYXQ4") && row["ZGZSYXQ4"] != null)
				{
					model.ZGZSYXQ4=row["ZGZSYXQ4"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSFZJG5") && row["ZGZSFZJG5"] != null)
				{
					model.ZGZSFZJG5=row["ZGZSFZJG5"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSZSBH5") && row["ZGZSZSBH5"] != null)
				{
					model.ZGZSZSBH5=row["ZGZSZSBH5"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSYXQ5") && row["ZGZSYXQ5"] != null)
				{
					model.ZGZSYXQ5=row["ZGZSYXQ5"].ToString();
				}
				if(row["WXJCSBXUH1"]!=null)
				{
					model.WXJCSBXUH1=row["WXJCSBXUH1"].ToString();
				}
				if(row["WXJCSBMC1"]!=null)
				{
					model.WXJCSBMC1=row["WXJCSBMC1"].ToString();
				}
				if(row["WXJCSBXH1"]!=null)
				{
					model.WXJCSBXH1=row["WXJCSBXH1"].ToString();
				}
				if(row["WXJCSBSL1"]!=null)
				{
					model.WXJCSBSL1=row["WXJCSBSL1"].ToString();
				}
				if(row["WXJCSBBZ1"]!=null)
				{
					model.WXJCSBBZ1=row["WXJCSBBZ1"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXUH2") && row["WXJCSBXUH2"] != null)
				{
					model.WXJCSBXUH2=row["WXJCSBXUH2"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBMC2") && row["WXJCSBMC2"] != null)
				{
					model.WXJCSBMC2=row["WXJCSBMC2"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXH2") && row["WXJCSBXH2"] != null)
				{
					model.WXJCSBXH2=row["WXJCSBXH2"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBSL2") && row["WXJCSBSL2"] != null)
				{
					model.WXJCSBSL2=row["WXJCSBSL2"].ToString();
				}
                if (row.Table.Columns.Contains("ZGZSYXQ5") && row["WXJCSBBZ2"] != null)
				{
					model.WXJCSBBZ2=row["WXJCSBBZ2"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXUH3") && row["WXJCSBXUH3"] != null)
				{
					model.WXJCSBXUH3=row["WXJCSBXUH3"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBMC3") && row["WXJCSBMC3"] != null)
				{
					model.WXJCSBMC3=row["WXJCSBMC3"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXH3") && row["WXJCSBXH3"] != null)
				{
					model.WXJCSBXH3=row["WXJCSBXH3"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBSL3") && row["WXJCSBSL3"] != null)
				{
					model.WXJCSBSL3=row["WXJCSBSL3"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBBZ3") && row["WXJCSBBZ3"] != null)
				{
					model.WXJCSBBZ3=row["WXJCSBBZ3"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXUH4") && row["WXJCSBXUH4"] != null)
				{
					model.WXJCSBXUH4=row["WXJCSBXUH4"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBMC4") && row["WXJCSBMC4"] != null)
				{
					model.WXJCSBMC4=row["WXJCSBMC4"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXH4") && row["WXJCSBXH4"] != null)
				{
					model.WXJCSBXH4=row["WXJCSBXH4"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBSL4") && row["WXJCSBSL4"] != null)
				{
					model.WXJCSBSL4=row["WXJCSBSL4"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBBZ4") && row["WXJCSBBZ4"] != null)
				{
					model.WXJCSBBZ4=row["WXJCSBBZ4"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXUH5") && row["WXJCSBXUH5"] != null)
				{
					model.WXJCSBXUH5=row["WXJCSBXUH5"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBMC5") && row["WXJCSBMC5"] != null)
				{
					model.WXJCSBMC5=row["WXJCSBMC5"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBXH5") && row["WXJCSBXH5"] != null)
				{
					model.WXJCSBXH5=row["WXJCSBXH5"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBSL5") && row["WXJCSBSL5"] != null)
				{
					model.WXJCSBSL5=row["WXJCSBSL5"].ToString();
				}
                if (row.Table.Columns.Contains("WXJCSBBZ5") && row["WXJCSBBZ5"] != null)
				{
					model.WXJCSBBZ5=row["WXJCSBBZ5"].ToString();
				}
				if(row["GCYJXH1"]!=null)
				{
					model.GCYJXH1=row["GCYJXH1"].ToString();
				}
				if(row["GCYJGCXMMC1"]!=null)
				{
					model.GCYJGCXMMC1=row["GCYJGCXMMC1"].ToString();
				}
				if(row["GCYJZLDLTS1"]!=null)
				{
					model.GCYJZLDLTS1=row["GCYJZLDLTS1"].ToString();
				}
				if(row["GCYJZJZE1"]!=null)
				{
					model.GCYJZJZE1=row["GCYJZJZE1"].ToString();
				}
				if(row["GCYJKJGSJ1"]!=null)
				{
					model.GCYJKJGSJ1=row["GCYJKJGSJ1"].ToString();
				}
				if(row["GCYJBZ1"]!=null)
				{
					model.GCYJBZ1=row["GCYJBZ1"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJXH2") && row["GCYJXH2"] != null)
				{
					model.GCYJXH2=row["GCYJXH2"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJGCXMMC2") && row["GCYJGCXMMC2"] != null)
				{
					model.GCYJGCXMMC2=row["GCYJGCXMMC2"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZLDLTS2") && row["GCYJZLDLTS2"] != null)
				{
					model.GCYJZLDLTS2=row["GCYJZLDLTS2"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZJZE2") && row["GCYJZJZE2"] != null)
				{
					model.GCYJZJZE2=row["GCYJZJZE2"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJKJGSJ2") && row["GCYJKJGSJ2"] != null)
				{
					model.GCYJKJGSJ2=row["GCYJKJGSJ2"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJBZ2") && row["GCYJBZ2"] != null)
				{
					model.GCYJBZ2=row["GCYJBZ2"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJXH3") && row["GCYJXH3"] != null)
				{
					model.GCYJXH3=row["GCYJXH3"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJGCXMMC3") && row["GCYJGCXMMC3"] != null)
				{
					model.GCYJGCXMMC3=row["GCYJGCXMMC3"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZLDLTS3") && row["GCYJZLDLTS3"] != null)
				{
					model.GCYJZLDLTS3=row["GCYJZLDLTS3"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZJZE3") && row["GCYJZJZE3"] != null)
				{
					model.GCYJZJZE3=row["GCYJZJZE3"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJKJGSJ3") && row["GCYJKJGSJ3"] != null)
				{
					model.GCYJKJGSJ3=row["GCYJKJGSJ3"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJBZ3") && row["GCYJBZ3"] != null)
				{
					model.GCYJBZ3=row["GCYJBZ3"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJXH4") && row["GCYJXH4"] != null)
				{
					model.GCYJXH4=row["GCYJXH4"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJGCXMMC4") && row["GCYJGCXMMC4"] != null)
				{
					model.GCYJGCXMMC4=row["GCYJGCXMMC4"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZLDLTS4") && row["GCYJZLDLTS4"] != null)
				{
					model.GCYJZLDLTS4=row["GCYJZLDLTS4"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZJZE4") && row["GCYJZJZE4"] != null)
				{
					model.GCYJZJZE4=row["GCYJZJZE4"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJKJGSJ4") && row["GCYJKJGSJ4"] != null)
				{
					model.GCYJKJGSJ4=row["GCYJKJGSJ4"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJBZ4") && row["GCYJBZ4"] != null)
				{
					model.GCYJBZ4=row["GCYJBZ4"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJXH5") && row["GCYJXH5"] != null)
				{
					model.GCYJXH5=row["GCYJXH5"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJGCXMMC5") && row["GCYJGCXMMC5"] != null)
				{
					model.GCYJGCXMMC5=row["GCYJGCXMMC5"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZLDLTS5") && row["GCYJZLDLTS5"] != null)
				{
					model.GCYJZLDLTS5=row["GCYJZLDLTS5"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJZJZE5") && row["GCYJZJZE5"] != null)
				{
					model.GCYJZJZE5=row["GCYJZJZE5"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJKJGSJ5") && row["GCYJKJGSJ5"] != null)
				{
					model.GCYJKJGSJ5=row["GCYJKJGSJ5"].ToString();
				}
                if (row.Table.Columns.Contains("GCYJBZ5") && row["GCYJBZ5"] != null)
				{
					model.GCYJBZ5=row["GCYJBZ5"].ToString();
				}
				if(row["CZDLXUH1"]!=null)
				{
					model.CZDLXUH1=row["CZDLXUH1"].ToString();
				}
				if(row["CZDLXH1"]!=null)
				{
					model.CZDLXH1=row["CZDLXH1"].ToString();
				}
				if(row["CZDLMC1"]!=null)
				{
					model.CZDLMC1=row["CZDLMC1"].ToString();
				}
				if(row["CZDLCCRQ1"]!=null)
				{
					model.CZDLCCRQ1=row["CZDLCCRQ1"].ToString();
				}
				if(row["CZDLDLZZCJ1"]!=null)
				{
					model.CZDLDLZZCJ1=row["CZDLDLZZCJ1"].ToString();
				}
				if(row["CZDLSL1"]!=null)
				{
					model.CZDLSL1=row["CZDLSL1"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXUH2") && row["CZDLXUH2"] != null)
				{
					model.CZDLXUH2=row["CZDLXUH2"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXH2") && row["CZDLXH2"] != null)
				{
					model.CZDLXH2=row["CZDLXH2"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLMC2") && row["CZDLMC2"] != null)
				{
					model.CZDLMC2=row["CZDLMC2"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLCCRQ2") && row["CZDLCCRQ2"] != null)
				{
					model.CZDLCCRQ2=row["CZDLCCRQ2"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLDLZZCJ2") && row["CZDLDLZZCJ2"] != null)
				{
					model.CZDLDLZZCJ2=row["CZDLDLZZCJ2"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLSL2") && row["CZDLSL2"] != null)
				{
					model.CZDLSL2=row["CZDLSL2"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXUH3") && row["CZDLXUH3"] != null)
				{
					model.CZDLXUH3=row["CZDLXUH3"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXH3") && row["CZDLXH3"] != null)
				{
					model.CZDLXH3=row["CZDLXH3"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLMC3") && row["CZDLMC3"] != null)
				{
					model.CZDLMC3=row["CZDLMC3"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLCCRQ3") && row["CZDLCCRQ3"] != null)
				{
					model.CZDLCCRQ3=row["CZDLCCRQ3"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLDLZZCJ3") && row["CZDLDLZZCJ3"] != null)
				{
					model.CZDLDLZZCJ3=row["CZDLDLZZCJ3"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLSL3") && row["CZDLSL3"] != null)
				{
					model.CZDLSL3=row["CZDLSL3"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXUH4") && row["CZDLXUH4"] != null)
				{
					model.CZDLXUH4=row["CZDLXUH4"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXH4") && row["CZDLXH4"] != null)
				{
					model.CZDLXH4=row["CZDLXH4"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLMC4") && row["CZDLMC4"] != null)
				{
					model.CZDLMC4=row["CZDLMC4"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLCCRQ4") && row["CZDLCCRQ4"] != null)
				{
					model.CZDLCCRQ4=row["CZDLCCRQ4"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLDLZZCJ4") && row["CZDLDLZZCJ4"] != null)
				{
					model.CZDLDLZZCJ4=row["CZDLDLZZCJ4"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLSL4") && row["CZDLSL4"] != null)
				{
					model.CZDLSL4=row["CZDLSL4"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXUH5") && row["CZDLXUH5"] != null)
				{
					model.CZDLXUH5=row["CZDLXUH5"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLXH5") && row["CZDLXH5"] != null)
				{
					model.CZDLXH5=row["CZDLXH5"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLMC5") && row["CZDLMC5"] != null)
				{
					model.CZDLMC5=row["CZDLMC5"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLCCRQ5") && row["CZDLCCRQ5"] != null)
				{
					model.CZDLCCRQ5=row["CZDLCCRQ5"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLDLZZCJ5") && row["CZDLDLZZCJ5"] != null)
				{
					model.CZDLDLZZCJ5=row["CZDLDLZZCJ5"].ToString();
				}
                if (row.Table.Columns.Contains("CZDLSL5") && row["CZDLSL5"] != null)
				{
					model.CZDLSL5=row["CZDLSL5"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,QYQYMC,QYQYDZ,QYYB,QYZZJGDM,QYLXR,QYGDDH,QYYDDH,QYDZYX,QYCZ,QYYYZZZCH,QYZCRQ,QYYYZZDJJG,QYJJLX,QYZCZJ,QYGDZC,QYCSDLYWRS,QYQYZGZRS,QYCZYDLSL,QYKSCSDLYWRQ,QYQYJJ,QYFRXM,QYFRXB,QYFRZGXL,QYFRZW,QYFRZC,QYFRZY,QYFRGDDH,QYFRYDDH,QYFRPX,QYFRPXSJ,QYFRPXHGZSBH,QYJLXM,QYJLXB,QYJLZGXL,QYJLZW,QYJLZC,QYJLZY,QYJLGDDH,QYJLYDDH,QYJLPX,QYJLPXSJ,QYJLPXHGZSBH,QYJSXM,QYJSXB,QYJSZGXL,QYJSZW,QYJSZC,QYJSZY,QYJSGDDH,QYJSYDDH,QYJSPX,QYJSPXSJ,QYJSPXHGZSBH,GLRYXH1,GLRYXM1,GLRYZW1,GLRYZC1,GLRYXL1,GLRYZY1,GLRYSFZHM1,GLRYXH2,GLRYXM2,GLRYZW2,GLRYZC2,GLRYXL2,GLRYZY2,GLRYSFZHM2,GLRYXH3,GLRYXM3,GLRYZW3,GLRYZC3,GLRYXL3,GLRYZY3,GLRYSFZHM3,GLRYXH4,GLRYXM4,GLRYZW4,GLRYZC4,GLRYXL4,GLRYZY4,GLRYSFZHM4,GLRYXH5,GLRYXM5,GLRYZW5,GLRYZC5,GLRYXL5,GLRYZY5,GLRYSFZHM5,JSGRXH1,JSGRXM1,JSGRGZ1,JSGRXH2,JSGRXM2,JSGRGZ2,JSGRXH3,JSGRXM3,JSGRGZ3,JSGRXH4,JSGRXM4,JSGRGZ4,JSGRXH5,JSGRXM5,JSGRGZ5,ZGZSFZJG1,ZGZSZSBH1,ZGZSYXQ1,ZGZSFZJG2,ZGZSZSBH2,ZGZSYXQ2,ZGZSFZJG3,ZGZSZSBH3,ZGZSYXQ3,ZGZSFZJG4,ZGZSZSBH4,ZGZSYXQ4,ZGZSFZJG5,ZGZSZSBH5,ZGZSYXQ5,WXJCSBXUH1,WXJCSBMC1,WXJCSBXH1,WXJCSBSL1,WXJCSBBZ1,WXJCSBXUH2,WXJCSBMC2,WXJCSBXH2,WXJCSBSL2,WXJCSBBZ2,WXJCSBXUH3,WXJCSBMC3,WXJCSBXH3,WXJCSBSL3,WXJCSBBZ3,WXJCSBXUH4,WXJCSBMC4,WXJCSBXH4,WXJCSBSL4,WXJCSBBZ4,WXJCSBXUH5,WXJCSBMC5,WXJCSBXH5,WXJCSBSL5,WXJCSBBZ5,GCYJXH1,GCYJGCXMMC1,GCYJZLDLTS1,GCYJZJZE1,GCYJKJGSJ1,GCYJBZ1,GCYJXH2,GCYJGCXMMC2,GCYJZLDLTS2,GCYJZJZE2,GCYJKJGSJ2,GCYJBZ2,GCYJXH3,GCYJGCXMMC3,GCYJZLDLTS3,GCYJZJZE3,GCYJKJGSJ3,GCYJBZ3,GCYJXH4,GCYJGCXMMC4,GCYJZLDLTS4,GCYJZJZE4,GCYJKJGSJ4,GCYJBZ4,GCYJXH5,GCYJGCXMMC5,GCYJZLDLTS5,GCYJZJZE5,GCYJKJGSJ5,GCYJBZ5,CZDLXUH1,CZDLXH1,CZDLMC1,CZDLCCRQ1,CZDLDLZZCJ1,CZDLSL1,CZDLXUH2,CZDLXH2,CZDLMC2,CZDLCCRQ2,CZDLDLZZCJ2,CZDLSL2,CZDLXUH3,CZDLXH3,CZDLMC3,CZDLCCRQ3,CZDLDLZZCJ3,CZDLSL3,CZDLXUH4,CZDLXH4,CZDLMC4,CZDLCCRQ4,CZDLDLZZCJ4,CZDLSL4,CZDLXUH5,CZDLXH5,CZDLMC5,CZDLCCRQ5,CZDLDLZZCJ5,CZDLSL5 ");
			strSql.Append(" FROM basket_rent ");
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
			strSql.Append("select count(1) FROM basket_rent ");
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
        public basket_rent GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_rent ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            basket_rent model = new basket_rent();
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
            strSql.Append("select * from basket_rent ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM basket_rent TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM basket_rent TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

