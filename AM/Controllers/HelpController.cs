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
    public class HelpController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {

            var userid = "eb6b3739-506a-4a04-9b00-8c859e3ec45e";
            var goodsid = "f3adad39-3c5e-45c7-8d61-1a74462db0fd";
            string[] goodsidlist = goodsid.Split(',');
            var a1=DB.Instant.CatManager.Where(a => (a.userid == userid) && (string.IsNullOrEmpty(goodsid) ? true : goodsidlist.Contains(a.goodsid))).ToList();
            var cats = (from a in DB.Instant.CatManager.Where(a => (a.userid == userid) && (string.IsNullOrEmpty(goodsid) ? true : goodsidlist.Contains(a.goodsid)))
                        join bb in DB.Instant.OrderGoodsManager.Where(a => true) on a.goodsid equals bb.ordergoodsid
                        select new
                        {
                            a.goodsid,
                            bb.ordergoodsprice,
                            a.goodssize,
                            bb.ordergoodsname,
                            bb.ordergoodslogo,
                            goodsdiscountprice = bb.ordergoodsdiscountprice

                        }).ToList();
            var x = cats;
            return View();
        }
    }
}
