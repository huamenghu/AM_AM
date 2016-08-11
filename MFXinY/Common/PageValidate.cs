using System;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace MFXinY.Common
{
    /// <summary>
    /// 页面数据校验类，主要是根据正则表达式匹配结果
    /// 李天平，后经 小辛 扩充
    /// 2004.8
    /// </summary>
    public class PageValidate
    {
        private static Regex RegPhone = new Regex("^[0-9]+[-]?[0-9]+[-]?[0-9]$");
        private static Regex RegNumber = new Regex("^[0-9]+$");
        private static Regex RegNumberSign = new Regex("^[+-]?[0-9]+$");
        private static Regex RegDecimal = new Regex("^[0-9]+[.]?[0-9]+$");
        private static Regex RegDecimalSign = new Regex("^[+-]?[0-9]+[.]?[0-9]+$"); //等价于^[+-]?\d+[.]?\d+$
        private static Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");//w 英文字母或数字的字符串，和 [a-zA-Z0-9] 语法一样 
        private static Regex RegCHZN = new Regex("[\u4e00-\u9fa5]");
        
        /// <summary>
        /// 使用正则表达式 得到匹配的结果
        /// </summary>
        /// <param name="regexString">正则表达式</param>        
        /// <param name="content">匹配的范围</param>
        /// <returns>返回匹配到的字符串</returns>
        public static string GetRegValue(string regexString, string content)
        {
            //先简单匹配，匹配不到再复杂匹配
            Regex reg = new Regex(regexString, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            Match match = reg.Match(content);
            if (match.Success)
            {
                return match.Value;
            }
            return string.Empty;
        }
        /// <summary>
        /// 使用正则表达式 得到匹配的结果
        /// </summary>
        /// <param name="startFlag">匹配的起始字符串</param>
        /// <param name="endFlag">匹配结尾的字符串</param>
        /// <param name="content">匹配的范围</param>
        /// <returns>返回匹配的结果</returns>
        public static string GetRegValue(string startFlag, string endFlag, string content)
        {
            //先简单匹配，匹配不到再复杂匹配
            string regex1 = string.Format(@"{0}(.*){1}", startFlag, endFlag);
            var result = GetRegValue(regex1, content);
            if (string.IsNullOrEmpty(result))
            {              
                regex1 = string.Format(@"{0}[\s\S]*{1}", startFlag, endFlag);
                result = GetRegValue(regex1, content);
            }
            return result;
        }
        /// <summary>
        /// 根据某一特定的正则表达式来匹配字符串
        /// </summary>
        /// <param name="regex">正则表达式</param>
        /// <param name="inputString">输入字符串</param>
        /// <returns>返回是否匹配成功</returns>
        public static bool IsMatch(string regex,string inputString)
        {
            Regex reg = new Regex(regex);
            return reg.Match(inputString).Success;
        }
        #region 数字字符串检查
        /// <summary>
        /// 检查字符串是不是电话格式
        /// </summary>
        /// <param name="inputData">要检查的字符串</param>
        /// <returns>返回字符串是不是电话格式</returns>
        public static bool IsPhone(string inputData)
        {
            Match m = RegPhone.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// 检查Request查询字符串的键值，是否是数字，最大长度限制
        /// </summary>
        /// <param name="req">Request</param>
        /// <param name="inputKey">Request的键值</param>
        /// <param name="maxLen">最大长度</param>
        /// <returns>返回Request查询字符串</returns>
        public static string FetchInputDigit(HttpRequest req, string inputKey, int maxLen)
        {
            string retVal = string.Empty;
            if (inputKey != null && inputKey != string.Empty)
            {
                retVal = req.QueryString[inputKey];
                if (null == retVal)
                    retVal = req.Form[inputKey];
                if (null != retVal)
                {
                    retVal = SqlText(retVal, maxLen);
                    if (!IsNumber(retVal))
                        retVal = string.Empty;
                }
            }
            if (retVal == null)
                retVal = string.Empty;
            return retVal;
        }
        /// <summary>
        /// 是否数字字符串
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns>返回是否数字字符串结果</returns>
        public static bool IsNumber(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegNumber.Match(inputData);
            return m.Success;
        }

        /// <summary>
        /// 是否数字字符串 可带正负号
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns>返回结果</returns>
        public static bool IsNumberSign(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegNumberSign.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// 是否是浮点数
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns>返回结果</returns>
        public static bool IsDecimal(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegDecimal.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// 是否是浮点数 可带正负号
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns>返回结果</returns>
        public static bool IsDecimalSign(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegDecimalSign.Match(inputData);
            return m.Success;
        }

        #endregion

        #region 中文检测

        /// <summary>
        /// 检测是否有中文字符
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns>返回结果</returns>
        public static bool IsHasCHZN(string inputData)
        {
            Match m = RegCHZN.Match(inputData);
            return m.Success;
        }

        #endregion

        #region 邮件地址
        /// <summary>
        /// 是否是浮点数 可带正负号
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns>返回结果</returns>
        public static bool IsEmail(string inputData)
        {
            Match m = RegEmail.Match(inputData);
            return m.Success;
        }

        #endregion

        #region 日期格式判断
        /// <summary>
        /// 日期格式字符串判断
        /// </summary>
        /// <param name="str">要检查的字符串</param>
        /// <returns>返回结果</returns>
        public static bool IsDateTime(string str)
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    DateTime.Parse(str);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 其他

        /// <summary>
        /// 检查字符串最大长度，返回指定长度的串
        /// </summary>
        /// <param name="sqlInput">输入字符串</param>
        /// <param name="maxLength">最大长度</param>
        /// <returns>返回指定长度的串</returns>			
        public static string SqlText(string sqlInput, int maxLength)
        {
            if (sqlInput != null && sqlInput != string.Empty)
            {
                sqlInput = sqlInput.Trim();
                if (sqlInput.Length > maxLength)//按最大长度截取字符串
                    sqlInput = sqlInput.Substring(0, maxLength);
            }
            return sqlInput;
        }
        /// <summary>
        /// 字符串编码
        /// </summary>
        /// <param name="inputData">要编码的字符串</param>
        /// <returns>返回编码后的字符串</returns>
        public static string HtmlEncode(string inputData)
        {
            return HttpUtility.HtmlEncode(inputData);
        }
        /// <summary>
        /// 设置Label显示Encode的字符串
        /// </summary>
        /// <param name="lbl">Label控件</param>
        /// <param name="txtInput">要显示的字符串</param>
        public static void SetLabel(Label lbl, string txtInput)
        {
            lbl.Text = HtmlEncode(txtInput);
        }
        /// <summary>
        /// 设置Label显示Encode的对象
        /// </summary>
        /// <param name="lbl">Label控件</param>
        /// <param name="inputObj">要显示的对象</param>
        public static void SetLabel(Label lbl, object inputObj)
        {
            SetLabel(lbl, inputObj.ToString());
        }
       /// <summary>
       /// 字符串清理
       /// </summary>
       /// <param name="inputString">要操作的字符串</param>
       /// <param name="maxLength">最大长度</param>
       /// <returns>返回清理后的字符串</returns>
        public static string InputText(string inputString, int maxLength)
        {
            StringBuilder retVal = new StringBuilder();

            // 检查是否为空
            if ((inputString != null) && (inputString != String.Empty))
            {
                inputString = inputString.Trim();

                //检查长度
                if (inputString.Length > maxLength)
                    inputString = inputString.Substring(0, maxLength);

                //替换危险字符
                for (int i = 0; i < inputString.Length; i++)
                {
                    switch (inputString[i])
                    {
                        case '"':
                            retVal.Append("&quot;");
                            break;
                        case '<':
                            retVal.Append("&lt;");
                            break;
                        case '>':
                            retVal.Append("&gt;");
                            break;
                        default:
                            retVal.Append(inputString[i]);
                            break;
                    }
                }
                retVal.Replace("'", " ");// 替换单引号
            }
            return retVal.ToString();

        }
        /// <summary>
        /// 转换成 HTML code
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>string</returns>
        public static string Encode(string str)
        {
            str = str.Replace("&", "&amp;");
            str = str.Replace("'", "''");
            str = str.Replace("\"", "&quot;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("<", "&lt;");
            str = str.Replace(">", "&gt;");
            str = str.Replace("\n", "<br>");
            return str;
        }
        /// <summary>
        ///解析html成 普通文本
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>string</returns>
        public static string Decode(string str)
        {
            str = str.Replace("<br>", "\n");
            str = str.Replace("&gt;", ">");
            str = str.Replace("&lt;", "<");
            str = str.Replace("&nbsp;", " ");
            str = str.Replace("&quot;", "\"");
            return str;
        }
        /// <summary>
        /// SqlTextClear
        /// </summary>
        /// <param name="sqlText">string</param>
        /// <returns>string</returns>
        public static string SqlTextClear(string sqlText)
        {
            if (sqlText == null)
            {
                return null;
            }
            if (sqlText == "")
            {
                return "";
            }
            sqlText = sqlText.Replace(",", "");//去除,
            sqlText = sqlText.Replace("<", "");//去除<
            sqlText = sqlText.Replace(">", "");//去除>
            sqlText = sqlText.Replace("--", "");//去除--
            sqlText = sqlText.Replace("'", "");//去除'
            sqlText = sqlText.Replace("\"", "");//去除"
            sqlText = sqlText.Replace("=", "");//去除=
            sqlText = sqlText.Replace("%", "");//去除%
            sqlText = sqlText.Replace(" ", "");//去除空格
            return sqlText;
        }
        #endregion               

        #region 检查输入的参数是不是某些定义好的特殊字符：这个方法目前用于密码输入的安全检查
        /// <summary>
        /// 检查输入的参数是不是某些定义好的特殊字符：这个方法目前用于密码输入的安全检查
        /// </summary>
        /// <param name="strInput">输入字符串</param>
        /// <param name="list">定义好的特殊字符串数组</param>
        /// <returns>返回结果</returns>
        public static bool isContainSpecChar(string strInput, string[] list)
        {            
            bool result = new bool();
            for (int i = 0; i < list.Length; i++)
            {
                if (strInput == list[i])
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        #endregion
    }
}
