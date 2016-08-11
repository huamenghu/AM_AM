using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 商品搜索扩展类
    /// </summary>
    public class ExShopSearch : Base
    {
        public string pagesize { get; set; }
        public string currentpage { get; set; }
        public string countpage { get; set; }
        public string countitems { get; set; }
        public List<ExAd> ads { get; set; }
        public List<ExGoodsSearch> goods { get; set; }
    }
}
