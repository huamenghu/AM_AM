using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExAddr : ExAddrSimple
    {
        public string addrid { get; set; }
        //默认地址 1默认地址 0非默认地址
        public string adddefault { get; set; }

    }
    public class ExAddrSimple
    {
        public string addrname { get; set; }
        public string addrphone { get; set; }
        public string addraddr { get; set; }
    }
}
