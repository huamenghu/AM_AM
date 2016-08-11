using Dao;
using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.BLL
{
    public class AdminManager : MFXinYEFBase<admin>
    {
        DB db;
        public AdminManager(DB db)
        {
            this.db = db;
        }
        public admin Authention(string userName, string passowrd)
        {
            admin a = null;
            try
            {
                using (var db = new amEntities())
                {
                    a = db.admin.FirstOrDefault(p => p.UserName.Trim().ToLower() == userName.Trim().ToLower() && p.Password.Trim().ToLower() == passowrd.Trim().ToLower());
                }
            }
            catch (Exception exc)
            {

            }
            return a;
        }

        #region 重写增删改
        public override IAOPResult Add(admin model)
        {
            var r = base.Add(model);
            return r;
        }
        public override MFXinY.Common.IAOPResult Add(List<admin> list)
        {

            var r = base.Add(list);

            return r;
        }
        public override IAOPResult Update(admin model)
        {
            var r = base.Update(model);
            return r;
        }
        public override MFXinY.Common.IAOPResult Update(List<admin> list)
        {

            var r = base.Update(list);
            return r;
        }
        public override IAOPResult Delete(List<admin> list)
        {
            var r = base.Delete(list);
            return r;
        }

        public override IAOPResult Delete(admin model)
        {
            var r = base.Delete(model);
            return r;
        }
        #endregion
    }
}