using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFXinY.EF;
using System.Collections;
using Dao;
using MFXinY.Common;
using System.Data.Entity;

namespace AM.BLL
{
    public class GradeManager : MFXinYEFBase<grade>
    {
        DB db;
        public GradeManager(DB db)
        {
            this.db = db;
        }

        public double GetDiscount(string gradeid)
        {
            double discount = 1;
            if (!string.IsNullOrEmpty(gradeid))
            {

                var m = Where(a => a.gradeid == gradeid).ToList();
                if (m.Count >= 1)
                {
                    discount = m[0].gradediscount;
                }
            }
            return discount;
        }
        public IAOPResult SetUserGrade(string userid)
        {
            //查询消费总额
            var sum = db.ConsumptionnoteManager.Where(a => a.userid == userid).Sum(a => a.consumptionnotecountmoney);
            var user = db.UserManager.First(a => a.userid == userid);
            if (user == null)
            {
                return new AOPResult(-1, "用户未找到");
            }
            // var grade = db.GradeManager.First(a => a.gradeid == user.gradeid);
            var gradelist = db.GradeManager.Where(a => a.gradefull <= sum).OrderByDescending(a => a.gradefull).FirstOrDefault();

            if (gradelist != null && user.gradeid != gradelist.gradeid)
            {
                user.gradeid = gradelist.gradeid;
                var r = db.UserManager.Update(user);
                return r;
            }
            else
            {
                return new AOPResult(-2, "没有符合的等级");
            }           
        }
    }
}

