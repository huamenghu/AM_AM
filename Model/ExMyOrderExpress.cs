using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单物流 扩展类
    /// </summary>
    public class ExMyOrderExpress:Base
    {
        public List<ExExpress> express { get; set; }
        public ExOrder_Express order { get; set; }
    }
}
