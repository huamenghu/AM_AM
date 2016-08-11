using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Base
    {
        /// <summary>
        /// 接口失败时，返回附带的消息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 1接口成功 0接口失败
        /// </summary>
        public int code { get; set; }
    }
}
