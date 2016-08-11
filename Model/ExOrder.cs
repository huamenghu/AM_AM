using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单的信息属性 扩展类
    /// </summary>
    public class ExOrder
    {
        public string orderid { get; set; }
        public string ordernumber { get; set; }
        public string orderstruts { get; set; }
        public double ordercountprice { get; set; }
        public double yunfei { get; set; }
        public double pointforfei { get; set; }       
        public List<ExOrderGoods> orderall { get; set; }

    }
    public class ExOrder_Express : ExOrder
    {
        public string expresscompanyname { get; set; }
        public string ordersendgoodsexpressnumber { get; set; }
    }
}
