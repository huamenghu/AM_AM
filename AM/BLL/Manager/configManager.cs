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
    public class ConfigManager : MFXinYEFBase<config>
    {
        DB db;
        public ConfigManager(DB db)
        {
            this.db = db;
        }

        public double GetDouble(string key)
        {
            try
            {
                var x = DataStore.Config.FirstOrDefault(a => a.Key == key);
                if (x != null)
                {
                    return Convert.ToDouble(x.Value);
                }
            }
            catch
            {
            }
            return 0;
        }

        public string GetValue(string key)
        {
            try
            {
                var x = DataStore.Config.FirstOrDefault(a => a.Key == key);
                if (x != null)
                {
                    return x.Value;
                }
            }
            catch
            {
            }
            return string.Empty;
        }
    }
}

