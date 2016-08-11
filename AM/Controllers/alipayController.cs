using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dao;
using Model;
using Com.Alipay;

using AM.BLL;
using log4net;
using System.Net.Http;


namespace AM.Controllers
{
    public class AlipayController : Controller
    {
        [HttpPost]
        public ActionResult notify_url()
        {
            SortedDictionary<string, string> sPara = GetRequestPost();
            var log = DB.log;

            try
            {
                if (sPara.Count > 0)//判断是否有带返回参数
                {
                    Com.Alipay.Notify aliNotify = new Notify();
                    //bool verifyResult = aliNotify.Verify(sPara, Request.Form["notify_id"], Request.Form["sign"]); //跳过验证
                    bool verifyResult = true;

                    //商户订单单号
                    string out_trade_no = Request.Form["out_trade_no"];
                    //支付宝缴易号(流水号)
                    string trade_no = Request.Form["trade_no"];
                    //缴易状态
                    string trade_status = Request.Form["trade_status"];
                    var intS = ((int)EnumOrderType.WaitingSend).ToString();

                    #region 测试打印各参数
                    if (log.IsInfoEnabled)
                    {
                        string msg = "支付提示：" + "支付参数返回：订单单号" + out_trade_no + "，" + sPara.Select(a => a.Key + "：" + a.Value).Aggregate((m, n) => m + "，" + n);
                        log.Info(msg);
                    }
                    #endregion

                    if (verifyResult)//验证成功
                    {
                        var list = DB.Instant.OrderManager.Where(a => a.ordernumber == out_trade_no).ToList();
                        if (Request.Form["trade_status"] == "TRADE_SUCCESS")
                        {
                            if (list.Any())
                            {
                                foreach (var item in list)
                                {
                                    item.orderstruts = intS;
                                }
                                var x = DB.Instant.OrderManager.Update(list);

                                if (x.IsSuccess)
                                {

                                    var money = DB.Instant.OrderManager.First(a => a.ordernumber == out_trade_no);
                                    if (money != null)
                                    {
                                        if (log.IsInfoEnabled)
                                        {
                                            string msg = "支付提示：" + "支付成功，订单单号:" + out_trade_no ;
                                            log.Info(msg);
                                        }
                                    }
                                    else
                                    {
                                        if (log.IsInfoEnabled)
                                        {
                                            string msg = "支付提示：" + "支付成功，订单单号:" + out_trade_no + " 更新用户积分时未成功:" + "订单未找到用户";
                                            log.Info(msg);
                                        }
                                    }

                                    if (log.IsInfoEnabled)
                                    {
                                        string msg = "支付提示：" + "支付成功，订单单号:" + out_trade_no;
                                        log.Info(msg);
                                    }
                                    //缴费成功,返回成功通知支付宝
                                    return Content("success");
                                }
                            }
                        }
                        else
                        {
                            //foreach (var item in list)
                            //{
                            //    if (item.orderstruts != intS)
                            //    {
                            //         //状态先保持原来的
                            //    }
                            //}
                            //var x = DB.Instant.OrderManager.Update(list);
                            //if (x.IsSuccess)
                            //{
                            //    if (log.IsInfoEnabled)
                            //    {
                            //        string msg = "支付提示：" + "支付失败，订单单号:" + out_trade_no;
                            //        log.Info(msg);
                            //    }
                            //    //缴费成功,返回成功通知支付宝
                            //    return Content("success");
                            //}
                            //else
                            {
                                //没成功，则什么也不做
                                if (log.IsInfoEnabled)
                                {
                                    string msg = "支付提示：" + "支付未成功，订单单号:" + out_trade_no;
                                    log.Info(msg);
                                }
                            }
                        }
                    }
                    else//验证失败
                    {
                        if (log.IsInfoEnabled)
                        {
                            string msg = "提示：" + "验证失败，订单单号:" + out_trade_no;

                            log.Info(msg);
                        }
                        return Content("fail");
                    }
                }
                else
                {
                    if (log.IsInfoEnabled)
                    {
                        string msg = "提示：" + "参数错误:";

                        log.Info(msg);
                    }
                    return Content("无通知参数");
                }
            }
            catch (Exception e)
            {
                if (log.IsInfoEnabled)
                {
                    string msg = "alipay提示：" + "出现异常:" + e.Message;
                    log.Info(msg);
                }
            }

            return Content("fail");
        }

        public ActionResult return_url()
        {
            //SortedDictionary<string, string> sPara = GetRequestGet();

            //if (sPara.Count > 0)//判断是否有带返回参数
            //{
            //    Notify aliNotify = new Notify();
            //    bool verifyResult = aliNotify.Verify(sPara, Request.QueryString["notify_id"], Request.QueryString["sign"]);
            //    //商户订单单号
            //    string out_trade_no = Request.QueryString["out_trade_no"];
            //    //支付宝缴易号
            //    string trade_no = Request.QueryString["trade_no"];
            //    //缴易状态
            //    string trade_status = Request.QueryString["trade_status"];

            //    var list = DB.Pay.Where(a => a.paynum == out_trade_no).ToList();
            //    if (verifyResult)//验证成功
            //    {
            //        if (Request.QueryString["trade_status"] == "TRADE_SUCCESS")
            //        {
            //            ViewBag.Message = ("<div><img src='/content/images/success.png' class='img'/></div>缴费成功<br />");
            //        }
            //        else
            //        {
            //            ViewBag.Message = ("<div><img src='/content/images/success.png' class='img'/></div>缴费失败！<br />");
            //        }
            //    }
            //    else//验证失败
            //    {
            //        ViewBag.Message = ("<div><img src='/content/images/fail.png' class='img'/></div>缴费失败！<br />");
            //    }
            //}
            //else
            //{
            //    ViewBag.Message = ("无返回参数");
            //}
            return View();
        }

        #region 辅助方法
        /// <summary>
        /// 获取支付宝POST过来通知消息，并以“参数名=参数值”的形式组成数组
        /// </summary>
        /// <returns>request回来的信息组成的数组</returns>
        public SortedDictionary<string, string> GetRequestPost()
        {
            int i = 0;
            SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
            System.Collections.Specialized.NameValueCollection coll;
            //Load QueryString variables into NameValueCollection variable.
            coll = Request.Form;

            // Get names of all QueryStrings into a string array.
            String[] requestItem = coll.AllKeys;

            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], Request.Form[requestItem[i]]);
            }

            return sArray;
        }

        /// <summary>
        /// 获取支付宝GET过来通知消息，并以“参数名=参数值”的形式组成数组
        /// </summary>
        /// <returns>request回来的信息组成的数组</returns>
        public SortedDictionary<string, string> GetRequestGet()
        {
            int i = 0;
            SortedDictionary<string, string> sArray = new SortedDictionary<string, string>();
            System.Collections.Specialized.NameValueCollection coll;
            //Load QueryString variables into NameValueCollection variable.
            coll = Request.QueryString;

            // Get names of all QueryStrings into a string array.
            String[] requestItem = coll.AllKeys;

            for (i = 0; i < requestItem.Length; i++)
            {
                sArray.Add(requestItem[i], Request.QueryString[requestItem[i]]);
            }

            return sArray;
        }
        #endregion
        public ActionResult A() { return View(); }
    }
}
