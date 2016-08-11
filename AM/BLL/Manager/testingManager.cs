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
    public class TestingManager : MFXinYEFBase<testing>
    {
        DB db;
        public TestingManager(DB db)
        {
            this.db = db;
        } 

    }
}

