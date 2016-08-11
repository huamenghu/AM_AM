using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using MFXinY.EF;
using System.IO;
using AM.Common;
using Dao;
using System.Threading.Tasks;
namespace AM.BLL
{
    public class DataStore
    {
        #region construct
        DataStore()
        {

        }
        #endregion

        #region 常量、变量

        public static string NoImg = "/Content/web/images/noimg.gif";
        /// <summary>
        /// 空Guid
        /// </summary>
        public static Guid NullGuid = new Guid("00000000-0000-0000-0000-000000000000");
        /// <summary>
        /// 自动关闭 info 窗口提示的秒数
        /// </summary>
        public const int AutoCloseTipTime = 2;
        /// <summary>
        /// 每级显示5位数编号
        /// </summary>
        public const int EveryLayerLength = 5;
        /// <summary>
        /// 人员系统
        /// </summary>
        public const int PersonSystem = 1;
        /// <summary>
        /// 瓦斯系统
        /// </summary>
        public const int WaSiSystem = 2;
        /// <summary>
        /// 密钥,8位
        /// </summary>
        public const string MIYAO = "mfxiny88";
        /// <summary>
        /// 短信模板中的时间格式1--上下井短信
        /// </summary>
        public const string DataTimeFormat1 = "yyyy-MM-dd HH:mm:ss";
        /// <summary>
        /// 短信模板中的时间格式2--上下井短信
        /// </summary>
        public const string DataTimeFormat2 = "yyyy年M月d日 HH:mm:ss";
        /// <summary>
        /// 短信模板中的时间格式3--上下井短信
        /// </summary>
        public const string DataTimeFormat3 = "yyyy/MM/dd HH:mm:ss";

        /// <summary>
        /// 短信模板中的时间格式1--生日短信
        /// </summary>
        public const string DataTimeBirthdayFormat1 = "yyyy-MM-dd";
        /// <summary>
        /// 短信模板中的时间格式2--生日短信
        /// </summary>
        public const string DataTimeBirthdayFormat2 = "yyyy年M月d日";
        /// <summary>
        /// 短信模板中的时间格式3--生日短信
        /// </summary>
        public const string DataTimeBirthdayFormat3 = "yyyy/MM/dd";

        public const string FailToDBMessage = "短信平台连接失败，请检查网络或以超级管理员身份登录修改服务端配置！";

        public const string DataTimeString1 = "{DataTime1}";
        public const string DataTimeString2 = "{DataTime2}";
        public const string DataTimeString3 = "{DataTime3}";
        public const string UserNameFormat = "{UserName}";

        //public const string Copyright = "Copyright © 2013 MFXinY.山西嘉讯信达科技有限公司";
        public const string Copyright = "Copyright © 2013 MFXinY.";

        /// <summary>
        /// 短信模板里的 用户预览名称
        /// </summary>
        public const string TestUserName = "张三";

        #endregion
        #region 系统常量
        /// <summary>
        /// 超级管理员的角色
        /// </summary>
        public const string AdminRole = "Admin";

        public const string DefaultPassword = "123456";
        /// <summary>
        /// 分页大小
        /// </summary>
        public const int PageSize = 10;
        /// <summary>
        /// 短信验证码位数
        /// </summary>
        public const int SMSCodeLength = 6;

        public static string[] ImgageTtpe = new string[] { "bmp", "jpg", "png", "gif" };
        #endregion

        #region 系统变量

        public static double Price_train = 100;
        /// <summary>
        /// 短信发送地址
        /// </summary>
        public static string SMS_url = "http://v.juhe.cn/sms/send";
        /// <summary>
        /// 短信key
        /// </summary>
        public static string SMS_key = "5c388fd734a84907febacca127b40bf4";
        /// <summary>
        /// 短信模板ID
        /// </summary>
        public static string SMS_tpl_id = "5247";
        public static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
        /// <summary>
        /// 积分换算率
        /// </summary>
        public static double PointsMoneyExchange = 0.1;
        #endregion

        #region 程序相关
        public static string Version = "1.10";  //当前版本
        public static string LastVersion = Version;  //当前版本
        public const string SoftName = "SMSW";  //软件名称
        public static long ClientID = 0;  //客户端ID
        public static string IP = "";
        public static bool IsRuning = false;
        #endregion

        #region 变量
        /// <summary>
        /// 过期时间
        /// </summary>
        public static DateTime OutDateTime = new DateTime(2015, 05, 11);
        /// <summary>
        /// 默认分页大小
        /// </summary>
        //public static int DefaultPageSize = PageSizeList.FirstOrDefault();
        #endregion

        #region #静态集合  将用户，角色，权限，类别等常用数据存入静态集合中

        #region 用户-AuthUser
        private static List<AuthUser> user;
        /// <summary>
        /// 用户User列表
        /// </summary>
        public static List<AuthUser> User
        {
            get
            {
                if (user == null)
                {
                    RefreshUser();
                }
                return user;
            }
            set { DataStore.user = value; }
        }
        public static void RefreshUser()
        {
            user = DB.AuthUserManager.Where(a => true).Select(a => new
            {
                UserName = a.UserName,
                UserNo = a.UserNo,
                IsAvailable = a.IsAvailable,
                IsInner = a.IsInner,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                Password = a.Password,
                RealName = a.RealName,
                Remark = a.Remark,
                Sequence = a.Sequence,
            }).ToList().Select(a => new AuthUser()
            {
                UserName = a.UserName,
                UserNo = a.UserNo,
                IsAvailable = a.IsAvailable,
                IsInner = a.IsInner,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                Password = a.Password,
                RealName = a.RealName,
                Remark = a.Remark,
                Sequence = a.Sequence,
            }).ToList();
        }
        #endregion

        #region 角色-AuthRole
        private static List<AuthRole> role;
        /// <summary>
        /// 角色Role列表
        /// </summary>
        public static List<AuthRole> Role
        {
            get
            {
                if (role == null)
                {
                    RefreshRole();
                }
                return role;
            }
            set { DataStore.role = value; }
        }
        public static void RefreshRole()
        {
            role = DB.AuthRoleManager.Where(a => true).Select(a => new
            {
                Description = a.Description,
                IsAvailable = a.IsAvailable,
                IsInner = a.IsInner,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                Priority = a.Priority,
                RoleName = a.RoleName,
                Sequence = a.Sequence,
                Title = a.Title
            }).ToList().Select(a => new AuthRole()
            {
                Description = a.Description,
                IsAvailable = a.IsAvailable,
                IsInner = a.IsInner,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                Priority = a.Priority,
                RoleName = a.RoleName,
                Sequence = a.Sequence,
                Title = a.Title
            }).ToList();
        }
        #endregion

        #region 用户-角色 UserRole
        private static List<AuthUserRole> userRole;
        /// <summary>
        /// 用户-角色 UserRole列表
        /// </summary>
        public static List<AuthUserRole> UserRole
        {
            get
            {
                if (userRole == null)
                {
                    RefreshUserRole();
                }
                return userRole;
            }
            set { DataStore.userRole = value; }
        }
        public static void RefreshUserRole()
        {
            userRole = DB.AuthUserRoleManager.Where(a => true).Select(a => new
            {
                ID = a.ID,
                RoleName = a.RoleName,
                UserName = a.UserName
            }).ToList().Select(a => new AuthUserRole()
            {
                ID = a.ID,
                RoleName = a.RoleName,
                UserName = a.UserName
            }).ToList();
        }
        #endregion

        #region 权限-permission
        private static List<AuthPermission> permission;
        /// <summary>
        ///权限列表
        /// </summary>
        public static List<AuthPermission> Permission
        {
            get
            {
                if (permission == null)
                {
                    RefreshPermission();
                }
                return permission;
            }
            set { DataStore.permission = value; }
        }
        public static void RefreshPermission()
        {
            permission = DB.AuthPermissionManager.Where(a => true).Select(a => new
            {
                Code = a.Code,
                Sequence = a.Sequence,
                Name = a.Name,
                IsShow = a.IsShow,
                Description = a.Description,
                HttpType = a.HttpType,
                IsAvailable = a.IsAvailable,
                Operator = a.Operator,
                OperateTime = a.OperateTime,
                PCode = a.PCode,
                Res = a.Res,
                URL = a.URL
            }).ToList().Select(a => new AuthPermission()
            {
                Code = a.Code,
                Sequence = a.Sequence,
                Name = a.Name,
                IsShow = a.IsShow,
                Description = a.Description,
                HttpType = a.HttpType,
                IsAvailable = a.IsAvailable,
                Operator = a.Operator,
                OperateTime = a.OperateTime,
                PCode = a.PCode,
                Res = a.Res,
                URL = a.URL
            }).ToList();
        }
        #endregion

        #region 角色-权限 Relation
        private static List<AuthRelation> relation;
        /// <summary>
        /// 角色-权限Relation列表
        /// </summary>
        public static List<AuthRelation> Relation
        {
            get
            {
                if (relation == null)
                {
                    RefreshRelation();
                }
                return relation;
            }
            set { DataStore.relation = value; }
        }
        public static void RefreshRelation()
        {
            relation = DB.AuthRelationManager.Where(a => true).Select(a => new
            {
                ID = a.ID,
                IsShow = a.IsShow,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                PermissionCode = a.PermissionCode,
                RoleName = a.RoleName
            }).ToList().Select(a => new AuthRelation
            {
                ID = a.ID,
                IsShow = a.IsShow,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                PermissionCode = a.PermissionCode,
                RoleName = a.RoleName
            }).ToList();
        }
        #endregion

        #region 用户-权限 AuthUserPermission
        private static List<AuthUserPermission> userPermission;
        /// <summary>
        /// 角色-权限Relation列表
        /// </summary>
        public static List<AuthUserPermission> UserPermission
        {
            get
            {
                if (userPermission == null)
                {
                    RefreshUserPermission();
                }
                return userPermission;
            }
            set { DataStore.userPermission = value; }
        }
        public static void RefreshUserPermission()
        {
            userPermission = DB.AuthUserPermission.Where(a => true).Select(a => new
            {
                ID = a.ID,
                PCode = a.PCode,
                UserName = a.UserName
            }).ToList().Select(a => new AuthUserPermission
            {
                ID = a.ID,
                PCode = a.PCode,
                UserName = a.UserName
            }).ToList();
        }
        #endregion


        #endregion

        #region 静态集合
        private static List<goodstype> _goodtype;
        /// <summary>
        /// 商品 类别
        /// </summary>
        public static List<goodstype> GoodsType
        {
            get
            {
                if (_goodtype == null)
                {
                    Refreshgoodstype();
                }
                return _goodtype;
            }
            set { _goodtype = value; }
        }
        public static void Refreshgoodstype()
        {
            _goodtype = DB.Instant.GoodsTypeManager.Where(a => a.Isshow == true).Select(a => new
            {
                a.typeid,
                a.typename,
                a.sort
            }).ToList().Select(a => new goodstype()
            {
                typeid = a.typeid,
                typename = a.typename,
                sort = a.sort
            }).ToList();
        }

        #region config
        private static List<config> config;
        /// <summary>
        ///  
        /// </summary>
        public static List<config> Config
        {
            get
            {
                if (config == null)
                {
                    RefreshConfig();
                }
                return config;
            }
            set { config = value; }
        }
        public static void RefreshConfig()
        {
            config = DB.Instant.ConfigManager.Where(a => true).Select(a => new
            {
                a.GUID,
                a.Key,
                a.Value
            }).ToList().Select(a => new config()
            {
                GUID = a.GUID,
                Key = a.Key,
                Value = a.Value
            }).ToList();
        }
        #endregion

        #region 新闻类别
        private static List<newstype> newstype;
        /// <summary>
        ///  
        /// </summary>
        public static List<newstype> NewsType
        {
            get
            {
                if (newstype == null)
                {
                    RefreshNewsType();
                }
                return newstype;
            }
            set { newstype = value; }
        }
        public static void RefreshNewsType()
        {
            newstype = DB.Instant.NewsTypeManager.Where(a => true).Select(a => new
            {
                a.typeid,
                a.typelogo,
                a.typename,
                a.Isshow,
                a.sort,
                a.description
            }).ToList().Select(a => new newstype()
            {
                typeid = a.typeid,
                typelogo = a.typelogo,
                typename = a.typename,
                description = a.description,
                sort = a.sort,
                Isshow = a.Isshow
            }).ToList();
        }
        #endregion
        #endregion


        public static bool IsInit = false;
        /// <summary>
        /// 刷新缓存
        /// </summary>
        public static void RefreshCache()
        {
            if (IsInit == false)
            {
                Task t = new Task(() =>
                {
                    try
                    {
                        var time1 = DateTime.Now;
                        var a1 = User;
                        var a2 = UserRole;
                        var a3 = Role;
                        var a4 = Relation;
                        var a5 = Permission;
                        var a6 = UserPermission;
                        var a7 = GoodsType;
                        var a8 = Config;
                        var a9 = NewsType;
                        var time2 = DateTime.Now;
                        var tt = time2 - time1;
                        var x = tt;
                    }
                    catch { }
                    finally
                    {
                        IsInit = true;
                    }
                });
                t.Start();
            }
        }
    }
}