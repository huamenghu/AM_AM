using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AM.Common;
using System.Web.Optimization;
using System.Web.Http;
using System.Text.RegularExpressions;

namespace AM
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest()
        {
            //Regex regex = new Regex("client");

            //if (regex.IsMatch(Context.Request.FilePath))
            //{
            //   // string path = Context.Request.FilePath.Replace("client/", "client/get"); ;
            //    //if (Context.Request.FilePath == "/")
            //    //{
            //    //    path = string.Format("Html/HomePage/{0}.html", "0");
            //    //}
            //    //else
            //    //{
            //    //    path = string.Format("Html/HomePage/{0}.html", Context.Request.FilePath.Substring(1));
            //    //}
            //    //string p = Manager.Instant.ConstantManager.RootDirection + path;

            //    Context.RewritePath(path, false);

            //}

        }
    }
}