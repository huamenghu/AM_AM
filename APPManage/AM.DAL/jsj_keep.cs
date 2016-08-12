/**  版本信息模板在安装目录下，可自行修改。
* jsj_keep.cs
*
* 功 能： N/A
* 类 名： jsj_keep
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/12 22:32:18   N/A    初版
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
	/// 数据访问类:jsj_keep
	/// </summary>
	public partial class jsj_keepDAL
	{
        public jsj_keepDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Guid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from jsj_keep");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AM.Model.jsj_keep model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into jsj_keep(");
			strSql.Append("Guid,userid,CreateDate,GCMC,XMDZ,SBCQDW,CQDWFZRJDH,AZDW,SBZZDW,ZZDJ,ZZBH,SBXH,SBJJH,ZMWJJYJG,ZMWJJL,ZMWJBZ,CQZMJYJG,CQZMJL,CQZMBZ,ZZZSJYJG,ZZZSJL,ZZZSBZ,SYSMSJYJG,SYSMSJL,SYSMSBZ,GQDBZJZBSJYJG,GQDBZJZBSJL,GQDBZJZBSBZ,ZYSLGJCZZMJYJG,ZYSLGJCZZMJL,ZYSLGJCZZMBZ,ZCBYJLJYJG,ZCBYJLJL,ZCBYJLBZ,ZYJGJJYJG,ZYJGJJL,ZYJGJBZ,ZYSLGJJYJG,ZYSLGJJL,ZYSLGJBZ,ZJSXXJYJG,ZJSXXJL,ZJSXXBZ,FGSXXJYJG,FGSXXJL,FGSXXBZ,DGPZZXDJYJG,DGPZZXDJL,DGPZZXDBZ,DGBMWHJYJG,DGBMWHJL,DGBMWHBZ,FQZZDXJGJYJG,FQZZDXJGJL,FQZZDXJGBZ,FQZZSFQJGJYJG,FQZZSFQJGJL,FQZZSFQJGBZ,FQZZFZLJGJYJG,FQZZFZLJGJL,FQZZFZLJGBZ,FZLZZLMKKJYJG,FZLZZLMKKJL,FZLZZLMKKBZ,FZLZZDLGDJYJG,FZLZZDLGDJL,FZLZZDLGDBZ,FCFWRJYJG,FCFWRJL,FCFWRBZ,GDGSFZLZZJYJG,GDGSFZLZZJL,GDGSFZLZZBZ,FQFZZBKDGJYJG,FQFZZBKDGJL,FQFZZBKDGBZ,SZFQDGJYJG,SZFQDGJL,SZFQDGBZ,FZSXZKJQXJYJG,FZSXZKJQXJL,FZSXZKJQXBZ,SJSBMPJYJG,SJSBMPJL,SJSBMPBZ,DDHLJJYJG,DDHLJJL,DDHLJBZ,LTWHJYJG,LTWHJL,LTWHBZ,CQLSZJCDJYJG,CQLSZJCDJL,CQLSZJCDBZ,DBCCJYJG,DBCCJL,DBCCBZ,XZHZZKXTJYJG,XZHZZKXTJL,XZHZZKXTBZ,CZSZBJTJJYJG,CZSZBJTJJL,CZSZBJTJBZ,XSJYCCJYJG,XSJYCCJL,XSJYCCBZ,MMSAQLWJYJG,MMSAQLWJL,MMSAQLWBZ,FHLGGDJYJG,FHLGGDJL,FHLGGDBZ,DJBGDJYJG,DJBGDJL,DJBGDBZ)");
			strSql.Append(" values (");
			strSql.Append("@Guid,@userid,@CreateDate,@GCMC,@XMDZ,@SBCQDW,@CQDWFZRJDH,@AZDW,@SBZZDW,@ZZDJ,@ZZBH,@SBXH,@SBJJH,@ZMWJJYJG,@ZMWJJL,@ZMWJBZ,@CQZMJYJG,@CQZMJL,@CQZMBZ,@ZZZSJYJG,@ZZZSJL,@ZZZSBZ,@SYSMSJYJG,@SYSMSJL,@SYSMSBZ,@GQDBZJZBSJYJG,@GQDBZJZBSJL,@GQDBZJZBSBZ,@ZYSLGJCZZMJYJG,@ZYSLGJCZZMJL,@ZYSLGJCZZMBZ,@ZCBYJLJYJG,@ZCBYJLJL,@ZCBYJLBZ,@ZYJGJJYJG,@ZYJGJJL,@ZYJGJBZ,@ZYSLGJJYJG,@ZYSLGJJL,@ZYSLGJBZ,@ZJSXXJYJG,@ZJSXXJL,@ZJSXXBZ,@FGSXXJYJG,@FGSXXJL,@FGSXXBZ,@DGPZZXDJYJG,@DGPZZXDJL,@DGPZZXDBZ,@DGBMWHJYJG,@DGBMWHJL,@DGBMWHBZ,@FQZZDXJGJYJG,@FQZZDXJGJL,@FQZZDXJGBZ,@FQZZSFQJGJYJG,@FQZZSFQJGJL,@FQZZSFQJGBZ,@FQZZFZLJGJYJG,@FQZZFZLJGJL,@FQZZFZLJGBZ,@FZLZZLMKKJYJG,@FZLZZLMKKJL,@FZLZZLMKKBZ,@FZLZZDLGDJYJG,@FZLZZDLGDJL,@FZLZZDLGDBZ,@FCFWRJYJG,@FCFWRJL,@FCFWRBZ,@GDGSFZLZZJYJG,@GDGSFZLZZJL,@GDGSFZLZZBZ,@FQFZZBKDGJYJG,@FQFZZBKDGJL,@FQFZZBKDGBZ,@SZFQDGJYJG,@SZFQDGJL,@SZFQDGBZ,@FZSXZKJQXJYJG,@FZSXZKJQXJL,@FZSXZKJQXBZ,@SJSBMPJYJG,@SJSBMPJL,@SJSBMPBZ,@DDHLJJYJG,@DDHLJJL,@DDHLJBZ,@LTWHJYJG,@LTWHJL,@LTWHBZ,@CQLSZJCDJYJG,@CQLSZJCDJL,@CQLSZJCDBZ,@DBCCJYJG,@DBCCJL,@DBCCBZ,@XZHZZKXTJYJG,@XZHZZKXTJL,@XZHZZKXTBZ,@CZSZBJTJJYJG,@CZSZBJTJJL,@CZSZBJTJBZ,@XSJYCCJYJG,@XSJYCCJL,@XSJYCCBZ,@MMSAQLWJYJG,@MMSAQLWJL,@MMSAQLWBZ,@FHLGGDJYJG,@FHLGGDJL,@FHLGGDBZ,@DJBGDJYJG,@DJBGDJL,@DJBGDBZ)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@XMDZ", MySqlDbType.Text),
					new MySqlParameter("@SBCQDW", MySqlDbType.Text),
					new MySqlParameter("@CQDWFZRJDH", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@SBZZDW", MySqlDbType.Text),
					new MySqlParameter("@ZZDJ", MySqlDbType.Text),
					new MySqlParameter("@ZZBH", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@SBJJH", MySqlDbType.Text),
					new MySqlParameter("@ZMWJJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZMWJJL", MySqlDbType.Text),
					new MySqlParameter("@ZMWJBZ", MySqlDbType.Text),
					new MySqlParameter("@CQZMJYJG", MySqlDbType.Text),
					new MySqlParameter("@CQZMJL", MySqlDbType.Text),
					new MySqlParameter("@CQZMBZ", MySqlDbType.Text),
					new MySqlParameter("@ZZZSJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZZZSJL", MySqlDbType.Text),
					new MySqlParameter("@ZZZSBZ", MySqlDbType.Text),
					new MySqlParameter("@SYSMSJYJG", MySqlDbType.Text),
					new MySqlParameter("@SYSMSJL", MySqlDbType.Text),
					new MySqlParameter("@SYSMSBZ", MySqlDbType.Text),
					new MySqlParameter("@GQDBZJZBSJYJG", MySqlDbType.Text),
					new MySqlParameter("@GQDBZJZBSJL", MySqlDbType.Text),
					new MySqlParameter("@GQDBZJZBSBZ", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJCZZMJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJCZZMJL", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJCZZMBZ", MySqlDbType.Text),
					new MySqlParameter("@ZCBYJLJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZCBYJLJL", MySqlDbType.Text),
					new MySqlParameter("@ZCBYJLBZ", MySqlDbType.Text),
					new MySqlParameter("@ZYJGJJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZYJGJJL", MySqlDbType.Text),
					new MySqlParameter("@ZYJGJBZ", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJJL", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJBZ", MySqlDbType.Text),
					new MySqlParameter("@ZJSXXJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZJSXXJL", MySqlDbType.Text),
					new MySqlParameter("@ZJSXXBZ", MySqlDbType.Text),
					new MySqlParameter("@FGSXXJYJG", MySqlDbType.Text),
					new MySqlParameter("@FGSXXJL", MySqlDbType.Text),
					new MySqlParameter("@FGSXXBZ", MySqlDbType.Text),
					new MySqlParameter("@DGPZZXDJYJG", MySqlDbType.Text),
					new MySqlParameter("@DGPZZXDJL", MySqlDbType.Text),
					new MySqlParameter("@DGPZZXDBZ", MySqlDbType.Text),
					new MySqlParameter("@DGBMWHJYJG", MySqlDbType.Text),
					new MySqlParameter("@DGBMWHJL", MySqlDbType.Text),
					new MySqlParameter("@DGBMWHBZ", MySqlDbType.Text),
					new MySqlParameter("@FQZZDXJGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQZZDXJGJL", MySqlDbType.Text),
					new MySqlParameter("@FQZZDXJGBZ", MySqlDbType.Text),
					new MySqlParameter("@FQZZSFQJGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQZZSFQJGJL", MySqlDbType.Text),
					new MySqlParameter("@FQZZSFQJGBZ", MySqlDbType.Text),
					new MySqlParameter("@FQZZFZLJGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQZZFZLJGJL", MySqlDbType.Text),
					new MySqlParameter("@FQZZFZLJGBZ", MySqlDbType.Text),
					new MySqlParameter("@FZLZZLMKKJYJG", MySqlDbType.Text),
					new MySqlParameter("@FZLZZLMKKJL", MySqlDbType.Text),
					new MySqlParameter("@FZLZZLMKKBZ", MySqlDbType.Text),
					new MySqlParameter("@FZLZZDLGDJYJG", MySqlDbType.Text),
					new MySqlParameter("@FZLZZDLGDJL", MySqlDbType.Text),
					new MySqlParameter("@FZLZZDLGDBZ", MySqlDbType.Text),
					new MySqlParameter("@FCFWRJYJG", MySqlDbType.Text),
					new MySqlParameter("@FCFWRJL", MySqlDbType.Text),
					new MySqlParameter("@FCFWRBZ", MySqlDbType.Text),
					new MySqlParameter("@GDGSFZLZZJYJG", MySqlDbType.Text),
					new MySqlParameter("@GDGSFZLZZJL", MySqlDbType.Text),
					new MySqlParameter("@GDGSFZLZZBZ", MySqlDbType.Text),
					new MySqlParameter("@FQFZZBKDGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQFZZBKDGJL", MySqlDbType.Text),
					new MySqlParameter("@FQFZZBKDGBZ", MySqlDbType.Text),
					new MySqlParameter("@SZFQDGJYJG", MySqlDbType.Text),
					new MySqlParameter("@SZFQDGJL", MySqlDbType.Text),
					new MySqlParameter("@SZFQDGBZ", MySqlDbType.Text),
					new MySqlParameter("@FZSXZKJQXJYJG", MySqlDbType.Text),
					new MySqlParameter("@FZSXZKJQXJL", MySqlDbType.Text),
					new MySqlParameter("@FZSXZKJQXBZ", MySqlDbType.Text),
					new MySqlParameter("@SJSBMPJYJG", MySqlDbType.Text),
					new MySqlParameter("@SJSBMPJL", MySqlDbType.Text),
					new MySqlParameter("@SJSBMPBZ", MySqlDbType.Text),
					new MySqlParameter("@DDHLJJYJG", MySqlDbType.Text),
					new MySqlParameter("@DDHLJJL", MySqlDbType.Text),
					new MySqlParameter("@DDHLJBZ", MySqlDbType.Text),
					new MySqlParameter("@LTWHJYJG", MySqlDbType.Text),
					new MySqlParameter("@LTWHJL", MySqlDbType.Text),
					new MySqlParameter("@LTWHBZ", MySqlDbType.Text),
					new MySqlParameter("@CQLSZJCDJYJG", MySqlDbType.Text),
					new MySqlParameter("@CQLSZJCDJL", MySqlDbType.Text),
					new MySqlParameter("@CQLSZJCDBZ", MySqlDbType.Text),
					new MySqlParameter("@DBCCJYJG", MySqlDbType.Text),
					new MySqlParameter("@DBCCJL", MySqlDbType.Text),
					new MySqlParameter("@DBCCBZ", MySqlDbType.Text),
					new MySqlParameter("@XZHZZKXTJYJG", MySqlDbType.Text),
					new MySqlParameter("@XZHZZKXTJL", MySqlDbType.Text),
					new MySqlParameter("@XZHZZKXTBZ", MySqlDbType.Text),
					new MySqlParameter("@CZSZBJTJJYJG", MySqlDbType.Text),
					new MySqlParameter("@CZSZBJTJJL", MySqlDbType.Text),
					new MySqlParameter("@CZSZBJTJBZ", MySqlDbType.Text),
					new MySqlParameter("@XSJYCCJYJG", MySqlDbType.Text),
					new MySqlParameter("@XSJYCCJL", MySqlDbType.Text),
					new MySqlParameter("@XSJYCCBZ", MySqlDbType.Text),
					new MySqlParameter("@MMSAQLWJYJG", MySqlDbType.Text),
					new MySqlParameter("@MMSAQLWJL", MySqlDbType.Text),
					new MySqlParameter("@MMSAQLWBZ", MySqlDbType.Text),
					new MySqlParameter("@FHLGGDJYJG", MySqlDbType.Text),
					new MySqlParameter("@FHLGGDJL", MySqlDbType.Text),
					new MySqlParameter("@FHLGGDBZ", MySqlDbType.Text),
					new MySqlParameter("@DJBGDJYJG", MySqlDbType.Text),
					new MySqlParameter("@DJBGDJL", MySqlDbType.Text),
					new MySqlParameter("@DJBGDBZ", MySqlDbType.Text)};
			parameters[0].Value = model.Guid;
			parameters[1].Value = model.userid;
			parameters[2].Value = model.CreateDate;
			parameters[3].Value = model.GCMC;
			parameters[4].Value = model.XMDZ;
			parameters[5].Value = model.SBCQDW;
			parameters[6].Value = model.CQDWFZRJDH;
			parameters[7].Value = model.AZDW;
			parameters[8].Value = model.SBZZDW;
			parameters[9].Value = model.ZZDJ;
			parameters[10].Value = model.ZZBH;
			parameters[11].Value = model.SBXH;
			parameters[12].Value = model.SBJJH;
			parameters[13].Value = model.ZMWJJYJG;
			parameters[14].Value = model.ZMWJJL;
			parameters[15].Value = model.ZMWJBZ;
			parameters[16].Value = model.CQZMJYJG;
			parameters[17].Value = model.CQZMJL;
			parameters[18].Value = model.CQZMBZ;
			parameters[19].Value = model.ZZZSJYJG;
			parameters[20].Value = model.ZZZSJL;
			parameters[21].Value = model.ZZZSBZ;
			parameters[22].Value = model.SYSMSJYJG;
			parameters[23].Value = model.SYSMSJL;
			parameters[24].Value = model.SYSMSBZ;
			parameters[25].Value = model.GQDBZJZBSJYJG;
			parameters[26].Value = model.GQDBZJZBSJL;
			parameters[27].Value = model.GQDBZJZBSBZ;
			parameters[28].Value = model.ZYSLGJCZZMJYJG;
			parameters[29].Value = model.ZYSLGJCZZMJL;
			parameters[30].Value = model.ZYSLGJCZZMBZ;
			parameters[31].Value = model.ZCBYJLJYJG;
			parameters[32].Value = model.ZCBYJLJL;
			parameters[33].Value = model.ZCBYJLBZ;
			parameters[34].Value = model.ZYJGJJYJG;
			parameters[35].Value = model.ZYJGJJL;
			parameters[36].Value = model.ZYJGJBZ;
			parameters[37].Value = model.ZYSLGJJYJG;
			parameters[38].Value = model.ZYSLGJJL;
			parameters[39].Value = model.ZYSLGJBZ;
			parameters[40].Value = model.ZJSXXJYJG;
			parameters[41].Value = model.ZJSXXJL;
			parameters[42].Value = model.ZJSXXBZ;
			parameters[43].Value = model.FGSXXJYJG;
			parameters[44].Value = model.FGSXXJL;
			parameters[45].Value = model.FGSXXBZ;
			parameters[46].Value = model.DGPZZXDJYJG;
			parameters[47].Value = model.DGPZZXDJL;
			parameters[48].Value = model.DGPZZXDBZ;
			parameters[49].Value = model.DGBMWHJYJG;
			parameters[50].Value = model.DGBMWHJL;
			parameters[51].Value = model.DGBMWHBZ;
			parameters[52].Value = model.FQZZDXJGJYJG;
			parameters[53].Value = model.FQZZDXJGJL;
			parameters[54].Value = model.FQZZDXJGBZ;
			parameters[55].Value = model.FQZZSFQJGJYJG;
			parameters[56].Value = model.FQZZSFQJGJL;
			parameters[57].Value = model.FQZZSFQJGBZ;
			parameters[58].Value = model.FQZZFZLJGJYJG;
			parameters[59].Value = model.FQZZFZLJGJL;
			parameters[60].Value = model.FQZZFZLJGBZ;
			parameters[61].Value = model.FZLZZLMKKJYJG;
			parameters[62].Value = model.FZLZZLMKKJL;
			parameters[63].Value = model.FZLZZLMKKBZ;
			parameters[64].Value = model.FZLZZDLGDJYJG;
			parameters[65].Value = model.FZLZZDLGDJL;
			parameters[66].Value = model.FZLZZDLGDBZ;
			parameters[67].Value = model.FCFWRJYJG;
			parameters[68].Value = model.FCFWRJL;
			parameters[69].Value = model.FCFWRBZ;
			parameters[70].Value = model.GDGSFZLZZJYJG;
			parameters[71].Value = model.GDGSFZLZZJL;
			parameters[72].Value = model.GDGSFZLZZBZ;
			parameters[73].Value = model.FQFZZBKDGJYJG;
			parameters[74].Value = model.FQFZZBKDGJL;
			parameters[75].Value = model.FQFZZBKDGBZ;
			parameters[76].Value = model.SZFQDGJYJG;
			parameters[77].Value = model.SZFQDGJL;
			parameters[78].Value = model.SZFQDGBZ;
			parameters[79].Value = model.FZSXZKJQXJYJG;
			parameters[80].Value = model.FZSXZKJQXJL;
			parameters[81].Value = model.FZSXZKJQXBZ;
			parameters[82].Value = model.SJSBMPJYJG;
			parameters[83].Value = model.SJSBMPJL;
			parameters[84].Value = model.SJSBMPBZ;
			parameters[85].Value = model.DDHLJJYJG;
			parameters[86].Value = model.DDHLJJL;
			parameters[87].Value = model.DDHLJBZ;
			parameters[88].Value = model.LTWHJYJG;
			parameters[89].Value = model.LTWHJL;
			parameters[90].Value = model.LTWHBZ;
			parameters[91].Value = model.CQLSZJCDJYJG;
			parameters[92].Value = model.CQLSZJCDJL;
			parameters[93].Value = model.CQLSZJCDBZ;
			parameters[94].Value = model.DBCCJYJG;
			parameters[95].Value = model.DBCCJL;
			parameters[96].Value = model.DBCCBZ;
			parameters[97].Value = model.XZHZZKXTJYJG;
			parameters[98].Value = model.XZHZZKXTJL;
			parameters[99].Value = model.XZHZZKXTBZ;
			parameters[100].Value = model.CZSZBJTJJYJG;
			parameters[101].Value = model.CZSZBJTJJL;
			parameters[102].Value = model.CZSZBJTJBZ;
			parameters[103].Value = model.XSJYCCJYJG;
			parameters[104].Value = model.XSJYCCJL;
			parameters[105].Value = model.XSJYCCBZ;
			parameters[106].Value = model.MMSAQLWJYJG;
			parameters[107].Value = model.MMSAQLWJL;
			parameters[108].Value = model.MMSAQLWBZ;
			parameters[109].Value = model.FHLGGDJYJG;
			parameters[110].Value = model.FHLGGDJL;
			parameters[111].Value = model.FHLGGDBZ;
			parameters[112].Value = model.DJBGDJYJG;
			parameters[113].Value = model.DJBGDJL;
			parameters[114].Value = model.DJBGDBZ;

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
		public bool Update(AM.Model.jsj_keep model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update jsj_keep set ");
			strSql.Append("userid=@userid,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("GCMC=@GCMC,");
			strSql.Append("XMDZ=@XMDZ,");
			strSql.Append("SBCQDW=@SBCQDW,");
			strSql.Append("CQDWFZRJDH=@CQDWFZRJDH,");
			strSql.Append("AZDW=@AZDW,");
			strSql.Append("SBZZDW=@SBZZDW,");
			strSql.Append("ZZDJ=@ZZDJ,");
			strSql.Append("ZZBH=@ZZBH,");
			strSql.Append("SBXH=@SBXH,");
			strSql.Append("SBJJH=@SBJJH,");
			strSql.Append("ZMWJJYJG=@ZMWJJYJG,");
			strSql.Append("ZMWJJL=@ZMWJJL,");
			strSql.Append("ZMWJBZ=@ZMWJBZ,");
			strSql.Append("CQZMJYJG=@CQZMJYJG,");
			strSql.Append("CQZMJL=@CQZMJL,");
			strSql.Append("CQZMBZ=@CQZMBZ,");
			strSql.Append("ZZZSJYJG=@ZZZSJYJG,");
			strSql.Append("ZZZSJL=@ZZZSJL,");
			strSql.Append("ZZZSBZ=@ZZZSBZ,");
			strSql.Append("SYSMSJYJG=@SYSMSJYJG,");
			strSql.Append("SYSMSJL=@SYSMSJL,");
			strSql.Append("SYSMSBZ=@SYSMSBZ,");
			strSql.Append("GQDBZJZBSJYJG=@GQDBZJZBSJYJG,");
			strSql.Append("GQDBZJZBSJL=@GQDBZJZBSJL,");
			strSql.Append("GQDBZJZBSBZ=@GQDBZJZBSBZ,");
			strSql.Append("ZYSLGJCZZMJYJG=@ZYSLGJCZZMJYJG,");
			strSql.Append("ZYSLGJCZZMJL=@ZYSLGJCZZMJL,");
			strSql.Append("ZYSLGJCZZMBZ=@ZYSLGJCZZMBZ,");
			strSql.Append("ZCBYJLJYJG=@ZCBYJLJYJG,");
			strSql.Append("ZCBYJLJL=@ZCBYJLJL,");
			strSql.Append("ZCBYJLBZ=@ZCBYJLBZ,");
			strSql.Append("ZYJGJJYJG=@ZYJGJJYJG,");
			strSql.Append("ZYJGJJL=@ZYJGJJL,");
			strSql.Append("ZYJGJBZ=@ZYJGJBZ,");
			strSql.Append("ZYSLGJJYJG=@ZYSLGJJYJG,");
			strSql.Append("ZYSLGJJL=@ZYSLGJJL,");
			strSql.Append("ZYSLGJBZ=@ZYSLGJBZ,");
			strSql.Append("ZJSXXJYJG=@ZJSXXJYJG,");
			strSql.Append("ZJSXXJL=@ZJSXXJL,");
			strSql.Append("ZJSXXBZ=@ZJSXXBZ,");
			strSql.Append("FGSXXJYJG=@FGSXXJYJG,");
			strSql.Append("FGSXXJL=@FGSXXJL,");
			strSql.Append("FGSXXBZ=@FGSXXBZ,");
			strSql.Append("DGPZZXDJYJG=@DGPZZXDJYJG,");
			strSql.Append("DGPZZXDJL=@DGPZZXDJL,");
			strSql.Append("DGPZZXDBZ=@DGPZZXDBZ,");
			strSql.Append("DGBMWHJYJG=@DGBMWHJYJG,");
			strSql.Append("DGBMWHJL=@DGBMWHJL,");
			strSql.Append("DGBMWHBZ=@DGBMWHBZ,");
			strSql.Append("FQZZDXJGJYJG=@FQZZDXJGJYJG,");
			strSql.Append("FQZZDXJGJL=@FQZZDXJGJL,");
			strSql.Append("FQZZDXJGBZ=@FQZZDXJGBZ,");
			strSql.Append("FQZZSFQJGJYJG=@FQZZSFQJGJYJG,");
			strSql.Append("FQZZSFQJGJL=@FQZZSFQJGJL,");
			strSql.Append("FQZZSFQJGBZ=@FQZZSFQJGBZ,");
			strSql.Append("FQZZFZLJGJYJG=@FQZZFZLJGJYJG,");
			strSql.Append("FQZZFZLJGJL=@FQZZFZLJGJL,");
			strSql.Append("FQZZFZLJGBZ=@FQZZFZLJGBZ,");
			strSql.Append("FZLZZLMKKJYJG=@FZLZZLMKKJYJG,");
			strSql.Append("FZLZZLMKKJL=@FZLZZLMKKJL,");
			strSql.Append("FZLZZLMKKBZ=@FZLZZLMKKBZ,");
			strSql.Append("FZLZZDLGDJYJG=@FZLZZDLGDJYJG,");
			strSql.Append("FZLZZDLGDJL=@FZLZZDLGDJL,");
			strSql.Append("FZLZZDLGDBZ=@FZLZZDLGDBZ,");
			strSql.Append("FCFWRJYJG=@FCFWRJYJG,");
			strSql.Append("FCFWRJL=@FCFWRJL,");
			strSql.Append("FCFWRBZ=@FCFWRBZ,");
			strSql.Append("GDGSFZLZZJYJG=@GDGSFZLZZJYJG,");
			strSql.Append("GDGSFZLZZJL=@GDGSFZLZZJL,");
			strSql.Append("GDGSFZLZZBZ=@GDGSFZLZZBZ,");
			strSql.Append("FQFZZBKDGJYJG=@FQFZZBKDGJYJG,");
			strSql.Append("FQFZZBKDGJL=@FQFZZBKDGJL,");
			strSql.Append("FQFZZBKDGBZ=@FQFZZBKDGBZ,");
			strSql.Append("SZFQDGJYJG=@SZFQDGJYJG,");
			strSql.Append("SZFQDGJL=@SZFQDGJL,");
			strSql.Append("SZFQDGBZ=@SZFQDGBZ,");
			strSql.Append("FZSXZKJQXJYJG=@FZSXZKJQXJYJG,");
			strSql.Append("FZSXZKJQXJL=@FZSXZKJQXJL,");
			strSql.Append("FZSXZKJQXBZ=@FZSXZKJQXBZ,");
			strSql.Append("SJSBMPJYJG=@SJSBMPJYJG,");
			strSql.Append("SJSBMPJL=@SJSBMPJL,");
			strSql.Append("SJSBMPBZ=@SJSBMPBZ,");
			strSql.Append("DDHLJJYJG=@DDHLJJYJG,");
			strSql.Append("DDHLJJL=@DDHLJJL,");
			strSql.Append("DDHLJBZ=@DDHLJBZ,");
			strSql.Append("LTWHJYJG=@LTWHJYJG,");
			strSql.Append("LTWHJL=@LTWHJL,");
			strSql.Append("LTWHBZ=@LTWHBZ,");
			strSql.Append("CQLSZJCDJYJG=@CQLSZJCDJYJG,");
			strSql.Append("CQLSZJCDJL=@CQLSZJCDJL,");
			strSql.Append("CQLSZJCDBZ=@CQLSZJCDBZ,");
			strSql.Append("DBCCJYJG=@DBCCJYJG,");
			strSql.Append("DBCCJL=@DBCCJL,");
			strSql.Append("DBCCBZ=@DBCCBZ,");
			strSql.Append("XZHZZKXTJYJG=@XZHZZKXTJYJG,");
			strSql.Append("XZHZZKXTJL=@XZHZZKXTJL,");
			strSql.Append("XZHZZKXTBZ=@XZHZZKXTBZ,");
			strSql.Append("CZSZBJTJJYJG=@CZSZBJTJJYJG,");
			strSql.Append("CZSZBJTJJL=@CZSZBJTJJL,");
			strSql.Append("CZSZBJTJBZ=@CZSZBJTJBZ,");
			strSql.Append("XSJYCCJYJG=@XSJYCCJYJG,");
			strSql.Append("XSJYCCJL=@XSJYCCJL,");
			strSql.Append("XSJYCCBZ=@XSJYCCBZ,");
			strSql.Append("MMSAQLWJYJG=@MMSAQLWJYJG,");
			strSql.Append("MMSAQLWJL=@MMSAQLWJL,");
			strSql.Append("MMSAQLWBZ=@MMSAQLWBZ,");
			strSql.Append("FHLGGDJYJG=@FHLGGDJYJG,");
			strSql.Append("FHLGGDJL=@FHLGGDJL,");
			strSql.Append("FHLGGDBZ=@FHLGGDBZ,");
			strSql.Append("DJBGDJYJG=@DJBGDJYJG,");
			strSql.Append("DJBGDJL=@DJBGDJL,");
			strSql.Append("DJBGDBZ=@DJBGDBZ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@GCMC", MySqlDbType.Text),
					new MySqlParameter("@XMDZ", MySqlDbType.Text),
					new MySqlParameter("@SBCQDW", MySqlDbType.Text),
					new MySqlParameter("@CQDWFZRJDH", MySqlDbType.Text),
					new MySqlParameter("@AZDW", MySqlDbType.Text),
					new MySqlParameter("@SBZZDW", MySqlDbType.Text),
					new MySqlParameter("@ZZDJ", MySqlDbType.Text),
					new MySqlParameter("@ZZBH", MySqlDbType.Text),
					new MySqlParameter("@SBXH", MySqlDbType.Text),
					new MySqlParameter("@SBJJH", MySqlDbType.Text),
					new MySqlParameter("@ZMWJJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZMWJJL", MySqlDbType.Text),
					new MySqlParameter("@ZMWJBZ", MySqlDbType.Text),
					new MySqlParameter("@CQZMJYJG", MySqlDbType.Text),
					new MySqlParameter("@CQZMJL", MySqlDbType.Text),
					new MySqlParameter("@CQZMBZ", MySqlDbType.Text),
					new MySqlParameter("@ZZZSJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZZZSJL", MySqlDbType.Text),
					new MySqlParameter("@ZZZSBZ", MySqlDbType.Text),
					new MySqlParameter("@SYSMSJYJG", MySqlDbType.Text),
					new MySqlParameter("@SYSMSJL", MySqlDbType.Text),
					new MySqlParameter("@SYSMSBZ", MySqlDbType.Text),
					new MySqlParameter("@GQDBZJZBSJYJG", MySqlDbType.Text),
					new MySqlParameter("@GQDBZJZBSJL", MySqlDbType.Text),
					new MySqlParameter("@GQDBZJZBSBZ", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJCZZMJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJCZZMJL", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJCZZMBZ", MySqlDbType.Text),
					new MySqlParameter("@ZCBYJLJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZCBYJLJL", MySqlDbType.Text),
					new MySqlParameter("@ZCBYJLBZ", MySqlDbType.Text),
					new MySqlParameter("@ZYJGJJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZYJGJJL", MySqlDbType.Text),
					new MySqlParameter("@ZYJGJBZ", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJJL", MySqlDbType.Text),
					new MySqlParameter("@ZYSLGJBZ", MySqlDbType.Text),
					new MySqlParameter("@ZJSXXJYJG", MySqlDbType.Text),
					new MySqlParameter("@ZJSXXJL", MySqlDbType.Text),
					new MySqlParameter("@ZJSXXBZ", MySqlDbType.Text),
					new MySqlParameter("@FGSXXJYJG", MySqlDbType.Text),
					new MySqlParameter("@FGSXXJL", MySqlDbType.Text),
					new MySqlParameter("@FGSXXBZ", MySqlDbType.Text),
					new MySqlParameter("@DGPZZXDJYJG", MySqlDbType.Text),
					new MySqlParameter("@DGPZZXDJL", MySqlDbType.Text),
					new MySqlParameter("@DGPZZXDBZ", MySqlDbType.Text),
					new MySqlParameter("@DGBMWHJYJG", MySqlDbType.Text),
					new MySqlParameter("@DGBMWHJL", MySqlDbType.Text),
					new MySqlParameter("@DGBMWHBZ", MySqlDbType.Text),
					new MySqlParameter("@FQZZDXJGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQZZDXJGJL", MySqlDbType.Text),
					new MySqlParameter("@FQZZDXJGBZ", MySqlDbType.Text),
					new MySqlParameter("@FQZZSFQJGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQZZSFQJGJL", MySqlDbType.Text),
					new MySqlParameter("@FQZZSFQJGBZ", MySqlDbType.Text),
					new MySqlParameter("@FQZZFZLJGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQZZFZLJGJL", MySqlDbType.Text),
					new MySqlParameter("@FQZZFZLJGBZ", MySqlDbType.Text),
					new MySqlParameter("@FZLZZLMKKJYJG", MySqlDbType.Text),
					new MySqlParameter("@FZLZZLMKKJL", MySqlDbType.Text),
					new MySqlParameter("@FZLZZLMKKBZ", MySqlDbType.Text),
					new MySqlParameter("@FZLZZDLGDJYJG", MySqlDbType.Text),
					new MySqlParameter("@FZLZZDLGDJL", MySqlDbType.Text),
					new MySqlParameter("@FZLZZDLGDBZ", MySqlDbType.Text),
					new MySqlParameter("@FCFWRJYJG", MySqlDbType.Text),
					new MySqlParameter("@FCFWRJL", MySqlDbType.Text),
					new MySqlParameter("@FCFWRBZ", MySqlDbType.Text),
					new MySqlParameter("@GDGSFZLZZJYJG", MySqlDbType.Text),
					new MySqlParameter("@GDGSFZLZZJL", MySqlDbType.Text),
					new MySqlParameter("@GDGSFZLZZBZ", MySqlDbType.Text),
					new MySqlParameter("@FQFZZBKDGJYJG", MySqlDbType.Text),
					new MySqlParameter("@FQFZZBKDGJL", MySqlDbType.Text),
					new MySqlParameter("@FQFZZBKDGBZ", MySqlDbType.Text),
					new MySqlParameter("@SZFQDGJYJG", MySqlDbType.Text),
					new MySqlParameter("@SZFQDGJL", MySqlDbType.Text),
					new MySqlParameter("@SZFQDGBZ", MySqlDbType.Text),
					new MySqlParameter("@FZSXZKJQXJYJG", MySqlDbType.Text),
					new MySqlParameter("@FZSXZKJQXJL", MySqlDbType.Text),
					new MySqlParameter("@FZSXZKJQXBZ", MySqlDbType.Text),
					new MySqlParameter("@SJSBMPJYJG", MySqlDbType.Text),
					new MySqlParameter("@SJSBMPJL", MySqlDbType.Text),
					new MySqlParameter("@SJSBMPBZ", MySqlDbType.Text),
					new MySqlParameter("@DDHLJJYJG", MySqlDbType.Text),
					new MySqlParameter("@DDHLJJL", MySqlDbType.Text),
					new MySqlParameter("@DDHLJBZ", MySqlDbType.Text),
					new MySqlParameter("@LTWHJYJG", MySqlDbType.Text),
					new MySqlParameter("@LTWHJL", MySqlDbType.Text),
					new MySqlParameter("@LTWHBZ", MySqlDbType.Text),
					new MySqlParameter("@CQLSZJCDJYJG", MySqlDbType.Text),
					new MySqlParameter("@CQLSZJCDJL", MySqlDbType.Text),
					new MySqlParameter("@CQLSZJCDBZ", MySqlDbType.Text),
					new MySqlParameter("@DBCCJYJG", MySqlDbType.Text),
					new MySqlParameter("@DBCCJL", MySqlDbType.Text),
					new MySqlParameter("@DBCCBZ", MySqlDbType.Text),
					new MySqlParameter("@XZHZZKXTJYJG", MySqlDbType.Text),
					new MySqlParameter("@XZHZZKXTJL", MySqlDbType.Text),
					new MySqlParameter("@XZHZZKXTBZ", MySqlDbType.Text),
					new MySqlParameter("@CZSZBJTJJYJG", MySqlDbType.Text),
					new MySqlParameter("@CZSZBJTJJL", MySqlDbType.Text),
					new MySqlParameter("@CZSZBJTJBZ", MySqlDbType.Text),
					new MySqlParameter("@XSJYCCJYJG", MySqlDbType.Text),
					new MySqlParameter("@XSJYCCJL", MySqlDbType.Text),
					new MySqlParameter("@XSJYCCBZ", MySqlDbType.Text),
					new MySqlParameter("@MMSAQLWJYJG", MySqlDbType.Text),
					new MySqlParameter("@MMSAQLWJL", MySqlDbType.Text),
					new MySqlParameter("@MMSAQLWBZ", MySqlDbType.Text),
					new MySqlParameter("@FHLGGDJYJG", MySqlDbType.Text),
					new MySqlParameter("@FHLGGDJL", MySqlDbType.Text),
					new MySqlParameter("@FHLGGDBZ", MySqlDbType.Text),
					new MySqlParameter("@DJBGDJYJG", MySqlDbType.Text),
					new MySqlParameter("@DJBGDJL", MySqlDbType.Text),
					new MySqlParameter("@DJBGDBZ", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
			parameters[0].Value = model.userid;
			parameters[1].Value = model.CreateDate;
			parameters[2].Value = model.GCMC;
			parameters[3].Value = model.XMDZ;
			parameters[4].Value = model.SBCQDW;
			parameters[5].Value = model.CQDWFZRJDH;
			parameters[6].Value = model.AZDW;
			parameters[7].Value = model.SBZZDW;
			parameters[8].Value = model.ZZDJ;
			parameters[9].Value = model.ZZBH;
			parameters[10].Value = model.SBXH;
			parameters[11].Value = model.SBJJH;
			parameters[12].Value = model.ZMWJJYJG;
			parameters[13].Value = model.ZMWJJL;
			parameters[14].Value = model.ZMWJBZ;
			parameters[15].Value = model.CQZMJYJG;
			parameters[16].Value = model.CQZMJL;
			parameters[17].Value = model.CQZMBZ;
			parameters[18].Value = model.ZZZSJYJG;
			parameters[19].Value = model.ZZZSJL;
			parameters[20].Value = model.ZZZSBZ;
			parameters[21].Value = model.SYSMSJYJG;
			parameters[22].Value = model.SYSMSJL;
			parameters[23].Value = model.SYSMSBZ;
			parameters[24].Value = model.GQDBZJZBSJYJG;
			parameters[25].Value = model.GQDBZJZBSJL;
			parameters[26].Value = model.GQDBZJZBSBZ;
			parameters[27].Value = model.ZYSLGJCZZMJYJG;
			parameters[28].Value = model.ZYSLGJCZZMJL;
			parameters[29].Value = model.ZYSLGJCZZMBZ;
			parameters[30].Value = model.ZCBYJLJYJG;
			parameters[31].Value = model.ZCBYJLJL;
			parameters[32].Value = model.ZCBYJLBZ;
			parameters[33].Value = model.ZYJGJJYJG;
			parameters[34].Value = model.ZYJGJJL;
			parameters[35].Value = model.ZYJGJBZ;
			parameters[36].Value = model.ZYSLGJJYJG;
			parameters[37].Value = model.ZYSLGJJL;
			parameters[38].Value = model.ZYSLGJBZ;
			parameters[39].Value = model.ZJSXXJYJG;
			parameters[40].Value = model.ZJSXXJL;
			parameters[41].Value = model.ZJSXXBZ;
			parameters[42].Value = model.FGSXXJYJG;
			parameters[43].Value = model.FGSXXJL;
			parameters[44].Value = model.FGSXXBZ;
			parameters[45].Value = model.DGPZZXDJYJG;
			parameters[46].Value = model.DGPZZXDJL;
			parameters[47].Value = model.DGPZZXDBZ;
			parameters[48].Value = model.DGBMWHJYJG;
			parameters[49].Value = model.DGBMWHJL;
			parameters[50].Value = model.DGBMWHBZ;
			parameters[51].Value = model.FQZZDXJGJYJG;
			parameters[52].Value = model.FQZZDXJGJL;
			parameters[53].Value = model.FQZZDXJGBZ;
			parameters[54].Value = model.FQZZSFQJGJYJG;
			parameters[55].Value = model.FQZZSFQJGJL;
			parameters[56].Value = model.FQZZSFQJGBZ;
			parameters[57].Value = model.FQZZFZLJGJYJG;
			parameters[58].Value = model.FQZZFZLJGJL;
			parameters[59].Value = model.FQZZFZLJGBZ;
			parameters[60].Value = model.FZLZZLMKKJYJG;
			parameters[61].Value = model.FZLZZLMKKJL;
			parameters[62].Value = model.FZLZZLMKKBZ;
			parameters[63].Value = model.FZLZZDLGDJYJG;
			parameters[64].Value = model.FZLZZDLGDJL;
			parameters[65].Value = model.FZLZZDLGDBZ;
			parameters[66].Value = model.FCFWRJYJG;
			parameters[67].Value = model.FCFWRJL;
			parameters[68].Value = model.FCFWRBZ;
			parameters[69].Value = model.GDGSFZLZZJYJG;
			parameters[70].Value = model.GDGSFZLZZJL;
			parameters[71].Value = model.GDGSFZLZZBZ;
			parameters[72].Value = model.FQFZZBKDGJYJG;
			parameters[73].Value = model.FQFZZBKDGJL;
			parameters[74].Value = model.FQFZZBKDGBZ;
			parameters[75].Value = model.SZFQDGJYJG;
			parameters[76].Value = model.SZFQDGJL;
			parameters[77].Value = model.SZFQDGBZ;
			parameters[78].Value = model.FZSXZKJQXJYJG;
			parameters[79].Value = model.FZSXZKJQXJL;
			parameters[80].Value = model.FZSXZKJQXBZ;
			parameters[81].Value = model.SJSBMPJYJG;
			parameters[82].Value = model.SJSBMPJL;
			parameters[83].Value = model.SJSBMPBZ;
			parameters[84].Value = model.DDHLJJYJG;
			parameters[85].Value = model.DDHLJJL;
			parameters[86].Value = model.DDHLJBZ;
			parameters[87].Value = model.LTWHJYJG;
			parameters[88].Value = model.LTWHJL;
			parameters[89].Value = model.LTWHBZ;
			parameters[90].Value = model.CQLSZJCDJYJG;
			parameters[91].Value = model.CQLSZJCDJL;
			parameters[92].Value = model.CQLSZJCDBZ;
			parameters[93].Value = model.DBCCJYJG;
			parameters[94].Value = model.DBCCJL;
			parameters[95].Value = model.DBCCBZ;
			parameters[96].Value = model.XZHZZKXTJYJG;
			parameters[97].Value = model.XZHZZKXTJL;
			parameters[98].Value = model.XZHZZKXTBZ;
			parameters[99].Value = model.CZSZBJTJJYJG;
			parameters[100].Value = model.CZSZBJTJJL;
			parameters[101].Value = model.CZSZBJTJBZ;
			parameters[102].Value = model.XSJYCCJYJG;
			parameters[103].Value = model.XSJYCCJL;
			parameters[104].Value = model.XSJYCCBZ;
			parameters[105].Value = model.MMSAQLWJYJG;
			parameters[106].Value = model.MMSAQLWJL;
			parameters[107].Value = model.MMSAQLWBZ;
			parameters[108].Value = model.FHLGGDJYJG;
			parameters[109].Value = model.FHLGGDJL;
			parameters[110].Value = model.FHLGGDBZ;
			parameters[111].Value = model.DJBGDJYJG;
			parameters[112].Value = model.DJBGDJL;
			parameters[113].Value = model.DJBGDBZ;
			parameters[114].Value = model.Guid;

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
			strSql.Append("delete from jsj_keep ");
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
			strSql.Append("delete from jsj_keep ");
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
		public AM.Model.jsj_keep GetModel(string Guid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Guid,userid,CreateDate,GCMC,XMDZ,SBCQDW,CQDWFZRJDH,AZDW,SBZZDW,ZZDJ,ZZBH,SBXH,SBJJH,ZMWJJYJG,ZMWJJL,ZMWJBZ,CQZMJYJG,CQZMJL,CQZMBZ,ZZZSJYJG,ZZZSJL,ZZZSBZ,SYSMSJYJG,SYSMSJL,SYSMSBZ,GQDBZJZBSJYJG,GQDBZJZBSJL,GQDBZJZBSBZ,ZYSLGJCZZMJYJG,ZYSLGJCZZMJL,ZYSLGJCZZMBZ,ZCBYJLJYJG,ZCBYJLJL,ZCBYJLBZ,ZYJGJJYJG,ZYJGJJL,ZYJGJBZ,ZYSLGJJYJG,ZYSLGJJL,ZYSLGJBZ,ZJSXXJYJG,ZJSXXJL,ZJSXXBZ,FGSXXJYJG,FGSXXJL,FGSXXBZ,DGPZZXDJYJG,DGPZZXDJL,DGPZZXDBZ,DGBMWHJYJG,DGBMWHJL,DGBMWHBZ,FQZZDXJGJYJG,FQZZDXJGJL,FQZZDXJGBZ,FQZZSFQJGJYJG,FQZZSFQJGJL,FQZZSFQJGBZ,FQZZFZLJGJYJG,FQZZFZLJGJL,FQZZFZLJGBZ,FZLZZLMKKJYJG,FZLZZLMKKJL,FZLZZLMKKBZ,FZLZZDLGDJYJG,FZLZZDLGDJL,FZLZZDLGDBZ,FCFWRJYJG,FCFWRJL,FCFWRBZ,GDGSFZLZZJYJG,GDGSFZLZZJL,GDGSFZLZZBZ,FQFZZBKDGJYJG,FQFZZBKDGJL,FQFZZBKDGBZ,SZFQDGJYJG,SZFQDGJL,SZFQDGBZ,FZSXZKJQXJYJG,FZSXZKJQXJL,FZSXZKJQXBZ,SJSBMPJYJG,SJSBMPJL,SJSBMPBZ,DDHLJJYJG,DDHLJJL,DDHLJBZ,LTWHJYJG,LTWHJL,LTWHBZ,CQLSZJCDJYJG,CQLSZJCDJL,CQLSZJCDBZ,DBCCJYJG,DBCCJL,DBCCBZ,XZHZZKXTJYJG,XZHZZKXTJL,XZHZZKXTBZ,CZSZBJTJJYJG,CZSZBJTJJL,CZSZBJTJBZ,XSJYCCJYJG,XSJYCCJL,XSJYCCBZ,MMSAQLWJYJG,MMSAQLWJL,MMSAQLWBZ,FHLGGDJYJG,FHLGGDJL,FHLGGDBZ,DJBGDJYJG,DJBGDJL,DJBGDBZ from jsj_keep ");
			strSql.Append(" where Guid=@Guid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
			parameters[0].Value = Guid;

			AM.Model.jsj_keep model=new AM.Model.jsj_keep();
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
		public AM.Model.jsj_keep DataRowToModel(DataRow row)
		{
			AM.Model.jsj_keep model=new AM.Model.jsj_keep();
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
				if(row["XMDZ"]!=null)
				{
					model.XMDZ=row["XMDZ"].ToString();
				}
				if(row["SBCQDW"]!=null)
				{
					model.SBCQDW=row["SBCQDW"].ToString();
				}
				if(row["CQDWFZRJDH"]!=null)
				{
					model.CQDWFZRJDH=row["CQDWFZRJDH"].ToString();
				}
				if(row["AZDW"]!=null)
				{
					model.AZDW=row["AZDW"].ToString();
				}
				if(row["SBZZDW"]!=null)
				{
					model.SBZZDW=row["SBZZDW"].ToString();
				}
				if(row["ZZDJ"]!=null)
				{
					model.ZZDJ=row["ZZDJ"].ToString();
				}
				if(row["ZZBH"]!=null)
				{
					model.ZZBH=row["ZZBH"].ToString();
				}
				if(row["SBXH"]!=null)
				{
					model.SBXH=row["SBXH"].ToString();
				}
				if(row["SBJJH"]!=null)
				{
					model.SBJJH=row["SBJJH"].ToString();
				}
				if(row["ZMWJJYJG"]!=null)
				{
					model.ZMWJJYJG=row["ZMWJJYJG"].ToString();
				}
				if(row["ZMWJJL"]!=null)
				{
					model.ZMWJJL=row["ZMWJJL"].ToString();
				}
				if(row["ZMWJBZ"]!=null)
				{
					model.ZMWJBZ=row["ZMWJBZ"].ToString();
				}
				if(row["CQZMJYJG"]!=null)
				{
					model.CQZMJYJG=row["CQZMJYJG"].ToString();
				}
				if(row["CQZMJL"]!=null)
				{
					model.CQZMJL=row["CQZMJL"].ToString();
				}
				if(row["CQZMBZ"]!=null)
				{
					model.CQZMBZ=row["CQZMBZ"].ToString();
				}
				if(row["ZZZSJYJG"]!=null)
				{
					model.ZZZSJYJG=row["ZZZSJYJG"].ToString();
				}
				if(row["ZZZSJL"]!=null)
				{
					model.ZZZSJL=row["ZZZSJL"].ToString();
				}
				if(row["ZZZSBZ"]!=null)
				{
					model.ZZZSBZ=row["ZZZSBZ"].ToString();
				}
				if(row["SYSMSJYJG"]!=null)
				{
					model.SYSMSJYJG=row["SYSMSJYJG"].ToString();
				}
				if(row["SYSMSJL"]!=null)
				{
					model.SYSMSJL=row["SYSMSJL"].ToString();
				}
				if(row["SYSMSBZ"]!=null)
				{
					model.SYSMSBZ=row["SYSMSBZ"].ToString();
				}
				if(row["GQDBZJZBSJYJG"]!=null)
				{
					model.GQDBZJZBSJYJG=row["GQDBZJZBSJYJG"].ToString();
				}
				if(row["GQDBZJZBSJL"]!=null)
				{
					model.GQDBZJZBSJL=row["GQDBZJZBSJL"].ToString();
				}
				if(row["GQDBZJZBSBZ"]!=null)
				{
					model.GQDBZJZBSBZ=row["GQDBZJZBSBZ"].ToString();
				}
				if(row["ZYSLGJCZZMJYJG"]!=null)
				{
					model.ZYSLGJCZZMJYJG=row["ZYSLGJCZZMJYJG"].ToString();
				}
				if(row["ZYSLGJCZZMJL"]!=null)
				{
					model.ZYSLGJCZZMJL=row["ZYSLGJCZZMJL"].ToString();
				}
				if(row["ZYSLGJCZZMBZ"]!=null)
				{
					model.ZYSLGJCZZMBZ=row["ZYSLGJCZZMBZ"].ToString();
				}
				if(row["ZCBYJLJYJG"]!=null)
				{
					model.ZCBYJLJYJG=row["ZCBYJLJYJG"].ToString();
				}
				if(row["ZCBYJLJL"]!=null)
				{
					model.ZCBYJLJL=row["ZCBYJLJL"].ToString();
				}
				if(row["ZCBYJLBZ"]!=null)
				{
					model.ZCBYJLBZ=row["ZCBYJLBZ"].ToString();
				}
				if(row["ZYJGJJYJG"]!=null)
				{
					model.ZYJGJJYJG=row["ZYJGJJYJG"].ToString();
				}
				if(row["ZYJGJJL"]!=null)
				{
					model.ZYJGJJL=row["ZYJGJJL"].ToString();
				}
				if(row["ZYJGJBZ"]!=null)
				{
					model.ZYJGJBZ=row["ZYJGJBZ"].ToString();
				}
				if(row["ZYSLGJJYJG"]!=null)
				{
					model.ZYSLGJJYJG=row["ZYSLGJJYJG"].ToString();
				}
				if(row["ZYSLGJJL"]!=null)
				{
					model.ZYSLGJJL=row["ZYSLGJJL"].ToString();
				}
				if(row["ZYSLGJBZ"]!=null)
				{
					model.ZYSLGJBZ=row["ZYSLGJBZ"].ToString();
				}
				if(row["ZJSXXJYJG"]!=null)
				{
					model.ZJSXXJYJG=row["ZJSXXJYJG"].ToString();
				}
				if(row["ZJSXXJL"]!=null)
				{
					model.ZJSXXJL=row["ZJSXXJL"].ToString();
				}
				if(row["ZJSXXBZ"]!=null)
				{
					model.ZJSXXBZ=row["ZJSXXBZ"].ToString();
				}
				if(row["FGSXXJYJG"]!=null)
				{
					model.FGSXXJYJG=row["FGSXXJYJG"].ToString();
				}
				if(row["FGSXXJL"]!=null)
				{
					model.FGSXXJL=row["FGSXXJL"].ToString();
				}
				if(row["FGSXXBZ"]!=null)
				{
					model.FGSXXBZ=row["FGSXXBZ"].ToString();
				}
				if(row["DGPZZXDJYJG"]!=null)
				{
					model.DGPZZXDJYJG=row["DGPZZXDJYJG"].ToString();
				}
				if(row["DGPZZXDJL"]!=null)
				{
					model.DGPZZXDJL=row["DGPZZXDJL"].ToString();
				}
				if(row["DGPZZXDBZ"]!=null)
				{
					model.DGPZZXDBZ=row["DGPZZXDBZ"].ToString();
				}
				if(row["DGBMWHJYJG"]!=null)
				{
					model.DGBMWHJYJG=row["DGBMWHJYJG"].ToString();
				}
				if(row["DGBMWHJL"]!=null)
				{
					model.DGBMWHJL=row["DGBMWHJL"].ToString();
				}
				if(row["DGBMWHBZ"]!=null)
				{
					model.DGBMWHBZ=row["DGBMWHBZ"].ToString();
				}
				if(row["FQZZDXJGJYJG"]!=null)
				{
					model.FQZZDXJGJYJG=row["FQZZDXJGJYJG"].ToString();
				}
				if(row["FQZZDXJGJL"]!=null)
				{
					model.FQZZDXJGJL=row["FQZZDXJGJL"].ToString();
				}
				if(row["FQZZDXJGBZ"]!=null)
				{
					model.FQZZDXJGBZ=row["FQZZDXJGBZ"].ToString();
				}
				if(row["FQZZSFQJGJYJG"]!=null)
				{
					model.FQZZSFQJGJYJG=row["FQZZSFQJGJYJG"].ToString();
				}
				if(row["FQZZSFQJGJL"]!=null)
				{
					model.FQZZSFQJGJL=row["FQZZSFQJGJL"].ToString();
				}
				if(row["FQZZSFQJGBZ"]!=null)
				{
					model.FQZZSFQJGBZ=row["FQZZSFQJGBZ"].ToString();
				}
				if(row["FQZZFZLJGJYJG"]!=null)
				{
					model.FQZZFZLJGJYJG=row["FQZZFZLJGJYJG"].ToString();
				}
				if(row["FQZZFZLJGJL"]!=null)
				{
					model.FQZZFZLJGJL=row["FQZZFZLJGJL"].ToString();
				}
				if(row["FQZZFZLJGBZ"]!=null)
				{
					model.FQZZFZLJGBZ=row["FQZZFZLJGBZ"].ToString();
				}
				if(row["FZLZZLMKKJYJG"]!=null)
				{
					model.FZLZZLMKKJYJG=row["FZLZZLMKKJYJG"].ToString();
				}
				if(row["FZLZZLMKKJL"]!=null)
				{
					model.FZLZZLMKKJL=row["FZLZZLMKKJL"].ToString();
				}
				if(row["FZLZZLMKKBZ"]!=null)
				{
					model.FZLZZLMKKBZ=row["FZLZZLMKKBZ"].ToString();
				}
				if(row["FZLZZDLGDJYJG"]!=null)
				{
					model.FZLZZDLGDJYJG=row["FZLZZDLGDJYJG"].ToString();
				}
				if(row["FZLZZDLGDJL"]!=null)
				{
					model.FZLZZDLGDJL=row["FZLZZDLGDJL"].ToString();
				}
				if(row["FZLZZDLGDBZ"]!=null)
				{
					model.FZLZZDLGDBZ=row["FZLZZDLGDBZ"].ToString();
				}
				if(row["FCFWRJYJG"]!=null)
				{
					model.FCFWRJYJG=row["FCFWRJYJG"].ToString();
				}
				if(row["FCFWRJL"]!=null)
				{
					model.FCFWRJL=row["FCFWRJL"].ToString();
				}
				if(row["FCFWRBZ"]!=null)
				{
					model.FCFWRBZ=row["FCFWRBZ"].ToString();
				}
				if(row["GDGSFZLZZJYJG"]!=null)
				{
					model.GDGSFZLZZJYJG=row["GDGSFZLZZJYJG"].ToString();
				}
				if(row["GDGSFZLZZJL"]!=null)
				{
					model.GDGSFZLZZJL=row["GDGSFZLZZJL"].ToString();
				}
				if(row["GDGSFZLZZBZ"]!=null)
				{
					model.GDGSFZLZZBZ=row["GDGSFZLZZBZ"].ToString();
				}
				if(row["FQFZZBKDGJYJG"]!=null)
				{
					model.FQFZZBKDGJYJG=row["FQFZZBKDGJYJG"].ToString();
				}
				if(row["FQFZZBKDGJL"]!=null)
				{
					model.FQFZZBKDGJL=row["FQFZZBKDGJL"].ToString();
				}
				if(row["FQFZZBKDGBZ"]!=null)
				{
					model.FQFZZBKDGBZ=row["FQFZZBKDGBZ"].ToString();
				}
				if(row["SZFQDGJYJG"]!=null)
				{
					model.SZFQDGJYJG=row["SZFQDGJYJG"].ToString();
				}
				if(row["SZFQDGJL"]!=null)
				{
					model.SZFQDGJL=row["SZFQDGJL"].ToString();
				}
				if(row["SZFQDGBZ"]!=null)
				{
					model.SZFQDGBZ=row["SZFQDGBZ"].ToString();
				}
				if(row["FZSXZKJQXJYJG"]!=null)
				{
					model.FZSXZKJQXJYJG=row["FZSXZKJQXJYJG"].ToString();
				}
				if(row["FZSXZKJQXJL"]!=null)
				{
					model.FZSXZKJQXJL=row["FZSXZKJQXJL"].ToString();
				}
				if(row["FZSXZKJQXBZ"]!=null)
				{
					model.FZSXZKJQXBZ=row["FZSXZKJQXBZ"].ToString();
				}
				if(row["SJSBMPJYJG"]!=null)
				{
					model.SJSBMPJYJG=row["SJSBMPJYJG"].ToString();
				}
				if(row["SJSBMPJL"]!=null)
				{
					model.SJSBMPJL=row["SJSBMPJL"].ToString();
				}
				if(row["SJSBMPBZ"]!=null)
				{
					model.SJSBMPBZ=row["SJSBMPBZ"].ToString();
				}
				if(row["DDHLJJYJG"]!=null)
				{
					model.DDHLJJYJG=row["DDHLJJYJG"].ToString();
				}
				if(row["DDHLJJL"]!=null)
				{
					model.DDHLJJL=row["DDHLJJL"].ToString();
				}
				if(row["DDHLJBZ"]!=null)
				{
					model.DDHLJBZ=row["DDHLJBZ"].ToString();
				}
				if(row["LTWHJYJG"]!=null)
				{
					model.LTWHJYJG=row["LTWHJYJG"].ToString();
				}
				if(row["LTWHJL"]!=null)
				{
					model.LTWHJL=row["LTWHJL"].ToString();
				}
				if(row["LTWHBZ"]!=null)
				{
					model.LTWHBZ=row["LTWHBZ"].ToString();
				}
				if(row["CQLSZJCDJYJG"]!=null)
				{
					model.CQLSZJCDJYJG=row["CQLSZJCDJYJG"].ToString();
				}
				if(row["CQLSZJCDJL"]!=null)
				{
					model.CQLSZJCDJL=row["CQLSZJCDJL"].ToString();
				}
				if(row["CQLSZJCDBZ"]!=null)
				{
					model.CQLSZJCDBZ=row["CQLSZJCDBZ"].ToString();
				}
				if(row["DBCCJYJG"]!=null)
				{
					model.DBCCJYJG=row["DBCCJYJG"].ToString();
				}
				if(row["DBCCJL"]!=null)
				{
					model.DBCCJL=row["DBCCJL"].ToString();
				}
				if(row["DBCCBZ"]!=null)
				{
					model.DBCCBZ=row["DBCCBZ"].ToString();
				}
				if(row["XZHZZKXTJYJG"]!=null)
				{
					model.XZHZZKXTJYJG=row["XZHZZKXTJYJG"].ToString();
				}
				if(row["XZHZZKXTJL"]!=null)
				{
					model.XZHZZKXTJL=row["XZHZZKXTJL"].ToString();
				}
				if(row["XZHZZKXTBZ"]!=null)
				{
					model.XZHZZKXTBZ=row["XZHZZKXTBZ"].ToString();
				}
				if(row["CZSZBJTJJYJG"]!=null)
				{
					model.CZSZBJTJJYJG=row["CZSZBJTJJYJG"].ToString();
				}
				if(row["CZSZBJTJJL"]!=null)
				{
					model.CZSZBJTJJL=row["CZSZBJTJJL"].ToString();
				}
				if(row["CZSZBJTJBZ"]!=null)
				{
					model.CZSZBJTJBZ=row["CZSZBJTJBZ"].ToString();
				}
				if(row["XSJYCCJYJG"]!=null)
				{
					model.XSJYCCJYJG=row["XSJYCCJYJG"].ToString();
				}
				if(row["XSJYCCJL"]!=null)
				{
					model.XSJYCCJL=row["XSJYCCJL"].ToString();
				}
				if(row["XSJYCCBZ"]!=null)
				{
					model.XSJYCCBZ=row["XSJYCCBZ"].ToString();
				}
				if(row["MMSAQLWJYJG"]!=null)
				{
					model.MMSAQLWJYJG=row["MMSAQLWJYJG"].ToString();
				}
				if(row["MMSAQLWJL"]!=null)
				{
					model.MMSAQLWJL=row["MMSAQLWJL"].ToString();
				}
				if(row["MMSAQLWBZ"]!=null)
				{
					model.MMSAQLWBZ=row["MMSAQLWBZ"].ToString();
				}
				if(row["FHLGGDJYJG"]!=null)
				{
					model.FHLGGDJYJG=row["FHLGGDJYJG"].ToString();
				}
				if(row["FHLGGDJL"]!=null)
				{
					model.FHLGGDJL=row["FHLGGDJL"].ToString();
				}
				if(row["FHLGGDBZ"]!=null)
				{
					model.FHLGGDBZ=row["FHLGGDBZ"].ToString();
				}
				if(row["DJBGDJYJG"]!=null)
				{
					model.DJBGDJYJG=row["DJBGDJYJG"].ToString();
				}
				if(row["DJBGDJL"]!=null)
				{
					model.DJBGDJL=row["DJBGDJL"].ToString();
				}
				if(row["DJBGDBZ"]!=null)
				{
					model.DJBGDBZ=row["DJBGDBZ"].ToString();
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
			strSql.Append("select Guid,userid,CreateDate,GCMC,XMDZ,SBCQDW,CQDWFZRJDH,AZDW,SBZZDW,ZZDJ,ZZBH,SBXH,SBJJH,ZMWJJYJG,ZMWJJL,ZMWJBZ,CQZMJYJG,CQZMJL,CQZMBZ,ZZZSJYJG,ZZZSJL,ZZZSBZ,SYSMSJYJG,SYSMSJL,SYSMSBZ,GQDBZJZBSJYJG,GQDBZJZBSJL,GQDBZJZBSBZ,ZYSLGJCZZMJYJG,ZYSLGJCZZMJL,ZYSLGJCZZMBZ,ZCBYJLJYJG,ZCBYJLJL,ZCBYJLBZ,ZYJGJJYJG,ZYJGJJL,ZYJGJBZ,ZYSLGJJYJG,ZYSLGJJL,ZYSLGJBZ,ZJSXXJYJG,ZJSXXJL,ZJSXXBZ,FGSXXJYJG,FGSXXJL,FGSXXBZ,DGPZZXDJYJG,DGPZZXDJL,DGPZZXDBZ,DGBMWHJYJG,DGBMWHJL,DGBMWHBZ,FQZZDXJGJYJG,FQZZDXJGJL,FQZZDXJGBZ,FQZZSFQJGJYJG,FQZZSFQJGJL,FQZZSFQJGBZ,FQZZFZLJGJYJG,FQZZFZLJGJL,FQZZFZLJGBZ,FZLZZLMKKJYJG,FZLZZLMKKJL,FZLZZLMKKBZ,FZLZZDLGDJYJG,FZLZZDLGDJL,FZLZZDLGDBZ,FCFWRJYJG,FCFWRJL,FCFWRBZ,GDGSFZLZZJYJG,GDGSFZLZZJL,GDGSFZLZZBZ,FQFZZBKDGJYJG,FQFZZBKDGJL,FQFZZBKDGBZ,SZFQDGJYJG,SZFQDGJL,SZFQDGBZ,FZSXZKJQXJYJG,FZSXZKJQXJL,FZSXZKJQXBZ,SJSBMPJYJG,SJSBMPJL,SJSBMPBZ,DDHLJJYJG,DDHLJJL,DDHLJBZ,LTWHJYJG,LTWHJL,LTWHBZ,CQLSZJCDJYJG,CQLSZJCDJL,CQLSZJCDBZ,DBCCJYJG,DBCCJL,DBCCBZ,XZHZZKXTJYJG,XZHZZKXTJL,XZHZZKXTBZ,CZSZBJTJJYJG,CZSZBJTJJL,CZSZBJTJBZ,XSJYCCJYJG,XSJYCCJL,XSJYCCBZ,MMSAQLWJYJG,MMSAQLWJL,MMSAQLWBZ,FHLGGDJYJG,FHLGGDJL,FHLGGDBZ,DJBGDJYJG,DJBGDJL,DJBGDBZ ");
			strSql.Append(" FROM jsj_keep ");
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
			strSql.Append("select count(1) FROM jsj_keep ");
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
        public jsj_keep GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from jsj_keep ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            jsj_keep model = new jsj_keep();
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
            strSql.Append("select * from jsj_keep ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM jsj_keep TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM jsj_keep TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

