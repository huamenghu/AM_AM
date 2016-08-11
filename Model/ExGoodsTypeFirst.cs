using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExGoodsTypeFirst
    {
        public string typeid { get; set; }
        public string typename { get; set; }
        public string typelogo { get; set; }
        public string typeadimgurl { get; set; }
        public List<ExGoodsTypeSecond> sontype { get; set; }
    }
}
