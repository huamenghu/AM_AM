using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MFXinY.EF
{
    /// <summary> 
    /// 数据库建立工厂       
    /// Created By : 张占岭       
    /// Created Date：2011-10-14       
    /// Modify By:       
    /// Modify Date:       
    /// Modify Reason:       
    /// </summary>       
    public sealed class DbFactory
    {
        #region Fields
        static System.Timers.Timer sysTimer = new System.Timers.Timer(10000);
        volatile static Dictionary<Thread, DbContext[]> divDataContext = new Dictionary<Thread, DbContext[]>();
        #endregion
        #region Constructors
        /// <summary>           
        /// 类构造方法         
        /// /// </summary>      
        static DbFactory()
        {
            sysTimer.AutoReset = true;
            sysTimer.Enabled = true;
            sysTimer.Elapsed += new System.Timers.ElapsedEventHandler(sysTimer_Elapsed);
            sysTimer.Start();
        }
        #endregion
        #region  Static Methods
        /// <summary>           
        /// 订阅Elapsed事件的方法       
        /// </summary>         
        /// <param name="sender"></param>     
        /// <param name="e"></param>    
        static void sysTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            List<Thread> list = divDataContext.Keys.Where(item => item.ThreadState == ThreadState.Stopped).ToList();
            for (int index = 0; index < list.Count; index++)
            {
                for (int refer = 0; refer < divDataContext[list[index]].Length; refer++)
                    if (divDataContext[list[index]][refer] != null)
                    {
                        divDataContext[list[index]][refer].Dispose();
                        divDataContext[list[index]][refer] = null;
                    } divDataContext.Remove(list[index]);
                list[index] = null;
            }
        }
        /// <summary>         
        /// 通过工厂的制造模式获取相应的LINQ数据库连接对象     
        /// </summary>        
        /// <param name="dbName">数据库名称(需要与真实数据库名称保持一致)</param>     
        /// <returns>LINQ数据库连接对象</returns>      
        public static DbContext Intance(string dbName)
        {
            return Intance(dbName, Thread.CurrentThread, 1, 0);
        }
        /// <summary>
        /// 通过工厂的制造模式获取相应的LINQ数据库连接对象    
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="dbCount"></param>
        /// <param name="dbIndex"></param>
        /// <returns></returns>
        public static DbContext Intance(string dbName, int dbCount, int dbIndex)
        {
            return Intance(dbName, Thread.CurrentThread, dbCount, dbIndex);
        }
        /// <summary>         
        ///  通过工厂的制造模式获取相应的LINQ数据库连接对象      
        ///  </summary>      
        ///  <param name="dbName">数据库名称(需要与真实数据库名称保持一致)</param>   
        ///  <param name="thread">当前线程引用的对象</param>          
        ///  <param name="dbCount">linq to sql数据库数量</param>          
        ///  <param name="dbIndex">当前索引</param>          
        ///  <returns>LINQ对象上下文</returns>         

        public static DbContext Intance(string dbName, Thread thread, int dbCount, int dbIndex)
        {
            lock ("1")
            {
                if (!divDataContext.Keys.Contains(thread))
                {
                    divDataContext.Add(thread, new DbContext[dbCount]);
                } if (divDataContext[thread][dbIndex] == null)
                {
                    divDataContext[thread][dbIndex] = new DbContext(dbName);
                }
                return divDataContext[thread][dbIndex];
            }
        }
        /// <summary>
        /// 通过工厂的制造模式获取相应的LINQ数据库连接对象       
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="thread"></param>
        /// <returns></returns>
        public static DbContext Intance(string dbName, Thread thread)
        {
            return Intance(dbName, thread, 1, 0);
        }
        #endregion
    }
}

