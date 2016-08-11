using AM.BLL;
using Dao;
using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class ConfigController : Controller
    {
        //
        // GET: /Config/

        public ActionResult Index()
        {
            //获取配置参数
            var list = DB.Instant.ConfigManager.Where(a => true).ToList();
            var alipay = DB.Instant.AlipayManager.First();
            ViewBag.Money_PX = GetConfig("Money_PX", list);
            ViewBag.Money_JC = GetConfig("Money_JC", list);
            ViewBag.Money_ZZ = GetConfig("Money_ZZ", list);
            ViewBag.Money_FBFALZ = GetConfig("Money_FBFALZ", list);
            ViewBag.Money_FBFASJ = GetConfig("Money_FBFASJ", list);
            ViewBag.Money_ZJCPJD = GetConfig("Money_ZJCPJD", list);
            ViewBag.Money_ZJSGJD = GetConfig("Money_ZJSGJD", list);
            ViewBag.Money_JiFen = GetConfig("Money_JiFen", list);
            ViewBag.Money_JiFen2 = GetConfig("Money_JiFen2", list);
            ViewBag.Money_YouFei = GetConfig("Money_YouFei", list);
            ViewBag.Money_BaoYou = GetConfig("Money_BaoYou", list);
            if (alipay != null)
            {
                ViewBag.partner = alipay.partner;
                ViewBag.seller = alipay.seller;
                ViewBag.ali_publick_key = alipay.ali_publick_key;
                ViewBag.notify_url = alipay.notify_url;
                ViewBag.private_key = alipay.private_key;
            }
            return View();
        }
        public ActionResult WebIndex()
        {
            //获取配置参数
            var list = DB.Instant.ConfigManager.Where(a => true).ToList();

            ViewBag.IndexTitle = GetConfig("IndexTitle", list);
            ViewBag.IndexKeyword = GetConfig("IndexKeyword", list);
            ViewBag.IndexDescription = GetConfig("IndexDescription", list);
            ViewBag.Tel = GetConfig("Tel", list);
            ViewBag.Address = GetConfig("Address", list);
            ViewBag.Email = GetConfig("Email", list);
            ViewBag.Copyright = GetConfig("Copyright", list);
            ViewBag.ICP = GetConfig("ICP", list);
            ViewBag.ExpressKey = GetConfig("ExpressKey", list);
            return View();
        }

        private string GetConfig(string key, List<config> list)
        {
            var m = list.FirstOrDefault(a => a.Key == key);
            if (m == null)
                return string.Empty;
            return m.Value;
        }

        public JsonResult SetConfig(FormCollection form)
        {
            try
            {
                var Money_PX = form.Get("Money_PX");
                var Money_JC = form.Get("Money_JC");
                var Money_ZZ = form.Get("Money_ZZ");
                var Money_FBFALZ = form.Get("Money_FBFALZ");
                var Money_FBFASJ = form.Get("Money_FBFASJ");
                var Money_ZJCPJD = form.Get("Money_ZJCPJD");
                var Money_ZJSGJD = form.Get("Money_ZJSGJD");
                var Money_JiFen = form.Get("Money_JiFen");
                var Money_JiFen2 = form.Get("Money_JiFen2");
                var Money_YouFei = form.Get("Money_YouFei");
                var Money_BaoYou = form.Get("Money_BaoYou");

                var partner = form.Get("partner");
                var private_key = form.Get("private_key");
                var ali_publick_key = form.Get("ali_publick_key");
                var notify_url = form.Get("notify_url");
                var seller = form.Get("seller");
                try
                {
                    var jf = Convert.ToInt32(Money_JiFen);
                    if (jf < 1)
                    {
                        return Json(new AOPResult(-2, "积分数不能小于或等于0"), "text/html");
                    }
                    var jf2 = Convert.ToDecimal(Money_JiFen2);
                    
                }
                catch
                {
                    return Json(new AOPResult(-5, "积分数设置不正确"), "text/html");
                }

                List<config> List = DB.Instant.ConfigManager.Where(a => true).ToList();
                List<config> addList = new List<config>();
                List<config> updateList = new List<config>();
                SetValue(List, addList, updateList, "Money_PX", Money_PX);
                SetValue(List, addList, updateList, "Money_JC", Money_JC);
                SetValue(List, addList, updateList, "Money_ZZ", Money_ZZ);
                SetValue(List, addList, updateList, "Money_FBFALZ", Money_FBFALZ);
                SetValue(List, addList, updateList, "Money_FBFASJ", Money_FBFASJ);
                SetValue(List, addList, updateList, "Money_ZJCPJD", Money_ZJCPJD);
                SetValue(List, addList, updateList, "Money_ZJSGJD", Money_ZJSGJD);
                SetValue(List, addList, updateList, "Money_JiFen", Money_JiFen);
                SetValue(List, addList, updateList, "Money_JiFen2", Money_JiFen2);
                SetValue(List, addList, updateList, "Money_YouFei", Money_YouFei);
                SetValue(List, addList, updateList, "Money_BaoYou", Money_BaoYou);               

                var r = DB.Instant.ConfigManager.Add(addList);
                r = DB.Instant.ConfigManager.Update(updateList);
                //更新支付宝
                var alipay = DB.Instant.AlipayManager.First();
                if (alipay == null)
                {
                    alipay = new alipay()
                    {
                        guid = Guid.NewGuid().ToString(),
                        ali_publick_key = ali_publick_key,
                        notify_url = notify_url,
                        private_key = private_key,
                        seller=seller,
                        partner = partner
                    };
                    r = DB.Instant.AlipayManager.Add(alipay);
                }
                else
                {
                    alipay.ali_publick_key = ali_publick_key;
                    alipay.notify_url = notify_url;
                    alipay.private_key = private_key;
                    alipay.seller = seller;
                    alipay.partner = partner;
                    r = DB.Instant.AlipayManager.Update(alipay);
                }
                DataStore.RefreshConfig();
                return Json(r, "text/html");
            }
            catch (Exception ee)
            {
                return Json(new AOPResult(-2, ee.Message.Replace("'", "")), "text/html");
            }
        }
        public JsonResult SetWebConfig(FormCollection form)
        {
            try
            {
                var IndexTitle = form.Get("IndexTitle");
                var IndexKeyword = form.Get("IndexKeyword");
                var IndexDescription = form.Get("IndexDescription");
                var Tel = form.Get("Tel");
                var Address = form.Get("Address");
                var Email = form.Get("Email");
                var Copyright = form.Get("Copyright");
                var ICP = form.Get("ICP");
                var ExpressKey = form.Get("ExpressKey");

                List<config> List = DB.Instant.ConfigManager.Where(a => true).ToList();
                List<config> addList = new List<config>();
                List<config> updateList = new List<config>();
                SetValue(List, addList, updateList, "IndexTitle", IndexTitle);
                SetValue(List, addList, updateList, "IndexKeyword", IndexKeyword);
                SetValue(List, addList, updateList, "IndexDescription", IndexDescription);
                SetValue(List, addList, updateList, "Tel", Tel);
                SetValue(List, addList, updateList, "Address", Address);
                SetValue(List, addList, updateList, "Email", Email);
                SetValue(List, addList, updateList, "Copyright", Copyright);
                SetValue(List, addList, updateList, "ICP", ICP);
                SetValue(List, addList, updateList, "ExpressKey", ExpressKey);
                var r = DB.Instant.ConfigManager.Add(addList);
                r = DB.Instant.ConfigManager.Update(updateList);

                DataStore.RefreshConfig();
                return Json(r, "text/html");
            }
            catch (Exception ee)
            {
                return Json(new AOPResult(-2, ee.Message.Replace("'", "")), "text/html");
            }
        }

        private void SetValue(List<config> List, List<config> addList, List<config> updateList, string key, string value)
        {
            var m = List.FirstOrDefault(a => a.Key == key);
            if (m == null)
            {
                addList.Add(new config() { GUID = Guid.NewGuid().ToString(), Key = key, Value = value });
            }
            else
            {
                m.Value = value;
                updateList.Add(m);
            }
        }
    }
}
