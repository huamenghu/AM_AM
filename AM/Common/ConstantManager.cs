using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace AM.Common
{
    public class ConstantManager
    {
        Manager manager;

        public ConstantManager(Manager manager)
        {
            this.manager = manager;

        }
        #region 当前用户
        private admin curAdmin;

        //<summary>
        //登录用户
        //</summary>
        public admin CurAdmin
        {
            get { return curAdmin; }
            set { curAdmin = value; }
        }
        #endregion

        public string DateTimeToCodeFormat = "yyyyMMddHHmmssf";

        public string Version = "V2.0";
        public string CopyRight = "Copyright © 2015 MFXinY.";

        public string texthtml = "text/html";

        /// <summary>
        /// 短信处理状态提示
        /// </summary>
        public List<string> msgs = new List<string>();


        /// <summary>
        /// 系统时间
        /// </summary>
        public string OutDateTime = "2017-10-01";
        /// <summary>
        /// 欢迎进入短信管理平台
        /// </summary>
        public string Title = "欢迎进入售后无忧管理平台";
        /// <summary>
        /// 短信管理平台登录界面
        /// </summary>
        public string LoginTitle = "售后无忧管理平台登录界面";
        /// <summary>
        /// 短信管理平台主界面
        /// </summary>
        public string MainTitle = "售后无忧管理平台主界面";
        /// <summary>
        /// 该项不能为空！
        /// </summary>
        public string NotNull = "该项不能为空";
        /// <summary>
        /// 该项不能为空且只能输入数字
        /// </summary>
        public string NumberNotNull = "该项不能为空只能输入数字";
        /// <summary>
        /// 根目录
        /// </summary>
        public string RootDirection = string.Empty;

        /// <summary>
        /// 积分规则
        /// </summary>
        public Guid GUIDPointsRule = new Guid("00000000-0000-0000-0000-000000000001");
        /// <summary>
        /// 联系我
        /// </summary>
        public Guid GUIDLinkMe = new Guid("00000000-0000-0000-0000-000000000002");
        /// <summary>
        /// 关于我
        /// </summary>
        public Guid GUIDAboutMe = new Guid("00000000-0000-0000-0000-000000000003");

    }
}