using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
using AM.Model;//Please add references
namespace AM.DAL
{
    /// <summary>
    /// 数据访问类:basket_keep
    /// </summary>
    public partial class basket_keepDAL
    {
        public basket_keepDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Guid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from basket_keep");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
            parameters[0].Value = Guid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(AM.Model.basket_keep model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into basket_keep(");
            strSql.Append("Guid,userid,CreateDate,sbxh,azdw,sccj,tsjbh,aqscxkzbh,aqsbh,ccrq,yssl,cpcchgzjyjg,cpcchgzjl,cpcchgznz,cqdjzjyjg,cqdjzjl,cqdjzbz,aqsbdzsjyjg,aqsbdzsjl,aqsbdzsbz,sysmsjyjg,sysmsjl,sysmsbz,gsscsbgjyjg,gsscsbgjl,gsscsbgbz,aqscsbgjyjg,aqscsbgjl,aqscsbgbz,zyslgjczzmjyjg,zyslgjczzmjl,zyslgjczzmbz,dlzcbyjljyjg,dlzcbyjljl,dlzcbyjlbz,xxlwjyjg,xxlwjl,xxlwbz,zyslgjyfhcjsjyqjyjg,zyslgjyfhcjsjyqjl,zyslgjyfhcjsjyqbz,jgjyjg,jgjl,jgbz,jgjgljlsyqqjyjg,jgjgljlsyqqjl,jgjgljlsyqqbz,gwwwjyjg,gwwwjl,gwwwbz,ywjyjg,ywjl,ywbz,jyjg41,jl41,bz41,jyjg42,jl42,bz42,jyjg43,jl43,bz43,jyjg51,jl51,bz51,jyjg52,jl52,bz52,jyjg6,jl6,bz6,jyjg71,jl71,bz71,jyjg72,jl72,bz72,jyjg73,jl73,bz73,jyjg8,jl8,bz8,jyjg91,jl91,bz91,jyjg92,jl92,bz92,jyjg93,jl93,bz93)");
            strSql.Append(" values (");
            strSql.Append("@Guid,@userid,@CreateDate,@sbxh,@azdw,@sccj,@tsjbh,@aqscxkzbh,@aqsbh,@ccrq,@yssl,@cpcchgzjyjg,@cpcchgzjl,@cpcchgznz,@cqdjzjyjg,@cqdjzjl,@cqdjzbz,@aqsbdzsjyjg,@aqsbdzsjl,@aqsbdzsbz,@sysmsjyjg,@sysmsjl,@sysmsbz,@gsscsbgjyjg,@gsscsbgjl,@gsscsbgbz,@aqscsbgjyjg,@aqscsbgjl,@aqscsbgbz,@zyslgjczzmjyjg,@zyslgjczzmjl,@zyslgjczzmbz,@dlzcbyjljyjg,@dlzcbyjljl,@dlzcbyjlbz,@xxlwjyjg,@xxlwjl,@xxlwbz,@zyslgjyfhcjsjyqjyjg,@zyslgjyfhcjsjyqjl,@zyslgjyfhcjsjyqbz,@jgjyjg,@jgjl,@jgbz,@jgjgljlsyqqjyjg,@jgjgljlsyqqjl,@jgjgljlsyqqbz,@gwwwjyjg,@gwwwjl,@gwwwbz,@ywjyjg,@ywjl,@ywbz,@jyjg41,@jl41,@bz41,@jyjg42,@jl42,@bz42,@jyjg43,@jl43,@bz43,@jyjg51,@jl51,@bz51,@jyjg52,@jl52,@bz52,@jyjg6,@jl6,@bz6,@jyjg71,@jl71,@bz71,@jyjg72,@jl72,@bz72,@jyjg73,@jl73,@bz73,@jyjg8,@jl8,@bz8,@jyjg91,@jl91,@bz91,@jyjg92,@jl92,@bz92,@jyjg93,@jl93,@bz93)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@sbxh", MySqlDbType.Text),
					new MySqlParameter("@azdw", MySqlDbType.Text),
					new MySqlParameter("@sccj", MySqlDbType.Text),
					new MySqlParameter("@tsjbh", MySqlDbType.Text),
					new MySqlParameter("@aqscxkzbh", MySqlDbType.Text),
					new MySqlParameter("@aqsbh", MySqlDbType.Text),
					new MySqlParameter("@ccrq", MySqlDbType.Text),
					new MySqlParameter("@yssl", MySqlDbType.Text),
					new MySqlParameter("@cpcchgzjyjg", MySqlDbType.Text),
					new MySqlParameter("@cpcchgzjl", MySqlDbType.Text),
					new MySqlParameter("@cpcchgznz", MySqlDbType.Text),
					new MySqlParameter("@cqdjzjyjg", MySqlDbType.Text),
					new MySqlParameter("@cqdjzjl", MySqlDbType.Text),
					new MySqlParameter("@cqdjzbz", MySqlDbType.Text),
					new MySqlParameter("@aqsbdzsjyjg", MySqlDbType.Text),
					new MySqlParameter("@aqsbdzsjl", MySqlDbType.Text),
					new MySqlParameter("@aqsbdzsbz", MySqlDbType.Text),
					new MySqlParameter("@sysmsjyjg", MySqlDbType.Text),
					new MySqlParameter("@sysmsjl", MySqlDbType.Text),
					new MySqlParameter("@sysmsbz", MySqlDbType.Text),
					new MySqlParameter("@gsscsbgjyjg", MySqlDbType.Text),
					new MySqlParameter("@gsscsbgjl", MySqlDbType.Text),
					new MySqlParameter("@gsscsbgbz", MySqlDbType.Text),
					new MySqlParameter("@aqscsbgjyjg", MySqlDbType.Text),
					new MySqlParameter("@aqscsbgjl", MySqlDbType.Text),
					new MySqlParameter("@aqscsbgbz", MySqlDbType.Text),
					new MySqlParameter("@zyslgjczzmjyjg", MySqlDbType.Text),
					new MySqlParameter("@zyslgjczzmjl", MySqlDbType.Text),
					new MySqlParameter("@zyslgjczzmbz", MySqlDbType.Text),
					new MySqlParameter("@dlzcbyjljyjg", MySqlDbType.Text),
					new MySqlParameter("@dlzcbyjljl", MySqlDbType.Text),
					new MySqlParameter("@dlzcbyjlbz", MySqlDbType.Text),
					new MySqlParameter("@xxlwjyjg", MySqlDbType.Text),
					new MySqlParameter("@xxlwjl", MySqlDbType.Text),
					new MySqlParameter("@xxlwbz", MySqlDbType.Text),
					new MySqlParameter("@zyslgjyfhcjsjyqjyjg", MySqlDbType.Text),
					new MySqlParameter("@zyslgjyfhcjsjyqjl", MySqlDbType.Text),
					new MySqlParameter("@zyslgjyfhcjsjyqbz", MySqlDbType.Text),
					new MySqlParameter("@jgjyjg", MySqlDbType.Text),
					new MySqlParameter("@jgjl", MySqlDbType.Text),
					new MySqlParameter("@jgbz", MySqlDbType.Text),
					new MySqlParameter("@jgjgljlsyqqjyjg", MySqlDbType.Text),
					new MySqlParameter("@jgjgljlsyqqjl", MySqlDbType.Text),
					new MySqlParameter("@jgjgljlsyqqbz", MySqlDbType.Text),
					new MySqlParameter("@gwwwjyjg", MySqlDbType.Text),
					new MySqlParameter("@gwwwjl", MySqlDbType.Text),
					new MySqlParameter("@gwwwbz", MySqlDbType.Text),
					new MySqlParameter("@ywjyjg", MySqlDbType.Text),
					new MySqlParameter("@ywjl", MySqlDbType.Text),
					new MySqlParameter("@ywbz", MySqlDbType.Text),
					new MySqlParameter("@jyjg41", MySqlDbType.Text),
					new MySqlParameter("@jl41", MySqlDbType.Text),
					new MySqlParameter("@bz41", MySqlDbType.Text),
					new MySqlParameter("@jyjg42", MySqlDbType.Text),
					new MySqlParameter("@jl42", MySqlDbType.Text),
					new MySqlParameter("@bz42", MySqlDbType.Text),
					new MySqlParameter("@jyjg43", MySqlDbType.Text),
					new MySqlParameter("@jl43", MySqlDbType.Text),
					new MySqlParameter("@bz43", MySqlDbType.Text),
					new MySqlParameter("@jyjg51", MySqlDbType.Text),
					new MySqlParameter("@jl51", MySqlDbType.Text),
					new MySqlParameter("@bz51", MySqlDbType.Text),
					new MySqlParameter("@jyjg52", MySqlDbType.Text),
					new MySqlParameter("@jl52", MySqlDbType.Text),
					new MySqlParameter("@bz52", MySqlDbType.Text),
					new MySqlParameter("@jyjg6", MySqlDbType.Text),
					new MySqlParameter("@jl6", MySqlDbType.Text),
					new MySqlParameter("@bz6", MySqlDbType.Text),
					new MySqlParameter("@jyjg71", MySqlDbType.Text),
					new MySqlParameter("@jl71", MySqlDbType.Text),
					new MySqlParameter("@bz71", MySqlDbType.Text),
					new MySqlParameter("@jyjg72", MySqlDbType.Text),
					new MySqlParameter("@jl72", MySqlDbType.Text),
					new MySqlParameter("@bz72", MySqlDbType.Text),
					new MySqlParameter("@jyjg73", MySqlDbType.Text),
					new MySqlParameter("@jl73", MySqlDbType.Text),
					new MySqlParameter("@bz73", MySqlDbType.Text),
					new MySqlParameter("@jyjg8", MySqlDbType.Text),
					new MySqlParameter("@jl8", MySqlDbType.Text),
					new MySqlParameter("@bz8", MySqlDbType.Text),
					new MySqlParameter("@jyjg91", MySqlDbType.Text),
					new MySqlParameter("@jl91", MySqlDbType.Text),
					new MySqlParameter("@bz91", MySqlDbType.Text),
					new MySqlParameter("@jyjg92", MySqlDbType.Text),
					new MySqlParameter("@jl92", MySqlDbType.Text),
					new MySqlParameter("@bz92", MySqlDbType.Text),
					new MySqlParameter("@jyjg93", MySqlDbType.Text),
					new MySqlParameter("@jl93", MySqlDbType.Text),
					new MySqlParameter("@bz93", MySqlDbType.Text)};
            parameters[0].Value = model.Guid;
            parameters[1].Value = model.userid;
            parameters[2].Value = model.CreateDate;
            parameters[3].Value = model.sbxh;
            parameters[4].Value = model.azdw;
            parameters[5].Value = model.sccj;
            parameters[6].Value = model.tsjbh;
            parameters[7].Value = model.aqscxkzbh;
            parameters[8].Value = model.aqsbh;
            parameters[9].Value = model.ccrq;
            parameters[10].Value = model.yssl;
            parameters[11].Value = model.cpcchgzjyjg;
            parameters[12].Value = model.cpcchgzjl;
            parameters[13].Value = model.cpcchgznz;
            parameters[14].Value = model.cqdjzjyjg;
            parameters[15].Value = model.cqdjzjl;
            parameters[16].Value = model.cqdjzbz;
            parameters[17].Value = model.aqsbdzsjyjg;
            parameters[18].Value = model.aqsbdzsjl;
            parameters[19].Value = model.aqsbdzsbz;
            parameters[20].Value = model.sysmsjyjg;
            parameters[21].Value = model.sysmsjl;
            parameters[22].Value = model.sysmsbz;
            parameters[23].Value = model.gsscsbgjyjg;
            parameters[24].Value = model.gsscsbgjl;
            parameters[25].Value = model.gsscsbgbz;
            parameters[26].Value = model.aqscsbgjyjg;
            parameters[27].Value = model.aqscsbgjl;
            parameters[28].Value = model.aqscsbgbz;
            parameters[29].Value = model.zyslgjczzmjyjg;
            parameters[30].Value = model.zyslgjczzmjl;
            parameters[31].Value = model.zyslgjczzmbz;
            parameters[32].Value = model.dlzcbyjljyjg;
            parameters[33].Value = model.dlzcbyjljl;
            parameters[34].Value = model.dlzcbyjlbz;
            parameters[35].Value = model.xxlwjyjg;
            parameters[36].Value = model.xxlwjl;
            parameters[37].Value = model.xxlwbz;
            parameters[38].Value = model.zyslgjyfhcjsjyqjyjg;
            parameters[39].Value = model.zyslgjyfhcjsjyqjl;
            parameters[40].Value = model.zyslgjyfhcjsjyqbz;
            parameters[41].Value = model.jgjyjg;
            parameters[42].Value = model.jgjl;
            parameters[43].Value = model.jgbz;
            parameters[44].Value = model.jgjgljlsyqqjyjg;
            parameters[45].Value = model.jgjgljlsyqqjl;
            parameters[46].Value = model.jgjgljlsyqqbz;
            parameters[47].Value = model.gwwwjyjg;
            parameters[48].Value = model.gwwwjl;
            parameters[49].Value = model.gwwwbz;
            parameters[50].Value = model.ywjyjg;
            parameters[51].Value = model.ywjl;
            parameters[52].Value = model.ywbz;
            parameters[53].Value = model.jyjg41;
            parameters[54].Value = model.jl41;
            parameters[55].Value = model.bz41;
            parameters[56].Value = model.jyjg42;
            parameters[57].Value = model.jl42;
            parameters[58].Value = model.bz42;
            parameters[59].Value = model.jyjg43;
            parameters[60].Value = model.jl43;
            parameters[61].Value = model.bz43;
            parameters[62].Value = model.jyjg51;
            parameters[63].Value = model.jl51;
            parameters[64].Value = model.bz51;
            parameters[65].Value = model.jyjg52;
            parameters[66].Value = model.jl52;
            parameters[67].Value = model.bz52;
            parameters[68].Value = model.jyjg6;
            parameters[69].Value = model.jl6;
            parameters[70].Value = model.bz6;
            parameters[71].Value = model.jyjg71;
            parameters[72].Value = model.jl71;
            parameters[73].Value = model.bz71;
            parameters[74].Value = model.jyjg72;
            parameters[75].Value = model.jl72;
            parameters[76].Value = model.bz72;
            parameters[77].Value = model.jyjg73;
            parameters[78].Value = model.jl73;
            parameters[79].Value = model.bz73;
            parameters[80].Value = model.jyjg8;
            parameters[81].Value = model.jl8;
            parameters[82].Value = model.bz8;
            parameters[83].Value = model.jyjg91;
            parameters[84].Value = model.jl91;
            parameters[85].Value = model.bz91;
            parameters[86].Value = model.jyjg92;
            parameters[87].Value = model.jl92;
            parameters[88].Value = model.bz92;
            parameters[89].Value = model.jyjg93;
            parameters[90].Value = model.jl93;
            parameters[91].Value = model.bz93;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(AM.Model.basket_keep model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update basket_keep set ");
            strSql.Append("userid=@userid,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("sbxh=@sbxh,");
            strSql.Append("azdw=@azdw,");
            strSql.Append("sccj=@sccj,");
            strSql.Append("tsjbh=@tsjbh,");
            strSql.Append("aqscxkzbh=@aqscxkzbh,");
            strSql.Append("aqsbh=@aqsbh,");
            strSql.Append("ccrq=@ccrq,");
            strSql.Append("yssl=@yssl,");
            strSql.Append("cpcchgzjyjg=@cpcchgzjyjg,");
            strSql.Append("cpcchgzjl=@cpcchgzjl,");
            strSql.Append("cpcchgznz=@cpcchgznz,");
            strSql.Append("cqdjzjyjg=@cqdjzjyjg,");
            strSql.Append("cqdjzjl=@cqdjzjl,");
            strSql.Append("cqdjzbz=@cqdjzbz,");
            strSql.Append("aqsbdzsjyjg=@aqsbdzsjyjg,");
            strSql.Append("aqsbdzsjl=@aqsbdzsjl,");
            strSql.Append("aqsbdzsbz=@aqsbdzsbz,");
            strSql.Append("sysmsjyjg=@sysmsjyjg,");
            strSql.Append("sysmsjl=@sysmsjl,");
            strSql.Append("sysmsbz=@sysmsbz,");
            strSql.Append("gsscsbgjyjg=@gsscsbgjyjg,");
            strSql.Append("gsscsbgjl=@gsscsbgjl,");
            strSql.Append("gsscsbgbz=@gsscsbgbz,");
            strSql.Append("aqscsbgjyjg=@aqscsbgjyjg,");
            strSql.Append("aqscsbgjl=@aqscsbgjl,");
            strSql.Append("aqscsbgbz=@aqscsbgbz,");
            strSql.Append("zyslgjczzmjyjg=@zyslgjczzmjyjg,");
            strSql.Append("zyslgjczzmjl=@zyslgjczzmjl,");
            strSql.Append("zyslgjczzmbz=@zyslgjczzmbz,");
            strSql.Append("dlzcbyjljyjg=@dlzcbyjljyjg,");
            strSql.Append("dlzcbyjljl=@dlzcbyjljl,");
            strSql.Append("dlzcbyjlbz=@dlzcbyjlbz,");
            strSql.Append("xxlwjyjg=@xxlwjyjg,");
            strSql.Append("xxlwjl=@xxlwjl,");
            strSql.Append("xxlwbz=@xxlwbz,");
            strSql.Append("zyslgjyfhcjsjyqjyjg=@zyslgjyfhcjsjyqjyjg,");
            strSql.Append("zyslgjyfhcjsjyqjl=@zyslgjyfhcjsjyqjl,");
            strSql.Append("zyslgjyfhcjsjyqbz=@zyslgjyfhcjsjyqbz,");
            strSql.Append("jgjyjg=@jgjyjg,");
            strSql.Append("jgjl=@jgjl,");
            strSql.Append("jgbz=@jgbz,");
            strSql.Append("jgjgljlsyqqjyjg=@jgjgljlsyqqjyjg,");
            strSql.Append("jgjgljlsyqqjl=@jgjgljlsyqqjl,");
            strSql.Append("jgjgljlsyqqbz=@jgjgljlsyqqbz,");
            strSql.Append("gwwwjyjg=@gwwwjyjg,");
            strSql.Append("gwwwjl=@gwwwjl,");
            strSql.Append("gwwwbz=@gwwwbz,");
            strSql.Append("ywjyjg=@ywjyjg,");
            strSql.Append("ywjl=@ywjl,");
            strSql.Append("ywbz=@ywbz,");
            strSql.Append("jyjg41=@jyjg41,");
            strSql.Append("jl41=@jl41,");
            strSql.Append("bz41=@bz41,");
            strSql.Append("jyjg42=@jyjg42,");
            strSql.Append("jl42=@jl42,");
            strSql.Append("bz42=@bz42,");
            strSql.Append("jyjg43=@jyjg43,");
            strSql.Append("jl43=@jl43,");
            strSql.Append("bz43=@bz43,");
            strSql.Append("jyjg51=@jyjg51,");
            strSql.Append("jl51=@jl51,");
            strSql.Append("bz51=@bz51,");
            strSql.Append("jyjg52=@jyjg52,");
            strSql.Append("jl52=@jl52,");
            strSql.Append("bz52=@bz52,");
            strSql.Append("jyjg6=@jyjg6,");
            strSql.Append("jl6=@jl6,");
            strSql.Append("bz6=@bz6,");
            strSql.Append("jyjg71=@jyjg71,");
            strSql.Append("jl71=@jl71,");
            strSql.Append("bz71=@bz71,");
            strSql.Append("jyjg72=@jyjg72,");
            strSql.Append("jl72=@jl72,");
            strSql.Append("bz72=@bz72,");
            strSql.Append("jyjg73=@jyjg73,");
            strSql.Append("jl73=@jl73,");
            strSql.Append("bz73=@bz73,");
            strSql.Append("jyjg8=@jyjg8,");
            strSql.Append("jl8=@jl8,");
            strSql.Append("bz8=@bz8,");
            strSql.Append("jyjg91=@jyjg91,");
            strSql.Append("jl91=@jl91,");
            strSql.Append("bz91=@bz91,");
            strSql.Append("jyjg92=@jyjg92,");
            strSql.Append("jl92=@jl92,");
            strSql.Append("bz92=@bz92,");
            strSql.Append("jyjg93=@jyjg93,");
            strSql.Append("jl93=@jl93,");
            strSql.Append("bz93=@bz93");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@sbxh", MySqlDbType.Text),
					new MySqlParameter("@azdw", MySqlDbType.Text),
					new MySqlParameter("@sccj", MySqlDbType.Text),
					new MySqlParameter("@tsjbh", MySqlDbType.Text),
					new MySqlParameter("@aqscxkzbh", MySqlDbType.Text),
					new MySqlParameter("@aqsbh", MySqlDbType.Text),
					new MySqlParameter("@ccrq", MySqlDbType.Text),
					new MySqlParameter("@yssl", MySqlDbType.Text),
					new MySqlParameter("@cpcchgzjyjg", MySqlDbType.Text),
					new MySqlParameter("@cpcchgzjl", MySqlDbType.Text),
					new MySqlParameter("@cpcchgznz", MySqlDbType.Text),
					new MySqlParameter("@cqdjzjyjg", MySqlDbType.Text),
					new MySqlParameter("@cqdjzjl", MySqlDbType.Text),
					new MySqlParameter("@cqdjzbz", MySqlDbType.Text),
					new MySqlParameter("@aqsbdzsjyjg", MySqlDbType.Text),
					new MySqlParameter("@aqsbdzsjl", MySqlDbType.Text),
					new MySqlParameter("@aqsbdzsbz", MySqlDbType.Text),
					new MySqlParameter("@sysmsjyjg", MySqlDbType.Text),
					new MySqlParameter("@sysmsjl", MySqlDbType.Text),
					new MySqlParameter("@sysmsbz", MySqlDbType.Text),
					new MySqlParameter("@gsscsbgjyjg", MySqlDbType.Text),
					new MySqlParameter("@gsscsbgjl", MySqlDbType.Text),
					new MySqlParameter("@gsscsbgbz", MySqlDbType.Text),
					new MySqlParameter("@aqscsbgjyjg", MySqlDbType.Text),
					new MySqlParameter("@aqscsbgjl", MySqlDbType.Text),
					new MySqlParameter("@aqscsbgbz", MySqlDbType.Text),
					new MySqlParameter("@zyslgjczzmjyjg", MySqlDbType.Text),
					new MySqlParameter("@zyslgjczzmjl", MySqlDbType.Text),
					new MySqlParameter("@zyslgjczzmbz", MySqlDbType.Text),
					new MySqlParameter("@dlzcbyjljyjg", MySqlDbType.Text),
					new MySqlParameter("@dlzcbyjljl", MySqlDbType.Text),
					new MySqlParameter("@dlzcbyjlbz", MySqlDbType.Text),
					new MySqlParameter("@xxlwjyjg", MySqlDbType.Text),
					new MySqlParameter("@xxlwjl", MySqlDbType.Text),
					new MySqlParameter("@xxlwbz", MySqlDbType.Text),
					new MySqlParameter("@zyslgjyfhcjsjyqjyjg", MySqlDbType.Text),
					new MySqlParameter("@zyslgjyfhcjsjyqjl", MySqlDbType.Text),
					new MySqlParameter("@zyslgjyfhcjsjyqbz", MySqlDbType.Text),
					new MySqlParameter("@jgjyjg", MySqlDbType.Text),
					new MySqlParameter("@jgjl", MySqlDbType.Text),
					new MySqlParameter("@jgbz", MySqlDbType.Text),
					new MySqlParameter("@jgjgljlsyqqjyjg", MySqlDbType.Text),
					new MySqlParameter("@jgjgljlsyqqjl", MySqlDbType.Text),
					new MySqlParameter("@jgjgljlsyqqbz", MySqlDbType.Text),
					new MySqlParameter("@gwwwjyjg", MySqlDbType.Text),
					new MySqlParameter("@gwwwjl", MySqlDbType.Text),
					new MySqlParameter("@gwwwbz", MySqlDbType.Text),
					new MySqlParameter("@ywjyjg", MySqlDbType.Text),
					new MySqlParameter("@ywjl", MySqlDbType.Text),
					new MySqlParameter("@ywbz", MySqlDbType.Text),
					new MySqlParameter("@jyjg41", MySqlDbType.Text),
					new MySqlParameter("@jl41", MySqlDbType.Text),
					new MySqlParameter("@bz41", MySqlDbType.Text),
					new MySqlParameter("@jyjg42", MySqlDbType.Text),
					new MySqlParameter("@jl42", MySqlDbType.Text),
					new MySqlParameter("@bz42", MySqlDbType.Text),
					new MySqlParameter("@jyjg43", MySqlDbType.Text),
					new MySqlParameter("@jl43", MySqlDbType.Text),
					new MySqlParameter("@bz43", MySqlDbType.Text),
					new MySqlParameter("@jyjg51", MySqlDbType.Text),
					new MySqlParameter("@jl51", MySqlDbType.Text),
					new MySqlParameter("@bz51", MySqlDbType.Text),
					new MySqlParameter("@jyjg52", MySqlDbType.Text),
					new MySqlParameter("@jl52", MySqlDbType.Text),
					new MySqlParameter("@bz52", MySqlDbType.Text),
					new MySqlParameter("@jyjg6", MySqlDbType.Text),
					new MySqlParameter("@jl6", MySqlDbType.Text),
					new MySqlParameter("@bz6", MySqlDbType.Text),
					new MySqlParameter("@jyjg71", MySqlDbType.Text),
					new MySqlParameter("@jl71", MySqlDbType.Text),
					new MySqlParameter("@bz71", MySqlDbType.Text),
					new MySqlParameter("@jyjg72", MySqlDbType.Text),
					new MySqlParameter("@jl72", MySqlDbType.Text),
					new MySqlParameter("@bz72", MySqlDbType.Text),
					new MySqlParameter("@jyjg73", MySqlDbType.Text),
					new MySqlParameter("@jl73", MySqlDbType.Text),
					new MySqlParameter("@bz73", MySqlDbType.Text),
					new MySqlParameter("@jyjg8", MySqlDbType.Text),
					new MySqlParameter("@jl8", MySqlDbType.Text),
					new MySqlParameter("@bz8", MySqlDbType.Text),
					new MySqlParameter("@jyjg91", MySqlDbType.Text),
					new MySqlParameter("@jl91", MySqlDbType.Text),
					new MySqlParameter("@bz91", MySqlDbType.Text),
					new MySqlParameter("@jyjg92", MySqlDbType.Text),
					new MySqlParameter("@jl92", MySqlDbType.Text),
					new MySqlParameter("@bz92", MySqlDbType.Text),
					new MySqlParameter("@jyjg93", MySqlDbType.Text),
					new MySqlParameter("@jl93", MySqlDbType.Text),
					new MySqlParameter("@bz93", MySqlDbType.Text),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
            parameters[0].Value = model.userid;
            parameters[1].Value = model.CreateDate;
            parameters[2].Value = model.sbxh;
            parameters[3].Value = model.azdw;
            parameters[4].Value = model.sccj;
            parameters[5].Value = model.tsjbh;
            parameters[6].Value = model.aqscxkzbh;
            parameters[7].Value = model.aqsbh;
            parameters[8].Value = model.ccrq;
            parameters[9].Value = model.yssl;
            parameters[10].Value = model.cpcchgzjyjg;
            parameters[11].Value = model.cpcchgzjl;
            parameters[12].Value = model.cpcchgznz;
            parameters[13].Value = model.cqdjzjyjg;
            parameters[14].Value = model.cqdjzjl;
            parameters[15].Value = model.cqdjzbz;
            parameters[16].Value = model.aqsbdzsjyjg;
            parameters[17].Value = model.aqsbdzsjl;
            parameters[18].Value = model.aqsbdzsbz;
            parameters[19].Value = model.sysmsjyjg;
            parameters[20].Value = model.sysmsjl;
            parameters[21].Value = model.sysmsbz;
            parameters[22].Value = model.gsscsbgjyjg;
            parameters[23].Value = model.gsscsbgjl;
            parameters[24].Value = model.gsscsbgbz;
            parameters[25].Value = model.aqscsbgjyjg;
            parameters[26].Value = model.aqscsbgjl;
            parameters[27].Value = model.aqscsbgbz;
            parameters[28].Value = model.zyslgjczzmjyjg;
            parameters[29].Value = model.zyslgjczzmjl;
            parameters[30].Value = model.zyslgjczzmbz;
            parameters[31].Value = model.dlzcbyjljyjg;
            parameters[32].Value = model.dlzcbyjljl;
            parameters[33].Value = model.dlzcbyjlbz;
            parameters[34].Value = model.xxlwjyjg;
            parameters[35].Value = model.xxlwjl;
            parameters[36].Value = model.xxlwbz;
            parameters[37].Value = model.zyslgjyfhcjsjyqjyjg;
            parameters[38].Value = model.zyslgjyfhcjsjyqjl;
            parameters[39].Value = model.zyslgjyfhcjsjyqbz;
            parameters[40].Value = model.jgjyjg;
            parameters[41].Value = model.jgjl;
            parameters[42].Value = model.jgbz;
            parameters[43].Value = model.jgjgljlsyqqjyjg;
            parameters[44].Value = model.jgjgljlsyqqjl;
            parameters[45].Value = model.jgjgljlsyqqbz;
            parameters[46].Value = model.gwwwjyjg;
            parameters[47].Value = model.gwwwjl;
            parameters[48].Value = model.gwwwbz;
            parameters[49].Value = model.ywjyjg;
            parameters[50].Value = model.ywjl;
            parameters[51].Value = model.ywbz;
            parameters[52].Value = model.jyjg41;
            parameters[53].Value = model.jl41;
            parameters[54].Value = model.bz41;
            parameters[55].Value = model.jyjg42;
            parameters[56].Value = model.jl42;
            parameters[57].Value = model.bz42;
            parameters[58].Value = model.jyjg43;
            parameters[59].Value = model.jl43;
            parameters[60].Value = model.bz43;
            parameters[61].Value = model.jyjg51;
            parameters[62].Value = model.jl51;
            parameters[63].Value = model.bz51;
            parameters[64].Value = model.jyjg52;
            parameters[65].Value = model.jl52;
            parameters[66].Value = model.bz52;
            parameters[67].Value = model.jyjg6;
            parameters[68].Value = model.jl6;
            parameters[69].Value = model.bz6;
            parameters[70].Value = model.jyjg71;
            parameters[71].Value = model.jl71;
            parameters[72].Value = model.bz71;
            parameters[73].Value = model.jyjg72;
            parameters[74].Value = model.jl72;
            parameters[75].Value = model.bz72;
            parameters[76].Value = model.jyjg73;
            parameters[77].Value = model.jl73;
            parameters[78].Value = model.bz73;
            parameters[79].Value = model.jyjg8;
            parameters[80].Value = model.jl8;
            parameters[81].Value = model.bz8;
            parameters[82].Value = model.jyjg91;
            parameters[83].Value = model.jl91;
            parameters[84].Value = model.bz91;
            parameters[85].Value = model.jyjg92;
            parameters[86].Value = model.jl92;
            parameters[87].Value = model.bz92;
            parameters[88].Value = model.jyjg93;
            parameters[89].Value = model.jl93;
            parameters[90].Value = model.bz93;
            parameters[91].Value = model.Guid;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from basket_keep ");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
            parameters[0].Value = Guid;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Guidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from basket_keep ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public AM.Model.basket_keep GetModel(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Guid,userid,CreateDate,sbxh,azdw,sccj,tsjbh,aqscxkzbh,aqsbh,ccrq,yssl,cpcchgzjyjg,cpcchgzjl,cpcchgznz,cqdjzjyjg,cqdjzjl,cqdjzbz,aqsbdzsjyjg,aqsbdzsjl,aqsbdzsbz,sysmsjyjg,sysmsjl,sysmsbz,gsscsbgjyjg,gsscsbgjl,gsscsbgbz,aqscsbgjyjg,aqscsbgjl,aqscsbgbz,zyslgjczzmjyjg,zyslgjczzmjl,zyslgjczzmbz,dlzcbyjljyjg,dlzcbyjljl,dlzcbyjlbz,xxlwjyjg,xxlwjl,xxlwbz,zyslgjyfhcjsjyqjyjg,zyslgjyfhcjsjyqjl,zyslgjyfhcjsjyqbz,jgjyjg,jgjl,jgbz,jgjgljlsyqqjyjg,jgjgljlsyqqjl,jgjgljlsyqqbz,gwwwjyjg,gwwwjl,gwwwbz,ywjyjg,ywjl,ywbz,jyjg41,jl41,bz41,jyjg42,jl42,bz42,jyjg43,jl43,bz43,jyjg51,jl51,bz51,jyjg52,jl52,bz52,jyjg6,jl6,bz6,jyjg71,jl71,bz71,jyjg72,jl72,bz72,jyjg73,jl73,bz73,jyjg8,jl8,bz8,jyjg91,jl91,bz91,jyjg92,jl92,bz92,jyjg93,jl93,bz93 from basket_keep ");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
            parameters[0].Value = Guid;

            AM.Model.basket_keep model = new AM.Model.basket_keep();
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public AM.Model.basket_keep DataRowToModel(DataRow row)
        {
            AM.Model.basket_keep model = new AM.Model.basket_keep();
            if (row != null)
            {
                if (row["Guid"] != null)
                {
                    model.Guid = row["Guid"].ToString();
                }
                if (row["userid"] != null)
                {
                    model.userid = row["userid"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["sbxh"] != null)
                {
                    model.sbxh = row["sbxh"].ToString();
                }
                if (row["azdw"] != null)
                {
                    model.azdw = row["azdw"].ToString();
                }
                if (row["sccj"] != null)
                {
                    model.sccj = row["sccj"].ToString();
                }
                if (row["tsjbh"] != null)
                {
                    model.tsjbh = row["tsjbh"].ToString();
                }
                if (row["aqscxkzbh"] != null)
                {
                    model.aqscxkzbh = row["aqscxkzbh"].ToString();
                }
                if (row["aqsbh"] != null)
                {
                    model.aqsbh = row["aqsbh"].ToString();
                }
                if (row["ccrq"] != null)
                {
                    model.ccrq = row["ccrq"].ToString();
                }
                if (row["yssl"] != null)
                {
                    model.yssl = row["yssl"].ToString();
                }
                if (row["cpcchgzjyjg"] != null)
                {
                    model.cpcchgzjyjg = row["cpcchgzjyjg"].ToString();
                }
                if (row["cpcchgzjl"] != null)
                {
                    model.cpcchgzjl = row["cpcchgzjl"].ToString();
                }
                if (row["cpcchgznz"] != null)
                {
                    model.cpcchgznz = row["cpcchgznz"].ToString();
                }
                if (row["cqdjzjyjg"] != null)
                {
                    model.cqdjzjyjg = row["cqdjzjyjg"].ToString();
                }
                if (row["cqdjzjl"] != null)
                {
                    model.cqdjzjl = row["cqdjzjl"].ToString();
                }
                if (row["cqdjzbz"] != null)
                {
                    model.cqdjzbz = row["cqdjzbz"].ToString();
                }
                if (row["aqsbdzsjyjg"] != null)
                {
                    model.aqsbdzsjyjg = row["aqsbdzsjyjg"].ToString();
                }
                if (row["aqsbdzsjl"] != null)
                {
                    model.aqsbdzsjl = row["aqsbdzsjl"].ToString();
                }
                if (row["aqsbdzsbz"] != null)
                {
                    model.aqsbdzsbz = row["aqsbdzsbz"].ToString();
                }
                if (row["sysmsjyjg"] != null)
                {
                    model.sysmsjyjg = row["sysmsjyjg"].ToString();
                }
                if (row["sysmsjl"] != null)
                {
                    model.sysmsjl = row["sysmsjl"].ToString();
                }
                if (row["sysmsbz"] != null)
                {
                    model.sysmsbz = row["sysmsbz"].ToString();
                }
                if (row["gsscsbgjyjg"] != null)
                {
                    model.gsscsbgjyjg = row["gsscsbgjyjg"].ToString();
                }
                if (row["gsscsbgjl"] != null)
                {
                    model.gsscsbgjl = row["gsscsbgjl"].ToString();
                }
                if (row["gsscsbgbz"] != null)
                {
                    model.gsscsbgbz = row["gsscsbgbz"].ToString();
                }
                if (row["aqscsbgjyjg"] != null)
                {
                    model.aqscsbgjyjg = row["aqscsbgjyjg"].ToString();
                }
                if (row["aqscsbgjl"] != null)
                {
                    model.aqscsbgjl = row["aqscsbgjl"].ToString();
                }
                if (row["aqscsbgbz"] != null)
                {
                    model.aqscsbgbz = row["aqscsbgbz"].ToString();
                }
                if (row["zyslgjczzmjyjg"] != null)
                {
                    model.zyslgjczzmjyjg = row["zyslgjczzmjyjg"].ToString();
                }
                if (row["zyslgjczzmjl"] != null)
                {
                    model.zyslgjczzmjl = row["zyslgjczzmjl"].ToString();
                }
                if (row["zyslgjczzmbz"] != null)
                {
                    model.zyslgjczzmbz = row["zyslgjczzmbz"].ToString();
                }
                if (row["dlzcbyjljyjg"] != null)
                {
                    model.dlzcbyjljyjg = row["dlzcbyjljyjg"].ToString();
                }
                if (row["dlzcbyjljl"] != null)
                {
                    model.dlzcbyjljl = row["dlzcbyjljl"].ToString();
                }
                if (row["dlzcbyjlbz"] != null)
                {
                    model.dlzcbyjlbz = row["dlzcbyjlbz"].ToString();
                }
                if (row["xxlwjyjg"] != null)
                {
                    model.xxlwjyjg = row["xxlwjyjg"].ToString();
                }
                if (row["xxlwjl"] != null)
                {
                    model.xxlwjl = row["xxlwjl"].ToString();
                }
                if (row["xxlwbz"] != null)
                {
                    model.xxlwbz = row["xxlwbz"].ToString();
                }
                if (row["zyslgjyfhcjsjyqjyjg"] != null)
                {
                    model.zyslgjyfhcjsjyqjyjg = row["zyslgjyfhcjsjyqjyjg"].ToString();
                }
                if (row["zyslgjyfhcjsjyqjl"] != null)
                {
                    model.zyslgjyfhcjsjyqjl = row["zyslgjyfhcjsjyqjl"].ToString();
                }
                if (row["zyslgjyfhcjsjyqbz"] != null)
                {
                    model.zyslgjyfhcjsjyqbz = row["zyslgjyfhcjsjyqbz"].ToString();
                }
                if (row["jgjyjg"] != null)
                {
                    model.jgjyjg = row["jgjyjg"].ToString();
                }
                if (row["jgjl"] != null)
                {
                    model.jgjl = row["jgjl"].ToString();
                }
                if (row["jgbz"] != null)
                {
                    model.jgbz = row["jgbz"].ToString();
                }
                if (row["jgjgljlsyqqjyjg"] != null)
                {
                    model.jgjgljlsyqqjyjg = row["jgjgljlsyqqjyjg"].ToString();
                }
                if (row["jgjgljlsyqqjl"] != null)
                {
                    model.jgjgljlsyqqjl = row["jgjgljlsyqqjl"].ToString();
                }
                if (row["jgjgljlsyqqbz"] != null)
                {
                    model.jgjgljlsyqqbz = row["jgjgljlsyqqbz"].ToString();
                }
                if (row["gwwwjyjg"] != null)
                {
                    model.gwwwjyjg = row["gwwwjyjg"].ToString();
                }
                if (row["gwwwjl"] != null)
                {
                    model.gwwwjl = row["gwwwjl"].ToString();
                }
                if (row["gwwwbz"] != null)
                {
                    model.gwwwbz = row["gwwwbz"].ToString();
                }
                if (row["ywjyjg"] != null)
                {
                    model.ywjyjg = row["ywjyjg"].ToString();
                }
                if (row["ywjl"] != null)
                {
                    model.ywjl = row["ywjl"].ToString();
                }
                if (row["ywbz"] != null)
                {
                    model.ywbz = row["ywbz"].ToString();
                }
                if (row["jyjg41"] != null)
                {
                    model.jyjg41 = row["jyjg41"].ToString();
                }
                if (row["jl41"] != null)
                {
                    model.jl41 = row["jl41"].ToString();
                }
                if (row["bz41"] != null)
                {
                    model.bz41 = row["bz41"].ToString();
                }
                if (row["jyjg42"] != null)
                {
                    model.jyjg42 = row["jyjg42"].ToString();
                }
                if (row["jl42"] != null)
                {
                    model.jl42 = row["jl42"].ToString();
                }
                if (row["bz42"] != null)
                {
                    model.bz42 = row["bz42"].ToString();
                }
                if (row["jyjg43"] != null)
                {
                    model.jyjg43 = row["jyjg43"].ToString();
                }
                if (row["jl43"] != null)
                {
                    model.jl43 = row["jl43"].ToString();
                }
                if (row["bz43"] != null)
                {
                    model.bz43 = row["bz43"].ToString();
                }
                if (row["jyjg51"] != null)
                {
                    model.jyjg51 = row["jyjg51"].ToString();
                }
                if (row["jl51"] != null)
                {
                    model.jl51 = row["jl51"].ToString();
                }
                if (row["bz51"] != null)
                {
                    model.bz51 = row["bz51"].ToString();
                }
                if (row["jyjg52"] != null)
                {
                    model.jyjg52 = row["jyjg52"].ToString();
                }
                if (row["jl52"] != null)
                {
                    model.jl52 = row["jl52"].ToString();
                }
                if (row["bz52"] != null)
                {
                    model.bz52 = row["bz52"].ToString();
                }
                if (row["jyjg6"] != null)
                {
                    model.jyjg6 = row["jyjg6"].ToString();
                }
                if (row["jl6"] != null)
                {
                    model.jl6 = row["jl6"].ToString();
                }
                if (row["bz6"] != null)
                {
                    model.bz6 = row["bz6"].ToString();
                }
                if (row["jyjg71"] != null)
                {
                    model.jyjg71 = row["jyjg71"].ToString();
                }
                if (row["jl71"] != null)
                {
                    model.jl71 = row["jl71"].ToString();
                }
                if (row["bz71"] != null)
                {
                    model.bz71 = row["bz71"].ToString();
                }
                if (row["jyjg72"] != null)
                {
                    model.jyjg72 = row["jyjg72"].ToString();
                }
                if (row["jl72"] != null)
                {
                    model.jl72 = row["jl72"].ToString();
                }
                if (row["bz72"] != null)
                {
                    model.bz72 = row["bz72"].ToString();
                }
                if (row["jyjg73"] != null)
                {
                    model.jyjg73 = row["jyjg73"].ToString();
                }
                if (row["jl73"] != null)
                {
                    model.jl73 = row["jl73"].ToString();
                }
                if (row["bz73"] != null)
                {
                    model.bz73 = row["bz73"].ToString();
                }
                if (row["jyjg8"] != null)
                {
                    model.jyjg8 = row["jyjg8"].ToString();
                }
                if (row["jl8"] != null)
                {
                    model.jl8 = row["jl8"].ToString();
                }
                if (row["bz8"] != null)
                {
                    model.bz8 = row["bz8"].ToString();
                }
                if (row["jyjg91"] != null)
                {
                    model.jyjg91 = row["jyjg91"].ToString();
                }
                if (row["jl91"] != null)
                {
                    model.jl91 = row["jl91"].ToString();
                }
                if (row["bz91"] != null)
                {
                    model.bz91 = row["bz91"].ToString();
                }
                if (row["jyjg92"] != null)
                {
                    model.jyjg92 = row["jyjg92"].ToString();
                }
                if (row["jl92"] != null)
                {
                    model.jl92 = row["jl92"].ToString();
                }
                if (row["bz92"] != null)
                {
                    model.bz92 = row["bz92"].ToString();
                }
                if (row["jyjg93"] != null)
                {
                    model.jyjg93 = row["jyjg93"].ToString();
                }
                if (row["jl93"] != null)
                {
                    model.jl93 = row["jl93"].ToString();
                }
                if (row["bz93"] != null)
                {
                    model.bz93 = row["bz93"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Guid,userid,CreateDate,sbxh,azdw,sccj,tsjbh,aqscxkzbh,aqsbh,ccrq,yssl,cpcchgzjyjg,cpcchgzjl,cpcchgznz,cqdjzjyjg,cqdjzjl,cqdjzbz,aqsbdzsjyjg,aqsbdzsjl,aqsbdzsbz,sysmsjyjg,sysmsjl,sysmsbz,gsscsbgjyjg,gsscsbgjl,gsscsbgbz,aqscsbgjyjg,aqscsbgjl,aqscsbgbz,zyslgjczzmjyjg,zyslgjczzmjl,zyslgjczzmbz,dlzcbyjljyjg,dlzcbyjljl,dlzcbyjlbz,xxlwjyjg,xxlwjl,xxlwbz,zyslgjyfhcjsjyqjyjg,zyslgjyfhcjsjyqjl,zyslgjyfhcjsjyqbz,jgjyjg,jgjl,jgbz,jgjgljlsyqqjyjg,jgjgljlsyqqjl,jgjgljlsyqqbz,gwwwjyjg,gwwwjl,gwwwbz,ywjyjg,ywjl,ywbz,jyjg41,jl41,bz41,jyjg42,jl42,bz42,jyjg43,jl43,bz43,jyjg51,jl51,bz51,jyjg52,jl52,bz52,jyjg6,jl6,bz6,jyjg71,jl71,bz71,jyjg72,jl72,bz72,jyjg73,jl73,bz73,jyjg8,jl8,bz8,jyjg91,jl91,bz91,jyjg92,jl92,bz92,jyjg93,jl93,bz93 ");
            strSql.Append(" FROM basket_keep ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM basket_keep ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        public basket_keep GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from basket_keep ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            basket_keep model = new basket_keep();
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
            strSql.Append("select * from basket_keep ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM basket_keep TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM basket_keep TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

