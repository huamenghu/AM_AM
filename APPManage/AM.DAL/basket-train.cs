/**  版本信息模板在安装目录下，可自行修改。
* basket_train.cs
*
* 功 能： N/A
* 类 名： basket_train
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/10 10:46:45   N/A    初版
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
using Maticsoft.DBUtility;
using MySql.Data.MySqlClient;
using AM.Model;//Please add references
namespace AM.DAL
{
	/// <summary>
	/// 数据访问类:basket_train
	/// </summary>
	public partial class basket_trainDAL
	{
        public basket_trainDAL()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Guid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from basket_train");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)			};
            parameters[0].Value = Guid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(basket_train model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into basket_train(");
            strSql.Append("Guid,userid,CreateDate,xm,xb,whcd,lxdh,zygl,stzk,sfzh,gzdw,yb,yx,brqz,pxd,gzjl,szdwyj)");
            strSql.Append(" values (");
            strSql.Append("@Guid,@userid,@CreateDate,@xm,@xb,@whcd,@lxdh,@zygl,@stzk,@sfzh,@gzdw,@yb,@yx,@brqz,@pxd,@gzjl,@szdwyj)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36),
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@xm", MySqlDbType.VarChar,255),
					new MySqlParameter("@xb", MySqlDbType.VarChar,255),
					new MySqlParameter("@whcd", MySqlDbType.VarChar,255),
					new MySqlParameter("@lxdh", MySqlDbType.VarChar,255),
					new MySqlParameter("@zygl", MySqlDbType.VarChar,255),
					new MySqlParameter("@stzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@sfzh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@yb", MySqlDbType.VarChar,255),
					new MySqlParameter("@yx", MySqlDbType.VarChar,255),
					new MySqlParameter("@brqz", MySqlDbType.VarChar,255),
					new MySqlParameter("@pxd", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzjl", MySqlDbType.VarChar,255),
					new MySqlParameter("@szdwyj", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.Guid;
            parameters[1].Value = model.userid;
            parameters[2].Value = model.CreateDate;
            parameters[3].Value = model.xm;
            parameters[4].Value = model.xb;
            parameters[5].Value = model.whcd;
            parameters[6].Value = model.lxdh;
            parameters[7].Value = model.zygl;
            parameters[8].Value = model.stzk;
            parameters[9].Value = model.sfzh;
            parameters[10].Value = model.gzdw;
            parameters[11].Value = model.yb;
            parameters[12].Value = model.yx;
            parameters[13].Value = model.brqz;
            parameters[14].Value = model.pxd;
            parameters[15].Value = model.gzjl;
            parameters[16].Value = model.szdwyj;

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
        public bool Update(basket_train model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update basket_train set ");
            strSql.Append("userid=@userid,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("xm=@xm,");
            strSql.Append("xb=@xb,");
            strSql.Append("whcd=@whcd,");
            strSql.Append("lxdh=@lxdh,");
            strSql.Append("zygl=@zygl,");
            strSql.Append("stzk=@stzk,");
            strSql.Append("sfzh=@sfzh,");
            strSql.Append("gzdw=@gzdw,");
            strSql.Append("yb=@yb,");
            strSql.Append("yx=@yx,");
            strSql.Append("brqz=@brqz,");
            strSql.Append("pxd=@pxd,");
            strSql.Append("gzjl=@gzjl,");
            strSql.Append("szdwyj=@szdwyj");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@userid", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@xm", MySqlDbType.VarChar,255),
					new MySqlParameter("@xb", MySqlDbType.VarChar,255),
					new MySqlParameter("@whcd", MySqlDbType.VarChar,255),
					new MySqlParameter("@lxdh", MySqlDbType.VarChar,255),
					new MySqlParameter("@zygl", MySqlDbType.VarChar,255),
					new MySqlParameter("@stzk", MySqlDbType.VarChar,255),
					new MySqlParameter("@sfzh", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzdw", MySqlDbType.VarChar,255),
					new MySqlParameter("@yb", MySqlDbType.VarChar,255),
					new MySqlParameter("@yx", MySqlDbType.VarChar,255),
					new MySqlParameter("@brqz", MySqlDbType.VarChar,255),
					new MySqlParameter("@pxd", MySqlDbType.VarChar,255),
					new MySqlParameter("@gzjl", MySqlDbType.VarChar,255),
					new MySqlParameter("@szdwyj", MySqlDbType.VarChar,255),
					new MySqlParameter("@Guid", MySqlDbType.VarChar,36)};
            parameters[0].Value = model.userid;
            parameters[1].Value = model.CreateDate;
            parameters[2].Value = model.xm;
            parameters[3].Value = model.xb;
            parameters[4].Value = model.whcd;
            parameters[5].Value = model.lxdh;
            parameters[6].Value = model.zygl;
            parameters[7].Value = model.stzk;
            parameters[8].Value = model.sfzh;
            parameters[9].Value = model.gzdw;
            parameters[10].Value = model.yb;
            parameters[11].Value = model.yx;
            parameters[12].Value = model.brqz;
            parameters[13].Value = model.pxd;
            parameters[14].Value = model.gzjl;
            parameters[15].Value = model.szdwyj;
            parameters[16].Value = model.Guid;

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
            strSql.Append("delete from basket_train ");
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
            strSql.Append("delete from basket_train ");
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
        public basket_train GetModel(string Guid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Guid,userid,CreateDate,xm,xb,whcd,lxdh,zygl,stzk,sfzh,gzdw,yb,yx,brqz,pxd,gzjl,szdwyj from basket_train ");
            strSql.Append(" where Guid=@Guid ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Guid", MySqlDbType.VarChar,255)			};
            parameters[0].Value = Guid;

            basket_train model = new basket_train();
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Guid,userid,CreateDate,xm,xb,whcd,lxdh,zygl,stzk,sfzh,gzdw,yb,yx,brqz,pxd,gzjl,szdwyj ");
            strSql.Append(" FROM basket_train ");
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
            strSql.Append("select count(1) FROM basket_train ");
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
            parameters[0].Value = "basket_train";
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
        public basket_train DataRowToModel(DataRow row)
        {
            basket_train model = new basket_train();
            if (row != null)
            {
                if (row["Guid"] == null)
                {
                    model.Guid = Guid.NewGuid().ToString();
                }
                else {
                    model.Guid = row["Guid"].ToString();
                }
                if (row["userid"] != null)
                {
                    model.userid = row["userid"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Now;
                }
                if (row["xm"] != null)
                {
                    model.xm = row["xm"].ToString();
                }
                if (row["xb"] != null)
                {
                    model.xb = row["xb"].ToString();
                }
                if (row["whcd"] != null)
                {
                    model.whcd = row["whcd"].ToString();
                }
                if (row["lxdh"] != null)
                {
                    model.lxdh = row["lxdh"].ToString();
                }
                if (row["zygl"] != null)
                {
                    model.zygl = row["zygl"].ToString();
                }
                if (row["stzk"] != null)
                {
                    model.stzk = row["stzk"].ToString();
                }
                if (row["sfzh"] != null)
                {
                    model.sfzh = row["sfzh"].ToString();
                }
                if (row["gzdw"] != null)
                {
                    model.gzdw = row["gzdw"].ToString();
                }
                if (row["yb"] != null)
                {
                    model.yb = row["yb"].ToString();
                }
                if (row["yx"] != null)
                {
                    model.yx = row["yx"].ToString();
                }
                if (row["brqz"] != null)
                {
                    model.brqz = row["brqz"].ToString();
                }
                if (row["pxd"] != null)
                {
                    model.pxd = row["pxd"].ToString();
                }
                if (row["gzjl"] != null)
                {
                    model.gzjl = row["gzjl"].ToString();
                }
                if (row["szdwyj"] != null)
                {
                    model.szdwyj = row["szdwyj"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public basket_train GetModelByUserId(string UserId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Guid,userid,CreateDate,xm,xb,whcd,lxdh,zygl,stzk,sfzh,gzdw,yb,yx,brqz,pxd,gzjl,szdwyj from basket_train ");
            strSql.Append(" where UserId=@UserId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserId", MySqlDbType.VarChar,36)			};
            parameters[0].Value = UserId;

            basket_train model = new basket_train();
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
            strSql.Append("select * from basket_train ");
            strSql.Append(" where Guid in (" + Guidlist + ")  ");
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            return ds;
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM basket_train TT  ");
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
            strSql.Append(";SELECT count(Guid) as count FROM basket_train TT  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetColumnInfo(string tableName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COLUMN_NAME,COLUMN_COMMENT from INFORMATION_SCHEMA.Columns where table_name=@tableName and table_schema='am'");
            MySqlParameter[] parameters = {
					new MySqlParameter("@tableName", MySqlDbType.VarChar,255)			};
            parameters[0].Value = tableName;
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            return ds;
        }
        #endregion  ExtensionMethod
	}
}

