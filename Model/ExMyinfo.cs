using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ExMyinfo : Base
    {
        public string userid { get; set; }
        public string userlogo { get; set; }
        public string usernickname { get; set; }
        public string gradename { get; set; }
        public string gradelogo { get; set; }
        public int userpoints { get; set; }
        public double userconsumption { get; set; }
        public string loginname { get; set; }
        public string loginpwd { get; set; }
    }
}
