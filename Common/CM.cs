using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.Common
{
    public class CM
    {
        #region 单例
        private static CM instant;
        static object lockObj = new object();
        public static CM Instant
        {
            get
            {
                if (instant == null)
                {
                    lock (lockObj)
                    {
                        if (instant == null)
                        {
                            instant = new CM();
                        }
                    }
                }
                return instant;
            }
        }
        #endregion

        private HashDomain hashDomain;

        public HashDomain HashHelper
        {
            get
            {
                if (hashDomain == null)
                {
                    hashDomain = new HashDomain(instant);
                }
                return hashDomain;
            }

        }


    }


}