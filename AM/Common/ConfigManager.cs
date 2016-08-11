using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace AM.Common
{
    public class ConfigManager
    {
        Manager manager;
        ILog managerLog;
        public ConfigManager(Manager manager)
        {
            this.manager = manager;
            managerLog = manager.Log;
        }

        private string redisServerIP;

        public string RedisServerIP
        {
            get
            {
                if (string.IsNullOrEmpty(redisServerIP))
                {
                    redisServerIP = GetConfig("RedisServerIP");
                }
                //System.Configuration.ConfigurationManager.AppSettings["RedisServerIP1"];

                return redisServerIP;
            }
        }

        private int redisServerPort;

        public int RedisServerPort
        {
            get
            {
                try
                {
                    redisServerPort = int.Parse(GetConfig("RedisServerPort"));
                }
                catch (Exception)
                {
                    redisServerPort = 6379;
                }
                return redisServerPort;
            }
        }

        private string apiUrl;

        public string ApiUrl
        {
            get
            {
                if (apiUrl == null)
                {
                    string tempApiUrl = System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
                    if (string.IsNullOrEmpty(tempApiUrl))
                    {
                        apiUrl = "http://am.nchanpin.com";
                    }
                    else
                    {
                        apiUrl = tempApiUrl;
                    }

                }
                return apiUrl;
            }

        }


        public string Mas_Redis = "Mas_Redis";
        /// <summary>
        /// 订阅人员客户端
        /// </summary>
        public string Mas_RenYuan = "Mas_RenYuan";
        /// <summary>
        /// 订阅瓦斯客户端
        /// </summary>
        public string Mas_WaSi = "Mas_WaSi";

        /// <summary>
        /// 订阅传感器客户端
        /// </summary>
        public string Mas_Switcher = "Mas_Switcher";

        /// <summary>
        /// 订阅人员客户端心跳
        /// </summary>
        public string Mas_Redis_RenYuan_Heartbeat = "Mas_Redis_RenYuan_Heartbeat";

        /// <summary>
        /// 订阅瓦斯客户端心跳
        /// </summary>
        public string Mas_Redis_WaSi_Heartbeat = "Mas_Redis_WaSi_Heartbeat";


        public string Mas_Redis_Regist_Result = "Mas_Redis_Regist_Result";
        /// <summary>
        /// 服务端处理心跳订阅
        /// </summary>
        public string Mas_Redis_Heartbeat_Web = "Mas_Redis_Heartbeat_Web";


        public string GetConfig(string key)
        {
            return _GetConfig(key);
        }

        private string _GetConfig(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }
    }
}