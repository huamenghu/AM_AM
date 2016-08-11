using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFXinY.EF;
using System.Collections;
using Dao;
using MFXinY.Common;
using System.Data.Entity;
using Model;
using System.Text;
using AM.Common;

namespace AM.BLL
{
    public class OrderManager : MFXinYEFBase<order>
    {
        DB db;
        public OrderManager(DB db)
        {
            this.db = db;
        }

        public double GetYunFei(double money)
        {
            var yunfei = DB.Instant.ConfigManager.GetDouble("Money_YouFei");
            var Money_BaoYou = DB.Instant.ConfigManager.GetDouble("Money_BaoYou");

            double _yunfei = 0;
            if(money<Money_BaoYou){
                _yunfei = yunfei;
            }
            return _yunfei;
        }
    }
}

