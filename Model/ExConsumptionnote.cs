using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 用户消费记录的扩展类
    /// </summary>
    public class ExConsumptionnotes : Base
    {
        public double userconsumption { get; set; }
        public int currentpage { get; set; }
        public int pagesize { get; set; }
        public int countpage { get; set; }
        public int countitems { get; set; }
        public List<ExConsumptionnote> all { get; set; }
    }
    public class ExConsumptionnote
    {
        public string consumptionnoteid { get; set; }
        public string consumptionnotelogo { get; set; }
        public string consumptionnotedate { get; set; }
        public string consumptionnotetitle { get; set; }
        public double consumptionnotecountmoney { get; set; }
    }
}
