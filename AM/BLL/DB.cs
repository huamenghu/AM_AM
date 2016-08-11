
using log4net;
using System;
using System.Data.Entity;
namespace AM.BLL
{
    public class DB
    {
        private static DB instant;
        #region 数据库管理 的唯一实例（单件模式）
        /// <summary>
        /// 数据库管理 的唯一实例（单件模式）
        /// </summary>        
        public static DB Instant
        {
            get
            {
                if (instant == null)
                {
                    instant = new DB();
                }
                return instant;
            }
        }
        #endregion

        #region 权限类
        public static AuthPermissionManager AuthPermissionManager = new AuthPermissionManager();
        public static AuthRelationManager AuthRelationManager = new AuthRelationManager();
        public static AuthRoleManager AuthRoleManager = new AuthRoleManager();
        public static AuthUserManager AuthUserManager = new AuthUserManager();
        public static AuthUserPermissionManager AuthUserPermission = new AuthUserPermissionManager();
        public static AuthUserRoleManager AuthUserRoleManager = new AuthUserRoleManager();
        #endregion
        #region 各表的管理类


        private UserManager userManager;
        public UserManager UserManager
        {
            get
            {
                if (userManager == null)
                {
                    userManager = new UserManager(instant);
                }
                return userManager;
            }

        }

        private AdminManager adminManager;
        public AdminManager AdminManager
        {
            get
            {
                if (adminManager == null)
                {
                    adminManager = new AdminManager(instant);
                }
                return adminManager;
            }

        }

        private AddrManager addrManager;
        public AddrManager AddrManager
        {
            get
            {
                if (addrManager == null)
                {
                    addrManager = new AddrManager(instant);
                }
                return addrManager;
            }

        }

        private GoodsTypeManager goodsTypeManager;
        public GoodsTypeManager GoodsTypeManager
        {
            get
            {
                if (goodsTypeManager == null)
                {
                    goodsTypeManager = new GoodsTypeManager(instant);
                }
                return goodsTypeManager;
            }
        }

        private AppManager appManager;
        public AppManager AppManager
        {
            get
            {
                if (appManager == null)
                {
                    appManager = new AppManager(instant);
                }
                return appManager;
            }

        }

        private UpfeedBackInfoManager upfeedBackInfoManager;
        public UpfeedBackInfoManager UpfeedBackInfoManager
        {
            get
            {
                if (upfeedBackInfoManager == null)
                {
                    upfeedBackInfoManager = new UpfeedBackInfoManager(instant);
                }
                return upfeedBackInfoManager;
            }

        }

        private GoodsManager goodsManager;
        public GoodsManager GoodsManager
        {
            get
            {
                if (goodsManager == null)
                {
                    goodsManager = new GoodsManager(instant);
                }
                return goodsManager;
            }

        }

        private CatManager catManager;
        public CatManager CatManager
        {
            get
            {
                if (catManager == null)
                {
                    catManager = new CatManager(instant);
                }
                return catManager;
            }

        }

        private GradeManager gradeManager;
        public GradeManager GradeManager
        {
            get
            {
                if (gradeManager == null)
                {
                    gradeManager = new GradeManager(instant);
                }
                return gradeManager;
            }

        }

        private OrderManager orderManager;
        public OrderManager OrderManager
        {
            get
            {
                if (orderManager == null)
                {
                    orderManager = new OrderManager(instant);
                }
                return orderManager;
            }

        }

        private OrderGoodsManager ordergoodsManager;
        public OrderGoodsManager OrderGoodsManager
        {
            get
            {
                if (ordergoodsManager == null)
                {
                    ordergoodsManager = new OrderGoodsManager(instant);
                }
                return ordergoodsManager;
            }

        }

        private RecommendedManager recommendedManager;
        public RecommendedManager RecommendedManager
        {
            get
            {
                if (recommendedManager == null)
                {
                    recommendedManager = new RecommendedManager(instant);
                }
                return recommendedManager;
            }
        }

        private OrderPingJiaManager orderPingJiaManager;
        public OrderPingJiaManager OrderPingJiaManager
        {
            get
            {
                if (orderPingJiaManager == null)
                {
                    orderPingJiaManager = new OrderPingJiaManager(instant);
                }
                return orderPingJiaManager;
            }
        }

        private AlipayManager alipayManager;
        public AlipayManager AlipayManager
        {
            get
            {
                if (alipayManager == null)
                {
                    alipayManager = new AlipayManager(instant);
                }
                return alipayManager;
            }
        }

        private ConsumptionnoteManager consumptionnoteManager;
        public ConsumptionnoteManager ConsumptionnoteManager
        {
            get
            {
                if (consumptionnoteManager == null)
                {
                    consumptionnoteManager = new ConsumptionnoteManager(instant);
                }
                return consumptionnoteManager;
            }
        }

        private ApplicationinfoManager applicationinfoManager;
        public ApplicationinfoManager ApplicationinfoManager
        {
            get
            {
                if (applicationinfoManager == null)
                {
                    applicationinfoManager = new ApplicationinfoManager(instant);
                }
                return applicationinfoManager;
            }
        }

        private AppraisalaccidentManager appraisalaccidentManager;
        public AppraisalaccidentManager AppraisalaccidentManager
        {
            get
            {
                if (appraisalaccidentManager == null)
                {
                    appraisalaccidentManager = new AppraisalaccidentManager(instant);
                }
                return appraisalaccidentManager;
            }
        }

        private AppraisalapplicationManager appraisalapplicationManager;
        public AppraisalapplicationManager AppraisalapplicationManager
        {
            get
            {
                if (appraisalapplicationManager == null)
                {
                    appraisalapplicationManager = new AppraisalapplicationManager(instant);
                }
                return appraisalapplicationManager;
            }
        }

        private ExpertsdesigninfoManager expertsdesigninfoManager;
        public ExpertsdesigninfoManager ExpertsdesigninfoManager
        {
            get
            {
                if (expertsdesigninfoManager == null)
                {
                    expertsdesigninfoManager = new ExpertsdesigninfoManager(instant);
                }
                return expertsdesigninfoManager;
            }
        }

        private ExpertsproofinfoManager expertsproofinfoManager;
        public ExpertsproofinfoManager ExpertsproofinfoManager
        {
            get
            {
                if (expertsproofinfoManager == null)
                {
                    expertsproofinfoManager = new ExpertsproofinfoManager(instant);
                }
                return expertsproofinfoManager;
            }
        }

        private FaultManager faultManager;
        public FaultManager FaultManager
        {
            get
            {
                if (faultManager == null)
                {
                    faultManager = new FaultManager(instant);
                }
                return faultManager;
            }
        }

        private NewsManager newsManager;
        public NewsManager NewsManager
        {
            get
            {
                if (newsManager == null)
                {
                    newsManager = new NewsManager(instant);
                }
                return newsManager;
            }
        }

        private TestingManager testingManager;
        public TestingManager TestingManager
        {
            get
            {
                if (testingManager == null)
                {
                    testingManager = new TestingManager(instant);
                }
                return testingManager;
            }
        }

        private TrainManager trainManager;
        public TrainManager TrainManager
        {
            get
            {
                if (trainManager == null)
                {
                    trainManager = new TrainManager(instant);
                }
                return trainManager;
            }
        }

        private TrainTypeManager trainTypeManager;
        public TrainTypeManager TrainTypeManager
        {
            get
            {
                if (trainTypeManager == null)
                {
                    trainTypeManager = new TrainTypeManager(instant);
                }
                return trainTypeManager;
            }
        }

        private QualificationTypeManager qualificationTypeManager;
        public QualificationTypeManager QualificationTypeManager
        {
            get
            {
                if (qualificationTypeManager == null)
                {
                    qualificationTypeManager = new QualificationTypeManager(instant);
                }
                return qualificationTypeManager;
            }
        }

        private AdManager adManager;
        public AdManager AdManager
        {
            get
            {
                if (adManager == null)
                {
                    adManager = new AdManager(instant);
                }
                return adManager;
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

        private NewsTypeManager newsTypeManager;
        public NewsTypeManager NewsTypeManager
        {
            get
            {
                if (newsTypeManager == null)
                {
                    newsTypeManager = new NewsTypeManager(instant);
                }
                return newsTypeManager;
            }
        }

        private FaultTypeManager faultTypeManager;
        public FaultTypeManager FaultTypeManager
        {
            get
            {
                if (faultTypeManager == null)
                {
                    faultTypeManager = new FaultTypeManager(instant);
                }
                return faultTypeManager;
            }
        }
        #endregion

        public static Express Express = new Express();

        public static ExpressCodeManager ExpressCode = new ExpressCodeManager();

        #region 日志Log4
        public static log4net.ILog log = LogManager.GetLogger("LogToTXT");
        #endregion
    }
}

