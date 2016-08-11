using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单商品属性的扩展类
    /// </summary>
    public class ExOrderGoods
    {
        public string ordergoodsid { get; set; }
        public string ordergoodslogo { get; set; }
        public string ordergoodsname { get; set; }
        public double ordergoodsprice { get; set; }
        public double ordergoodsdiscountprice { get; set; }
        public int ordergoodssize { get; set; }
        public double ordergoodscountprice { get; set; }
    }
}
