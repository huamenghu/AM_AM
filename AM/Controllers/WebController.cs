using Dao;
using AM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MFXinY.Common;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class WebController : Controller
    {
        public string UserID
        {
            get
            {
                if (Session["WebUser"] != null)
                {
                    return Session["WebUser"].ToString();
                }
                return string.Empty;
            }
            set
            {
                Session["WebUser"] = value;
            }
        }
        public ActionResult Index()
        {
            ViewBag.Title = DB.Instant.ConfigManager.GetValue("IndexTitle");
            ViewBag.Keyword = DB.Instant.ConfigManager.GetValue("IndexKeyword");
            ViewBag.Description = DB.Instant.ConfigManager.GetValue("IndexDescription");
            ViewBag.Tel = DB.Instant.ConfigManager.GetValue("Tel");
            ViewBag.Address = DB.Instant.ConfigManager.GetValue("Address");
            ViewBag.Email = DB.Instant.ConfigManager.GetValue("Email");

            #region //无忧资讯
            var newstype = DataStore.NewsType.Where(a => true).OrderBy(a => a.sort).Take(2).ToList();
            ViewBag.NewsType = newstype;

            #endregion

            return View();
        }

        #region 关于我们
        public ActionResult AboutUS()
        {
            var n = DB.Instant.NewsManager.Where(a => a.newstype == "00003").FirstOrDefault();
            if (n == null) n = new news();
            ViewBag.News = n;

            ViewBag.Tel = DB.Instant.ConfigManager.GetValue("Tel");
            ViewBag.Address = DB.Instant.ConfigManager.GetValue("Address");
            ViewBag.Email = DB.Instant.ConfigManager.GetValue("Email");
            return View();
        }
        #endregion

        #region 荣誉资质
        public ActionResult RYZZ()
        {
            var list = DB.Instant.NewsManager.Where(a => a.newstype == "00005").Select(a => new
            {
                a.newsdate,
                a.newsid,
                a.newstitle,
                a.newslogo
            }).OrderByDescending(a => a.newsdate).ToList().Select(a => new news
            {
                newsdate = a.newsdate,
                newsid = a.newsid,
                newstitle = a.newstitle,
                newslogo = a.newslogo
            }).ToList();
            ViewBag.List = list;

            ViewBag.Tel = DB.Instant.ConfigManager.GetValue("Tel");
            ViewBag.Address = DB.Instant.ConfigManager.GetValue("Address");
            ViewBag.Email = DB.Instant.ConfigManager.GetValue("Email");
            return View();
        }
        #endregion

        #region 注册
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Register2(FormCollection form)
        {
            var phone = form.Get("phone");
            var code = form.Get("smscode");

            ViewBag.phone = phone;
            ViewBag.smscode = code;
            if (string.IsNullOrEmpty(code))
            {
                return View("Register");
            }
            return View();
        }
        public ActionResult Register3()
        {
            return View();
        }
        #endregion

        #region 新闻资讯
        public ActionResult News(string id = null, string fid = null, int pageIndex = 1, int? pageSize = 6)
        {
            ViewBag.ID = id;
            ViewBag.FID = fid;
            ViewBag.PageIndex = pageIndex;

            if (pageSize == null)
            {
                pageSize = 6;
            }

            List<news> list = new List<news>();
            if (string.IsNullOrEmpty(fid))
            {
                //查新闻
                newstype newstype = null;
                if (string.IsNullOrEmpty(id))
                {
                    newstype = DataStore.NewsType.Where(a => true).OrderBy(a => a.sort).FirstOrDefault();
                }
                else
                {
                    newstype = DataStore.NewsType.Where(a => a.typeid == id).FirstOrDefault();
                }
                if (newstype != null)
                {
                    var list0 = DB.Instant.NewsManager.Where(a => a.newstype == newstype.typeid).OrderByDescending(a => a.newsislogo).ThenBy(a => a.newsdate);

                    int count = list0.Count();
                    var pagecount = (int)Math.Ceiling(count / (pageSize.Value * 1.0));
                    ViewBag.PageCount = pagecount;
                    list = list0.Skip((pageIndex - 1) * pageSize.Value).Take(pageSize.Value).Select(a => new
                        {
                            a.newstitle,
                            a.newsid,
                            a.newsdate,
                            a.newslogo,
                            a.newssummary
                        }).ToList().Select(a => new news
                        {
                            newstitle = a.newstitle,
                            newsid = a.newsid,
                            newsdate = a.newsdate,
                            newslogo = a.newslogo,
                            newssummary = a.newssummary
                        }).ToList();
                    ViewBag.List = list;
                }
                else
                {
                    ViewBag.Exist = false;
                    return View();
                }
            }
            else
            {
                //var type = DB.Instant.FaultTypeManager.Where(a => a.typeid == fid).FirstOrDefault();
                //if (type != null)
                {
                    var list0 = DB.Instant.FaultManager.Where(a => true).OrderByDescending(a => a.faultdate).ThenBy(a => a.faulttitle);
                    int count = list0.Count();
                    var pagecount = (int)Math.Ceiling(count / (pageSize.Value * 1.0));
                    ViewBag.PageCount = pagecount;
                    list = list0.Skip((pageIndex - 1) * pageSize.Value).Take(pageSize.Value).Select(a => new
                        {
                            a.faulttitle,
                            a.faultid,
                            a.faultdate,
                            a.faultlogo,
                            a.faultsummary
                        }).ToList().Select(a => new news
                        {
                            newstitle = a.faulttitle,
                            newsid = a.faultid,
                            newsdate = a.faultdate,
                            newslogo = a.faultlogo,
                            newssummary = a.faultsummary
                        }).ToList();
                    ViewBag.List = list;
                }
            }
            //两个新闻类别
            var types = DataStore.NewsType.Where(a => true).OrderBy(a => a.sort).Take(2).ToList();
            ViewBag.Types = types;

            //推荐新闻
            var tj = DB.Instant.NewsManager.Where(a => a.newsistj == true).OrderByDescending(a => a.newsdate).Select(a => new
            {
                a.newsdate,
                a.newsid,
                a.newslogo,
                a.newstitle
            }).Take(10).ToList().Select(a => new news
            {
                newsdate = a.newsdate,
                newsid = a.newsid,
                newslogo = a.newslogo,
                newstitle = a.newstitle
            }).ToList();
            ViewBag.TJ = tj;

            return View();
        }

        public ActionResult NewsDetail(string id)
        {
            ViewBag.NewsID = id;
            return View();
        }
        public ActionResult FaultDetail(string id)
        {
            ViewBag.ID = id;
            return View();
        }
        #endregion

        #region 产品鉴定申请表
        public ActionResult CPJD()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        public string CPJDForm(FormCollection form)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                if (string.IsNullOrEmpty(UserID))
                {
                    sb.AppendFormat("alert('用户未登录或登录失效，请重新登录，然后再申请');");
                }
                #region 表单检验
                var appraisalcompanyname = form.Get("appraisalcompanyname");
                var appraisalcompanyaddr = form.Get("appraisalcompanyaddr");
                var appraisalgoodsname = form.Get("appraisalgoodsname");
                var appraisalgoodstype = form.Get("appraisalgoodstype");
                var appraisalmanufacturer = form.Get("appraisalmanufacturer");
                var appraisaloutfactorydate = form.Get("appraisaloutfactorydate");
                var appraisalgoodssummary = form.Get("appraisalgoodssummary");
                var appraisalplandate = form.Get("appraisalplandate");
                var appraisalapplicationdate = form.Get("appraisalapplicationdate");
                var appraisallinkname = form.Get("appraisallinkname");
                var appraisallinktel = form.Get("appraisallinktel");
                var appraisalemail = form.Get("appraisalemail");
                if (string.IsNullOrEmpty(appraisalcompanyname))
                {
                    sb.Append("公司名称不能为空！");
                }
                if (string.IsNullOrEmpty(appraisalgoodsname))
                {
                    sb.Append("产品名称不能为空！");
                }
                if (string.IsNullOrEmpty(appraisalgoodssummary))
                {
                    sb.Append("产品简介不能为空！");
                }
                if (string.IsNullOrEmpty(appraisalplandate))
                {
                    sb.Append("计划鉴定时间不能为空！");
                }
                if (string.IsNullOrEmpty(appraisalapplicationdate))
                {
                    sb.Append("申请时间不能为空！");
                }
                if (string.IsNullOrEmpty(appraisallinkname))
                {
                    sb.Append("联系人不能为空！");
                }
                if (string.IsNullOrEmpty(appraisallinktel))
                {
                    sb.Append("联系电话不能为空！");
                }
                #endregion

                #region 表单提交
                var model = new appraisalapplication()
                {
                    appraisalcompanyname = appraisalcompanyname,
                    appraisalcompanyaddr = appraisalcompanyaddr,
                    appraisalgoodsname = appraisalgoodsname,
                    appraisalgoodstype = appraisalgoodstype,
                    appraisalmanufacturer = appraisalmanufacturer,
                    appraisaloutfactorydate = appraisaloutfactorydate,
                    appraisalgoodssummary = appraisalgoodssummary,
                    //appraisalplandate = appraisalplandate,
                    //appraisalapplicationdate = appraisalapplicationdate,
                    appraisallinkname = appraisallinkname,
                    appraisallinktel = appraisallinktel,
                    appraisalemail = appraisalemail,
                    GUID = Guid.NewGuid().ToString(),
                    ispay = false,
                    operatetime = DateTime.Now,
                    state = "未处理",
                    userid = UserID
                };
                if (!string.IsNullOrEmpty(appraisalplandate))
                {
                    model.appraisalplandate = Convert.ToDateTime(appraisalplandate);
                }
                if (!string.IsNullOrEmpty(appraisalapplicationdate))
                {
                    model.appraisalapplicationdate = Convert.ToDateTime(appraisalapplicationdate);
                }
                var r = DB.Instant.AppraisalapplicationManager.Add(model);
                if (r.IsSuccess == false)
                {
                    sb.AppendFormat(r.ResultDescription);
                }
                #endregion
            }
            catch (Exception e)
            {
                sb.AppendFormat("提交错误：请检查出厂日期，计划鉴定时间与申请时间是否为有效的日期或网络是否正常");
            }
            var result = sb.ToString();
            if (string.IsNullOrEmpty(result))
            {
                result = "alert('提交成功！稍候相关人员会电话联系你');";
            }
            return sb.ToString();
        }
        #endregion

        #region 检测申请
        public ActionResult Test()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        #endregion

        #region 培训申请
        public ActionResult Train()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        #endregion

        #region 事故鉴定申请表
        public ActionResult SGJD()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        #endregion

        #region 资质申请
        public ActionResult ZZSQ()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        #endregion

        #region 专家非标技术方案论证
        public ActionResult FALZ()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        //public string FALZForm(FormCollection form)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    try
        //    {
        //        if (string.IsNullOrEmpty(UserName))
        //        {
        //            sb.AppendFormat("alert('用户未登录或登录失效，请重新登录，然后再申请');");
        //        }
        //        #region 表单检验
        //        var proofcompanyname = form.Get("proofcompanyname");
        //        var proofcompanyaddr = form.Get("proofcompanyaddr");
        //        var proofnenginename = form.Get("proofnenginename");
        //        var proofnengineaddr = form.Get("proofnengineaddr");
        //        var proofgoodsname = form.Get("proofgoodsname");
        //        var proofgoodstype = form.Get("proofgoodstype");
        //        var prooftype = form.Get("prooftype");
        //        var proofplandate = form.Get("proofplandate");
        //        var proofapplicationdate = form.Get("proofapplicationdate");
        //        var prooflinkname = form.Get("prooflinkname");
        //        var prooflinktel = form.Get("prooflinktel");
        //        var proofemail = form.Get("proofemail");
        //        if (string.IsNullOrEmpty(proofcompanyname))
        //        {
        //            sb.Append("公司名称不能为空！");
        //        }
        //        if (string.IsNullOrEmpty(proofnenginename))
        //        {
        //            sb.Append("工程名称不能为空！");
        //        }
        //        if (string.IsNullOrEmpty(proofgoodsname))
        //        {
        //            sb.Append("产品名称不能为空！");
        //        }
        //        if (string.IsNullOrEmpty(proofplandate))
        //        {
        //            sb.Append("计划完成时间不能为空！");
        //        }
        //        if (string.IsNullOrEmpty(proofapplicationdate))
        //        {
        //            sb.Append("申请时间不能为空！");
        //        }
        //        if (string.IsNullOrEmpty(prooflinkname))
        //        {
        //            sb.Append("联系人不能为空！");
        //        }
        //        if (string.IsNullOrEmpty(prooflinktel))
        //        {
        //            sb.Append("联系电话不能为空！");
        //        }
        //        #endregion

        //        #region 表单提交
        //        var model = new expertsproofinfo()
        //        {
        //            proofcompanyname = proofcompanyname,
        //            proofcompanyaddr = proofcompanyaddr,
        //            proofnenginename = proofnenginename,
        //            proofnengineaddr = proofnengineaddr,
        //            proofgoodsname = proofgoodsname,
        //            proofgoodstype = proofgoodstype,
        //            prooftype = prooftype,
        //            //appraisalplandate = appraisalplandate,
        //            //appraisalapplicationdate = appraisalapplicationdate,
        //            prooflinkname = prooflinkname,
        //            prooflinktel = prooflinktel,
        //            proofemail = proofemail,
        //            GUID = Guid.NewGuid().ToString(),
        //            ispay = false,
        //            operatetime = DateTime.Now,
        //            state = "未处理",
        //            userid = UserName
        //        };
        //        if (!string.IsNullOrEmpty(proofplandate))
        //        {
        //            model.proofplandate = Convert.ToDateTime(proofplandate);
        //        }
        //        if (!string.IsNullOrEmpty(proofapplicationdate))
        //        {
        //            model.proofapplicationdate = Convert.ToDateTime(proofapplicationdate);
        //        }
        //        var r = DB.Instant.ExpertsproofinfoManager.Add(model);
        //        if (r.IsSuccess == false)
        //        {
        //            sb.AppendFormat(r.ResultDescription);
        //        }
        //        #endregion
        //    }
        //    catch (Exception e)
        //    {
        //        sb.AppendFormat("提交错误：请检查出厂日期，计划鉴定时间与申请时间是否为有效的日期或网络是否正常");
        //    }
        //    var result = sb.ToString();
        //    if (string.IsNullOrEmpty(result))
        //    {
        //        result = "alert('提交成功！稍候相关人员会电话联系你');";
        //    }
        //    return sb.ToString();
        //}
        #endregion

        #region 专家非标技术方案设计
        public ActionResult FASJ()
        {
            ViewBag.UserID = UserID;
            return View();
        }
        #endregion

        #region Page404
        public ActionResult Page404()
        {
            return View();
        }
        #endregion

        #region 登录
        public JsonResult Login(string userphone, string password)
        {
            var Pwd = password;
            var user = DB.Instant.UserManager.First(a => a.userphone == userphone && a.password == Pwd);
            if (user != null)
            {
                UserID = userphone;
                var phone = (user.userphone.Length > 3 ? user.userphone.Substring(0, 3) : user.userphone) + "****" + (user.userphone.Length > 7 ? user.userphone.Substring(7, 4) : "");
                return Json(new AOPResult(0, user.userphone), "text/html");
            }
            return Json(new AOPResult(-1, "手机号或密码错误！"), "text/html");
        }
        #endregion

        #region 内容页面
        public ActionResult GoodsContent(string id)
        {
            var news = DB.Instant.GoodsManager.First(a => a.goodsid == id);
            if (news != null)
            {
                ViewBag.Content = news.goodscontent;
                ViewBag.Title = news.goodsname;
            }
            return View();
        }
        public ActionResult AppContent(string id)
        {
            var news = DB.Instant.AppManager.First(a => a.appid == id);
            if (news != null)
            {
                ViewBag.Content = news.content;
                ViewBag.Title = news.description.Length > 20 ? news.description.Substring(0, 20) : news.description;
            }
            return View();
        }
        public ActionResult NewsContent(string id)
        {
            var news = DB.Instant.NewsManager.First(a => a.newsid == id);
            if (news != null)
            {
                ViewBag.Content = news.newscontent;
                ViewBag.Title = news.newstitle;
            }
            return View();
        }
        public ActionResult FaultContent(string id)
        {
            var news = DB.Instant.FaultManager.First(a => a.faultid == id);
            if (news != null)
            {
                ViewBag.Content = news.faultcontent;
                ViewBag.Title = news.faulttitle;
            }
            return View();
        }
        #endregion
    }
}
