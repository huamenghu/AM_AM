using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExAliPay : Base
    {
        public string partner { get; set; }
        public string private_key { get; set; }
        public string ali_public_key { get; set; }
        public string notify_url { get; set; }
        public string seller { get; set; }
    }
    public class ExAliPayOrder : ExAliPay
    { 
        public string ordernumber { get; set; }
        public double price { get; set; }
    }
    public class ExAliPayOrderGN : ExAliPay
    {
        public string ordernumber { get; set; }
        public double gnprice { get; set; }
    }
}
