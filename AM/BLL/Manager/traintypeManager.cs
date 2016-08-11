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
    public class TrainTypeManager : MFXinYEFBase<traintype>
    {
        DB db;
        public TrainTypeManager(DB db)
        {
            this.db = db;
        } 

    }
}

