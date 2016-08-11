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

namespace AM.BLL
{
    public class UpfeedBackInfoManager : MFXinYEFBase<upfeedbackinfo>
    {
        DB db;
        public UpfeedBackInfoManager(DB db)
        {
            this.db = db;
        }


        #region 重写增删改
        public override IAOPResult Add(upfeedbackinfo model)
        {
            var r = base.Add(model);
            return r;
        }

        public override IAOPResult Update(upfeedbackinfo model)
        {
            var r = base.Update(model);
            return r;
        }

        public override IAOPResult Delete(upfeedbackinfo model)
        {
            var r = base.Delete(model);
            return r;
        }
        #endregion
    }
}
