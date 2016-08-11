using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 一级分类商品类
    /// </summary>
    public class ExTypeGoods 
    {
        public string typeadimgurl { get; set; }
        public string typename { get; set; }
        public string typeid { get; set; }
        public List<ExGoodsIndex> goods { get; set; }
    }
}
