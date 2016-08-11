using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MFXinY.Common
{
    /// <summary>
    /// 对象复制类
    /// 冯虎龙
    /// 2013-08-13 09:31:51
    /// </summary>
    /// <remarks>任何需要复制的类，只需要继承此类，并把类标识为可序列化，则可调用里面的Clone方法，进行对象复制</remarks>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class Cloneable<T> : IICloneable<T> where T : class
    {
        public T Clone()
        {
            T t = default(T);
            if (null != this)
            {
                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Seek(0, SeekOrigin.Begin);
                t = bf.Deserialize(ms) as T;
            }
            return t;
        }
    }
    /// <summary>
    /// 对象复制类，提供了对象的集合复制
    /// 冯虎龙
    /// 2013-08-13 09:36:17
    /// </summary>
    public class Cloneable
    {
        public static IList<T> Clone<T>(IList<T> listToClone) where T : Cloneable<T>
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }


}
