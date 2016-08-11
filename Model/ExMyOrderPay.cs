using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 支付宝 扩展类
    /// </summary>
    public class ExMyOrderPay : ExAliPay
    {

        public string ordernumber { get; set; }
        public string ordercountprice { get; set; }
    }
}
