using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单详情 扩展类
    /// </summary>
    public class ExMyOrderQX : ExAliPay
    {
        public ExAddrSimple addr { get; set; }
        public List<ExExpress> express { get; set; }
        public ExOrder order { get; set; }
    }
}
