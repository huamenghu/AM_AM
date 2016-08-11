using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFXinY.Common
{
    /// <summary>
    /// 深度复制接口
    /// 冯虎龙
    /// 2013-08-13 09:29:28
    /// </summary>
    /// <typeparam name="T">参数类型为要复制的对象</typeparam>
    interface IICloneable<T> where T : class
    {
        T Clone();
    }
}
