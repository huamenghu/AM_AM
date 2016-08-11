using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SMS_IPObj
    {
        public string error_code { get; set; }
        public string reason { get; set; }
        public SMS_Result result { get; set; }
    }
   public  class SMS_Result
    {
       public int count { get; set; }
       public int fee { get; set; }
       public string sid { get; set; }
    }
}
