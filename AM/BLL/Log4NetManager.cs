using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using AM.Common;

namespace AM.BLL
{
    public class Log4NetManager
    {
        Manager manager;
        public Log4NetManager(Manager manager)
        {


        }

        private ILog smtpLog;

        /// <summary>
        /// 邮件发送日志处理器
        /// </summary>
        public ILog SmtpLog
        {
            get
            {
                if (smtpLog == null)
                {
                    smtpLog = log4net.LogManager.GetLogger("LogToEmail");
                }
                return smtpLog;
            }

        }

        private ILog txtLog;

        public ILog TXTLog
        {
            get
            {
                if (txtLog == null)
                {
                    txtLog = log4net.LogManager.GetLogger("LogToTXT");
                }
                return txtLog;
            }

        }
    }
}