using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExShopIndex : Base
    {
        public List<ExAd> ads { get; set; }
        public List<ExGoodsIndex> tjgoods { get; set; }
        public List<ExTypeGoods> typegoods { get; set; }
    }
}
