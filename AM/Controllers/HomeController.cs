using Dao;
using AM.BLL;
using AM.Common;
using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{

    public class HomeController : BaseController
    {
        //
        // GET: /Admin/
        [AuthFilter]
        public ActionResult Index()
        {
            ViewBag.UserName = UserName;
            return _Index();
        }
        [AuthFilter]
        private ActionResult _Index()
        {
            DateTime time1 = DateTime.Now;
            ViewBag.Version = Manager.Instant.ConstantManager.Version;
            ViewBag.CopyRight = Manager.Instant.ConstantManager.CopyRight;
            ViewBag.MainTitle = Manager.Instant.ConstantManager.MainTitle;
            ViewBag.UserName = UserName;
            ViewBag.Title = Manager.Instant.ConstantManager.Title;

            #region 设置菜单

            #region 获取当前用户权限列表
            var p1 = from a in DataStore.UserRole.Where(a => a.UserName == UserName) join b in DataStore.Relation on a.RoleName equals b.RoleName select b.PermissionCode;
            var pp = p1.Distinct().ToList();
            var query = (from c in DataStore.Permission.Where(a => a.IsShow == true && a.IsAvailable == true)
                         join a in pp on c.Code equals a
                         select c).ToList();
            var isAdmin = DB.AuthUserManager.IsAdministrator(UserName);
            if (isAdmin)
            {
                query = DataStore.Permission.Where(a => a.IsShow == true && a.IsAvailable == true).Select(a => a).ToList();
            }
            query = query.Select(a => new AuthPermission
            {
                Code = a.Code,
                Sequence = a.Sequence,
                Name = a.Name,
                IsAvailable = a.IsAvailable,
                IsShow = a.IsShow,
                PCode = a.PCode,
                Description = a.Description,
                HttpType = a.HttpType,
                OperateTime = a.OperateTime,
                Operator = a.Operator,
                Res = a.Res,
                URL = a.URL
            }).ToList();

            #region  //修改权限标题：待付款，待发货，待收货等
            {
                var flag1 = ((int)EnumOrderType.WaitingMoney).ToString();
                var flag2 = ((int)EnumOrderType.WaitingSend).ToString();
                var flag3 = ((int)EnumOrderType.WaitingReceive).ToString();
                var flag5 = ((int)EnumOrderType.SQTK).ToString();
                var flag8 = ((int)EnumOrderType.Refund).ToString();
                var count1 = (from a in DB.Instant.OrderManager.Where(a => a.orderstruts == flag1)
                              join b in DB.Instant.UserManager.Where(a => true) on a.userid equals b.userid
                              select a.orderid).Count();
                var count2 = (from a in DB.Instant.OrderManager.Where(a => a.orderstruts == flag2)
                              join b in DB.Instant.UserManager.Where(a => true) on a.userid equals b.userid
                              select a.orderid).Count();
                var count3 = (from a in DB.Instant.OrderManager.Where(a => a.orderstruts == flag3)
                              join b in DB.Instant.UserManager.Where(a => true) on a.userid equals b.userid
                              select a.orderid).Count();
                var count5 = (from a in DB.Instant.OrderManager.Where(a => a.orderstruts == flag5)
                              join b in DB.Instant.UserManager.Where(a => true) on a.userid equals b.userid
                              select a.orderid).Count();
                var count8 = (from a in DB.Instant.OrderManager.Where(a => a.orderstruts == flag8)
                              join b in DB.Instant.UserManager.Where(a => true) on a.userid equals b.userid
                              select a.orderid).Count();
                var f1 = query.FirstOrDefault(a => a.Name == "待付款");
                if (f1 != null) f1.Name = string.Format("{0}({1})", f1.Name, count1);
                var f2 = query.FirstOrDefault(a => a.Name == "待发货");
                if (f2 != null) f2.Name = string.Format("{0}({1})", f2.Name, count2);
                var f3 = query.FirstOrDefault(a => a.Name == "待收货");
                if (f3 != null) f3.Name = string.Format("{0}({1})", f3.Name, count3);
                var f5 = query.FirstOrDefault(a => a.Name == "退款管理");
                if (f5 != null) f5.Name = string.Format("{0}({1})", f5.Name, count5);
                var f8 = query.FirstOrDefault(a => a.Name == "退货管理");
                if (f8 != null) f8.Name = string.Format("{0}({1})", f8.Name, count8);
            }
            #endregion
            #region 申请管理里的各未处理数字
            {
                var count1 = (from a in DB.Instant.TrainManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理")
                              join b in DB.Instant.TrainTypeManager.Where(a => true) on a.traintypeid equals b.typeid
                              select a.GUID).Count();
                var count2 = (from a in DB.Instant.ApplicationinfoManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理")
                              join b in DB.Instant.QualificationTypeManager.Where(a => true) on a.appliqualificationtypeid equals b.typeid
                              select a.GUID).Count();
                var count3 = DB.Instant.TestingManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理").Count();
                var count4 = DB.Instant.ExpertsdesigninfoManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理").Count();
                var count5 = DB.Instant.ExpertsproofinfoManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理").Count();
                var count6 = DB.Instant.AppraisalapplicationManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理").Count();
                var count7 = DB.Instant.AppraisalaccidentManager.Where(a => string.IsNullOrEmpty(a.state) || a.state == "未处理").Count();
                var f1 = query.FirstOrDefault(a => a.Name == "培训管理");
                if (f1 != null) f1.Name = string.Format("{0}({1})", f1.Name, count1);
                var f2 = query.FirstOrDefault(a => a.Name == "资质管理");
                if (f2 != null) f2.Name = string.Format("{0}({1})", f2.Name, count2);
                var f3 = query.FirstOrDefault(a => a.Name == "检测管理");
                if (f3 != null) f3.Name = string.Format("{0}({1})", f3.Name, count3);
                var f4 = query.FirstOrDefault(a => a.Name == "专家非标方案");
                if (f4 != null) f4.Name = string.Format("{0}({1})", f4.Name, count4);
                var f5 = query.FirstOrDefault(a => a.Name == "专家非标方案论证");
                if (f5 != null) f5.Name = string.Format("{0}({1})", f5.Name, count5);
                var f6 = query.FirstOrDefault(a => a.Name == "产品鉴定管理");
                if (f6 != null) f6.Name = string.Format("{0}({1})", f6.Name, count6);
                var f7 = query.FirstOrDefault(a => a.Name == "事故鉴定管理");
                if (f7 != null) f7.Name = string.Format("{0}({1})", f7.Name, count7);

            }

            #endregion
            var query1 = query.Where(a => string.IsNullOrEmpty(a.PCode)).OrderBy(a => a.Sequence).ToList();
            #endregion

            #region 组合脚本
            StringBuilder sb = new StringBuilder();
            int i1 = 0;

            foreach (var item in query1)
            {
                i1++;
                var icon1 = "icon-data";
                if (!string.IsNullOrEmpty(item.Res))
                {
                    icon1 = item.Res;
                }
                sb.Append("{");
                sb.AppendFormat("'menuid': '{0}', 'icon': '{1}', 'menuname': '{2}', 'menus': [", i1, icon1, item.Name);
                var query2 = query.Where(a => a.PCode == item.Code).OrderBy(a => a.Sequence).ToList();
                var i2 = 0;
                foreach (var item2 in query2)
                {
                    i2++;
                    var icon2 = "icon-datatime";
                    if (!string.IsNullOrEmpty(item2.Res))
                    {
                        icon2 = item2.Res;
                    }
                    sb.Append("{");
                    sb.AppendFormat(" 'menuid': '{0}_{1}', 'menuname': '{2}', 'icon': '{3}', 'url': '{4}' ", i1, i2, item2.Name, icon2, item2.URL);
                    sb.Append("}");
                    if (i2 < query2.Count)
                    {
                        sb.Append(",");
                    }
                }
                sb.Append("]}");

                if (i1 < query1.Count)
                {
                    sb.Append(",");
                }
            }
            ViewBag.Menus = sb.ToString();
            #endregion

            #endregion

            var time2 = DateTime.Now;
            var tt = time2 - time1;
            return View();
        }

        public ActionResult Exit()
        {
            return _Exit();
        }
        private ActionResult _Exit()
        {
            Session["UserName"] = null;
            return RedirectToAction("Login");
        }


        public JsonResult GetData()
        {
            return _GetData();
        }

        private JsonResult _GetData()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            //list.Add(new KeyValuePair<string, string>("RenYuanClientConnection", Manager.Instant.ClientConnectManager.RenYuanClientConnection.ToString().ToLower()));
            //list.Add(new KeyValuePair<string, string>("WaSiClientConnection", Manager.Instant.ClientConnectManager.WaSiClientConnection.ToString().ToLower()));
            //list.Add(new KeyValuePair<string, string>("IsConnect", Manager.Instant.PingManager.IsConnect.ToString().ToLower()));
            //list.Add(new KeyValuePair<string, string>("IsDataBaseConnect", Manager.Instant.PingManager.IsDataBaseConnect.ToString().ToLower()));
            //list.Add(new KeyValuePair<string, string>("secondBackGroundWorker", Manager.Instant.MasManager.secondBackGroundWorker.ToString()));
            return Json(list);
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public JsonResult ModifyPassword(FormCollection form)
        {
            var password = SecurityTools.MD5Encrypt(form.Get("password"));
            var oldpassword = SecurityTools.MD5Encrypt(form.Get("oldpassword"));

            var list = DB.AuthUserManager.First(a => a.UserName == UserName && a.Password == oldpassword);
            if (list != null)
            {
                list.Password = password;
                var r = DB.AuthUserManager.Update(list);
                return Json(r, "text/html");
            }
            else
            {
                return Json(new AOPResult(-1, "原密码错误"), "text/html");
            }
        }

        public JsonResult checkdata()
        {
            try
            {
                using (var db = new amEntities())
                {
                    var users = db.user.Where(a => true);
                    var xf = db.consumptionnote.Where(a => true).Select(a => new { a.userid, a.consumptionnotecountmoney }).ToList();
                    var list = db.grade.Where(a => true).ToList();
                    foreach (var item in users)
                    {
                        var sum = xf.Where(a => a.userid == item.userid).Sum(a => a.consumptionnotecountmoney);
                        var grade = list.Where(a => a.gradefull <= sum).OrderByDescending(a => a.gradefull).FirstOrDefault();

                        if (grade != null && item.gradeid != grade.gradeid)
                        {
                            item.gradeid = grade.gradeid;
                        }
                    }
                    db.SaveChanges();
                    return Json(new AOPResult(0), "text/html");
                }
            }
            catch
            {
                return Json(new AOPResult(-1), "text/html");
            }
        }
    }
}
