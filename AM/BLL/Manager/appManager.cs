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
    public class AppManager : MFXinYEFBase<app>
    {
        DB db;
        public AppManager(DB db)
        {
            this.db = db;
        }

        public app GetApp(string appid)
        {

            app ap = null;
            try
            {
                using (var db = new amEntities())
                {
                    ap = db.app.FirstOrDefault(a => a.appid == appid);
                }
            }

            catch (Exception Exc)
            {

            }
            return ap;
        }

        #region 重写增删改
        public override IAOPResult Add(app model)
        {
            var r = base.Add(model);
            return r;
        }

        public override IAOPResult Update(app model)
        {
            var r = base.Update(model);
            return r;
        }

        public override IAOPResult Delete(app model)
        {
            var r = base.Delete(model);
            return r;
        }
        #endregion

    }
}

