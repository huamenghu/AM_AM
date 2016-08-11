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
    public class AlipayManager : MFXinYEFBase<alipay>
    {
        DB db;
        public AlipayManager(DB db)
        {
            this.db = db;
        }

        public alipay GetAlipay()
        {
            var f = db.AlipayManager.First();
            if (f == null) f = new alipay();
            return f;
        }
    }
}

