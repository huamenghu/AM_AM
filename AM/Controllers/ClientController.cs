using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Dao;
using AM.BLL;
using AM.Common;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Configuration;
using System.Collections.Specialized;

namespace AM.Controllers
{
    public class ClientController : ApiController
    {
        //目前总开发了55个接口
        private string userLogo = "/fileupload/tx/original/";
        private string gradeLogo = "/fileupload/grade/original/";

        #region login--登录 1

        public HttpResponseMessage getlogin()
        {
            #region 获取参数
            string phone = HttpContext.Current.Request["phone"];
            string pwd = HttpContext.Current.Request["pwd"];
            #endregion

            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postlogin";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {    {"phone",phone},
                     {"pwd",pwd}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postlogin([FromBody]PaLogin model)
        {
            string method = HttpContext.Current.Request.Url.ToString();

            Base b = new Base();
            try
            {
                #region 参数校验
                if (string.IsNullOrEmpty(model.phone))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "phone为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(model.pwd))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "pwd为空";
                    return Json(b, method);
                }
                #endregion

                #region 通过判断手机号码和密码，验证是否登录成功

                using (var db = new amEntities())
                {
                    string loginpwd = string.Empty;
                    string loginname = string.Empty;
                    var user = db.user.FirstOrDefault(a => a.userphone == model.phone.Trim() && a.password == model.pwd.Trim());
                    if (user == null)
                    {
                        b.code = 0;
                        b.message = "phone和pwd不存在，登录失败!";
                        return Json(b, method);
                    }
                    else
                    {
                        if (user.ishuanxin == false)
                        {
                            loginpwd = RandomHelper.GetRandom(6).ToString();
                            loginname = user.userid.Replace("-", "");
                            b = RegHX(loginname, loginpwd);
                            if (b.code == 0)
                            {
                                b.message = "环信服务异常";
                                return Json(b, method);
                            }
                            else
                            {
                                user.ishuanxin = true;
                                user.hxpassword = loginpwd;
                                db.SaveChanges();
                            }
                        }
                    }
                    var query = from u in db.user.Where(a => a.userid == user.userid)
                                join g in db.grade on u.gradeid equals g.gradeid into _g
                                from __g in _g.DefaultIfEmpty()
                                select new
                                {
                                    gradename = __g == null ? string.Empty : __g.gradename,
                                    gradelogo = __g == null ? string.Empty : __g.gradelogo,
                                    userid = u.userid,
                                    userlogo = u.userlogo,
                                    usernickname = u.usernickname,
                                    userpoints = u.userpoints,
                                    userconsumption = u.userconsumption,
                                    ishuanxin = u.ishuanxin,
                                    hxpassword = u.hxpassword
                                };
                    var q = query.FirstOrDefault();
                    if (q == null)
                    {
                        b = new Base();
                        b.code = 0;
                        b.message = "phone和pwd不存在，登录失败!";
                        return Json(b, method);
                    }
                    else
                    {
                        var eLogin = new ExLogin();

                        eLogin.code = 1;
                        eLogin.message = "登录成功";
                        eLogin.userid = q.userid.ToString();
                        eLogin.userlogo = string.IsNullOrEmpty(q.userlogo) ? "" : string.Format("{0}{1}", userLogo, q.userlogo);
                        eLogin.usernickname = q.usernickname;
                        eLogin.gradename = q.gradename;
                        eLogin.gradelogo = string.IsNullOrEmpty(q.gradelogo) ? "" : string.Format("{0}{1}", gradeLogo, q.gradelogo);
                        eLogin.userpoints = q.userpoints;
                        eLogin.userconsumption = q.userconsumption;
                        eLogin.loginname = user.userid.Replace("-", "");
                        eLogin.loginpwd = user.hxpassword;
                        return Json(eLogin, method);
                    }
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 发送手机短信 02

        public HttpResponseMessage getsendsms()
        {
            #region 获取参数
            string phone = HttpContext.Current.Request["phone"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postsendsms";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "phone", phone } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postsendsms()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string phone = HttpContext.Current.Request["phone"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(phone))
                {
                    b.message = "手机号为空";
                    b.code = 0;
                    return Json(b, method);
                }
                #endregion

                var r = MVCTools.CreateSMSCode();

                var url = string.Format("{0}?mobile={1}&tpl_id={2}&tpl_value=%23code%23%3D{3}&dtype=&key={4}", DataStore.SMS_url, phone, DataStore.SMS_tpl_id, r, DataStore.SMS_key);
                CookieCollection cookies = new CookieCollection();
                HttpWebResponse response = MVCTools.CreateGetHttpResponse(url, null, null, cookies);
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                String retValue = sr.ReadToEnd();
                sr.Close();

                var serializer = new JavaScriptSerializer();
                SMS_IPObj ret = serializer.Deserialize<SMS_IPObj>(retValue);

                bool result = ret.error_code.Equals("0", StringComparison.Ordinal);
                if (result == false)
                {
                    b.message = ret.reason;
                    b.code = 0;
                    return Json(b, method);
                }
                else
                {
                    var smscode = new
                    {
                        message = "获取手机验证码成功",
                        code = 1,
                        smscode = r
                    };
                    return Json(smscode, method);
                }
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region registered--注册 3
        //http://am.nchanpin.com/client/getregistered?phone=15234022725&pwd=3
        public HttpResponseMessage getregistered()
        {
            #region 获取参数
            string phone = HttpContext.Current.Request["phone"];
            string pwd = HttpContext.Current.Request["pwd"];
            #endregion

            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postregistered";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {    {"phone",phone},
                     {"pwd",pwd}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postregistered([FromBody]PaRegistered model)
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 参数校验
                if (string.IsNullOrEmpty(model.phone))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "phone为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(model.pwd))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "pwd为空";
                    return Json(b, method);
                }

                //检查手机号码，是否重复
                var tempUser = DB.Instant.UserManager.GeyUserByPhone(model.phone.Trim());
                if (tempUser != null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = model.phone.Trim() + "已注册";
                    return Json(b, method);
                }
                #endregion

                #region 添加数据
                user u = new user();
                u.userid = Guid.NewGuid().ToString();
                u.userlogo = string.Empty;
                u.username = string.Empty;
                u.usernickname = string.Empty;
                u.userphone = model.phone;
                u.usersex = string.Empty;
                u.userpoints = 0;
                u.userconsumption = 0.0;
                u.password = model.pwd;
                u.addrid = string.Empty;
                u.ishuanxin = false;
                var r = DB.Instant.UserManager.Add(u);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "注册成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.message = "注册失败";
                    b.code = 0;
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region findpwd--找回密码 4
        //http://am.nchanpin.com/client/getfindpwd?phone=15234022725&pwd=3
        public HttpResponseMessage getfindpwd()
        {
            #region 获取参数
            string phone = HttpContext.Current.Request["phone"];
            string pwd = HttpContext.Current.Request["pwd"];
            #endregion

            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postfindpwd";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {    {"phone",phone},
                     {"pwd",pwd}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postfindpwd([FromBody]PaBase model)
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 参数校验
                if (string.IsNullOrEmpty(model.phone))
                {
                    b.code = 0;
                    b.message = "phone为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(model.pwd))
                {
                    b.code = 0;
                    b.message = "pwd为空";
                    return Json(b, method);
                }
                #endregion

                #region 更新数据
                var r = DB.Instant.UserManager.UpdatePwdByPhone(model.phone, model.pwd);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "失败";
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }
        #endregion

        #region getuserinfo--个人信息获取 5
        //http://am.nchanpin.com/client/getuserinfo?userid=1
        public HttpResponseMessage getuserinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postuserinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {    {"userid",userid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postuserinfo([FromBody]PaUserinfo model)
        {
            string method = HttpContext.Current.Request.Url.ToString(); Base b = new Base();
            try
            {
                #region 参数校验
                if (string.IsNullOrEmpty(model.userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }

                #endregion

                #region 通过判断userid，验证记录是否存在

                var useridUser = DB.Instant.UserManager.GeyUserByUserID(model.userid.Trim());

                if (useridUser == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                else
                {
                    var e = new ExUserinfo();
                    e.code = 1;
                    e.message = "成功获取个人信息";
                    ///fileupload/tx/original/952FCBD2AF661BDC.png
                    e.userlogo = string.IsNullOrEmpty(useridUser.userlogo) ? "" : string.Format("{0}{1}", userLogo, useridUser.userlogo);
                    e.usernickname = useridUser.usernickname;
                    e.username = useridUser.username;
                    e.userphone = useridUser.userphone;
                    e.uesrsex = useridUser.usersex;
                    return Json(e, method);
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region setuserinfo 6 修改用户信息

        public HttpResponseMessage getsetuserinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string usernickname = HttpContext.Current.Request["usernickname"];
            string username = HttpContext.Current.Request["username"];
            string userphone = HttpContext.Current.Request["userphone"];
            string usersex = HttpContext.Current.Request["usersex"];
            #endregion

            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postsetuserinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {    {"userid",userid},
                    {"usernickname",usernickname},
                    {"username",username},
                    {"userphone",userphone},
                    {"usersex",usersex}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postsetuserinfo()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string usernickname = HttpContext.Current.Request["usernickname"];
                string username = HttpContext.Current.Request["username"];
                string userphone = HttpContext.Current.Request["userphone"];
                string usersex = HttpContext.Current.Request["usersex"];
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                #endregion

                #region 更新数据
                var r = DB.Instant.UserManager.UpdateUserinfoByUserID(userid, usernickname, username, userphone, usersex);
                if (r.IsSuccess)
                {
                    b.code = 1;
                    b.message = "修改成功";
                }
                else
                {
                    b.code = 0;
                    b.message = "修改失败";
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region setuserlogo 6-1 修改头像 未提供 get方法 +1

        public HttpResponseMessage postsetuserlogo()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();

            try
            {
                #region 获取参数

                HttpPostedFile file = HttpContext.Current.Request.Files[0];
                string userid = HttpContext.Current.Request["userid"];

                #endregion

                #region 参数校验

                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }

                if (string.IsNullOrEmpty(file.FileName) || file.ContentLength <= 0)
                {
                    b.code = 0;
                    b.message = "file为空";
                    return Json(b, method);
                }

                #endregion

                #region 图片检验

                if (!CheckImgType(file))
                {
                    b.code = 0;
                    b.message = "图片格式错误,支持jpg,png,gif,bmp,jpeg";
                    return Json(b, method);
                }
                if (!CheckImgBit(file))
                {
                    b.code = 0;
                    b.message = "图片太大,不能超过2M";
                    return Json(b, method);
                }
                #endregion

                #region 上传图片
                //图片扩展名
                string extension = System.IO.Path.GetExtension(file.FileName);
                string fileName = System.IO.Path.GetFileNameWithoutExtension(file.FileName);

                string newFileNameWithExtension = CM.Instant.HashHelper.Hash_MD5_16(fileName);
                string newFileName = string.Format("{0}{1}", newFileNameWithExtension, extension);

                string path = HttpContext.Current.Server.MapPath("~/fileupload/tx/original/");
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                string filePathName = string.Format("{0}{1}", path, newFileName);

                file.SaveAs(filePathName);
                #endregion

                #region 更新数据
                var r = DB.Instant.UserManager.UpdateUserlogoByUserID(userid, newFileName);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = r.ResultDescription;
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }

            return Json(b, method);
        }
        #endregion

        #region 获取用户积分 7
        public HttpResponseMessage getuserpoints()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postuserpoints";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {    {"userid",userid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postuserpoints()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                string userid = HttpContext.Current.Request["userid"];

                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                #endregion

                #region 通过判断userid，验证记录是否存在

                var u = DB.Instant.UserManager.GeyUserByUserID(userid.Trim());

                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                else
                {
                    var e = new ExUserpoints();
                    e.code = 1;
                    e.message = "成功获取用户积分值";
                    e.userpoints = u.userpoints;
                    return Json(e, method);
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region  获取积分规则 8

        public HttpResponseMessage getpointsrule()
        {
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postpointsrule";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postpointsrule()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                #endregion

                #region 参数校验

                #endregion

                #region 获取积分规则
                var appid = Manager.Instant.ConstantManager.GUIDPointsRule.ToString();
                var app = DB.Instant.AppManager.GetApp(appid);
                if (app == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "获取信息不存在";
                    return Json(b, method);
                }
                else
                {
                    App m = new App();
                    m.code = 1;
                    m.message = "获取成功";
                    // m.content = app.content;
                    m.content = ConfigurationManager.AppSettings.Get("ApiUrl") + "/web/appContent/" + appid;
                    return Json(m, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 分页获取用户消费记录 9

        public HttpResponseMessage getuserconsumptionnote()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string pagenumber = HttpContext.Current.Request["pagenumber"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postuserconsumptionnote";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "pagenumber", pagenumber } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postuserconsumptionnote()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string pagenumber = HttpContext.Current.Request["pagenumber"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                #endregion

                #region
                int pageIndex = 0;
                int.TryParse(pagenumber, out pageIndex);
                if (pageIndex == 0) pageIndex = 1;

                var list = DB.Instant.ConsumptionnoteManager.Where(a => a.userid == userid);
                var count = list.Count();
                double sum = 0;
                if (list.Count() > 0)
                {
                    sum = list.Sum(a => a.consumptionnotecountmoney);
                }
                var pageSize = DataStore.PageSize;
                var pageList = list.OrderByDescending(a => a.consumptionnotedate).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new ExConsumptionnote
                {
                    consumptionnotecountmoney = a.consumptionnotecountmoney,
                    consumptionnotelogo = a.consumptionnotelogo,
                    consumptionnotedate = a.consumptionnotedate.ToString("yyyy-MM-dd"),
                    consumptionnoteid = a.consumptionnoteid,
                    consumptionnotetitle = a.consumptionnotetitle
                }).ToList();

                ExConsumptionnotes model = new ExConsumptionnotes()
                {
                    code = 1,
                    message = "获取成功",
                    countitems = count,
                    currentpage = pageIndex,
                    pagesize = pageSize,
                    countpage = (int)Math.Ceiling(count / (pageSize * 1.0)),
                    all = pageList,
                    userconsumption = sum
                };

                return Json(model, method);
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 获取我的全部订单或分类订单 10

        public HttpResponseMessage getmyorder()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string type = HttpContext.Current.Request["type"];
            string pagenumber = HttpContext.Current.Request["pagenumber"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorder";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "type", type }, { "pagenumber", pagenumber } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorder()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string type = HttpContext.Current.Request["type"];
                string pagenumber = HttpContext.Current.Request["pagenumber"];
                #endregion

                #region  参数检验
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(type))
                {
                    b.code = 0;
                    b.message = "type为空";
                    return Json(b, method);
                }
                #endregion

                #region
                var pageIndex = 0;
                var pageSize = DataStore.PageSize;
                int.TryParse(pagenumber, out pageIndex);
                if (pageIndex == 0) pageIndex = 1;
                //var yunfei = DB.Instant.ConfigManager.GetDouble("Money_YouFei");
                //var bi = DB.Instant.ConfigManager.GetDouble("Money_JiFen"); //1元的积分 数
                //var jf = u.userpoints;
                //var dikou = jf / bi;


                var list = new List<ExOrder>();
                var orderList = DB.Instant.OrderManager.Where(a => a.userid == userid && (type == "0" ? true : a.orderstruts == type)).Select(a => new
                {
                    ordercountprice = a.ordercountprice,
                    orderid = a.orderid,
                    ordernumber = a.ordernumber,
                    orderstruts = a.orderstruts,
                    orderdate = a.orderdate,
                    a.usepoints,
                    a.yunfei
                }).OrderByDescending(a => a.orderdate);
                var count = orderList.Count();
                list.AddRange(orderList.Skip(pageSize * (pageIndex - 1)).Take(pageSize).Select(a => new ExOrder
                {
                    ordercountprice = a.ordercountprice,
                    orderid = a.orderid,
                    ordernumber = a.ordernumber,
                    orderstruts = a.orderstruts,
                    yunfei = a.yunfei == null ? 0.0 : a.yunfei.Value,
                    pointforfei = a.usepoints

                }));

                var listOrderID = list.Select(a => a.orderid).ToList();
                var listOrderGoods = DB.Instant.OrderGoodsManager.Where(a => listOrderID.Contains(a.orderid)).ToList();
                foreach (var item in list)
                {
                    item.orderall = listOrderGoods.Where(a => a.orderid == item.orderid).Select(a => new ExOrderGoods
                    {
                        ordergoodsid = a.ordergoodsid,
                        ordergoodscountprice = a.ordergoodscountprice,
                        //ordergoodscountprice = a.ordergoodsdiscountprice * a.ordergoodssize,
                        ordergoodsdiscountprice = a.ordergoodsdiscountprice,
                        ordergoodslogo = a.ordergoodslogo,
                        ordergoodsname = a.ordergoodsname,
                        ordergoodsprice = a.ordergoodsprice,
                        ordergoodssize = a.ordergoodssize
                    }).ToList();
                }
                ExMyOrder myorder = new ExMyOrder();
                myorder.message = "获取成功";
                myorder.code = 1;
                myorder.currentpage = pageIndex;
                myorder.pagesize = pageSize;
                myorder.countitems = count;
                myorder.countpage = (int)Math.Ceiling(count / (pageSize * 1.0));

                var alipay = DB.Instant.AlipayManager.GetAlipay();
                myorder.partner = alipay.partner;
                myorder.private_key = alipay.private_key;
                myorder.ali_public_key = alipay.ali_publick_key;
                myorder.notify_url = alipay.notify_url;
                myorder.seller = alipay.seller;

                myorder.all = list;

                return Json(myorder, method);
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = "未找到订单！";
                return Json(b, method);
            }
        }

        #endregion

        #region 订单详情 11

        public HttpResponseMessage getmyorderxq()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderxq";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderxq()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(orderid))
                {
                    b.code = 0;
                    b.message = "orderid为空！";
                    return Json(b, method);
                }
                #endregion

                #region
                var order = DB.Instant.OrderManager.First(a => a.orderid == orderid);
                if (order == null)
                {
                    b.code = 0;
                    b.message = "未找到订单！";
                    return Json(b, method);
                }
                else
                {
                    var addr = DB.Instant.AddrManager.Where(a => a.addrid == order.addrid).Select(a => new ExAddrSimple
                    {
                        addraddr = a.addraddr,
                        addrname = a.addrname,
                        addrphone = a.addrphone
                    }).FirstOrDefault();

                    //TODO 快递内容
                    var express = DB.Express.SearchExpress(order.ordersendgoodsexpressnumber, order.expresscompanyid);

                    //var yunfei = DB.Instant.ConfigManager.GetDouble("Money_YouFei");
                    //var bi = DB.Instant.ConfigManager.GetDouble("Money_JiFen"); //1元的积分 数
                    //var u = DB.Instant.UserManager.First(a => a.userid == order.userid);
                    //var jf = u.userpoints;
                    //var dikou = jf / bi;

                    ExOrder exorder = new ExOrder()
                    {
                        orderid = order.orderid,
                        ordernumber = order.ordernumber,
                        orderstruts = order.orderstruts,
                        ordercountprice = order.ordercountprice,
                        yunfei = order.yunfei == null ? 0.0 : order.yunfei.Value,
                        pointforfei = order.usepoints
                    };
                    exorder.orderall = DB.Instant.OrderGoodsManager.Where(a => a.orderid == order.orderid).Select(a => new ExOrderGoods
                        {
                            ordergoodscountprice = a.ordergoodsdiscountprice * a.ordergoodssize,
                            //ordergoodscountprice = a.ordergoodscountprice,
                            ordergoodsdiscountprice = a.ordergoodsdiscountprice,
                            ordergoodsid = a.ordergoodsid,
                            ordergoodslogo = a.ordergoodslogo,
                            ordergoodsname = a.ordergoodsname,
                            ordergoodsprice = a.ordergoodsprice,
                            ordergoodssize = a.ordergoodssize
                        }).ToList();


                    ExMyOrderQX model = new ExMyOrderQX();
                    model.message = "获取成功";
                    model.code = 1;
                    model.addr = addr;
                    model.express = express;
                    model.order = exorder;

                    var alipay = DB.Instant.AlipayManager.GetAlipay();
                    model.partner = alipay.partner;
                    model.private_key = alipay.private_key;
                    model.ali_public_key = alipay.ali_publick_key;
                    model.notify_url = alipay.notify_url;
                    model.seller = alipay.seller;

                    return Json(model, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = "未找到订单！";
                return Json(b, method);
            }
        }

        #endregion

        #region 订单物流 12

        public HttpResponseMessage getmyorderexpress()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderexpress";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderexpress()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(orderid))
                {
                    b.code = 0;
                    b.message = "orderid为空！";
                    return Json(b, method);
                }
                #endregion

                #region
                var order = DB.Instant.OrderManager.First(a => a.orderid == orderid);
                if (order == null)
                {
                    b.code = 0;
                    b.message = "未找到订单！";
                    return Json(b, method);
                }
                else
                {
                    //快递内容
                    var express = DB.Express.SearchExpress(order.ordersendgoodsexpressnumber, order.expresscompanyid);

                    //var yunfei = DB.Instant.ConfigManager.GetDouble("Money_YouFei");
                    //var bi = DB.Instant.ConfigManager.GetDouble("Money_JiFen"); //1元的积分 数
                    //var u = DB.Instant.UserManager.First(a => a.userid == order.userid);
                    //var jf = u.userpoints;
                    //var dikou = jf / bi;

                    var exorder = new ExOrder_Express()
                    {
                        orderid = order.orderid,
                        ordernumber = order.ordernumber,
                        orderstruts = order.orderstruts,
                        ordercountprice = order.ordercountprice,
                        expresscompanyname = order.expresscompanyname,
                        ordersendgoodsexpressnumber = order.ordersendgoodsexpressnumber,
                        yunfei = order.yunfei == null ? 0.0 : order.yunfei.Value,
                        pointforfei = order.usepoints
                    };
                    exorder.orderall = DB.Instant.OrderGoodsManager.Where(a => a.orderid == order.orderid).Select(a => new ExOrderGoods
                    {
                        ordergoodscountprice = a.ordergoodscountprice,
                        ordergoodsdiscountprice = a.ordergoodsdiscountprice,
                        ordergoodsid = a.ordergoodsid,
                        ordergoodslogo = a.ordergoodslogo,
                        ordergoodsname = a.ordergoodsname,
                        ordergoodsprice = a.ordergoodsprice,
                        ordergoodssize = a.ordergoodssize
                    }).ToList();


                    ExMyOrderExpress model = new ExMyOrderExpress();
                    model.message = "获取成功";
                    model.code = 1;
                    model.express = express;
                    model.order = exorder;

                    return Json(model, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 退款 13

        public HttpResponseMessage getmyorderrefund()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            string _content = HttpContext.Current.Request["content"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderrefund";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid }, { "content", _content } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderrefund()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                string content = HttpContext.Current.Request["content"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(orderid))
                {
                    b.code = 0;
                    b.message = "orderid为空！";
                    return Json(b, method);
                }
                #endregion

                #region
                var order = DB.Instant.OrderManager.First(a => a.orderid == orderid);
                if (order == null)
                {
                    b.code = 0;
                    b.message = "未找到订单！";
                    return Json(b, method);
                }
                else
                {
                    order.orderstruts = ((int)EnumOrderType.SQTK).ToString();
                    order.orderrejectgoodsremark = content;
                    var r = DB.Instant.OrderManager.Update(order);
                    if (r.IsSuccess)
                    {
                        b.code = 1;
                        b.message = "申请退款成功！";
                        return Json(b, method);
                    }
                    else
                    {
                        b.code = 0;
                        b.message = "申请退款失败！" + MVCTools.FilterScriptFormat(r.ResultDescription);
                        return Json(b, method);
                    }
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 确认收货 14

        public HttpResponseMessage getmyordersureexpress()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyordersureexpress";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyordersureexpress()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(orderid))
                {
                    b.code = 0;
                    b.message = "orderid为空！";
                    return Json(b, method);
                }
                #endregion

                #region
                using (var db = new amEntities())
                {
                    var order = db.order.First(a => a.orderid == orderid);
                    if (order == null)
                    {
                        b.code = 0;
                        b.message = "未找到订单！";
                        return Json(b, method);
                    }
                    else
                    {
                        order.orderstruts = ((int)EnumOrderType.WaitingPingJia).ToString();
                        #region 计算会员积分、消费记录
                        //用户积分再加上消费获取的
                        var Money_JiFen2 = DB.Instant.ConfigManager.GetDouble("Money_JiFen2");
                        var user = db.user.First(a => a.userid == order.userid);
                        if (user != null)
                        {
                            var points = (int)(order.ordercountprice * Money_JiFen2);
                            user.userpoints += points;
                            user.userconsumption = (user.userconsumption == null ? 0.0 : user.userconsumption) + order.ordercountprice;

                        }
                        //消费记录                       
                        var consumptionnote = new consumptionnote()
                        {
                            userid = order.userid,
                            consumptionnoteid = Guid.NewGuid().ToString(),
                            consumptionnotedate = DateTime.Now,
                            consumptionnotelogo = string.Empty,
                            consumptionnotetitle = string.Format("购物-{0}", db.ordergoods.Where(a => a.orderid == order.orderid).Select(a => a.ordergoodsname).Aggregate((m, n) => m + "," + n)),
                            consumptionnotecountmoney = order.ordercountprice
                        };
                        db.consumptionnote.Add(consumptionnote);

                        #endregion
                        db.SaveChanges();

                        b.code = 1;
                        b.message = "确认收货成功";
                        return Json(b, method);
                    }
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 获取支付宝信息 15

        public HttpResponseMessage getmyorderpay()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderpay";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderpay()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region
                var order = DB.Instant.OrderManager.First(a => a.orderid == orderid);
                if (order == null)
                {
                    b.code = 0;
                    b.message = "未找到订单！";
                    return Json(b, method);
                }
                else
                {
                    var pay = DB.Instant.AlipayManager.First();
                    if (pay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空！";
                        return Json(b, method);
                    }
                    var myOrderPay = new ExMyOrderPay()
                    {
                        ali_public_key = pay.ali_publick_key,
                        notify_url = pay.notify_url,
                        private_key = pay.private_key,
                        partner = pay.partner,
                        seller = pay.seller,
                        code = 1,
                        message = "获取成功",
                        ordercountprice = order.ordercountprice.ToString(),
                        ordernumber = order.ordernumber
                    };

                    return Json(myOrderPay, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 获取订单退货信息 16

        public HttpResponseMessage getmyorderrejectedgoodsinfo()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderrejectedgoodsinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderrejectedgoodsinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(orderid))
                {
                    b.message = "订单id为空";
                    b.code = 0;
                    return Json(b, method);
                }
                #endregion

                #region
                var order = DB.Instant.OrderManager.First(a => a.orderid == orderid);
                if (order == null)
                {
                    b.message = "订单不存在";
                    b.code = 0;
                    return Json(b, method);
                }
                else
                {
                    var info = new ExMyOrderRejectedGoodsInfo()
                    {
                        code = 1,
                        message = "获取成功",
                        orderid = order.orderid,
                        ordernumber = order.ordernumber
                    };

                    //获取快递公司信息
                    var expresslist = DB.ExpressCode.Where(a => true).OrderBy(a => a.Sort).ThenBy(a => a.Name).Select(a => new ExWuLiu
                    {
                        wuliuid = a.Code,
                        wuliuname = a.Name
                    }).ToList();
                    info.wuliuinfo = expresslist;
                    return Json(info, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 订单退货 16-1 +2

        public HttpResponseMessage getmyorderrejectedgoods()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            string wuliuid = HttpContext.Current.Request["wuliuid"];
            string orderrejectgoodsexpressnumber = HttpContext.Current.Request["orderrejectgoodsexpressnumber"];
            string orderrejectgoodsremark = HttpContext.Current.Request["orderrejectgoodsremark"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderrejectedgoods";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid }, { "wuliuid", wuliuid }, { "orderrejectgoodsexpressnumber", orderrejectgoodsexpressnumber }, { "orderrejectgoodsremark", orderrejectgoodsremark } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderrejectedgoods()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                string wuliuid = HttpContext.Current.Request["wuliuid"];
                string orderrejectgoodsexpressnumber = HttpContext.Current.Request["orderrejectgoodsexpressnumber"];
                string orderrejectgoodsremark = HttpContext.Current.Request["orderrejectgoodsremark"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(orderid))
                {
                    b.message = "订单id为空";
                    b.code = 0;
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(wuliuid))
                {
                    b.message = "物流公司id为空";
                    b.code = 0;
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(orderrejectgoodsexpressnumber))
                {
                    b.message = "物流号为空";
                    b.code = 0;
                    return Json(b, method);
                }
                #endregion

                #region
                var order = DB.Instant.OrderManager.First(a => a.orderid == orderid);
                if (order == null)
                {
                    b.message = "订单不存在";
                    b.code = 0;
                    return Json(b, method);
                }
                else
                {
                    order.orderstruts = ((int)EnumOrderType.Refund).ToString();
                    order.orderrejectgoodsexpresscompanyid = wuliuid;
                    order.orderrejectgoodsexpressnumber = orderrejectgoodsexpressnumber;
                    order.orderrejectgoodsremark = orderrejectgoodsremark;
                    var r = DB.Instant.OrderManager.Update(order);
                    if (r.IsSuccess)
                    {
                        b.code = 1;
                        b.message = "订单退货成功！";
                        return Json(b, method);
                    }
                    else
                    {
                        b.code = 0;
                        b.message = "订单退货失败！";
                        return Json(b, method);
                    }
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 订单评价 17
        public HttpResponseMessage getmyorderpinjia()
        {
            #region 获取参数
            string orderid = HttpContext.Current.Request["orderid"];
            string pingjia = HttpContext.Current.Request["pingjia"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyorderpinjia";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "orderid", orderid }, { "pingjia", pingjia } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyorderpinjia()
        {
            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string orderid = HttpContext.Current.Request["orderid"];
                string pingjia = HttpContext.Current.Request["pingjia"];
                #endregion
                using (var db = new amEntities())
                {
                    #region 检验参数
                    if (string.IsNullOrEmpty(orderid))
                    {
                        b.code = 0;
                        b.message = "订单ID为空！";
                        return Json(b, method);
                    }
                    if (string.IsNullOrEmpty(pingjia))
                    {
                        b.code = 0;
                        b.message = "评价内容为空！";
                        return Json(b, method);
                    }

                    #endregion

                    #region
                    var isexist = db.orderpingjia.Any(a => a.orderid == orderid);
                    if (isexist == true)
                    {
                        b.message = "订单已评价，不能重复评价";
                        b.code = 0;
                        return Json(b, method);
                    }
                    var order = db.order.First(a => a.orderid == orderid);
                    if (order == null)
                    {
                        b.code = 0;
                        b.message = "订单不存在！";
                        return Json(b, method);
                    }
                    var model = new orderpingjia();
                    model.orderid = orderid;
                    model.pingjia = pingjia;
                    model.GUID = Guid.NewGuid().ToString();
                    db.orderpingjia.Add(model);

                    order.orderstruts = ((int)EnumOrderType.FinishOrder).ToString();
                    db.SaveChanges();
                    b.code = 1;
                    b.message = "订单评价成功！";
                    return Json(b, method);
                    #endregion
                }
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = "订单评价失败！" + Exc.Message;
                return Json(b, method);
            }
        }

        #endregion

        #region updatemypwd 登录用户修改密码 4-1 +3

        public HttpResponseMessage getupdatemypwd()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string oldpwd = HttpContext.Current.Request["oldpwd"];
            string newpwd = HttpContext.Current.Request["newpwd"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupdatemypwd";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   {"userid",userid},
                    {"oldpwd",oldpwd},
                    {"newpwd",newpwd}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupdatemypwd()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string oldpwd = HttpContext.Current.Request["oldpwd"];
                string newpwd = HttpContext.Current.Request["newpwd"];
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(oldpwd))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "oldpwd为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(newpwd))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "newpwd为空";
                    return Json(b, method);
                }
                #endregion

                #region 更新数据
                var r = DB.Instant.UserManager.UpdatemyPwdByUserID(userid, oldpwd, newpwd);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = r.ResultDescription;
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = r.ResultDescription;
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }
        #endregion

        #region 获取用户收货地址列表 18

        public HttpResponseMessage getmyaddrlist()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyaddrlist";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"userid",userid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyaddrlist()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                string userid = HttpContext.Current.Request["userid"];

                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }


                #endregion

                #region 通过userid，获取用户收货地址列表
                List<ExAddr> list = new List<ExAddr>();
                try
                {
                    //Guid g = Guid.Empty;
                    //Guid.TryParse(userid, out g);

                    using (var db = new amEntities())
                    {
                        var query = from a in db.addr.Where(a => a.userid == userid)
                                    join _u in db.user.Where(a => a.userid == userid) on a.addrid equals _u.addrid into c
                                    from d in c.DefaultIfEmpty()
                                    select new ExAddr() { addrid = a.addrid, addrname = a.addrname, addraddr = a.addraddr, addrphone = a.addrphone, adddefault = d == null ? "0" : "1" };
                        list = query.ToList();
                    }

                    //if (list.Any())   //list为空时，addr返回“[]”
                    {
                        ExMyaddrlist e = new ExMyaddrlist();
                        e.code = 1;
                        e.message = "获取成功";
                        e.addr = list;
                        return Json(e, method);
                    }
                }
                catch (Exception Exc)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = MVCTools.FilterScriptFormat(Exc.Message);

                }
                return Json(b, method);
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 获取一条收货地址详情 19

        public HttpResponseMessage getmyaddrone()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string addrid = HttpContext.Current.Request["addrid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyaddrone";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"userid",userid},
                {"addrid",addrid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyaddrone()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                string userid = HttpContext.Current.Request["userid"];
                string addrid = HttpContext.Current.Request["addrid"];

                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }

                if (string.IsNullOrEmpty(addrid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrid为空";
                    return Json(b, method);
                }

                #endregion

                #region 通过userid和addrid，获取用户收货地址列表

                var adr = DB.Instant.AddrManager.GetmyaddroneByUserIDAndAddrID(userid, addrid);
                if (adr == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrid不存在";
                    return Json(b, method);
                }
                else
                {
                    Myaddr m = new Myaddr();
                    m.code = 1;
                    m.message = "获取成功";
                    m.addrid = adr.addrid;
                    m.addrname = adr.addrname;
                    m.addrphone = adr.addrphone;
                    m.addraddr = adr.addraddr;
                    return Json(m, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 添加用户地址 20

        public HttpResponseMessage getaddmyaddr()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string addrname = HttpContext.Current.Request["addrname"];
            string addrphone = HttpContext.Current.Request["addrphone"];
            string addraddr = HttpContext.Current.Request["addraddr"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postaddmyaddr";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"userid",userid},
                {"addrname",addrname},
                {"addrphone",addrphone}, 
                {"addraddr",addraddr}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postaddmyaddr()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                string userid = HttpContext.Current.Request["userid"];
                string addrname = HttpContext.Current.Request["addrname"];
                string addrphone = HttpContext.Current.Request["addrphone"];
                string addraddr = HttpContext.Current.Request["addraddr"];
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addrname))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrname为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addrphone))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrphone为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addraddr))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addraddr为空";
                    return Json(b, method);
                }

                #endregion

                #region 添加数据
                addr ar = new addr();
                ar.addrid = Guid.NewGuid().ToString();
                ar.userid = userid;
                ar.addrname = addrname;
                ar.addrphone = addrphone;
                ar.addraddr = addraddr;
                var r = DB.Instant.AddrManager.Add(ar);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "添加成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.message = r.ResultDescription;
                    b.code = 0;
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 删除用户地址 20-1 +4

        public HttpResponseMessage getdeletemyaddr()
        {
            #region 获取参数
            string addrid = HttpContext.Current.Request["addrid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postdeletemyaddr";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "addrid", addrid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postdeletemyaddr()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string addrid = HttpContext.Current.Request["addrid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(addrid))
                {
                    b.code = 0;
                    b.message = "addrid为空";
                    return Json(b, method);
                }
                #endregion

                #region 删除地址
                using (var db = new amEntities())
                {
                    var r = db.addr.First(a => a.addrid == addrid);
                    if (r == null)
                    {
                        b.code = 0;
                        b.message = "未找到地址！";
                    }
                    else
                    {
                        db.addr.Remove(r);

                        //更新 user表
                        var user = db.user.First(a => a.addrid == addrid);
                        if (user != null)
                        {
                            //将他的默认地址换成其他的第一个地址
                            var addr = db.addr.First(a => a.userid == user.userid && a.addrid != addrid);
                            if (addr != null)
                            {
                                user.addrid = addr.addrid;
                            }
                            else
                            {
                                user.addrid = string.Empty;
                            }
                            db.SaveChanges();
                            b.code = 1;
                            b.message = "删除地址成功";
                        }
                        else
                        {
                            b.code = 0;
                            b.message = "用户未找到";
                        }
                    }
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region  修改某一收货地址 21

        public HttpResponseMessage getupdatemyaddr()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string addrid = HttpContext.Current.Request["addrid"];
            string addrname = HttpContext.Current.Request["addrname"];
            string addrphone = HttpContext.Current.Request["addrphone"];
            string addraddr = HttpContext.Current.Request["addraddr"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupdatemyaddr";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   {"userid",userid},
                    {"addrid",addrid},
                    {"addrname",addrname},
                    {"addrphone",addrphone},
                    {"addraddr",addraddr}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupdatemyaddr()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string addrid = HttpContext.Current.Request["addrid"];
                string addrname = HttpContext.Current.Request["addrname"];
                string addrphone = HttpContext.Current.Request["addrphone"];
                string addraddr = HttpContext.Current.Request["addraddr"];
                userid = userid.Trim();
                addrid = addrid.Trim();
                addrname = addrname.Trim();
                addrphone = addrphone.Trim();
                addraddr = addraddr.Trim();
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addrid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrid为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addrname))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrname为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addrphone))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrphone为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addraddr))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addraddr为空";
                    return Json(b, method);
                }
                #endregion

                #region 更新数据
                var r = DB.Instant.AddrManager.UpdateMyaddrByUserIDAndAddrID(userid, addrid, addrname, addrphone, addraddr);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "修改地址成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "修改地址失败";
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region  设置某一收货地址为默认地址 22

        public HttpResponseMessage getsetmyaddrdefault()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string addrid = HttpContext.Current.Request["addrid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postsetmyaddrdefault";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   {"userid",userid},
                    {"addrid",addrid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postsetmyaddrdefault()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string addrid = HttpContext.Current.Request["addrid"];
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(addrid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "addrid为空";
                    return Json(b, method);
                }

                #endregion

                #region 更新数据
                var r = DB.Instant.UserManager.UpdateSetMyDddrDefault(userid, addrid);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "设置地址成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "设置地址失败";
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 提交反馈意见 23

        public HttpResponseMessage getupfeedbackinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string content = HttpContext.Current.Request["content"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupfeedbackinfo";

            using (var http = new HttpClient())
            {
                var content_1 = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"userid",userid},
                {"content",content}
                 });
                var response = http.PostAsync(url, content_1).Result;
                return response;
            }
        }

        public HttpResponseMessage postupfeedbackinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                string userid = HttpContext.Current.Request["userid"];
                string content = HttpContext.Current.Request["content"];
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(content))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "content为空";
                    return Json(b, method);
                }
                #endregion

                #region 添加数据
                upfeedbackinfo up = new upfeedbackinfo();
                up.guid = Guid.NewGuid().ToString();
                up.userid = userid;
                up.content = content;
                up.dt = DateTime.Now;
                up.description = string.Empty;
                var r = DB.Instant.UpfeedBackInfoManager.Add(up);
                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "添加成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.message = "添加失败";
                    b.code = 0;
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region  获取联系我们内容 24

        public HttpResponseMessage getlinkme()
        {
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postlinkme";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postlinkme()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                #endregion

                #region 参数校验

                #endregion

                #region 获取联系我们内容
                var appid = Manager.Instant.ConstantManager.GUIDLinkMe.ToString();
                var app = DB.Instant.AppManager.GetApp(appid);
                if (app == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "获取内容不存在";
                    return Json(b, method);
                }
                else
                {
                    App m = new App();
                    m.code = 1;
                    m.message = "获取成功";
                    // m.content = app.content;
                    m.content = ConfigurationManager.AppSettings.Get("ApiUrl") + "/web/appContent/" + appid;
                    return Json(m, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region  获取关于我们信息 25

        public HttpResponseMessage getaboutme()
        {
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postaboutme";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postaboutme()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                #endregion

                #region 参数校验

                #endregion

                #region 获取关于我们
                var appid = Manager.Instant.ConstantManager.GUIDAboutMe.ToString();
                var app = DB.Instant.AppManager.GetApp(appid);
                if (app == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "获取信息不存在";
                    return Json(b, method);
                }
                else
                {
                    App m = new App();
                    m.code = 1;
                    m.message = "获取成功";
                    //m.content = app.content;
                    m.content = ConfigurationManager.AppSettings.Get("ApiUrl") + "/web/appContent/" + appid;
                    return Json(m, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 获取无忧商城首页信息 26

        public HttpResponseMessage getshopindex()
        {
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postshopindex";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postshopindex()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数

                #endregion

                #region 参数校验

                #endregion

                #region 获取无忧商城首页信息
                try
                {
                    ExShopIndex esi = new ExShopIndex();
                    esi.message = "获取成功";
                    esi.code = 1;
                    esi.tjgoods = new List<ExGoodsIndex>();
                    esi.typegoods = new List<ExTypeGoods>();
                    using (var db = new amEntities())
                    {
                        {
                            var ads = DB.Instant.AdManager.Where(a => true).Select(a => new ExAd
                            {
                                adid = a.adid,
                                adimgurl = a.adimgurl
                            }).ToList();
                            esi.ads = ads;
                        }
                        {
                            var tjlist = from r in db.recommended.Where(a => a.recommendedtype == "index")
                                         join g in db.goods on r.recommendedgoods equals g.goodsid
                                         select new { goodsid = g.goodsid, g.buycount, goodsname = g.goodsname, goodsprice = g.goodsprice, goodslogo = g.goodslogo, goodsdiscountprice = g.goodsdiscountprice };
                            var collection = tjlist.OrderByDescending(a => a.buycount).Take(3).ToList();

                            if (collection.Any())
                            {
                                List<ExGoodsIndex> list = new List<ExGoodsIndex>();
                                foreach (var g in collection)
                                {
                                    list.Add(new ExGoodsIndex() { goodsid = g.goodsid, goodsname = g.goodsname, goodsprice = g.goodsprice.ToString(), goodslogo = g.goodslogo, goodsdiscountprice = g.goodsdiscountprice.ToString() });
                                }

                                esi.tjgoods = list;
                            }
                        }

                        {
                            var typegoods = from gt in db.goodstype.Where(a => string.IsNullOrEmpty(a.pid))
                                            join g in db.goods on gt.typeid equals g.goodstype
                                            select new
                                            {
                                                pid = gt.pid,
                                                typeadimgurl = gt.typeadimgurl,
                                                typeid = gt.typeid,
                                                typename = gt.typename,
                                                goodsid = g.goodsid,
                                                goodsname = g.goodsname,
                                                goodslogo = g.goodslogo,
                                                goodsprice = g.goodsprice,
                                                goodsdiscountprice = g.goodsdiscountprice

                                            };

                            if (typegoods.Any())
                            {
                                var list = typegoods.GroupBy(a => new { a.typeadimgurl, a.typeid, a.typename }).Select(a => new { a.Key, a }).ToList();
                                //商品分类列表
                                List<ExTypeGoods> tglist = list.Where(a => true).Select(a => new ExTypeGoods() { typeadimgurl = a.Key.typeadimgurl, typeid = a.Key.typeid, typename = a.Key.typename }).Distinct().ToList();

                                if (list.Any())
                                {
                                    foreach (var item in list)
                                    {
                                        var tg = tglist.FirstOrDefault(a => a.typeid == item.Key.typeid);
                                        var gg = item.a.Where(a => true).Select(g => new ExGoodsIndex() { goodsid = g.goodsid, goodsname = g.goodsname, goodsprice = g.goodsprice.ToString(), goodslogo = g.goodslogo, goodsdiscountprice = g.goodsdiscountprice.ToString() }).Distinct().ToList();
                                        if (tg != null)
                                        {
                                            tg.goods = gg;
                                        }
                                    }
                                }
                                esi.typegoods = tglist;
                            }
                        }
                    }
                    return Json(esi, method);
                }
                catch (Exception Exc)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "未找到商品";
                    return Json(b, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 获取商城全部两级分类 27

        public HttpResponseMessage getshoptype()
        {
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postshoptype";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postshoptype()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                #endregion

                #region 参数校验

                #endregion

                #region 获取分类信息

                List<goodstype> list = null;
                using (var db = new amEntities())
                {
                    list = db.goodstype.Where(a => true).ToList();
                }
                if (list.Any())
                {
                    ExGoodsType e = new ExGoodsType();
                    e.code = 1;
                    e.message = "获取成功";
                    e.type = new List<ExGoodsTypeFirst>();
                    var f = list.Where(a => string.IsNullOrEmpty(a.pid));
                    foreach (var item in f)
                    {
                        ExGoodsTypeFirst etf = new ExGoodsTypeFirst();
                        etf.typeid = item.typeid;
                        etf.typename = item.typename;
                        etf.typeadimgurl = item.typeadimgurl;
                        etf.typelogo = item.typelogo;
                        etf.sontype = new List<ExGoodsTypeSecond>();
                        var s = list.Where(a => a.pid == item.typeid && a.isPinPai == false);
                        foreach (var item1 in s)
                        {
                            ExGoodsTypeSecond ets = new ExGoodsTypeSecond();
                            ets.typeid = item1.typeid;
                            ets.typename = item1.typename;
                            ets.typelogo = item1.typelogo;
                            ets.typeadimgurl = item1.typeadimgurl;
                            etf.sontype.Add(ets);
                        }
                        e.type.Add(etf);
                    }
                    return Json(e, method);
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "未找到商品分类";
                    return Json(b, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 条件搜索商城内容 28

        public HttpResponseMessage getshopsearch()
        {
            #region 获取参数
            string name = HttpContext.Current.Request["name"];
            string type1id = HttpContext.Current.Request["type1id"];
            string type2id = HttpContext.Current.Request["type2id"];
            string istj = HttpContext.Current.Request["istj"];
            string pagenumber = HttpContext.Current.Request["pagenumber"];
            #endregion

            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postshopsearch";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {
                {"name",name},
                {"type1id",type1id},
                {"type2id",type2id},
                {"istj",istj},
                {"pagenumber",pagenumber}
                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postshopsearch()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string name = HttpContext.Current.Request["name"];
                string type1id = HttpContext.Current.Request["type1id"];
                string type2id = HttpContext.Current.Request["type2id"];
                string istj = HttpContext.Current.Request["istj"];
                string pagenumber = HttpContext.Current.Request["pagenumber"];
                #endregion

                #region 参数校验
                //分类编码改为guid了，不按位数判断了
                //if (!string.IsNullOrEmpty(type1id) && type1id.Length != 5)
                //{
                //    b = new Base();
                //    b.code = 0;
                //    b.message = "一级分类编号错误";
                //    return Json(b,method);
                //}
                //if (!string.IsNullOrEmpty(type2id) && type2id.Length != 10)
                //{
                //    b = new Base();
                //    b.code = 0;
                //    b.message = "二级分类编号错误";
                //    return Json(b,method);
                //}
                if (string.IsNullOrEmpty(istj))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "istj为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(pagenumber))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "pagenumber为空";
                    return Json(b, method);
                }
                //if (!string.IsNullOrEmpty(type2id))
                //{
                //    type1id = type2id.Substring(0, 5);
                //}

                int pn = 0;
                int.TryParse(pagenumber, out pn);

                #endregion

                #region 获取无忧商城首页信息
                int pageSize = DataStore.PageSize;  //分页大小
                int currentpage = pn; //当前页码
                int countpage = 0;//总页面数
                int countitems = 0;//总条数
                try
                {
                    List<goods> list = new List<goods>();

                    using (var db = new amEntities())
                    {
                        var type2s = db.goodstype.Where(a => a.pid == type1id).Select(a => a.typeid).ToList();
                        var query1 = db.goods.Where(a => (string.IsNullOrEmpty(name) ? true : a.goodsname.IndexOf(name) > -1)
                            && (string.IsNullOrEmpty(type1id) ? true : a.goodstype == type1id)
                            && (string.IsNullOrEmpty(type2id) ? true : a.goodsType2 == type2id));


                        var query2 = from r in db.recommended.Where(a => a.recommendedtype == "index")
                                     join g in query1 on r.recommendedgoods equals g.goodsid
                                     select g;
                        if (istj == "0")
                        {
                            var query = query1;
                            countitems = query.Count();
                            countpage = (int)Math.Ceiling(countitems / (pageSize * 1.0));
                            list = query.OrderBy(a => a.goodsid).Skip(pageSize * (currentpage - 1)).Take(pageSize).ToList();

                        }
                        else
                        {
                            var query = query2;
                            countitems = query.Count();
                            countpage = (int)Math.Ceiling(countitems / (pageSize * 1.0));
                            list = query.OrderBy(a => a.goodsid).Skip(pageSize * (currentpage - 1)).Take(pageSize).ToList();
                        }

                    }
                    var ads = DB.Instant.AdManager.Where(a => true).Select(a => new ExAd
                    {
                        adid = a.adid,
                        adimgurl = a.adimgurl
                    }).ToList();
                    List<ExGoodsSearch> list1 = list.Select(a => new ExGoodsSearch() { goodsid = a.goodsid, goodsname = a.goodsname, goodslogo = a.goodslogo, goodsprice = a.goodsprice.ToString(), goodsdiscountprice = a.goodsdiscountprice.ToString() }).ToList();
                    ExShopSearch ess = new ExShopSearch();
                    ess.message = "获取成功";
                    ess.pagesize = pageSize.ToString();
                    ess.code = 1;
                    ess.countitems = countitems.ToString();
                    ess.countpage = countpage.ToString();
                    ess.currentpage = currentpage.ToString();
                    ess.goods = list1;
                    ess.ads = ads;

                    return Json(ess, method);

                }
                catch (Exception Exc)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "未找到商品";
                    return Json(b, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 查看商品详情 29

        public HttpResponseMessage getshoponegoods()
        {
            #region 获取参数
            string goodsid = HttpContext.Current.Request["goodsid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postshoponegoods";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"goodsid",goodsid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postshoponegoods()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数

                string goodsid = HttpContext.Current.Request["goodsid"];

                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(goodsid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsid为空";
                    return Json(b, method);
                }

                #endregion

                #region 查看商品详情

                var g = DB.Instant.GoodsManager.First(goodsid);
                if (g == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsid不存在";
                    return Json(b, method);
                }
                else
                {
                    ExGoods m = new ExGoods();
                    m.code = 1;
                    m.message = "获取成功";
                    m.goodsid = g.goodsid;
                    m.goodsname = g.goodsname;
                    m.goodslogo = g.goodslogo;
                    m.goodsprice = Convert.ToString(g.goodsprice);
                    m.goodsdiscountprice = Convert.ToString(g.goodsdiscountprice);
                    //m.goodscontent = g.goodscontent;
                    m.goodscontent = ConfigurationManager.AppSettings.Get("ApiUrl") + "/web/goodsContent/" + g.goodsid;
                    //更新查看数
                    g.clickcount = (g.clickcount == null ? 0 : g.clickcount) + 1;
                    DB.Instant.GoodsManager.Update(g);
                    return Json(m, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 加入购物车 30

        public HttpResponseMessage getaddcat()
        {
            #region 获取参数
            string goodsid = HttpContext.Current.Request["goodsid"];
            string userid = HttpContext.Current.Request["userid"];
            string goodssize = HttpContext.Current.Request["goodssize"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postaddcat";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"goodsid",goodsid},
                {"userid",userid},
                {"goodssize",Convert.ToString( goodssize)}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postaddcat()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数

                string goodsid = HttpContext.Current.Request["goodsid"];
                string userid = HttpContext.Current.Request["userid"];
                string goodssize = HttpContext.Current.Request["goodssize"];

                int gss = 0;
                int.TryParse(goodssize, out gss);

                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(goodsid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsid为空";
                    return Json(b, method);
                }
                var gd = DB.Instant.GoodsManager.GetGoodsByGoodsID(goodsid);
                if (gd == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(goodssize))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodssize为空";
                    return Json(b, method);
                }

                if (gss == 0)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodssize为0";
                    return Json(b, method);
                }
                #endregion

                #region 添加数据
                //检查购物车是否已经存在商品
                var old = DB.Instant.CatManager.Where(a => a.goodsid == goodsid && a.userid == userid);
                if (old.Any())
                {
                    var ct = old.FirstOrDefault();
                    ct.goodssize += gss;
                    var r = DB.Instant.CatManager.Update(ct);
                    if (r.IsSuccess)
                    {
                        b = new Base();
                        b.message = "添加成功";
                        b.code = 1;
                    }
                    else
                    {
                        b = new Base();
                        b.message = "添加失败";
                        b.code = 0;
                    }
                }
                else
                {
                    cat ct = new cat();
                    ct.catid = Guid.NewGuid().ToString();
                    ct.goodsid = goodsid;
                    ct.userid = userid;
                    ct.goodssize = gss;
                    var r = DB.Instant.CatManager.Add(ct);
                    if (r.IsSuccess)
                    {
                        b = new Base();
                        b.message = "添加成功";
                        b.code = 1;
                    }
                    else
                    {
                        b = new Base();
                        b.message = "添加失败";
                        b.code = 0;
                    }
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region 获取购物车 31

        public HttpResponseMessage getcat()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postcat";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postcat()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                #endregion

                #region
                var list = (from a in DB.Instant.CatManager.Where(a => a.userid == userid)
                            join bb in DB.Instant.GoodsManager.Where(a => true) on a.goodsid equals bb.goodsid
                            select new
                            {
                                goodsid = bb.goodsid,
                                goodsname = bb.goodsname,
                                goodslogo = bb.goodslogo,
                                goodsprice = bb.goodsprice,
                                goodsdiscountprice = bb.goodsdiscountprice,
                                goodssize = a.goodssize
                            }).ToList();
                var list2 = list.Select(a => new ExCatGoods
                            {
                                goodsid = a.goodsid,
                                goodsname = a.goodsname,
                                goodslogo = a.goodslogo,
                                goodsprice = a.goodsprice.ToString(),
                                goodsdiscountprice = a.goodsdiscountprice.ToString(),
                                goodssize = a.goodssize
                            }).ToList();
                var youlike = DB.Instant.GoodsManager.Where(a => true).OrderByDescending(a => a.buycount).Select(a => new
                {
                    goodsid = a.goodsid,
                    goodsname = a.goodsname,
                    goodslogo = a.goodslogo
                }).Take(2);

                var cat = new
                {
                    code = 1,
                    message = "获取成功",
                    goods = list2,
                    iscatnan = list.Count > 0 ? "1" : "0",
                    catcountprice = list.Sum(a => a.goodsdiscountprice * a.goodssize),
                    youlikegoods = youlike
                };
                return Json(cat, method);
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 删除购物车中商品 32

        public HttpResponseMessage getdeletecatgoods()
        {
            #region 获取参数
            string goodsids = HttpContext.Current.Request["goodsids"];
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postdeletecatgoods";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                {"goodsids",goodsids},
                {"userid",userid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postdeletecatgoods()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数

                string goodsids = HttpContext.Current.Request["goodsids"];
                string userid = HttpContext.Current.Request["userid"];

                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(goodsids))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsids为空";
                    return Json(b, method);
                }
                var goodsList = goodsids.Trim().Split(',').ToList();
                var gd = DB.Instant.GoodsManager.Count(a => goodsList.Contains(a.goodsid));
                if (gd != goodsList.Count)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsids格式非法或商品不存在，请检查是否以(,)分隔";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "user不存在";
                    return Json(b, method);
                }
                #endregion

                #region 删除购物车商品

                var ct = DB.Instant.CatManager.Delete(a => a.userid == userid && goodsList.Contains(a.goodsid));

                if (ct.IsSuccess)
                {
                    b = new Base();
                    b.message = "删除购物车商品成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.message = ct.ResultDescription;
                    b.code = 0;
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);

        }

        #endregion

        #region  修改购物车产品数量 33

        public HttpResponseMessage getupdatecatgoodssize()
        {
            #region 获取参数
            string goodsid = HttpContext.Current.Request["goodsid"];
            string userid = HttpContext.Current.Request["userid"];
            string goodssize = HttpContext.Current.Request["goodssize"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupdatecatgoodssize";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   {"goodsid",goodsid},
                    {"userid",userid},
                    {"goodssize",goodssize}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupdatecatgoodssize()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {

                #region 获取参数
                string goodsid = HttpContext.Current.Request["goodsid"];
                string userid = HttpContext.Current.Request["userid"];
                string goodssize = HttpContext.Current.Request["goodssize"];
                goodsid = goodsid.Trim();
                userid = userid.Trim();
                goodssize = goodssize.Trim();

                int gss = 0;
                int.TryParse(goodssize, out gss);

                #endregion

                #region 参数校验

                if (string.IsNullOrEmpty(goodsid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsid为空";
                    return Json(b, method);
                }
                var gd = DB.Instant.GoodsManager.GetGoodsByGoodsID(goodsid);
                if (gd == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodsid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(goodssize))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodssize为空";
                    return Json(b, method);
                }

                if (gss == 0)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "goodssize为0";
                    return Json(b, method);
                }
                #endregion

                #region 更新数据
                var r = DB.Instant.CatManager.UpdateCatGoodsSizeByGoodsIDAndUserID(goodsid, userid, goodssize);

                if (r.IsSuccess)
                {
                    b = new Base();
                    b.message = "更新成功";
                    b.code = 1;
                }
                else
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "更新失败";
                }

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region  确认下单，获取到用户的默认地址信息 34

        public HttpResponseMessage getsuremycat()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string goodsid = HttpContext.Current.Request["goodsid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postsuremycat";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()       
                {   
                    {"userid",userid}
                 });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postsuremycat()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string goodsid = HttpContext.Current.Request["goodsid"];
                string userid = HttpContext.Current.Request["userid"];
                string addrid = string.Empty;
                int userpoints = 0;
                double pointsmoneyexchange = 1 / DB.Instant.ConfigManager.GetDouble("Money_JiFen");

                double catcountprice = 0;
                #endregion

                #region 参数校验

                if (string.IsNullOrEmpty(userid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(goodsid))
                {
                    b.code = 0;
                    b.message = "goodsid为空";
                    return Json(b, method);
                }
                var ur = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (ur == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                else
                {
                    addrid = ur.addrid;
                    userpoints = ur.userpoints;
                }
                #endregion

                #region 获取数据
                ExSureMyCat esm = new ExSureMyCat();
                string[] goodsidlist = goodsid.Split(',');
                esm.code = 1;
                esm.message = "获取成功";

                var addr = DB.Instant.AddrManager.GetAddrByAddrID(addrid);
                if (addr == null)
                {
                    esm.isaddr = "0";
                    esm.addr = new ExAddr() { };
                }
                else
                {
                    esm.isaddr = "1";
                    esm.addr = new ExAddr()
                    {
                        addrid = addr.addrid,
                        addrname = addr.addrname,
                        addrphone = addr.addrphone,
                        addraddr = addr.addraddr,
                        adddefault = "1"
                    };
                }
                var bi = DB.Instant.GradeManager.GetDiscount(ur.gradeid);
                var cats = (from a in DB.Instant.CatManager.Where(a => (a.userid == userid) && (string.IsNullOrEmpty(goodsid) ? true : goodsidlist.Contains(a.goodsid)))
                            join bb in DB.Instant.GoodsManager.Where(a => true) on a.goodsid equals bb.goodsid
                            select new
                            {
                                a.goodsid,
                                bb.goodsprice,
                                a.goodssize,
                                bb.goodsname,
                                bb.goodslogo,
                                goodsdiscountprice = bb.goodsprice * bi

                            }).ToList();

                if (cats.Count > 0)
                {
                    foreach (var item in cats)
                    {
                        var price = item.goodsdiscountprice;
                        catcountprice += price * item.goodssize;
                    }
                    esm.goods = cats.Select(a => new ExGoods2
                    {
                        goodsid = a.goodsid,
                        goodsprice = MVCTools.ConvertToString(a.goodsprice),
                        goodssize = a.goodssize,
                        goodsname = a.goodsname,
                        goodslogo = a.goodslogo,
                        goodsdiscountprice = MVCTools.ConvertToString(a.goodsdiscountprice)
                    }).ToList();
                }
                else
                {
                    //购物车没有时，返回最热销2件
                    var cats2 = DB.Instant.GoodsManager.Where(a => true).OrderByDescending(a => a.buycount)
                        .Select(a => new
                        {
                            goodsid = a.goodsid,
                            goodsprice = a.goodsprice,
                            goodssize = 0,
                            goodsname = a.goodsname,
                            goodslogo = a.goodslogo,
                            goodsdiscountprice = a.goodsdiscountprice
                        }).Take(2).ToList().Select(a => new ExGoods2()
                     {
                         goodsid = a.goodsid,
                         goodsprice = a.goodsprice.ToString(),
                         goodssize = 0,
                         goodsname = a.goodsname,
                         goodslogo = a.goodslogo,
                         goodsdiscountprice = MVCTools.ConvertToString(a.goodsdiscountprice)
                     });
                    esm.goods = cats2.ToList();
                }

                esm.userpoints = userpoints;
                esm.pointsmoneyexchange = pointsmoneyexchange;
                esm.pointsmoney = userpoints * pointsmoneyexchange;
                esm.catcountprice = catcountprice;
                //邮费 包邮
                var youfei = DB.Instant.ConfigManager.GetDouble("Money_YouFei");
                var baoyou = DB.Instant.ConfigManager.GetDouble("Money_BaoYou");

                if (catcountprice >= baoyou)
                {
                    youfei = 0;
                }
                esm.yunfei = youfei;
                esm.baoyoue = baoyou;

                return Json(esm, method);

                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 下单 35

        public HttpResponseMessage getsavecattoorder()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string ispoints = HttpContext.Current.Request["ispoints"];
            string points = HttpContext.Current.Request["points"];
            string addrid = HttpContext.Current.Request["addrid"];
            string goodsid = HttpContext.Current.Request["goodsid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postsavecattoorder";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "ispoints", ispoints }, { "points", points }, { "addrid", addrid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postsavecattoorder()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                using (var db = new amEntities())
                {
                    #region 获取参数
                    string userid = HttpContext.Current.Request["userid"];
                    string ispoints = HttpContext.Current.Request["ispoints"];
                    string addrid = HttpContext.Current.Request["addrid"];
                    string goodsid = HttpContext.Current.Request["goodsid"];
                    string points = HttpContext.Current.Request["points"];
                    #endregion

                    #region 检验参数
                    if (string.IsNullOrEmpty(userid))
                    {
                        b.code = 0;
                        b.message = "userid为空";
                        return Json(b, method);
                    }
                    var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                    if (u == null)
                    {
                        b = new Base();
                        b.code = 0;
                        b.message = "userid不存在";
                        return Json(b, method);
                    }
                    if (string.IsNullOrEmpty(ispoints))
                    {
                        b.code = 0;
                        b.message = "ispoints为空";
                        return Json(b, method);
                    }
                    if (string.IsNullOrEmpty(points))
                    {
                        b.code = 0;
                        b.message = "points为空";
                        return Json(b, method);
                    }
                    if (string.IsNullOrEmpty(goodsid))
                    {
                        b.code = 0;
                        b.message = "goodsid为空";
                        return Json(b, method);
                    }
                    #endregion

                    #region 下单
                    //处理goodsid                     
                    string[] goodsidlist = goodsid.Split(',');

                    int p = 0;
                    int.TryParse(points, out p);
                    var user = db.user.FirstOrDefault(a => a.userid == userid);
                    if (user == null)
                    {
                        b.code = 0;
                        b.message = "未找到用户";
                        return Json(b, method);
                    }
                    if (ispoints == "1")
                    {
                        if (user.userpoints < p)
                        {
                            b.code = 0;
                            b.message = "积分不够";
                            return Json(b, method);
                        }
                    }
                    else
                    {
                        p = 0;
                    }

                    double orderuserdiscount = 1;
                    orderuserdiscount = DB.Instant.GradeManager.GetDiscount(user.gradeid);
                    var BI = DB.Instant.ConfigManager.GetDouble("Money_JiFen");
                    //生成订单,将购物车内容转移到这里
                    var cat = (from a in DB.Instant.GoodsManager.Where(a => true)
                               join bb in DB.Instant.CatManager.Where(t => (t.userid == userid) && (string.IsNullOrEmpty(goodsid) ? true : goodsidlist.Contains(t.goodsid))) on a.goodsid equals bb.goodsid
                               select new
                               {
                                   a.goodsid,
                                   a.goodsprice,
                                   goodsdiscountprice = a.goodsprice * orderuserdiscount,
                                   a.goodsname,
                                   bb.goodssize
                               }).ToList();
                    if (cat.Count == 0)
                    {
                        b.code = 0;
                        b.message = "下单失败：购物车里无商品";
                        return Json(b, method);
                    }

                    double summoney = 0;
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        userid = userid,
                        ordernumber = MVCTools.GetOrderNumber(),
                        ordertype = "1",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                        orderdate = DateTime.Now
                    };
                    if (!string.IsNullOrEmpty(addrid))
                    {
                        order.addrid = addrid;
                    }
                    else
                    {
                        order.addrid = user.addrid;
                    }
                    order.orderuserdiscount = orderuserdiscount;

                    foreach (var item in cat)
                    {
                        var goods = db.goods.FirstOrDefault(a => a.goodsid == item.goodsid);
                        if (goods == null)
                        {
                            b.message = string.Format("商品信息：{0}已经不存在，请删除此商品，重新添加购物车", goods.goodsname);
                            b.code = 0;
                            return Json(b, method);
                        }
                        var goodslogo = goods.goodslogo;
                        var ordergoods = new ordergoods()
                        {
                            orderid = order.orderid,
                            guid = Guid.NewGuid().ToString(),
                            ordergoodsid = item.goodsid,
                            ordergoodsname = item.goodsname,
                            ordergoodsprice = item.goodsprice,
                            ordergoodssize = item.goodssize,
                            ordergoodslogo = goodslogo,
                            //ordergoodsdiscountprice = orderuserdiscount * item.goodsprice,
                            ordergoodsdiscountprice = item.goodsdiscountprice,
                            ordergoodscountprice = item.goodssize * item.goodsdiscountprice
                        };
                        summoney += ordergoods.ordergoodscountprice;
                        db.ordergoods.Add(ordergoods);
                    }
                    var yunfei = DB.Instant.OrderManager.GetYunFei(summoney);  //运费
                    order.yunfei = yunfei;
                    order.ordercountprice = summoney + yunfei - (p / BI);//减去积分抵扣
                    order.usepoints = p / BI;
                    db.order.Add(order);
                    //更新用户积分                
                    user.userpoints -= p;

                    //清空购物车
                    var cats = db.cat.Where(a => a.userid == userid);
                    foreach (var item in cats)
                    {
                        db.cat.Remove(item);
                    }

                    var r = db.SaveChanges();
                    if (r > 0)
                    {
                        DB.Instant.GradeManager.SetUserGrade(userid);
                    }

                    alipay alipay = DB.Instant.AlipayManager.First();
                    if (alipay != null)
                    {
                        var x = new
                        {
                            code = 1,
                            message = "下单成功",
                            ordernumber = order.ordernumber,
                            orderpriice = order.ordercountprice,
                            partner = alipay.partner,
                            private_key = alipay.private_key,
                            ali_public_key = alipay.ali_publick_key,
                            notify_url = alipay.notify_url,
                            seller = alipay.seller
                        };
                        return Json(x, method);
                    }
                    else
                    {
                        var x = new
                        {
                            code = 1,
                            message = "下单成功",
                            ordernumber = order.ordernumber,
                            orderpriice = order.ordercountprice,
                            partner = string.Empty,
                            private_key = string.Empty,
                            ali_public_key = string.Empty,
                            notify_url = string.Empty,
                            seller = string.Empty
                        };
                        return Json(x, method);
                    }

                    #endregion
                }
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = "下单失败：" + MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 获取培训申请表信息 36

        public HttpResponseMessage gettrainapplicationinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/posttrainapplicationinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage posttrainapplicationinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                #endregion

                #region 获取培训申请表
                var list = DB.Instant.TrainTypeManager.Where(a => true).Select(a => new ExTrainType()
                {
                    traintypeid = a.typeid,
                    traintypename = a.typename
                }).ToList();
                var model = new ExTrainTypeList();
                if (list.Count > 0)
                {
                    model.code = 1;
                    model.message = "获取成功";
                    model.traintype = list;
                    return Json(model, method);
                }
                else
                {
                    b.code = 0;
                    b.message = "未找到培训工种";
                    return Json(b, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 提交培训申请 37

        public HttpResponseMessage getuptrainapplicationinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string trainname = HttpContext.Current.Request["trainname"];
            string trainsex = HttpContext.Current.Request["trainsex"];
            string trainculturaldegree = HttpContext.Current.Request["trainculturaldegree"];
            string trainbirthdate = HttpContext.Current.Request["trainbirthdate"];
            string trainservicelength = HttpContext.Current.Request["trainservicelength"];
            string trainphysicalcondition = HttpContext.Current.Request["trainphysicalcondition"];
            string traintypeid = HttpContext.Current.Request["traintypeid"];
            string trainID = HttpContext.Current.Request["trainID"];
            string traincompany = HttpContext.Current.Request["traincompany"];
            string trainpostcode = HttpContext.Current.Request["trainpostcode"];
            string traincompanyaddr = HttpContext.Current.Request["traincompanyaddr"];
            string trainlinkname = HttpContext.Current.Request["trainlinkname"];
            string traintel = HttpContext.Current.Request["traintel"];
            string trainemail = HttpContext.Current.Request["trainemail"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postuptrainapplicationinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "trainname", trainname }, { "trainsex", trainsex }, { "trainculturaldegree", trainculturaldegree }, { "trainbirthdate", trainbirthdate }, { "trainservicelength", trainservicelength }, { "trainphysicalcondition", trainphysicalcondition }, { "traintypeid", traintypeid }, { "trainID", trainID }, { "traincompany", traincompany }, { "trainpostcode", trainpostcode }, { "traincompanyaddr", traincompanyaddr }, { "trainlinkname", trainlinkname }, { "traintel", traintel }, { "trainemail", trainemail } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postuptrainapplicationinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string trainname = HttpContext.Current.Request["trainname"];
                string trainsex = HttpContext.Current.Request["trainsex"];
                string trainculturaldegree = HttpContext.Current.Request["trainculturaldegree"];
                string trainbirthdate = HttpContext.Current.Request["trainbirthdate"];
                string trainservicelength = HttpContext.Current.Request["trainservicelength"];
                string trainphysicalcondition = HttpContext.Current.Request["trainphysicalcondition"];
                string traintypeid = HttpContext.Current.Request["traintypeid"];
                string trainID = HttpContext.Current.Request["trainID"];
                string traincompany = HttpContext.Current.Request["traincompany"];
                string trainpostcode = HttpContext.Current.Request["trainpostcode"];
                string traincompanyaddr = HttpContext.Current.Request["traincompanyaddr"];
                string trainlinkname = HttpContext.Current.Request["trainlinkname"];
                string traintel = HttpContext.Current.Request["traintel"];
                string trainemail = HttpContext.Current.Request["trainemail"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(trainbirthdate))
                {
                    b.code = 0;
                    b.message = "trainbirthdate为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(trainname))
                {
                    b.code = 0;
                    b.message = "trainname为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(trainsex))
                {
                    b.code = 0;
                    b.message = "trainsex为空";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = db.alipay.FirstOrDefault();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    var app = new train()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        trainname = trainname,
                        trainsex = trainsex,
                        trainculturaldegree = trainculturaldegree,
                        trainservicelength = trainservicelength,
                        trainphysicalcondition = trainphysicalcondition,
                        traintypeid = traintypeid,
                        trainID = trainID,
                        traincompany = traincompany,
                        trainpostcode = trainpostcode,
                        traincompanyaddr = traincompanyaddr,
                        trainlinkname = trainlinkname,
                        traintel = traintel,
                        trainemail = trainemail,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    try
                    {
                        app.trainbirthdate = Convert.ToDateTime(trainbirthdate);
                    }
                    catch
                    {
                        b.code = 0;
                        b.message = "出生日期格式不是合法的日期格式，比如：1985-06-08";
                        return Json(b, method);
                    }
                    var r = db.train.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_PX"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    db.order.Add(order);
                    db.SaveChanges();

                    ExAliPayOrder pay = new ExAliPayOrder()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        price = order.ordercountprice
                    };

                    return Json(pay, method);
                }
                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 检测申请提交 39

        public HttpResponseMessage getuptestingapplicationinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string testingclientcompanyname = HttpContext.Current.Request["testingclientcompanyname"];
            string testingclientcompanyaddr = HttpContext.Current.Request["testingclientcompanyaddr"];
            string testinglinkname = HttpContext.Current.Request["testinglinkname"];
            string testingtel = HttpContext.Current.Request["testingtel"];
            string testingengineeringname = HttpContext.Current.Request["testingengineeringname"];
            string testingengineeringaddr = HttpContext.Current.Request["testingengineeringaddr"];
            string testingbuildercompany = HttpContext.Current.Request["testingbuildercompany"];
            string testingconstructioncompany = HttpContext.Current.Request["testingconstructioncompany"];
            string testingcontent = HttpContext.Current.Request["testingcontent"];
            string testingsize = HttpContext.Current.Request["testingsize"];
            string testingepitome = HttpContext.Current.Request["testingepitome"];
            string testingmanufacturer = HttpContext.Current.Request["testingmanufacturer"];
            string testingequipmentnumber = HttpContext.Current.Request["testingequipmentnumber"];
            string testingequipmenttype = HttpContext.Current.Request["testingequipmenttype"];
            string testingmountheight = HttpContext.Current.Request["testingmountheight"];
            string testingother = HttpContext.Current.Request["testingother"];
            string testingtheway = HttpContext.Current.Request["testingtheway"];
            string testingmailing = HttpContext.Current.Request["testingmailing"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postuptestingapplicationinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "testingclientcompanyname", testingclientcompanyname }, { "testingclientcompanyaddr", testingclientcompanyaddr }, { "testinglinkname", testinglinkname }, { "testingtel", testingtel }, { "testingengineeringname", testingengineeringname }, { "testingengineeringaddr", testingengineeringaddr }, { "testingbuildercompany", testingbuildercompany }, { "testingconstructioncompany", testingconstructioncompany }, { "testingcontent", testingcontent }, { "testingsize", testingsize }, { "testingepitome", testingepitome }, { "testingmanufacturer", testingmanufacturer }, { "testingequipmentnumber", testingequipmentnumber }, { "testingequipmenttype", testingequipmenttype }, { "testingmountheight", testingmountheight }, { "testingother", testingother }, { "testingtheway", testingtheway }, { "testingmailing", testingmailing } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postuptestingapplicationinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string testingclientcompanyname = HttpContext.Current.Request["testingclientcompanyname"];
                string testingclientcompanyaddr = HttpContext.Current.Request["testingclientcompanyaddr"];
                string testinglinkname = HttpContext.Current.Request["testinglinkname"];
                string testingtel = HttpContext.Current.Request["testingtel"];
                string testingengineeringname = HttpContext.Current.Request["testingengineeringname"];
                string testingengineeringaddr = HttpContext.Current.Request["testingengineeringaddr"];
                string testingbuildercompany = HttpContext.Current.Request["testingbuildercompany"];
                string testingconstructioncompany = HttpContext.Current.Request["testingconstructioncompany"];
                string testingcontent = HttpContext.Current.Request["testingcontent"];
                string testingsize = HttpContext.Current.Request["testingsize"];
                string testingepitome = HttpContext.Current.Request["testingepitome"];
                string testingmanufacturer = HttpContext.Current.Request["testingmanufacturer"];
                string testingequipmentnumber = HttpContext.Current.Request["testingequipmentnumber"];
                string testingequipmenttype = HttpContext.Current.Request["testingequipmenttype"];
                string testingmountheight = HttpContext.Current.Request["testingmountheight"];
                string testingother = HttpContext.Current.Request["testingother"];
                string testingtheway = HttpContext.Current.Request["testingtheway"];
                string testingmailing = HttpContext.Current.Request["testingmailing"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = DB.Instant.AlipayManager.First();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    if (string.IsNullOrEmpty(testingsize))
                    {
                        b.code = 0;
                        b.message = "testingsize为空";
                        return Json(b, method);
                    }
                    var app = new testing()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        testingclientcompanyname = testingclientcompanyname,
                        testingclientcompanyaddr = testingclientcompanyaddr,
                        testinglinkname = testinglinkname,
                        testingtel = testingtel,
                        testingengineeringname = testingengineeringname,
                        testingengineeringaddr = testingengineeringaddr,
                        testingbuildercompany = testingbuildercompany,
                        testingconstructioncompany = testingconstructioncompany,
                        testingcontent = testingcontent,
                        testingsize = Convert.ToInt32(testingsize),
                        testingepitome = testingepitome,
                        testingmanufacturer = testingmanufacturer,
                        testingequipmentnumber = testingequipmentnumber,
                        testingequipmenttype = testingequipmenttype,
                        testingmountheight = testingmountheight,
                        testingother = testingother,
                        testingtheway = testingtheway,
                        testingmailing = testingmailing,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    var r = db.testing.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_JC"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    var r2 = db.order.Add(order);
                    db.SaveChanges();

                    ExAliPayOrder pay = new ExAliPayOrder()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        price = order.ordercountprice
                    };
                    return Json(pay, method);
                }
                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 资质申请信息获取 40

        public HttpResponseMessage getqualificationapplicationinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postqualificationapplicationinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postqualificationapplicationinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                #endregion

                #region 获取资质申请表
                var list = DB.Instant.QualificationTypeManager.Where(a => true).Select(a => new ExQualificationType()
                {
                    qualificationtypeid = a.typeid,
                    qualificationtypename = a.typename
                }).ToList();
                var model = new ExQualificationTypeList();
                if (list.Count > 0)
                {
                    model.code = 1;
                    model.message = "获取成功";
                    model.qualificationtype = list;
                    return Json(model, method);
                }
                else
                {
                    b.code = 0;
                    b.message = "未找到资质申请信息";
                    return Json(b, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 提交资质申请表 41

        public HttpResponseMessage getupqualificationapplicationinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string applicompanyname = HttpContext.Current.Request["applicompanyname"];
            string applicompanyaddr = HttpContext.Current.Request["applicompanyaddr"];
            string applibusinessregistnumber = HttpContext.Current.Request["applibusinessregistnumber"];
            string appliorganizationcode = HttpContext.Current.Request["appliorganizationcode"];
            string appliregistercapital = HttpContext.Current.Request["appliregistercapital"];
            string appliemployer = HttpContext.Current.Request["appliemployer"];
            string appliregistrationdate = HttpContext.Current.Request["appliregistrationdate"];
            string applieconomytype = HttpContext.Current.Request["applieconomytype"];
            string appliqualificationtypeid = HttpContext.Current.Request["appliqualificationtypeid"];
            string applilinkname = HttpContext.Current.Request["applilinkname"];
            string applilinktel = HttpContext.Current.Request["applilinktel"];
            string appliemail = HttpContext.Current.Request["appliemail"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupqualificationapplicationinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "applicompanyname", applicompanyname }, { "applicompanyaddr", applicompanyaddr }, { "applibusinessregistnumber", applibusinessregistnumber }, { "appliorganizationcode", appliorganizationcode }, { "appliregistercapital", appliregistercapital }, { "appliemployer", appliemployer }, { "appliregistrationdate", appliregistrationdate }, { "applieconomytype", applieconomytype }, { "appliqualificationtypeid", appliqualificationtypeid }, { "applilinkname", applilinkname }, { "applilinktel", applilinktel }, { "appliemail", appliemail } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupqualificationapplicationinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string applicompanyname = HttpContext.Current.Request["applicompanyname"];
                string applicompanyaddr = HttpContext.Current.Request["applicompanyaddr"];
                string applibusinessregistnumber = HttpContext.Current.Request["applibusinessregistnumber"];
                string appliorganizationcode = HttpContext.Current.Request["appliorganizationcode"];
                string appliregistercapital = HttpContext.Current.Request["appliregistercapital"];
                string appliemployer = HttpContext.Current.Request["appliemployer"];
                string appliregistrationdate = HttpContext.Current.Request["appliregistrationdate"];
                string applieconomytype = HttpContext.Current.Request["applieconomytype"];
                string appliqualificationtypeid = HttpContext.Current.Request["appliqualificationtypeid"];
                string applilinkname = HttpContext.Current.Request["applilinkname"];
                string applilinktel = HttpContext.Current.Request["applilinktel"];
                string appliemail = HttpContext.Current.Request["appliemail"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(appliregistrationdate))
                {
                    b.code = 0;
                    b.message = "appliregistrationdate为空";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = DB.Instant.AlipayManager.First();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    var app = new applicationinfo()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        applicompanyname = applicompanyname,
                        applicompanyaddr = applicompanyaddr,
                        applibusinessregistnumber = applibusinessregistnumber,
                        appliorganizationcode = appliorganizationcode,
                        appliregistercapital = appliregistercapital,
                        appliemployer = appliemployer,
                        applieconomytype = applieconomytype,
                        appliqualificationtypeid = appliqualificationtypeid,
                        applilinkname = applilinkname,
                        applilinktel = applilinktel,
                        appliemail = appliemail,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    try
                    {
                        app.appliregistrationdate = Convert.ToDateTime(appliregistrationdate);
                    }
                    catch
                    {
                        b.code = 0;
                        b.message = "注册日期格式不是合法的日期格式，比如：1985-06-08";
                        return Json(b, method);
                    }
                    var r = db.applicationinfo.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_ZZ"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    var r2 = db.order.Add(order);
                    db.SaveChanges();

                    ExAliPayOrder pay = new ExAliPayOrder()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        price = order.ordercountprice
                    };
                    return Json(pay, method);
                }
                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 分页获取无忧新闻列表 42

        public HttpResponseMessage getnews()
        {
            #region 获取参数
            string pagenumber = HttpContext.Current.Request["pagenumber"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postnews";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "pagenumber", pagenumber } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postnews()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string pagenumber = HttpContext.Current.Request["pagenumber"];
                #endregion

                #region
                int pageIndex = 0;
                int.TryParse(pagenumber, out pageIndex);
                if (pageIndex == 0) pageIndex = 1;

                int pageSize = DataStore.PageSize;

                var list = DB.Instant.NewsManager.Where(a => true);
                var count = list.Count();
                var newslist = list.OrderByDescending(a => a.newsdate).Skip(pageSize * (pageIndex - 1)).Take(pageSize).Select(a => new ExNews()
                {
                    newsid = a.newsid,
                    newstitle = a.newstitle,
                    newsislogo = a.newsislogo == true ? "1" : "0",
                    newslogo = a.newslogo,
                    newssummary = a.newssummary
                }).ToList();

                var model = new ExNewsList()
                {
                    code = 1,
                    message = "获取成功",
                    currentpage = pageIndex,
                    pagesize = pageSize,
                    countpage = (int)Math.Ceiling(count / (pageSize * 1.0)),
                    countitems = count,
                    news = newslist
                };
                return Json(model, method);
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 查看某一新闻 43

        public HttpResponseMessage getonenews()
        {
            #region 获取参数
            string newsid = HttpContext.Current.Request["newsid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postonenews";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "newsid", newsid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postonenews()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string newsid = HttpContext.Current.Request["newsid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(newsid))
                {
                    b.code = 0;
                    b.message = "newsid为空";
                    return Json(b, method);
                }
                #endregion

                #region
                var news = DB.Instant.NewsManager.First(a => a.newsid == newsid);
                if (news != null)
                {
                    var exnews = new ExNewsDetail()
                    {
                        code = 1,
                        message = "获取成功",
                        newsid = news.newsid,
                        newstitle = news.newstitle,
                        newsislogo = news.newsislogo == true ? "1" : "0",
                        newslogo = news.newslogo,
                        newssummary = news.newssummary,
                        newsdate = news.newsdate.ToString("yyyy-MM-dd"),
                        //newscontent = news.newscontent
                        newscontent = ConfigurationManager.AppSettings.Get("ApiUrl") + "/web/newsContent/" + news.newsid
                    };
                    return Json(exnews, method);
                }
                else
                {
                    b.code = 0;
                    b.message = "未找到新闻";
                    return Json(b, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 故障列表 43

        public HttpResponseMessage getfaultlist()
        {
            #region 获取参数
            string typeid = HttpContext.Current.Request["typeid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postfaultlist";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "typeid", typeid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postfaultlist()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string typeid = HttpContext.Current.Request["typeid"];
                #endregion

                #region
                var faultList = DB.Instant.FaultManager.Where(a => string.IsNullOrEmpty(typeid) ? true : a.type1 == typeid).Select(a => new ExFault()
                {
                    faultid = a.faultid,
                    faultislogo = a.faultislogo == true ? "1" : "0",
                    faultlogo = a.faultlogo,
                    faultsummary = a.faultsummary,
                    faulttitle = a.faulttitle
                }).ToList();

                var type = DB.Instant.FaultTypeManager.Where(a => string.IsNullOrEmpty(typeid) ? string.IsNullOrEmpty(a.pid) : a.typeid == typeid).Select(a => new ExType2
                {
                    typeid = a.typeid,
                    typelogo = a.typelogo,
                    typename = a.typename
                }).ToList();

                var model = new ExFaultList()
                {
                    code = 1,
                    message = "获取成功",
                    faults = faultList,
                    type = type
                };
                return Json(model, method);
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 查看一条故障信息 44

        public HttpResponseMessage getonefault()
        {
            #region 获取参数
            string faultid = HttpContext.Current.Request["faultid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postonefault";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "faultid", faultid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postonefault()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string faultid = HttpContext.Current.Request["faultid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(faultid))
                {
                    b.code = 0;
                    b.message = "faultid为空";
                    return Json(b, method);
                }
                #endregion

                #region 查看一条故障信息
                var fault = DB.Instant.FaultManager.First(a => a.faultid == faultid);
                if (fault == null)
                {
                    b.message = "未找到故障信息";
                    b.code = 0;
                    return Json(b, method);
                }
                else
                {
                    var model = new ExFaultDetail()
                    {
                        code = 1,
                        message = "获取成功",
                        faultid = fault.faultid,
                        faulttitle = fault.faulttitle,
                        faultislogo = fault.faultislogo == true ? "1" : "0",
                        faultlogo = fault.faultlogo,
                        faultdate = fault.faultdate.ToString("yyyy-MM-dd"),
                        faultsummary = fault.faultsummary,
                        // faultcontent = fault.faultcontent
                        faultcontent = ConfigurationManager.AppSettings.Get("ApiUrl") + "/web/faultContent/" + fault.faultid
                    };
                    return Json(model, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 专家非标方案设计申请 45

        public HttpResponseMessage getupexpertsdesigninfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string designcompanyname = HttpContext.Current.Request["designcompanyname"];
            string designcompanyaddr = HttpContext.Current.Request["designcompanyaddr"];
            string designenginename = HttpContext.Current.Request["designenginename"];
            string designengineaddr = HttpContext.Current.Request["designengineaddr"];
            string designgoodsname = HttpContext.Current.Request["designgoodsname"];
            string designgoodstype = HttpContext.Current.Request["designgoodstype"];
            string designtechnologyrequest = HttpContext.Current.Request["designtechnologyrequest"];
            string designcompletedate = HttpContext.Current.Request["designcompletedate"];
            string designapplicationdate = HttpContext.Current.Request["designapplicationdate"];
            string designlinkname = HttpContext.Current.Request["designlinkname"];
            string designlinktel = HttpContext.Current.Request["designlinktel"];
            string designemail = HttpContext.Current.Request["designemail"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupexpertsdesigninfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "designcompanyname", designcompanyname }, { "designcompanyaddr", designcompanyaddr }, { "designenginename", designenginename }, { "designengineaddr", designengineaddr }, { "designgoodsname", designgoodsname }, { "designgoodstype", designgoodstype }, { "designtechnologyrequest", designtechnologyrequest }, { "designcompletedate", designcompletedate }, { "designapplicationdate", designapplicationdate }, { "designlinkname", designlinkname }, { "designlinktel", designlinktel }, { "designemail", designemail } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupexpertsdesigninfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string designcompanyname = HttpContext.Current.Request["designcompanyname"];
                string designcompanyaddr = HttpContext.Current.Request["designcompanyaddr"];
                string designenginename = HttpContext.Current.Request["designenginename"];
                string designengineaddr = HttpContext.Current.Request["designengineaddr"];
                string designgoodsname = HttpContext.Current.Request["designgoodsname"];
                string designgoodstype = HttpContext.Current.Request["designgoodstype"];
                string designtechnologyrequest = HttpContext.Current.Request["designtechnologyrequest"];
                string designcompletedate = HttpContext.Current.Request["designcompletedate"];
                string designapplicationdate = HttpContext.Current.Request["designapplicationdate"];
                string designlinkname = HttpContext.Current.Request["designlinkname"];
                string designlinktel = HttpContext.Current.Request["designlinktel"];
                string designemail = HttpContext.Current.Request["designemail"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(designcompletedate))
                {
                    b.code = 0;
                    b.message = "designcompletedate为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(designapplicationdate))
                {
                    b.code = 0;
                    b.message = "designapplicationdate为空";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = DB.Instant.AlipayManager.First();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    var app = new expertsdesigninfo()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        designcompanyname = designcompanyname,
                        designcompanyaddr = designcompanyaddr,
                        designenginename = designenginename,
                        designengineaddr = designengineaddr,
                        designgoodsname = designgoodsname,
                        designgoodstype = designgoodstype,
                        designtechnologyrequest = designtechnologyrequest,
                        //designcompletedate = Convert.ToDateTime(designcompletedate),
                        //designapplicationdate = Convert.ToDateTime(designapplicationdate),
                        designlinkname = designlinkname,
                        designlinktel = designlinktel,
                        designemail = designemail,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    try
                    {
                        app.designcompletedate = Convert.ToDateTime(designcompletedate);
                        app.designapplicationdate = Convert.ToDateTime(designapplicationdate);
                    }
                    catch
                    {
                        b.code = 0;
                        b.message = "完成时间或申请时间格式不是合法的日期时间格式，比如：1985-06-08 12:00或1987-01-10";
                        return Json(b, method);
                    }
                    var r = db.expertsdesigninfo.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_FBFASJ"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    var r2 = db.order.Add(order);
                    db.SaveChanges();

                    var pay = new ExAliPayOrderGN()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        gnprice = order.ordercountprice
                    };
                    return Json(pay, method);
                }
                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 专家非标方案论证申请 46

        public HttpResponseMessage getupexpertsproofinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string proofcompanyname = HttpContext.Current.Request["proofcompanyname"];
            string proofcompanyaddr = HttpContext.Current.Request["proofcompanyaddr"];
            string proofnenginename = HttpContext.Current.Request["proofnenginename"];
            string proofnengineaddr = HttpContext.Current.Request["proofnengineaddr"];
            string proofdesigncompany = HttpContext.Current.Request["proofdesigncompany"];
            string proofgoodsname = HttpContext.Current.Request["proofgoodsname"];
            string proofgoodstype = HttpContext.Current.Request["proofgoodstype"];
            string prooftype = HttpContext.Current.Request["prooftype"];
            string proofplandate = HttpContext.Current.Request["proofplandate"];
            string proofapplicationdate = HttpContext.Current.Request["proofapplicationdate"];
            string prooflinkname = HttpContext.Current.Request["prooflinkname"];
            string prooflinktel = HttpContext.Current.Request["prooflinktel"];
            string proofemail = HttpContext.Current.Request["proofemail"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupexpertsproofinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "proofcompanyname", proofcompanyname }, { "proofcompanyaddr", proofcompanyaddr }, { "proofnenginename", proofnenginename }, { "proofnengineaddr", proofnengineaddr }, { "proofdesigncompany", proofdesigncompany }, { "proofgoodsname", proofgoodsname }, { "proofgoodstype", proofgoodstype }, { "prooftype", prooftype }, { "proofplandate", proofplandate }, { "proofapplicationdate", proofapplicationdate }, { "prooflinkname", prooflinkname }, { "prooflinktel", prooflinktel }, { "proofemail", proofemail } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupexpertsproofinfo()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string proofcompanyname = HttpContext.Current.Request["proofcompanyname"];
                string proofcompanyaddr = HttpContext.Current.Request["proofcompanyaddr"];
                string proofnenginename = HttpContext.Current.Request["proofnenginename"];
                string proofnengineaddr = HttpContext.Current.Request["proofnengineaddr"];
                string proofdesigncompany = HttpContext.Current.Request["proofdesigncompany"];
                string proofgoodsname = HttpContext.Current.Request["proofgoodsname"];
                string proofgoodstype = HttpContext.Current.Request["proofgoodstype"];
                string prooftype = HttpContext.Current.Request["prooftype"];
                string proofplandate = HttpContext.Current.Request["proofplandate"];
                string proofapplicationdate = HttpContext.Current.Request["proofapplicationdate"];
                string prooflinkname = HttpContext.Current.Request["prooflinkname"];
                string prooflinktel = HttpContext.Current.Request["prooflinktel"];
                string proofemail = HttpContext.Current.Request["proofemail"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(proofplandate))
                {
                    b.code = 0;
                    b.message = "proofplandate为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(proofapplicationdate))
                {
                    b.code = 0;
                    b.message = "proofapplicationdate为空";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = DB.Instant.AlipayManager.First();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    var app = new expertsproofinfo()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        proofcompanyname = proofcompanyname,
                        proofcompanyaddr = proofcompanyaddr,
                        proofnenginename = proofnenginename,
                        proofnengineaddr = proofnengineaddr,
                        proofdesigncompany = proofdesigncompany,
                        proofgoodsname = proofgoodsname,
                        proofgoodstype = proofgoodstype,
                        prooftype = prooftype,
                        proofplandate = Convert.ToDateTime(proofplandate),
                        proofapplicationdate = Convert.ToDateTime(proofapplicationdate),
                        prooflinkname = prooflinkname,
                        prooflinktel = prooflinktel,
                        proofemail = proofemail,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    try
                    {
                        app.proofplandate = Convert.ToDateTime(proofplandate);
                        app.proofapplicationdate = Convert.ToDateTime(proofapplicationdate);
                    }
                    catch
                    {
                        b.code = 0;
                        b.message = "计划论证时间或申请时间格式不是合法的日期时间格式，比如：1985-06-08 12:00或1987-01-10";
                        return Json(b, method);
                    }
                    var r = db.expertsproofinfo.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_FBFALZ"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    var r2 = db.order.Add(order);
                    db.SaveChanges();

                    ExAliPayOrder pay = new ExAliPayOrder()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        price = order.ordercountprice
                    };
                    return Json(pay, method);

                }

                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 产品鉴定申请 47

        public HttpResponseMessage getupappraisalapplication()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string appraisalcompanyname = HttpContext.Current.Request["appraisalcompanyname"];
            string appraisalcompanyaddr = HttpContext.Current.Request["appraisalcompanyaddr"];
            string appraisalgoodsname = HttpContext.Current.Request["appraisalgoodsname"];
            string appraisalgoodstype = HttpContext.Current.Request["appraisalgoodstype"];
            string appraisalmanufacturer = HttpContext.Current.Request["appraisalmanufacturer"];
            string appraisaloutfactorydate = HttpContext.Current.Request["appraisaloutfactorydate"];
            string appraisalgoodssummary = HttpContext.Current.Request["appraisalgoodssummary"];
            string appraisalplandate = HttpContext.Current.Request["appraisalplandate"];
            string appraisalapplicationdate = HttpContext.Current.Request["appraisalapplicationdate"];
            string appraisallinkname = HttpContext.Current.Request["appraisallinkname"];
            string appraisallinktel = HttpContext.Current.Request["appraisallinktel"];
            string appraisalemail = HttpContext.Current.Request["appraisalemail"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupappraisalapplication";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "appraisalcompanyname", appraisalcompanyname }, { "appraisalcompanyaddr", appraisalcompanyaddr }, { "appraisalgoodsname", appraisalgoodsname }, { "appraisalgoodstype", appraisalgoodstype }, { "appraisalmanufacturer", appraisalmanufacturer }, { "appraisaloutfactorydate", appraisaloutfactorydate }, { "appraisalgoodssummary", appraisalgoodssummary }, { "appraisalplandate", appraisalplandate }, { "appraisalapplicationdate", appraisalapplicationdate }, { "appraisallinkname", appraisallinkname }, { "appraisallinktel", appraisallinktel }, { "appraisalemail", appraisalemail } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupappraisalapplication()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string appraisalcompanyname = HttpContext.Current.Request["appraisalcompanyname"];
                string appraisalcompanyaddr = HttpContext.Current.Request["appraisalcompanyaddr"];
                string appraisalgoodsname = HttpContext.Current.Request["appraisalgoodsname"];
                string appraisalgoodstype = HttpContext.Current.Request["appraisalgoodstype"];
                string appraisalmanufacturer = HttpContext.Current.Request["appraisalmanufacturer"];
                string appraisaloutfactorydate = HttpContext.Current.Request["appraisaloutfactorydate"];
                string appraisalgoodssummary = HttpContext.Current.Request["appraisalgoodssummary"];
                string appraisalplandate = HttpContext.Current.Request["appraisalplandate"];
                string appraisalapplicationdate = HttpContext.Current.Request["appraisalapplicationdate"];
                string appraisallinkname = HttpContext.Current.Request["appraisallinkname"];
                string appraisallinktel = HttpContext.Current.Request["appraisallinktel"];
                string appraisalemail = HttpContext.Current.Request["appraisalemail"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(appraisalplandate))
                {
                    b.code = 0;
                    b.message = "appraisalplandate为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(appraisalapplicationdate))
                {
                    b.code = 0;
                    b.message = "appraisalapplicationdate为空";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = DB.Instant.AlipayManager.First();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    var app = new appraisalapplication()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        appraisalcompanyname = appraisalcompanyname,
                        appraisalcompanyaddr = appraisalcompanyaddr,
                        appraisalgoodsname = appraisalgoodsname,
                        appraisalgoodstype = appraisalgoodstype,
                        appraisalmanufacturer = appraisalmanufacturer,
                        appraisaloutfactorydate = appraisaloutfactorydate,
                        appraisalgoodssummary = appraisalgoodssummary,

                        appraisallinkname = appraisallinkname,
                        appraisallinktel = appraisallinktel,
                        appraisalemail = appraisalemail,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    try
                    {
                        app.appraisalplandate = Convert.ToDateTime(appraisalplandate);
                        app.appraisalapplicationdate = Convert.ToDateTime(appraisalapplicationdate);
                    }
                    catch
                    {
                        b.code = 0;
                        b.message = "计划鉴定时间或申请时间格式不是合法的日期时间格式，比如：1985-06-08 12:00或1987-01-10";
                        return Json(b, method);
                    }
                    var r = db.appraisalapplication.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_ZJCPJD"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    var r2 = db.order.Add(order);
                    db.SaveChanges();

                    ExAliPayOrder pay = new ExAliPayOrder()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        price = order.ordercountprice
                    };
                    return Json(pay, method);

                }

                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 事故鉴定申请 48

        public HttpResponseMessage getupappraisalaccident()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string accidentcompanyname = HttpContext.Current.Request["accidentcompanyname"];
            string accidentcompanyaddr = HttpContext.Current.Request["accidentcompanyaddr"];
            string accidentnenginename = HttpContext.Current.Request["accidentnenginename"];
            string accidentnenginenaddr = HttpContext.Current.Request["accidentnenginenaddr"];
            string accidentgoodsname = HttpContext.Current.Request["accidentgoodsname"];
            string accidentgoodstype = HttpContext.Current.Request["accidentgoodstype"];
            string accidenttype = HttpContext.Current.Request["accidenttype"];
            string accidentdescription = HttpContext.Current.Request["accidentdescription"];
            string accidentoccurrencetime = HttpContext.Current.Request["accidentoccurrencetime"];
            string accidentlinkname = HttpContext.Current.Request["accidentlinkname"];
            string accidentlinktel = HttpContext.Current.Request["accidentlinktel"];
            string accidentemail = HttpContext.Current.Request["accidentemail"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postupappraisalaccident";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "accidentcompanyname", accidentcompanyname }, { "accidentcompanyaddr", accidentcompanyaddr }, { "accidentnenginename", accidentnenginename }, { "accidentnenginenaddr", accidentnenginenaddr }, { "accidentgoodsname", accidentgoodsname }, { "accidentgoodstype", accidentgoodstype }, { "accidenttype", accidenttype }, { "accidentdescription", accidentdescription }, { "accidentoccurrencetime", accidentoccurrencetime }, { "accidentlinkname", accidentlinkname }, { "accidentlinktel", accidentlinktel }, { "accidentemail", accidentemail } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postupappraisalaccident()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string accidentcompanyname = HttpContext.Current.Request["accidentcompanyname"];
                string accidentcompanyaddr = HttpContext.Current.Request["accidentcompanyaddr"];
                string accidentnenginename = HttpContext.Current.Request["accidentnenginename"];
                string accidentnenginenaddr = HttpContext.Current.Request["accidentnenginenaddr"];
                string accidentgoodsname = HttpContext.Current.Request["accidentgoodsname"];
                string accidentgoodstype = HttpContext.Current.Request["accidentgoodstype"];
                string accidenttype = HttpContext.Current.Request["accidenttype"];
                string accidentdescription = HttpContext.Current.Request["accidentdescription"];
                string accidentoccurrencetime = HttpContext.Current.Request["accidentoccurrencetime"];
                string accidentlinkname = HttpContext.Current.Request["accidentlinkname"];
                string accidentlinktel = HttpContext.Current.Request["accidentlinktel"];
                string accidentemail = HttpContext.Current.Request["accidentemail"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                var u = DB.Instant.UserManager.GeyUserByUserID(userid);
                if (u == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(accidentoccurrencetime))
                {
                    b.code = 0;
                    b.message = "accidentoccurrencetime为空";
                    return Json(b, method);
                }
                #endregion

                #region 提交申请
                using (var db = new amEntities())
                {
                    var alipay = DB.Instant.AlipayManager.First();
                    if (alipay == null)
                    {
                        b.code = 0;
                        b.message = "支付宝信息为空";
                        return Json(b, method);
                    }
                    var app = new appraisalaccident()
                    {
                        GUID = Guid.NewGuid().ToString(),
                        userid = userid,
                        accidentcompanyname = accidentcompanyname,
                        accidentcompanyaddr = accidentcompanyaddr,
                        accidentnenginename = accidentnenginename,
                        accidentnenginenaddr = accidentnenginenaddr,
                        accidentgoodsname = accidentgoodsname,
                        accidentgoodstype = accidentgoodstype,
                        accidenttype = accidenttype,
                        accidentdescription = accidentdescription,
                        accidentoccurrencetime = Convert.ToDateTime(accidentoccurrencetime),
                        accidentlinkname = accidentlinkname,
                        accidentlinktel = accidentlinktel,
                        accidentemail = accidentemail,
                        state = "未处理",
                        ispay = false,
                        operatetime = DateTime.Now
                    };
                    try
                    {
                        app.accidentoccurrencetime = Convert.ToDateTime(accidentoccurrencetime);
                    }
                    catch
                    {
                        b.code = 0;
                        b.message = "事故发生时间格式不是合法的日期时间格式，比如：1985-06-08 12:00或1987-01-10";
                        return Json(b, method);
                    }
                    var r = db.appraisalaccident.Add(app);

                    //生成订单                                                         
                    var order = new order()
                    {
                        orderid = Guid.NewGuid().ToString(),
                        orderdate = DateTime.Now,
                        ordernumber = MVCTools.GetOrderNumber(),
                        userid = userid,
                        ordercountprice = DB.Instant.ConfigManager.GetDouble("Money_ZJSGJD"),
                        ordertype = "2",
                        orderstruts = ((int)EnumOrderType.WaitingMoney).ToString(),
                    };
                    order.orderuserdiscount = order.ordercountprice;
                    order.addrid = "";
                    order.usepoints = 0;
                    var r2 = db.order.Add(order);
                    db.SaveChanges();

                    ExAliPayOrder pay = new ExAliPayOrder()
                    {
                        code = 1,
                        message = "申请成功",
                        ali_public_key = alipay.ali_publick_key,
                        notify_url = alipay.notify_url,
                        ordernumber = order.ordernumber,
                        partner = alipay.partner,
                        private_key = alipay.private_key,
                        seller = alipay.seller,
                        price = order.ordercountprice
                    };
                    return Json(pay, method);

                }

                #endregion

            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
                return Json(b, method);
            }
        }

        #endregion

        #region 获取系统会员等级信息 49

        public HttpResponseMessage getvipgrade()
        {
            #region 获取参数

            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postvipgrade";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>()
                {

                });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postvipgrade()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();

            #region 获取参数

            #endregion

            #region 参数校验

            #endregion

            #region 获取系统会员等级信息

            var list = DB.Instant.GradeManager.Where(a => true).ToList();
            if (list.Any())
            {
                ExGrade e = new ExGrade();
                e.code = 1;
                e.message = "获取成功";
                e.grades = list;
                return Json(e, method);
            }
            else
            {
                b = new Base();
                b.code = 0;
                b.message = "未找到会员等级信息";
                return Json(b, method);
            }
            #endregion

        }

        #endregion

        #region 删除已经完成的订单 50

        public HttpResponseMessage getdeletemycompleteorder()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postdeletemycompleteorder";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postdeletemycompleteorder()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(orderid))
                {
                    b.code = 0;
                    b.message = "orderid为空";
                    return Json(b, method);
                }
                #endregion

                #region 删除已完成订单
                var list = orderid.Split(',').ToList();
                var orders = DB.Instant.OrderManager.Where(a => a.userid == userid && list.Contains(a.orderid)).ToList();
                foreach (var item in list)
                {
                    var m = orders.FirstOrDefault(a => a.orderid == item);
                    if (m == null)
                    {
                        b.code = 0;
                        b.message = "删除订单失败！订单id:" + item + "不存在。";
                        return Json(b, method);
                    }
                    else
                    {
                        if (!(m.orderstruts == ((int)EnumOrderType.FinishOrder).ToString() || m.orderstruts == ((int)EnumOrderType.CancelOrder).ToString() || m.orderstruts == ((int)EnumOrderType.TKCG).ToString()))
                        {
                            b.code = 0;
                            b.message = "删除订单失败！订单id:" + item + "状态不是取消的订单或完成的订单。";
                            return Json(b, method);
                        }
                    }
                }
                var r = DB.Instant.OrderManager.Delete(orders);
                if (r.IsSuccess)
                {
                    b.code = 1;
                    b.message = "删除订单成功！";
                }
                else
                {
                    b.code = 0;
                    b.message = "删除订单失败:" + MVCTools.FilterScriptFormat(r.ResultDescription);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = MVCTools.FilterScriptFormat(Exc.Message);
            }
            return Json(b, method);
        }

        #endregion

        #region 添加订单取消接口 +5

        public HttpResponseMessage getmynopayordercancel()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            string orderid = HttpContext.Current.Request["orderid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmynopayordercancel";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid }, { "orderid", orderid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmynopayordercancel()
        {

            string method = HttpContext.Current.Request.Url.ToString();
            Base b = new Base();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                string orderid = HttpContext.Current.Request["orderid"];
                #endregion

                #region 检验参数
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(orderid))
                {
                    b.code = 0;
                    b.message = "orderid为空";
                    return Json(b, method);
                }
                #endregion

                #region
                var orders = orderid.Split(',');
                var list = DB.Instant.OrderManager.Where(a => a.userid == userid && orders.Contains(a.orderid)).ToList();
                var wfk = ((int)EnumOrderType.WaitingMoney).ToString(); //未付款
                var cancel = ((int)EnumOrderType.CancelOrder).ToString(); //取消订单
                foreach (var item in list)
                {
                    if (item.orderstruts == wfk)
                    {
                        item.orderstruts = cancel;
                    }
                    else
                    {
                        b.code = 0;
                        b.message = "只能取消未付款订单，请检查订单状态";
                        return Json(b, method);
                    }
                }
                var r = DB.Instant.OrderManager.Update(list);
                if (r.IsSuccess)
                {
                    b.code = 1;
                    b.message = "取消订单成功";
                }
                else
                {
                    b.code = 0;
                    b.message = "取消订单失败：" + r.ResultDescription.Replace("'", "");
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = Exc.Message;
            }
            return Json(b, method);
        }

        #endregion

        #region 登录后获取个人信息

        public HttpResponseMessage getmyinfo()
        {
            #region 获取参数
            string userid = HttpContext.Current.Request["userid"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postmyinfo";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "userid", userid } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postmyinfo()
        {
            Base b = new Base();
            string method = HttpContext.Current.Request.Url.ToString();
            try
            {
                #region 获取参数
                string userid = HttpContext.Current.Request["userid"];
                #endregion

                #region
                if (string.IsNullOrEmpty(userid))
                {
                    b.code = 0;
                    b.message = "userid为空";
                    return Json(b, method);
                }
                #endregion

                #region
                var user = DB.Instant.UserManager.GeyUserByUserID(userid);

                if (user == null)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "userid不存在";
                    return Json(b, method);
                }
                else
                {
                    var loginpwd = string.Empty;
                    var loginname = string.Empty;
                    if (user.ishuanxin == false)
                    {
                        loginpwd = RandomHelper.GetRandom(6).ToString();
                        loginname = user.userid.Replace("-", "");
                        b = RegHX(loginname, loginpwd);
                        if (b.code == 0)
                        {
                            b.message = "环信服务异常";
                            return Json(b, method);
                        }
                        else
                        {
                            user.ishuanxin = true;
                            user.hxpassword = loginpwd;
                            DB.Instant.UserManager.Update(user);
                        }
                    }
                    var e = new ExMyinfo();
                    e.code = 1;
                    e.message = "成功获取个人信息";
                    e.userid = user.userid;
                    e.userlogo = string.IsNullOrEmpty(user.userlogo) ? "" : string.Format("{0}{1}", userLogo, user.userlogo);
                    e.usernickname = user.usernickname;
                    var grade = DB.Instant.GradeManager.First(a => a.gradeid == user.gradeid);
                    if (grade != null)
                    {
                        e.gradename = grade.gradename;
                        e.gradelogo = string.IsNullOrEmpty(grade.gradelogo) ? "" : grade.gradelogo;
                    }
                    e.userpoints = user.userpoints;
                    e.userconsumption = user.userconsumption;
                    e.loginname = user.userid.Replace("-", "");
                    e.loginpwd = user.hxpassword;
                    return Json(e, method);
                }
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = Exc.Message;
            }
            return Json(b, method);
        }

        #endregion

        #region 测试方法
        public HttpResponseMessage getTest()
        {
            var obj1 = new ExAd
            {
                adid = "1",
                adimgurl = "2"
            };
            List<ExAd> obj2 = new List<ExAd>();
            obj2.Add(new ExAd());
            obj2.Add(new ExAd() { adid = "1" });

            List<ExAd> obj3 = new List<ExAd>();

            ExAd obj4 = new ExAd();
            //List<ExAd> obj3 = null;

            //ExAd obj4 = null;

            var b = new { obj1 = obj1, obj2 = obj2, obj3 = obj3, obj4 = obj4 };
            return Json(b, "getTest");
        }
        #endregion

        #region Json
        /// <summary>
        /// 把对象序列化为Json,自己写的Json处理方法，注意跟控制器里面的区分
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public HttpResponseMessage Json(object o, string method)
        {
            var settings = new JsonSerializerSettings() { ContractResolver = new NullToEmptyStringResolver() };
            var json = JsonConvert.SerializeObject(o, settings);
            //var json = JsonConvert.SerializeObject(o);   //原生的转换方式
            WriteLog(json, method);
            return new HttpResponseMessage { Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json") };
        }
        #endregion

        #region 三方登陆接口添加

        public HttpResponseMessage getthreeparthlogin()
        {
            #region 获取参数
            string openid = HttpContext.Current.Request["openid"];
            string type = HttpContext.Current.Request["type"];
            string userlogo = HttpContext.Current.Request["userlogo"];
            string usernickname = HttpContext.Current.Request["usernickname"];
            #endregion
            string url = Manager.Instant.ConfigManager.ApiUrl + "/client/postthreeparthlogin";

            using (var http = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new Dictionary<string, string>() { { "openid", openid }, { "type", type }, { "userlogo", userlogo }, { "usernickname", usernickname } });
                var response = http.PostAsync(url, content).Result;
                return response;
            }
        }

        public HttpResponseMessage postthreeparthlogin()
        {
            Base b = new Base();

            string method = HttpContext.Current.Request.Url.ToString();
            try
            {
                #region 获取参数
                string openid = HttpContext.Current.Request["openid"];
                string type = HttpContext.Current.Request["type"];
                string userlogo = HttpContext.Current.Request["userlogo"];
                string usernickname = HttpContext.Current.Request["usernickname"];
                #endregion

                #region 参数校验
                if (string.IsNullOrEmpty(openid))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "openid为空";
                    return Json(b, method);
                }
                if (string.IsNullOrEmpty(type))
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "type为空";
                    return Json(b, method);
                }
                if (type.Length > 2)
                {
                    b = new Base();
                    b.code = 0;
                    b.message = "type长度不能超过2位数";
                    return Json(b, method);
                }
                #endregion



                #region 处理：先判断是否存在 Opened，如果不存在，就注册一个，同时注册用户与之绑定
                #region 添加数据
                using (var db = new amEntities())
                {
                    string loginpwd = string.Empty;
                    string loginname = string.Empty;
                    var u = db.user.FirstOrDefault(a => a.openid == openid && a.type == type);
                    if (u == null)
                    {
                        u = new user();
                        u.userid = Guid.NewGuid().ToString();
                        u.userlogo = string.Empty;
                        u.username = string.Empty;
                        u.usernickname = string.Empty;
                        u.userphone = "";
                        u.usersex = string.Empty;
                        u.userpoints = 0;
                        u.userconsumption = 0.0;
                        u.password = "";
                        u.addrid = string.Empty;
                        if (u.ishuanxin == false)
                        {
                            loginpwd = RandomHelper.GetRandom(6).ToString();
                            loginname = u.userid.Replace("-", "");
                            b = RegHX(loginname, loginpwd);
                            if (b.code == 0)
                            {
                                b.message = "环信服务异常";
                                return Json(b, method);
                            }
                            else
                            {
                                u.ishuanxin = true;
                                u.hxpassword = loginpwd;
                                u.openid = openid;
                                u.usernickname = usernickname;
                                u.type = type;
                                db.user.Add(u);
                                db.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        loginname = u.userid.Replace("-", "");
                        loginpwd = u.hxpassword;
                    }
                    var query = from uu in db.user.Where(a => a.userid == u.userid)
                                join g in db.grade on uu.gradeid equals g.gradeid into _g
                                from __g in _g.DefaultIfEmpty()
                                select new
                                {
                                    gradename = __g == null ? string.Empty : __g.gradename,
                                    gradelogo = __g == null ? string.Empty : __g.gradelogo,
                                    userid = uu.userid,
                                    userlogo = uu.userlogo,
                                    usernickname = uu.usernickname,
                                    userpoints = uu.userpoints,
                                    userconsumption = uu.userconsumption,
                                    ishuanxin = uu.ishuanxin,
                                    hxpassword = uu.hxpassword
                                };
                    var q = query.FirstOrDefault();
                    if (q == null)
                    {
                        b = new Base();
                        b.code = 0;
                        b.message = "phone和pwd不存在，登录失败!";
                        return Json(b, method);
                    }
                    else
                    {
                        var eLogin = new ExLogin();

                        eLogin.code = 1;
                        eLogin.message = "登录成功";
                        eLogin.userid = q.userid.ToString();
                        eLogin.userlogo = string.IsNullOrEmpty(q.userlogo) ? "" : string.Format("{0}{1}", userLogo, q.userlogo);
                        eLogin.usernickname = q.usernickname;
                        eLogin.gradename = q.gradename;
                        eLogin.gradelogo = string.IsNullOrEmpty(q.gradelogo) ? "" : string.Format("{0}{1}", gradeLogo, q.gradelogo);
                        eLogin.userpoints = q.userpoints;
                        eLogin.userconsumption = q.userconsumption;
                        eLogin.loginname = loginname;
                        eLogin.loginpwd = loginpwd;
                        return Json(eLogin, method);
                    }
                }


                #endregion
                #endregion
            }
            catch (Exception Exc)
            {
                b.code = 0;
                b.message = Exc.Message;
            }
            return Json(b, method);
        }

        #endregion


        void WriteLog(string result, string method)
        {
            var ip = Manager.Instant.IPManager.GetIP();

            string request = string.Empty;
            NameValueCollection coll;
            coll = HttpContext.Current.Request.Form;

            String[] requestItem = coll.AllKeys;

            for (int i = 0; i < requestItem.Length; i++)
            {
                if (string.IsNullOrEmpty(request))
                {
                    request = string.Format("{0}:{1}", requestItem[i], HttpContext.Current.Request.Form[requestItem[i]]);
                }
                else
                {
                    request = request + " " + string.Format("{0}:{1}", requestItem[i], HttpContext.Current.Request.Form[requestItem[i]]);
                }
            }

            log4net.ILog txtLog = log4net.LogManager.GetLogger("LogToTXT");
            if (txtLog.IsInfoEnabled)
            {
                string msg = string.Format("{3} Request {0} Result {1} IP {2}", request, result, ip, method);
                txtLog.Info(msg);
            }
        }

        #region 图片校验方法
        public byte[] ConvertStreamToByteBuffer(Stream s)
        {
            MemoryStream ms = new MemoryStream();
            int b;
            while ((b = s.ReadByte()) != -1)
            {
                ms.WriteByte((byte)b);
            }
            return ms.ToArray();
        }

        //验证文件类型 是否是 图片类型 是就返回ture 不是返回false
        public bool CheckImgType(HttpPostedFile file)
        {
            bool ret = true;
            if (string.IsNullOrEmpty(file.FileName) || file.ContentLength <= 0)
            {
                ret = false;
            }
            var fileName = file.FileName;
            var fileType = fileName.Substring(fileName.LastIndexOf('.'));
            ret = fileType == ".jpg" || fileType == ".gif" || fileType == ".png" || fileType == ".bmp" || fileType == ".jpeg";
            return ret;


        }
        //图片大小验证 1M
        public bool CheckImgBit(HttpPostedFile file)
        {
            var bit = file.ContentLength;
            //图片大小2M
            int size = 1024 * 1024 * 1;
            //int size = 1024 * 200;
            return bit <= size;
        }
        #endregion

        #region 环信注册
        /// <summary>
        /// 环信注册 服务端已经修改成开放注册
        /// </summary>
        /// <returns></returns>
        public Base RegHX(string username, string password)
        {
            Base b = new Base();
            try
            {
                using (var hc = new HttpClient())
                {
                    #region 注册
                    {

                        ///此处需要注意，注册用户名密码不能带有下划线的 等特殊符号
                        var str = JsonConvert.SerializeObject(new { username = username, password = password });
                        HttpContent ct = new StringContent(str);
                        var regUrl = System.Configuration.ConfigurationManager.AppSettings["huanxinurl"] + "/users";
                        var r = hc.PostAsync(regUrl, ct).Result;
                        if (r.StatusCode == HttpStatusCode.OK)
                        {
                            b.code = 1;
                            b.message = "注册成功";
                        }
                        else
                        {
                            b.code = 0;
                            b.message = r.ReasonPhrase;
                        }
                    }
                    #endregion
                }

                #region 暂时不使用
                //string access_token = string.Empty;
                //using (var hc = new HttpClient())
                //{
                //    {
                //        var str = JsonConvert.SerializeObject(new { grant_type = "client_credentials", client_id = "YXA6Ib2oQJJzEeWi0tGG9ExMZg", client_secret = "YXA6etg6s49RC7UVbcR1nDK_D_LHzqY" });
                //        HttpContent ct = new StringContent(str);
                //        var regUrl = System.Configuration.ConfigurationManager.AppSettings["huanxinurl"] + "/token";
                //        var r = hc.PostAsync(regUrl, ct).Result;

                //        if (r.StatusCode == HttpStatusCode.OK)
                //        {
                //            var content = r.Content.ReadAsStringAsync().Result;
                //            var x = JsonConvert.DeserializeObject<HuanXinToken>(content);
                //            access_token = x.access_token;
                //        }
                //        else
                //        {
                //            b.code = 0;
                //            return b;
                //        }
                //    }
                //}
                #endregion
            }
            catch (Exception e)
            {
                b.code = 0;
                b.message = e.Message;
            }
            return b;
        }

        public class HuanXinToken
        {
            public string access_token { get; set; }
            public string expires_in { get; set; }
            public string application { get; set; }
        }
        #endregion
    }
}
