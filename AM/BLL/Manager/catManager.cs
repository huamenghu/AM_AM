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
    public class CatManager : MFXinYEFBase<cat>
    {
        DB db;
        public CatManager(DB db)
        {
            this.db = db;
        }

        public IAOPResult UpdateCatGoodsSizeByGoodsIDAndUserID(string goodsid, string userid, string goodssize)
        {
            AOPResult aop = null;

            try
            {
                using (var db = new amEntities())
                {
                    cat u = db.cat.FirstOrDefault(a => a.userid == userid && a.goodsid == goodsid);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "购物车不存在");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(goodssize))
                        {
                            u.goodssize = Convert.ToInt32(goodssize);
                        }

                        db.SaveChanges();
                        aop = new AOPResult(0, "修改成功");
                    }
                }
            }
            catch (Exception Exc)
            {
                aop = new AOPResult(-100, Exc.Message);
            }
            return aop;
        }

        #region 重写增删改
        public override IAOPResult Add(cat model)
        {
            var r = base.Add(model);
            return r;
        }

        public override IAOPResult Update(cat model)
        {
            var r = base.Update(model);
            return r;
        }

        public override IAOPResult Delete(cat model)
        {
            var r = base.Delete(model);
            return r;
        }
        #endregion

    }
}

