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
    public class GoodsManager : MFXinYEFBase<goods>
    {
        DB db;
        public GoodsManager(DB db)
        {
            this.db = db;
        }

        public goods GetGoodsByGoodsID(string goodsid)
        {
            goods u = null;
            try
            {
                using (var db = new amEntities())
                {
                    u = db.goods.FirstOrDefault(a => a.goodsid == goodsid);
                }
            }
            catch (Exception Exc)
            {

            }
            return u;
        }

    }
}

