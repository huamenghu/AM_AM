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
    public class AdManager : MFXinYEFBase<ad>
    {
        DB db;
        public AdManager(DB db)
        {
            this.db = db;
        }
         
    }
}
