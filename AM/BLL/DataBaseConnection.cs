using System;
using System.Linq;
using AM.Models;

namespace AM.BLL
{
    public class DataBaseConnection
    {
        /// <summary>
        /// 超时时间
        /// </summary>
        private static int connectionTimeout = 3;
        /// <summary>
        /// 最大超时时间
        /// </summary>
        private static readonly int maxConnectionTimeout = 15;
        /// <summary>
        /// 最小超时时间
        /// </summary>
        private static readonly int minConnectionTimeout = 3;

        /// <summary>
        /// 检测服务数据库连接状态
        /// </summary>
        /// <returns></returns>
        public static bool CheckDataBaseConnection()
        {
            bool flag = false;
            try
            {
                using (var ctx = new ServerEntities())
                {
                    //设置连接时间为1秒
                    string temp = string.Format(" ConnectionTimeout={0}", connectionTimeout);
                    ctx.Database.Connection.ConnectionString = string.Format("{0};{1}", ctx.Database.Connection.ConnectionString, temp);
                    var query = ctx.sms_outbox.Where(a => false).Any();
                    flag = true;
                }
                using (var ctx = new DBEntities())
                {
                    //设置连接时间为1秒
                    string temp = string.Format(" ConnectionTimeout={0}", connectionTimeout);
                    ctx.Database.Connection.ConnectionString = string.Format("{0};{1}", ctx.Database.Connection.ConnectionString, temp);
                    var query = ctx.send.Where(a => false).Any();
                    flag = true;
                }
                if (connectionTimeout > minConnectionTimeout)
                {
                    connectionTimeout--;
                }
            }
            catch (Exception exc)
            {
                connectionTimeout = maxConnectionTimeout;
                flag = false;
            }
            return flag;
        }
    }
}
