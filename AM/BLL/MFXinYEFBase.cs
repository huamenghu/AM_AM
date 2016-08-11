using MFXinY.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;

namespace AM.BLL
{
    public class MFXinYEFBase<T> : EFBase<T> where T : class,new()
    {
        private static readonly string _conn = ConfigurationManager.ConnectionStrings["amEntities"].ToString();
        public override DbContext DataBase
        {
            get
            {
                return DbFactory.Intance(_conn);
            }
        } 
    }
}
