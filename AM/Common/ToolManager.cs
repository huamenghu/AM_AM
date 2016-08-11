using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using log4net;
using AM.BLL;
using System.Data;
using System.Web.Script.Serialization;

namespace AM.Common
{
    public class ToolManager
    {
        Manager manager;
        ILog managerLog;
        public ToolManager(Manager manager)
        {
            this.manager = manager;
            managerLog = manager.Log;
        }
        #region 将模版短信转换为发送短信--普通短信

        /// <summary>
        /// 把模版短信转换为发送短信
        /// </summary>
        /// <param name="originMsg"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string ConvertToMsg(string originMsg, string userName, DateTime dt)
        {
            return _ConvertToMsg(originMsg, userName, dt);
        }


        private string _ConvertToMsg(string originMsg, string userName, DateTime dt)
        {
            string ret = string.Empty;
            try
            {
                ret = originMsg.Replace(DataStore.DataTimeString1, dt.ToString(DataStore.DataTimeFormat1))
                    .Replace(DataStore.DataTimeString2, dt.ToString(DataStore.DataTimeFormat2))
                    .Replace(DataStore.DataTimeString3, dt.ToString(DataStore.DataTimeFormat3))
                    .Replace(DataStore.UserNameFormat, userName);
            }
            catch (Exception Exc)
            {
                #region LogError
                //Fatal,Error,Warn,Info,Debug
                if (managerLog.IsErrorEnabled)
                {
                    managerLog.ErrorFormat("把其他短信模版转换为发送短信异常:{0}", Exc);
                }
                #endregion
                ret = string.Empty;
            }
            return ret;
        }

        #endregion

        #region 将模版短信转换为发送短信--生日短信

        /// <summary>
        /// 把模版短信转换为发送短信--生日短信
        /// </summary>
        /// <param name="originMsg"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string ConvertToMsgWithBirthday(string originMsg, string userName, DateTime dt)
        {
            return _ConvertToMsgWithBirthday(originMsg, userName, dt);
        }

        private string _ConvertToMsgWithBirthday(string originMsg, string userName, DateTime dt)
        {
            string ret = string.Empty;
            try
            {
                ret = originMsg.Replace(DataStore.DataTimeString1, dt.ToString(DataStore.DataTimeBirthdayFormat1))
                    .Replace(DataStore.DataTimeString2, dt.ToString(DataStore.DataTimeBirthdayFormat2))
                    .Replace(DataStore.DataTimeString3, dt.ToString(DataStore.DataTimeBirthdayFormat3))
                    .Replace(DataStore.UserNameFormat, userName);
            }
            catch (Exception Exc)
            {
                #region LogError
                //Fatal,Error,Warn,Info,Debug
                if (managerLog.IsErrorEnabled)
                {
                    managerLog.ErrorFormat("把生日短信模版转换为发送短信异常:{0}", Exc);
                }
                #endregion
                ret = string.Empty;
            }
            return ret;
        }

        #endregion

        /// <summary>
        /// 根据时间生成顺序码
        /// </summary>
        /// <returns></returns>
        public string GeneralCodeWithDateTime()
        {
            return DateTime.Now.ToString(manager.ConstantManager.DateTimeToCodeFormat);
        }

        /// <summary>
        /// 检查人员消息类别
        /// </summary>
        /// <returns></returns>
        public EnumMessageCatalog CheckRenYuan_DB14(string message)
        {
            EnumMessageCatalog mc = EnumMessageCatalog.Normal;

            Regex regex = new Regex("DB14/T 671.1-2012");
            if (regex.IsMatch(message))
            {
                mc = EnumMessageCatalog.DB14;
            }
            return mc;
        }

        public static DataSet JsonToDataSet(string Json)
        {
            try
            {
                DataSet ds = new DataSet();
                JavaScriptSerializer JSS = new JavaScriptSerializer();


                object obj = JSS.DeserializeObject(Json);
                Dictionary<string, object> datajson = (Dictionary<string, object>)obj;


                foreach (var item in datajson)
                {
                    DataTable dt = new DataTable(item.Key);
                    object[] rows = (object[])item.Value;
                    foreach (var row in rows)
                    {
                        Dictionary<string, object> val = (Dictionary<string, object>)row;
                        DataRow dr = dt.NewRow();
                        foreach (KeyValuePair<string, object> sss in val)
                        {
                            if (!dt.Columns.Contains(sss.Key))
                            {
                                dt.Columns.Add(sss.Key.ToString());
                                dr[sss.Key] = sss.Value;
                            }
                            else
                                dr[sss.Key] = sss.Value;
                        }
                        dt.Rows.Add(dr);
                    }
                    ds.Tables.Add(dt);
                }
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}