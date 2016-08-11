using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFXinY.Common
{
    /// <summary>
    /// 特性，标识类是否应用于工菜单显示
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Enum, AllowMultiple = true, Inherited = true)]
    public class ExDescriptionAttribute : Attribute
    {
        #region field
        /// <summary>
        /// 类型名
        /// </summary>
        private string descriptionName;
        /// <summary>
        /// 标记是否可用
        /// </summary>
        private bool isAvailable;
        private string layer = string.Empty;
        #endregion

        #region Property
        /// <summary>
        /// 对字段名的中文描述--中文名
        /// </summary>
        public string DescriptionName
        {
            get { return descriptionName; }
            set { descriptionName = value; }
        }
        /// <summary>
        /// 标记是否可用
        /// </summary>
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
        /// <summary>
        /// 描述字段的应用层次，为避免混淆，最好用常量标识
        /// </summary>
        public string Layer
        {
            get { return layer; }
            set { layer = value; }
        }
        #endregion
        #region construct
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="descriptionName">描述名称</param>
        public ExDescriptionAttribute(string descriptionName)
        {
            this.descriptionName = descriptionName;
        }
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="descriptionName">描述名称</param>
        /// <param name="isAvailable">是否可用</param>
        public ExDescriptionAttribute(string descriptionName, bool isAvailable)
        {
            this.descriptionName = descriptionName;
            this.isAvailable = isAvailable;
        }
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="descriptionName">描述名称</param>
        /// <param name="isAvailable">是否可用</param>
        /// <param name="layer">层次</param>
        public ExDescriptionAttribute(string descriptionName, bool isAvailable, string layer)
        {
            this.descriptionName = descriptionName;
            this.isAvailable = isAvailable;
            this.layer = layer;
        }
        #endregion
    }
}
