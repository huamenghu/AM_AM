using AM.BLL;
using AM.Common;
using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class LoginController : Controller
    {
        #region 用户-权限 保存
        public string UserSessionKey = "UserName";
        public string CurPermissionsKey = "CurPermissions";
        public string UserName
        {
            get
            {
                if (Session[UserSessionKey] != null)
                {
                    return Session[UserSessionKey].ToString();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                Session[UserSessionKey] = value;
            }
        }
        /// <summary>
        /// 当前用户的权限列表url
        /// </summary>
        public List<string> CurPermissions
        {
            get
            {
                if (Session[CurPermissionsKey] != null)
                {
                    return Session[CurPermissionsKey] as List<string>;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                Session[CurPermissionsKey] = value;
            }
        }
        #endregion
        
        public ActionResult Index()
        {
            DataStore.RefreshCache();
            return _Index();
        }

        private ActionResult _Index()
        {
            ViewBag.Title = Manager.Instant.ConstantManager.LoginTitle;
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            return _Login(form);
        }

        private ActionResult _Login(FormCollection form)
        {
            var message = string.Empty;
            var userName = form.Get("username");
            var password = form.Get("password");
            try
            {                 
                string uName = string.Empty;
                var r = DB.AuthUserManager.ValidUser(userName, password, out uName);
                if (r.IsSuccess)
                {
                    //初始化数据
                    UserName = uName;
                    //将当前用户的权限列表写入session
                    CurPermissions = DB.AuthPermissionManager.GetPermissions(UserName).Where(a => a.IsShow && a.IsAvailable).Select(a => a.URL).ToList();

                    //AddLog(EnumLogType.Login.ToString(), "登录成功");
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.Message = string.Format("登录失败：{0}", r.ResultDescription);
                    //AddLog(EnumLogType.Login.ToString(), "登录失败", string.Format("登录用户：{0} 失败原因：{1}", userName, r.ResultDescription));
                    return View("Index");
                }
            }
            catch (Exception e)
            {
                  message = Tools.GetFinallExceptionMessage(e);
                ViewBag.Message = string.Format("登录失败：{0}", message);
                //DB.Log.SQL(MVCTools.GetExecptionMessage(e), e);
                return View("Index");
            }
        }
    }
}
