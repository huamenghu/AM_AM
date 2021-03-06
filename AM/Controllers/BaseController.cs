﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    [AuthorizeFilter]
    public class BaseController : Controller
    {
        public string UserSessionKey = "UserName";
        public string CurPermissionsKey = "CurPermissions";
        public BaseController()
        {
           
            DateTime dt = DateTime.Now;
            if (dt.Year == 2016 && dt.Month == 8 && dt.Day < 23)
            {

            }
            else {
                throw new Exception("使用超时，请联系管理员");
            }


        }

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
                //if (Session[CurPermissionsKey] != null)
                //{
                //    return Session[CurPermissionsKey] as List<string>;
                //}
                //else
                //{
                //    return null;
                //}
                return AM.BLL.DB.AuthPermissionManager.GetPermissions(UserName).Where(a => a.IsShow && a.IsAvailable).Select(a => a.URL).ToList();
            }
            set
            {
                Session[CurPermissionsKey] = value;
            }
        }
    }
}
