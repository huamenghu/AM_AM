using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExSureMyCat : Base
    {
        public string isaddr { get; set; }
        public ExAddr addr { get; set; }
        public int userpoints { get; set; }
        public double pointsmoneyexchange { get; set; }
        public double pointsmoney { get; set; }
        public double catcountprice { get; set; }
        public double yunfei { get; set; }
        public double baoyoue { get; set; }
        public List<ExGoods2> goods { get; set; }
    }
}
