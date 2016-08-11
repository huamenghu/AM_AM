using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class CreateController : Controller
    {
        //
        // GET: /Create/

        public ActionResult Index()
        {
            return View();
        }

        public string ToGet(string remark, string txtp, string name)
        {
            StringBuilder sb = new StringBuilder();
            var list = txtp.Split(',');
            sb.AppendFormat("  #region {0}                                                                       \n\n", remark);
            sb.AppendFormat("  public HttpResponseMessage get{0}()                                         \n        ", name);
            sb.Append("  {                                                                                        \n  ");
            sb.AppendFormat("      #region 获取参数                                                               \n        ");
            foreach (var item in list)
            {
                sb.AppendFormat("      string {0} = HttpContext.Current.Request[\"{0}\"];                         \n      ", item);
            }

            sb.AppendFormat("      #endregion                                                                     \n        ");
            sb.AppendFormat("      string url = Manager.Instant.ConfigManager.ApiUrl + \"/client/post{0}\";       \n ", name);
            sb.AppendFormat("                                                                                     \n        ");
            sb.AppendFormat("      using (var http = new HttpClient())                                            \n        ");
            sb.Append("      {                                                                                    \n  ");
            sb.AppendFormat("          var content = new FormUrlEncodedContent(new Dictionary<string, string>()   \n        ");
            sb.Append("          {    ");
            var count = list.Length;
            int i = 0;
            foreach (var item in list)
            {
                i++;
                sb.Append("{");
                sb.AppendFormat("   \"{0}\",{0}                                                             ", item);
                sb.Append("}");
                if (count > i)
                {
                    sb.Append(",");
                }
            }

            sb.Append("           });                                                                                \n ");
            sb.AppendFormat("          var response = http.PostAsync(url, content).Result;                           \n       ");
            sb.AppendFormat("          return response;                                                              \n       ");
            sb.Append("      }                                                                                       \n ");
            sb.Append("  }                                                                                           \n ");
            sb.AppendFormat("                                                                                        \n       ");
            sb.AppendFormat("  public HttpResponseMessage post{0}()                                           \n       ", name);
            sb.Append("  {                                                                                           \n ");
            sb.Append("      Base b = new Base();        \n  try \n {                                                      \n       ");
            sb.AppendFormat("      #region 获取参数                                                               \n        ");
            foreach (var item in list)
            {
                sb.AppendFormat("      string {0} = HttpContext.Current.Request[\"{0}\"];                         \n      ", item);
            }
            sb.AppendFormat("      #endregion                                                                     \n\n        ");
            sb.AppendFormat("      #region                                                                   \n\n  #endregion      ");
            sb.AppendFormat("                                                                                      \n       ");
            sb.Append("    }                                   \n");
            sb.AppendFormat("  catch (Exception Exc)           \n      ");
            sb.Append("  {                               \n      ");
            sb.AppendFormat("      b.code = 0;                 \n      ");
            sb.AppendFormat("      b.message = Exc.Message;    \n      ");
            sb.Append("  }                                     \n");
            sb.AppendFormat("      return Json(b);                                                                   \n       ");
            sb.Append("  }                                                                                           \n\n  ");
            sb.AppendFormat("  #endregion");
            return sb.ToString();
        }

        public string ToGet2(string remark, string txtp, string name)
        {
            StringBuilder sb = new StringBuilder();
            var list = txtp.Split(',');
            sb.AppendFormat("  #region {0}                                                                       \n\n", remark);
            sb.AppendFormat("  public HttpResponseMessage get{0}()                                         \n        ", name);
            sb.Append("  {                                                                                        \n  ");
            sb.AppendFormat("      #region 获取参数                                                               \n        ");
            foreach (var item in list)
            {
                sb.AppendFormat("      string {0} = HttpContext.Current.Request[\"{0}\"];                         \n      ", item);
            }

            sb.AppendFormat("      #endregion                                                                     \n        ");
            sb.AppendFormat("      string url = Manager.Instant.ConfigManager.ApiUrl + \"/client/post{0}\";       \n ", name);
            sb.AppendFormat("                                                                                     \n        ");
            sb.AppendFormat("      using (var http = new HttpClient())                                            \n        ");
            sb.Append("      {                                                                                    \n  ");
            sb.AppendFormat("          var content = new FormUrlEncodedContent(new Dictionary<string, string>()   \n        ");
            sb.Append("          {    ");
            var count = list.Length;
            int i = 0;
            foreach (var item in list)
            {
                i++;
                sb.Append("{");
                sb.AppendFormat("   \"{0}\",{0}                                                             ", item);
                sb.Append("}");
                if (count > i)
                {
                    sb.Append(",");
                }
            }

            sb.Append("           });                                                                                \n ");
            sb.AppendFormat("          var response = http.PostAsync(url, content).Result;                           \n       ");
            sb.AppendFormat("          return response;                                                              \n       ");
            sb.Append("      }                                                                                       \n ");
            sb.Append("  }                                                                                           \n ");
            sb.AppendFormat("                                                                                        \n       ");
            sb.AppendFormat("  public HttpResponseMessage post{0}()                                           \n       ", name);
            sb.Append("  {                                                                                           \n ");
            sb.Append("      Base b = new Base();        \n  try \n {                                                      \n       ");
            sb.AppendFormat("      #region 获取参数                                                               \n        ");
            foreach (var item in list)
            {
                sb.AppendFormat("      string {0} = HttpContext.Current.Request[\"{0}\"];                         \n      ", item);
            }
            sb.AppendFormat("      #endregion                                                                     \n\n        ");

            #region true
            sb.AppendFormat("   #region 提交申请                                                       \n");
            sb.AppendFormat("   var alipay = DB.Instant.AlipayManager.First();                         \n");
            sb.AppendFormat("   if (alipay == null)                                                    \n");
            sb.Append("   {                                                                      \n");
            sb.AppendFormat("       b.code = 0;                                                        \n");
            sb.AppendFormat("       b.message = \"支付宝信息为空\";                                      \n");
            sb.AppendFormat("       return Json(b);                                                    \n");
            sb.Append("   }                                                                      \n");
            sb.AppendFormat("   var app = new {0}()                                                  \n", name);
            sb.Append("   {                                                                      \n");
            sb.AppendFormat("       GUID = Guid.NewGuid().ToString(),                                  \n");
            foreach (var item in list)
            {
                sb.AppendFormat("       {0} = {0},                                             \n", item);
            }

            sb.Append("   };                                                                     \n");
            sb.AppendFormat("   var r = DB.Instant.{0}Manager.Add(app);                              \n", name);
            sb.AppendFormat("   if (r.IsSuccess)                                                       \n");
            sb.Append("   {                                                                      \n");
            sb.AppendFormat("       //生成订单                                                         \n");
            sb.AppendFormat("       var order = new order()                                            \n");
            sb.Append("       {                                                                  \n");
            sb.AppendFormat("           orderid = Guid.NewGuid().ToString(),                           \n");
            sb.AppendFormat("           orderdate = DateTime.Now,                                      \n");
            sb.AppendFormat("           ordernumber = MVCTools.GetOrderNumber(),                       \n");
            sb.AppendFormat("           userid = userid,                                               \n");
            sb.AppendFormat("           ordercountprice = DataStore.Price_train,                       \n");
            sb.AppendFormat("           ordertype = \"2\",                                               \n");
            sb.AppendFormat("           orderstruts = \"1\",                                             \n");
            sb.Append("       };                                                                 \n");
            sb.AppendFormat("       order.orderuserdiscount = order.ordercountprice;                   \n");
            sb.AppendFormat("       order.addrid = \"\";                                                 \n");
            sb.AppendFormat("       var r2 = DB.Instant.OrderManager.Add(order);                       \n");
            sb.AppendFormat("       if (r2.IsSuccess)                                                  \n");
            sb.Append("       {                                                                  \n");
            sb.AppendFormat("           ExAliPayOrder pay = new ExAliPayOrder()                        \n");
            sb.Append("           {                                                              \n");
            sb.AppendFormat("               code = 1,                                                  \n");
            sb.AppendFormat("               message = \"申请成功\",                                      \n");
            sb.AppendFormat("               ali_public_key = alipay.ali_publick_key,                   \n");
            sb.AppendFormat("               notify_url = alipay.notify_url,                            \n");
            sb.AppendFormat("               ordernumber = order.ordernumber,                           \n");
            sb.AppendFormat("               partner = alipay.partner,                                  \n");
            sb.AppendFormat("               private_key = alipay.private_key,                          \n");
            sb.AppendFormat("               price = order.ordercountprice                              \n");
            sb.Append("           };                                                             \n");
            sb.AppendFormat("           return Json(pay);                                              \n");
            sb.Append("       }                                                                  \n");
            sb.AppendFormat("       else                                                               \n");
            sb.Append("       {                                                                  \n");
            sb.AppendFormat("           b.code = 0;                                                    \n");
            sb.AppendFormat("           b.message = \"生成订单失败\";                                    \n");
            sb.AppendFormat("           return Json(b);                                                \n");
            sb.Append("       }                                                                  \n");
            sb.Append("   }                                                                      \n");
            sb.AppendFormat("   else                                                                   \n");
            sb.Append("   {                                                                      \n");
            sb.AppendFormat("       b.code = 0;                                                        \n");
            sb.AppendFormat("       b.message = \"提交申请失败\";                                        \n");
            sb.AppendFormat("       return Json(b);                                                    \n");
            sb.Append("   }                                                                      \n");
            sb.AppendFormat("   #endregion                                                             \n");
            #endregion
            sb.AppendFormat("                                                                                      \n");
            sb.Append("    }                                   \n");
            sb.AppendFormat("  catch (Exception Exc)           \n      ");
            sb.Append("  {                               \n      ");
            sb.AppendFormat("      b.code = 0;                 \n      ");
            sb.AppendFormat("      b.message = Exc.Message;    \n  return Json(b); \n    ");
            sb.Append("  }                                     \n");
            sb.Append("  }                                                                                           \n\n  ");
            sb.AppendFormat("  #endregion");
            return sb.ToString();
        }

        public ActionResult A()
        {

            var obj1 = new ExAd
            {
                adid = "1",
                adimgurl = "2"
            };
            List<ExAd> obj2 = new List<ExAd>();
            obj2.Add(new ExAd());
            obj2.Add(new ExAd() { adid = "1" });

            List<ExAd> obj3 = null;

            ExAd obj4 = null;

            var x = new { obj1 = obj1, obj2 = obj2, obj3 = obj3, obj4 = obj4 };
            var json = JsonConvert.SerializeObject(x);
            var xy = json;
            return View();
        }

    }
}
