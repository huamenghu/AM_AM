using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using AM.BLL;

namespace AM.Common
{
    public class Manager
    {
        #region 单例
        private static Manager instant;
        static object lockObj = new object();
        public static Manager Instant
        {
            get
            {
                if (instant == null)
                {
                    lock (lockObj)
                    {
                        if (instant == null)
                        {
                            instant = new Manager();
                        }
                    }
                }
                return instant;
            }
        }
        #endregion

        #region 日志
        private ILog log;

        public ILog Log
        {
            get
            {
                if (log == null)
                {
                    log = LogManager.GetLogger("LogToTXT");
                }
                return log;
            }
        }
        #endregion

        private ToolManager toolManager;
        public ToolManager ToolManager
        {
            get
            {
                if (toolManager == null)
                {
                    toolManager = new ToolManager(instant);
                }
                return toolManager;
            }

        }

        private ConfigManager configManager;
        public ConfigManager ConfigManager
        {
            get
            {
                if (configManager == null)
                {
                    configManager = new ConfigManager(instant);
                }
                return configManager;
            }

        }

        private ConstantManager constantManager;
        public ConstantManager ConstantManager
        {
            get
            {
                if (constantManager == null)
                {
                    constantManager = new ConstantManager(instant);
                }
                return constantManager;
            }

        }

        private Log4NetManager log4netManager;
        public Log4NetManager Log4NetManager
        {
            get
            {
                if (log4netManager == null)
                {
                    log4netManager = new Log4NetManager(instant);
                }
                return log4netManager;
            }

        }

        private IPManager ipManager;

        public IPManager IPManager
        {
            get
            {
                if (ipManager == null)
                {
                    ipManager = new IPManager(instant);
                }

                return ipManager;
            }
        }

    }
}