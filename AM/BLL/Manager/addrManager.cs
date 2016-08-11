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
    public class AddrManager : MFXinYEFBase<addr>
    {
        DB db;
        public AddrManager(DB db)
        {
            this.db = db;
        }
        /// <summary>
        /// 根据userid获取多条收货地址
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public List<addr> GeyAddrsByUserID(string userid)
        {
            List<addr> list = null;
            try
            {
                using (var db = new amEntities())
                {
                    list = db.addr.Where(a => a.userid == userid).ToList();
                }
            }
            catch (Exception Exc)
            {

            }
            return list;
        }

        /// <summary>
        /// 根据addrid获取1条收货地址
        /// </summary>
        public addr GetmyaddroneByUserIDAndAddrID(string userid, string addrid)
        {
            addr ar = null;
            try
            {
                using (var db = new amEntities())
                {
                    ar = db.addr.FirstOrDefault(a => a.userid == userid && a.addrid == addrid);
                }
            }
            catch (Exception Exc)
            {

            }
            return ar;
        }

        /// <summary>
        /// 修改收货地址
        /// </summary>
        public IAOPResult UpdateMyaddrByUserIDAndAddrID(string userid, string addrid, string addrname, string addrphone, string addraddr)
        {
            AOPResult aop = null;

            try
            {
                using (var db = new amEntities())
                {
                    addr u = db.addr.FirstOrDefault(a => a.userid == userid && a.addrid == addrid);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "地址不存在");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(addrid))
                        {
                            u.addrid = addrid;
                        }
                        if (!string.IsNullOrEmpty(addrname))
                        {
                            u.addrname = addrname;
                        }
                        if (!string.IsNullOrEmpty(addrphone))
                        {
                            u.addrphone = addrphone;
                        }
                        if (!string.IsNullOrEmpty(addraddr))
                        {
                            u.addraddr = addraddr;
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

        public addr GetAddrByAddrID(string addrID)
        {
            addr model = null;
            try
            {
                using (var db = new amEntities())
                {
                    model = db.addr.FirstOrDefault(a => a.addrid == addrID);
                }
            }
            catch (Exception Exc)
            {

            }
            return model;
        }

        #region 重写增删改
        public override IAOPResult Add(addr model)
        {
            var r = base.Add(model);
            return r;
        }
        public override MFXinY.Common.IAOPResult Add(List<addr> list)
        {

            var r = base.Add(list);
            return r;
        }
        public override IAOPResult Update(addr model)
        {
            var r = base.Update(model);
            return r;
        }
        public override MFXinY.Common.IAOPResult Update(List<addr> list)
        {

            var r = base.Update(list);
            return r;
        }
        public override IAOPResult Delete(List<addr> list)
        {
            var r = base.Delete(list);
            return r;
        }

        public override IAOPResult Delete(addr model)
        {
            var r = base.Delete(model);
            return r;
        }
        #endregion
    }
}
