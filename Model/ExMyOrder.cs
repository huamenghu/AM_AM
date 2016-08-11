using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 我的订单的扩展类
    /// </summary>
    public class ExMyOrder : ExAliPay
    {
        public int currentpage { get; set; }
        public int pagesize { get; set; }
        public int countpage { get; set; }
        public int countitems { get; set; }
        public List<ExOrder> all { get; set; }
    }
}
