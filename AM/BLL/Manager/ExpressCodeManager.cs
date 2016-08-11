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
    public class ExpressCodeManager : MFXinYEFBase<expresscode>
    {

        public string GetName(string id)
        {
            var m = DB.ExpressCode.First(a => a.Code == id);
            if (m != null)
                return m.Name;
            return string.Empty;
        }
    }
}

