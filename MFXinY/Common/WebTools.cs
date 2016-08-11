using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls; 
using System.Reflection;
using System.Net;

namespace MFXinY.Common
{
    /// <summary>
    /// 操作页面常用的工具类，比如：得到下层控件,给页面各个控件赋值，取各个控件的值赋值给对象，获取网页源代码等
    /// </summary>
    public class WebTools
    {
        /// <summary>
        /// 得到下层所有的控件，包括下层的下层。。。
        /// </summary>
        /// <param name="parent">父控件</param>
        /// <param name="type">要得到的控件类型</param>
        /// <param name="list">要得到的控件集合</param>
        public void GetChildControls(Control parent, Type type, List<Control> list)
        {
            foreach (Control item in parent.Controls)
            {
                if (item.GetType() == type)
                {
                    list.Add(item);
                }
                GetChildControls(item, type, list);
            }
        }
        /// <summary>
        /// 下拉控件绑定数据
        /// </summary>
        /// <param name="ddl">下拉控件</param>
        /// <param name="data">数据源</param>
        /// <param name="valueField">值字段</param>
        /// <param name="textField">显示字段</param>
        public void DDLDataBind(DropDownList ddl, object data, string valueField, string textField)
        {
            ddl.DataSource = data;
            ddl.DataTextField = textField;
            ddl.DataValueField = valueField;
            ddl.DataBind();
        }
        #region 从对象里取值出来赋值给控件 或 将表单控件里取值组合对象
        #region 从对象model里取值出来赋值给控件
        /// <summary>
        /// 从对象model里取值出来赋值给控件
        /// </summary>
        /// <param name="parent">表单控件集合的父控件,比如：form1</param>
        /// <param name="rules">控件命名规则</param>
        /// <param name="obj">要赋值的对象</param>
        /// <returns></returns>
        public IAOPResult SetDataToControls(Control parent, List<ControlNameRule> rules, object obj)
        {
            try
            {
                //将obj进行html解码
                SecurityTools.HtmlDecode(obj);
                Type type = obj.GetType();
                PropertyInfo[] infos = type.GetProperties();
                SetDataToControls(parent, rules, obj, infos);
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, e.Message);
            }
        }
        private void SetDataToControls(Control parent, List<ControlNameRule> rules, object obj, PropertyInfo[] propertyInfos)
        {
            foreach (Control item in parent.Controls)
            {
                Type controlType = item.GetType();
                string id = item.ID;
                var rule = rules.FirstOrDefault(a => a.ControlType == controlType && id.StartsWith(a.StartWith));
                if (rule != null)
                {
                    var fieldName = item.ID.Substring(rule.StartWith.Length);     //字段名称
                    var p = propertyInfos.FirstOrDefault(a => a.Name == fieldName);
                    if (p != null)
                    {
                        var value = p.GetValue(obj, null);   //从对象obj里取出此字段的值
                        if (value == null)
                        {
                            continue;    //如果值为空，则继续下次循环
                        }
                        if (item.GetType() == typeof(TextBox))
                        {
                            (item as TextBox).Text = value.ToString();
                            continue;
                        }
                        if (item.GetType() == typeof(CheckBox))
                        {
                            (item as CheckBox).Checked = Convert.ToBoolean(value);
                            continue;
                        }
                        if (item.GetType() == typeof(RadioButtonList))
                        {
                            (item as RadioButtonList).SelectedValue = value.ToString();
                            continue;
                        }
                        if (item.GetType() == typeof(DropDownList))
                        {
                            (item as DropDownList).SelectedValue = value.ToString();
                            continue;
                        }
                        if (item.GetType() == typeof(RadioButton))
                        {
                            (item as RadioButton).Checked = Convert.ToBoolean(value);
                        }
                        continue;
                    }
                }
                SetDataToControls(item, rules, obj, propertyInfos);
            }
        }
        /// <summary>
        /// 从对象model里取值出来赋值给控件，控件命名规则【以"xx"开头】（TextBox[txt],CheckBox[cb],RadioButton[rb],RadioButtonList[rbl],DropDownList[ddl]）
        /// </summary>
        /// <param name="parent">表单控件集合的父控件,比如：form1</param>
        /// <param name="model"></param>
        /// <returns>赋值是否成功</returns>
        public IAOPResult SetDataToControls(Control parent, object model)
        {
            List<ControlNameRule> rules = new List<ControlNameRule>();
            rules.Add(new ControlNameRule("txt", typeof(TextBox)));
            rules.Add(new ControlNameRule("rb", typeof(RadioButton)));
            rules.Add(new ControlNameRule("rbl", typeof(RadioButtonList)));
            rules.Add(new ControlNameRule("cb", typeof(CheckBox)));
            rules.Add(new ControlNameRule("ddl", typeof(DropDownList)));
            return SetDataToControls(parent, rules, model);
        }
        #endregion
        #region 将表单控件里取值组合对象
        /// <summary>
        /// 将表单控件里取值组合对象
        /// </summary>
        /// <param name="parent">表单控件集合的父控件,比如：form1</param>
        /// <param name="rules">控件命名规则</param>
        /// <param name="obj">要组合的对象</param>
        /// <returns></returns>
        public IAOPResult GetDataFromControls(Control parent, List<ControlNameRule> rules, object obj)
        {
            try
            {
                Type type = obj.GetType();
                PropertyInfo[] infos = type.GetProperties();
                GetDataFromControls(parent, rules, obj, infos);
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, e.Message);
            }
        }
        private void GetDataFromControls(Control parent, List<ControlNameRule> rules, object obj, PropertyInfo[] propertyInfos)
        {
            foreach (Control item in parent.Controls)
            {
                Type controlType = item.GetType();
                string id = item.ID;
                var rule = rules.FirstOrDefault(a => a.ControlType == controlType && id.StartsWith(a.StartWith));
                if (rule != null)
                {
                    var fieldName = item.ID.Substring(rule.StartWith.Length);     //字段名称
                    var p = propertyInfos.FirstOrDefault(a => a.Name == fieldName);
                    if (p != null)
                    {
                        object value = null;
                        if (item.GetType() == typeof(TextBox))
                        {
                            value = (item as TextBox).Text;
                        }
                        if (item.GetType() == typeof(CheckBox))
                        {
                            value = (item as CheckBox).Checked;
                        }
                        if (item.GetType() == typeof(RadioButtonList))
                        {
                            value = (item as RadioButtonList).SelectedValue;
                        }
                        if (item.GetType() == typeof(DropDownList))
                        {
                            value = (item as DropDownList).SelectedValue;
                        }
                        if (item.GetType() == typeof(RadioButton))
                        {
                            p.SetValue(obj, (item as RadioButton).Checked, null);
                        }
                        p.SetValue(obj, ConvertType(value, p.PropertyType), null);
                    }
                }
                GetDataFromControls(item, rules, obj, propertyInfos);
            }
        }
        /// <summary>
        /// 从控件取值出来赋值给对象model，控件命名规则【以"xx"开头】（TextBox[txt],CheckBox[cb],RadioButton[rb],RadioButtonList[rbl],DropDownList[ddl]）
        /// </summary>
        /// <param name="parent">表单控件集合的父控件,比如：form1</param>
        /// <param name="model">model对象</param>
        /// <returns>赋值是否成功</returns>
        public IAOPResult GetDataFromControls(Control parent, object model)
        {
            List<ControlNameRule> rules = new List<ControlNameRule>();
            rules.Add(new ControlNameRule("txt", typeof(TextBox)));
            rules.Add(new ControlNameRule("rb", typeof(RadioButton)));
            rules.Add(new ControlNameRule("rbl", typeof(RadioButtonList)));
            rules.Add(new ControlNameRule("cb", typeof(CheckBox)));
            rules.Add(new ControlNameRule("ddl", typeof(DropDownList)));
            return GetDataFromControls(parent, rules, model);
        }
        #endregion
        #region 辅助类
        /// <summary>
        /// 控件名称规则类
        /// </summary>
        public class ControlNameRule
        {
            private string startWith;
            /// <summary>
            /// 控件名称的前置 字符
            /// </summary>
            public string StartWith
            {
                get { return startWith; }
                set { startWith = value; }
            }
            private Type controlType;
            /// <summary>
            /// 控件的类型
            /// </summary>
            public Type ControlType
            {
                get { return controlType; }
                set { controlType = value; }
            }
            /// <summary>
            /// 构造器
            /// </summary>
            /// <param name="startWith">控件名称开始标识</param>
            /// <param name="controlType">控件类型</param>
            public ControlNameRule(string startWith, Type controlType)
            {
                this.controlType = controlType;
                this.startWith = startWith;
            }
        }
        #endregion
        #endregion
        /// <summary>
        /// 转换类型,用于某个字段的类型转换，也就是适用于值类型的转换
        /// </summary>
        /// <param name="obj">要转换的对象</param>
        /// <param name="type">要转换到的类型</param>
        /// <returns>返回转换后的对象</returns>
        public object ConvertType(object obj, Type type)
        {
            if (obj == null || (obj != null && string.IsNullOrEmpty(obj.ToString())))
            {
                return null;
            }
            if (type == typeof(int) || type == typeof(int?))
            {
                return Convert.ToInt32(obj);
            }
            if (type == typeof(decimal) || type == typeof(decimal?))
            {
                return Convert.ToDecimal(obj);
            }
            if (type == typeof(string))
            {
                return obj.ToString();
            }
            if (type == typeof(bool) || type == typeof(bool?))
            {
                return Convert.ToBoolean(obj);
            }
            if (type == typeof(DateTime) || type == typeof(DateTime?))
            {
                return Convert.ToDateTime(obj);
            }
            #region 不常用的类型
            if (type == typeof(Byte) || type == typeof(Byte?))
            {
                return Convert.ToByte(obj);
            }
            if (type == typeof(DateTimeOffset) || type == typeof(DateTimeOffset?))
            {
                return Convert.ToDateTime(obj);
            }
            if (type == typeof(Double) || type == typeof(Double?))
            {
                return Convert.ToDouble(obj);
            }
            if (type == typeof(Int16) || type == typeof(Int16?))
            {
                return Convert.ToInt16(obj);
            }
            if (type == typeof(Int32) || type == typeof(Int32?))
            {
                return Convert.ToInt32(obj);
            }
            if (type == typeof(SByte) || type == typeof(SByte?))
            {
                return Convert.ToSByte(obj);
            }
            if (type == typeof(Int64) || type == typeof(Int64?))
            {
                return Convert.ToInt64(obj);
            }
            #endregion
            return obj;
        }

        /// <summary>
        /// 判断url是否为有效地址，有时判断不是太准确
        /// </summary>
        /// <param name="url">url</param>
        /// <returns>返回url是否为有效地址</returns>
        public bool UrlIsExist(String url)
        {
            System.Uri u = null;
            try
            {
                u = new Uri(url);
            }
            catch { return false; }
            bool isExist = false;
            System.Net.HttpWebRequest r = System.Net.HttpWebRequest.Create(u) as System.Net.HttpWebRequest;
            r.Method = "HEAD";
            try
            {
                System.Net.HttpWebResponse s = r.GetResponse() as System.Net.HttpWebResponse;
                if (s.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    isExist = true;
                }
            }
            catch (System.Net.WebException x)
            {
                try
                {
                    isExist = ((x.Response as System.Net.HttpWebResponse).StatusCode != System.Net.HttpStatusCode.NotFound);
                }
                catch { isExist = (x.Status == System.Net.WebExceptionStatus.Success); }
            }
            return isExist;
        }

        /// <summary>
        /// 获取网页源代码
        /// </summary>
        /// <param name="url">网页的url</param>
        /// <returns>返回获取获取结果，描述为网页的源代码</returns>
        public IAOPResult GetHtml(string url)
        {
            try
            {
                if (UrlIsExist(url))
                {
                    WebClient myWebClient = new WebClient();
                    var s = myWebClient.DownloadData(url);
                    return new AOPResult(0, Encoding.Default.GetString(s));
                }
                else
                {
                    return new AOPResult(-1, string.Format("URL:{0}不存在。", url));
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, e.Message);
            }
        }
    }
}
