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
    public class neworderController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.toolbar = "a";
            return View();
        }
        #region 待付款
        public ActionResult DFK()
        {

            return View();
        }
        #endregion
        #region 待发货
        public ActionResult DFH()
        {
            return View();
        }

        #endregion
        #region 待收货
        public ActionResult DSH(string id)
        {
            ViewBag.ID = id;
            return View();
        }
        #endregion
        #region 退款管理
        public ActionResult TKGL()
        {
            return View();
        }
        #endregion
        #region 退货管理
        public ActionResult THGL()
        {
            return View();
        }
        #endregion
        #region 交易成功
        public ActionResult Finish()
        {
            return View();
        }
        #endregion
        #region 其他
        public ActionResult Other()
        {
            return View();
        }
        #endregion
        public JsonResult GetData(string state)
        {
            var statearr = state.Split(',');
            int total;  //记录总条数                                                                     
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典            
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小                      
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码                      
                if (pageIndex < 1) pageIndex = 1;
                string ordernumber = Request["ordernumber"] == null ? string.Empty : Request["ordernumber"].ToString();
                string userphone = Request["userphone"] == null ? string.Empty : Request["userphone"].ToString();
                string orderstruts = state;

                var elist = EnumManager.GetTypes(typeof(EnumOrderType));
                var data = from a in DB.Instant.OrderManager.Where(a => (string.IsNullOrEmpty(ordernumber) ? true : a.ordernumber.IndexOf(ordernumber) > -1)
                      && (string.IsNullOrEmpty(orderstruts) ? true : statearr.Contains(a.orderstruts)))
                           join b in DB.Instant.UserManager.Where(a =>
(string.IsNullOrEmpty(userphone) ? true : a.userphone.IndexOf(userphone) > -1)) on a.userid equals b.userid
                           select new
                        {
                            a.orderid,
                            a.ordernumber,
                            a.orderstruts,
                            userid = b.username,
                            a.ordercountprice,
                            a.orderdate,
                            a.orderistytuikuan,
                            a.ordertuikuanliyou
                        };
                total = data.Count();
                var list = data.OrderBy(a => a.orderid).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.orderid,
                    a.ordernumber,
                    orderstruts = getstruts(a.orderstruts, elist),
                    a.userid,
                    a.ordercountprice,
                    orderdate = a.orderdate.ToString("yyyy-MM-dd HH:mm:ss"),
                    orderistytuikuan = a.orderistytuikuan == 1 ? "同意退款" : (a.orderistytuikuan == 2 ? "拒绝退款" : "待处理"),
                    a.ordertuikuanliyou
                });
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }

        private string getstruts(string orderstruts, List<KeyValuePair<string, string>> list)
        {
            if (string.IsNullOrEmpty(orderstruts))
            {
                return string.Empty;
            }
            else
            {
                var ik = -100;
                var i = int.TryParse(orderstruts, out ik);
                var e = (EnumOrderType)ik;

                var f = list.FirstOrDefault(a => a.Key == e.ToString()).Value;
                return f;
            }
        }

        public JsonResult FillForm(String id)
        {
            var data = DB.Instant.OrderManager.Where(a => a.orderid == id).ToList().Select(a => new
            {
                a.orderid,
                a.userid,
                a.ordernumber,
                a.orderstruts,
                a.ordercountprice,
                orderdate = a.orderdate.ToString("yyyy-MM-dd"),
                a.expresscompanyid,
                a.ordersendgoodsexpressnumber,
                a.ordertuikuanliyou,
                a.orderistytuikuan
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult FaHuo(FormCollection form, string id)
        {
            var t = DB.Instant.OrderManager.Find(id);
            t.expresscompanyid = form.Get("fh_expresscompanyid");
            t.ordersendgoodsexpressnumber = form.Get("fh_ordersendgoodsexpressnumber");
            //if (t.orderstruts == ((int)EnumOrderType.WaitingReceive).ToString())  //如果选择的是已发货
            {
                if (string.IsNullOrEmpty(t.expresscompanyid) || string.IsNullOrEmpty(t.ordersendgoodsexpressnumber))
                {
                    return Json(new AOPResult(-2, "请填写快递公司与快递单号"), "text/html");
                }
            }
            var x = DB.ExpressCode.First(a => a.Code == t.expresscompanyid);
            if (x != null)
            {
                t.expresscompanyname = x.Name;
            }
            t.orderstruts = ((int)EnumOrderType.WaitingReceive).ToString();
            var r = DB.Instant.OrderManager.Update(t);
            return Json(r, "text/html");
        }
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new order();
            MVCTools.SetValueFormToModel(t, form);
            t.orderid = Guid.NewGuid().ToString();
            t.ordertype = "1";
            t.addrid = "";
            t.orderuserdiscount = 1;
            if (t.orderstruts == ((int)EnumOrderType.WaitingReceive).ToString())  //如果选择的是已发货
            {
                if (string.IsNullOrEmpty(t.expresscompanyid) || string.IsNullOrEmpty(t.expresscompanyname))
                {
                    return Json(new AOPResult(-2, "请填写快递公司与快递单号"), "text/html");
                }
            }
            var r = DB.Instant.OrderManager.Add(t);
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form)
        {
            var t = DB.Instant.OrderManager.Find(id);
            MVCTools.SetValueFormToModel(t, form);
            if (t.orderstruts == ((int)EnumOrderType.WaitingReceive).ToString())  //如果选择的是已发货
            {
                if (string.IsNullOrEmpty(t.expresscompanyid) || string.IsNullOrEmpty(t.ordersendgoodsexpressnumber))
                {
                    return Json(new AOPResult(-2, "请填写快递公司与快递单号"), "text/html");
                }
            }
            var r = DB.Instant.OrderManager.Update(t);
            return Json(r, "text/html");
        }

        public JsonResult Delete(string id)
        {
            List<order> us = new List<order>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new order() { orderid = item });
            }
            var wfh = ((int)EnumOrderType.WaitingMoney).ToString();
            var finish = ((int)EnumOrderType.FinishOrder).ToString();
            var list = DB.Instant.OrderManager.Where(a => ids.Contains(a.orderid) && !(a.orderstruts == wfh || a.orderstruts == finish)).Any();
            if (list)
            {
                return Json(new AOPResult(-2, "只允许删除未付款或已完成的订单"), "text/html");
            }
            var r = DB.Instant.OrderManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var elist = EnumManager.GetTypes(typeof(EnumOrderType));
            var result = DB.Instant.OrderManager.Where(a => a.orderid == id).FirstOrDefault();
            var user = DB.Instant.UserManager.First(a => a.userid == result.userid);
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {
                list.Add(new KeyValuePair<string, string>("用户", user == null ? string.Empty : user.username));
                list.Add(new KeyValuePair<string, string>("订单id", result.orderid));
                list.Add(new KeyValuePair<string, string>("订单单号", result.ordernumber));
                list.Add(new KeyValuePair<string, string>("订单状态", getstruts(result.orderstruts, elist)));
                list.Add(new KeyValuePair<string, string>("订单价格", MVCTools.ConvertToString(result.ordercountprice)));
                list.Add(new KeyValuePair<string, string>("下单时间", result.orderdate.ToString("yyyy-MM-dd HH:mm:ss")));
                list.Add(new KeyValuePair<string, string>("运费", MVCTools.ConvertToString(result.yunfei)));
                list.Add(new KeyValuePair<string, string>("积分抵扣", MVCTools.ConvertToString(result.usepoints)));
                list.Add(new KeyValuePair<string, string>("快递公司", result.expresscompanyid));
                list.Add(new KeyValuePair<string, string>("快递单号", result.ordersendgoodsexpressnumber));
                if (!string.IsNullOrEmpty(result.orderrejectgoodsexpresscompanyid))
                {
                    var cc = DB.ExpressCode.GetName(result.orderrejectgoodsexpresscompanyid);
                    list.Add(new KeyValuePair<string, string>("退货快递", cc));
                    list.Add(new KeyValuePair<string, string>("退货单号", result.orderrejectgoodsexpressnumber));
                }
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }

        #region 生成订单单号
        public string getordernumber()
        {
            return MVCTools.GetOrderNumber();
        }
        #endregion
        #region 获取订单状态
        public JsonResult getorderstruts()
        {
            var a0 = new KeyValuePair<string, string>("", "");
            var a1 = new KeyValuePair<string, string>("1", "未付款");
            var a2 = new KeyValuePair<string, string>("2", "已付款");
            var a3 = new KeyValuePair<string, string>("4", "已发货");

            var list = new List<KeyValuePair<string, string>>();
            list.Add(a0);
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            return Json(list);
        }
        #endregion

        public JsonResult GetExpressCode(string q)
        {
            var list = DB.ExpressCode.Where(a => !string.IsNullOrEmpty(q) ? (a.Name.IndexOf(q) > -1 || a.Code.IndexOf(q) > -1) : true).OrderBy(a => a.Sort).Select(a => new
            {
                a.Code,
                a.Name
            }).ToList();
            return Json(list);
        }
        public JsonResult FillFormFH(String id)
        {
            var data = DB.Instant.OrderManager.Where(a => a.orderid == id).ToList().Select(a => new
            {
                a.orderid,
                a.userid,
                a.ordernumber,
                a.orderstruts,
                a.ordercountprice,
                orderdate = a.orderdate.ToString("yyyy-MM-dd"),
                fh_expresscompanyid = a.expresscompanyid,
                fh_ordersendgoodsexpressnumber = a.ordersendgoodsexpressnumber,
            }).FirstOrDefault();
            return Json(data);
        }

        public ActionResult Express()
        {
            return View();
        }
        public string SearchExpress(string code, string num)
        {
            StringBuilder sb = new StringBuilder();
            var list = DB.Express.SearchExpress(num, code);
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sb.AppendFormat("<p>时间：{0}  &nbsp;&nbsp;&nbsp;&nbsp;描述：{1}</p>", item.expressdate, item.expresscontent);
                }
            }
            else
            {
                sb.AppendFormat("无记录");
            }
            return sb.ToString();
        }

        #region 退款处理
        public JsonResult TuiKuan(string id, FormCollection form)
        {
            try
            {
                using (var db = new amEntities())
                {
                    var order = db.order.First(a => a.orderid == id);
                    if (order == null)
                    {
                        return Json(new AOPResult(-1, "订单未找到"), "text/html");
                    }
                    else
                    {
                        var orderistytuikuan = form.Get("orderistytuikuan");
                        var ordertuikuanliyou = form.Get("ordertuikuanliyou");
                        int _orderistytuikuan = 0;
                        int.TryParse(orderistytuikuan, out _orderistytuikuan);

                        order.orderistytuikuan = _orderistytuikuan;
                        order.ordertuikuanliyou = ordertuikuanliyou;
                        if (_orderistytuikuan == 1)
                        {
                            order.orderstruts = ((int)EnumOrderType.TKCG).ToString();
                            //更新用户的累计消费，减去金额
                            var user = db.user.FirstOrDefault(a => a.userid == order.userid);
                            if (user != null)
                            {
                                if (user.userconsumption >= order.ordercountprice)
                                {
                                    user.userconsumption = user.userconsumption - order.ordercountprice;
                                }
                            }
                        }
                        if (_orderistytuikuan == 2)
                        {
                            order.orderstruts = ((int)EnumOrderType.TKSB).ToString();
                        }

                        db.SaveChanges();

                        return Json(new AOPResult(0), "text/html");
                    }
                }
            }
            catch (Exception e)
            {
                return Json(new AOPResult(-100, e.Message), "text/html");
            }
        }
        #endregion
    }
}
