using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExGoods : Base
    {
        public string goodsid { get; set; }
        public string goodsname { get; set; }
        public string goodslogo { get; set; }
        public string goodsprice { get; set; }
        public string goodsdiscountprice { get; set; }
        public string goodscontent { get; set; }
    }
    public class ExGoods2 
    {
        public string goodsid { get; set; }
        public string goodsname { get; set; }
        public string goodslogo { get; set; }
        public string goodsprice { get; set; }
        public string goodsdiscountprice { get; set; }
        public int goodssize { get; set; }
    }
}
