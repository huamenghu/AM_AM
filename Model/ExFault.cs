using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 故障信息 扩展类
    /// </summary>
    public class ExFault
    {
        public string faultid { get; set; }
        public string faulttitle { get; set; }
        public string faultislogo { get; set; }
        public string faultlogo { get; set; }
        public string faultsummary { get; set; }

    }
    public class ExFaultList : Base
    {
        public List<ExType2> type { get; set; }
        public List<ExFault> faults { get; set; }
    }

    public class ExFaultDetail : Base
    {
        public string faultid { get; set; }
        public string faulttitle { get; set; }
        public string faultislogo { get; set; }
        public string faultlogo { get; set; }
        public string faultsummary { get; set; }
        public string faultdate { get; set; }
        public string faultcontent { get; set; }
    }

    public class ExType2 
    {
        public string typeid { get; set; }
        public string typename { get; set; }
        public string typelogo { get; set; }     
    }
}
