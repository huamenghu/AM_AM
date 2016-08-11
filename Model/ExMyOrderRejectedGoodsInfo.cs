using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 我的订单退货信息的扩展类
    /// </summary>
    public class ExMyOrderRejectedGoodsInfo : Base
    {
        public string orderid { get; set; }
        public string ordernumber { get; set; }
        public List<ExWuLiu> wuliuinfo { get; set; }        
    }
}
