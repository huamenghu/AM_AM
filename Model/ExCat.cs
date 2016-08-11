using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 购物车 扩展类
    /// </summary>
    public class ExCat : Base
    {
        public string iscatnan { get; set; }
        public List<ExCatGoods> goods { get; set; }
        public double catcountprice { get; set; }
    }
}
