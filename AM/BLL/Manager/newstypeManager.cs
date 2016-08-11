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
    public class NewsTypeManager : MFXinYEFBase<newstype>
    {
        DB db;
        public NewsTypeManager(DB db)
        {
            this.db = db;
        }

        #region 重写增删改
        public override IAOPResult Add(List<newstype> list)
        {
            var r = base.Add(list);
            DataStore.RefreshNewsType();
            return r;
        }
        public override IAOPResult Update(List<newstype> list)
        {
            var r = base.Update(list);
            DataStore.RefreshNewsType();
            return r;
        }
        public override IAOPResult Delete(List<newstype> list)
        {
            var r = base.Delete(list);
            DataStore.RefreshNewsType();
            return r;
        }
        #endregion
    }
}

