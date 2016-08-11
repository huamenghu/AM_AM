using System;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace MFXinY.Common
{
    /// <summary>
    /// ҳ������У���࣬��Ҫ�Ǹ���������ʽƥ����
    /// ����ƽ���� С�� ����
    /// 2004.8
    /// </summary>
    public class PageValidate
    {
        private static Regex RegPhone = new Regex("^[0-9]+[-]?[0-9]+[-]?[0-9]$");
        private static Regex RegNumber = new Regex("^[0-9]+$");
        private static Regex RegNumberSign = new Regex("^[+-]?[0-9]+$");
        private static Regex RegDecimal = new Regex("^[0-9]+[.]?[0-9]+$");
        private static Regex RegDecimalSign = new Regex("^[+-]?[0-9]+[.]?[0-9]+$"); //�ȼ���^[+-]?\d+[.]?\d+$
        private static Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");//w Ӣ����ĸ�����ֵ��ַ������� [a-zA-Z0-9] �﷨һ�� 
        private static Regex RegCHZN = new Regex("[\u4e00-\u9fa5]");
        
        /// <summary>
        /// ʹ��������ʽ �õ�ƥ��Ľ��
        /// </summary>
        /// <param name="regexString">������ʽ</param>        
        /// <param name="content">ƥ��ķ�Χ</param>
        /// <returns>����ƥ�䵽���ַ���</returns>
        public static string GetRegValue(string regexString, string content)
        {
            //�ȼ�ƥ�䣬ƥ�䲻���ٸ���ƥ��
            Regex reg = new Regex(regexString, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            Match match = reg.Match(content);
            if (match.Success)
            {
                return match.Value;
            }
            return string.Empty;
        }
        /// <summary>
        /// ʹ��������ʽ �õ�ƥ��Ľ��
        /// </summary>
        /// <param name="startFlag">ƥ�����ʼ�ַ���</param>
        /// <param name="endFlag">ƥ���β���ַ���</param>
        /// <param name="content">ƥ��ķ�Χ</param>
        /// <returns>����ƥ��Ľ��</returns>
        public static string GetRegValue(string startFlag, string endFlag, string content)
        {
            //�ȼ�ƥ�䣬ƥ�䲻���ٸ���ƥ��
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
        /// ����ĳһ�ض���������ʽ��ƥ���ַ���
        /// </summary>
        /// <param name="regex">������ʽ</param>
        /// <param name="inputString">�����ַ���</param>
        /// <returns>�����Ƿ�ƥ��ɹ�</returns>
        public static bool IsMatch(string regex,string inputString)
        {
            Regex reg = new Regex(regex);
            return reg.Match(inputString).Success;
        }
        #region �����ַ������
        /// <summary>
        /// ����ַ����ǲ��ǵ绰��ʽ
        /// </summary>
        /// <param name="inputData">Ҫ�����ַ���</param>
        /// <returns>�����ַ����ǲ��ǵ绰��ʽ</returns>
        public static bool IsPhone(string inputData)
        {
            Match m = RegPhone.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// ���Request��ѯ�ַ����ļ�ֵ���Ƿ������֣���󳤶�����
        /// </summary>
        /// <param name="req">Request</param>
        /// <param name="inputKey">Request�ļ�ֵ</param>
        /// <param name="maxLen">��󳤶�</param>
        /// <returns>����Request��ѯ�ַ���</returns>
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
        /// �Ƿ������ַ���
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns>�����Ƿ������ַ������</returns>
        public static bool IsNumber(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegNumber.Match(inputData);
            return m.Success;
        }

        /// <summary>
        /// �Ƿ������ַ��� �ɴ�������
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns>���ؽ��</returns>
        public static bool IsNumberSign(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegNumberSign.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// �Ƿ��Ǹ�����
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns>���ؽ��</returns>
        public static bool IsDecimal(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegDecimal.Match(inputData);
            return m.Success;
        }
        /// <summary>
        /// �Ƿ��Ǹ����� �ɴ�������
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns>���ؽ��</returns>
        public static bool IsDecimalSign(string inputData)
        {
            if (inputData == null)
                return false;
            Match m = RegDecimalSign.Match(inputData);
            return m.Success;
        }

        #endregion

        #region ���ļ��

        /// <summary>
        /// ����Ƿ��������ַ�
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns>���ؽ��</returns>
        public static bool IsHasCHZN(string inputData)
        {
            Match m = RegCHZN.Match(inputData);
            return m.Success;
        }

        #endregion

        #region �ʼ���ַ
        /// <summary>
        /// �Ƿ��Ǹ����� �ɴ�������
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns>���ؽ��</returns>
        public static bool IsEmail(string inputData)
        {
            Match m = RegEmail.Match(inputData);
            return m.Success;
        }

        #endregion

        #region ���ڸ�ʽ�ж�
        /// <summary>
        /// ���ڸ�ʽ�ַ����ж�
        /// </summary>
        /// <param name="str">Ҫ�����ַ���</param>
        /// <returns>���ؽ��</returns>
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

        #region ����

        /// <summary>
        /// ����ַ�����󳤶ȣ�����ָ�����ȵĴ�
        /// </summary>
        /// <param name="sqlInput">�����ַ���</param>
        /// <param name="maxLength">��󳤶�</param>
        /// <returns>����ָ�����ȵĴ�</returns>			
        public static string SqlText(string sqlInput, int maxLength)
        {
            if (sqlInput != null && sqlInput != string.Empty)
            {
                sqlInput = sqlInput.Trim();
                if (sqlInput.Length > maxLength)//����󳤶Ƚ�ȡ�ַ���
                    sqlInput = sqlInput.Substring(0, maxLength);
            }
            return sqlInput;
        }
        /// <summary>
        /// �ַ�������
        /// </summary>
        /// <param name="inputData">Ҫ������ַ���</param>
        /// <returns>���ر������ַ���</returns>
        public static string HtmlEncode(string inputData)
        {
            return HttpUtility.HtmlEncode(inputData);
        }
        /// <summary>
        /// ����Label��ʾEncode���ַ���
        /// </summary>
        /// <param name="lbl">Label�ؼ�</param>
        /// <param name="txtInput">Ҫ��ʾ���ַ���</param>
        public static void SetLabel(Label lbl, string txtInput)
        {
            lbl.Text = HtmlEncode(txtInput);
        }
        /// <summary>
        /// ����Label��ʾEncode�Ķ���
        /// </summary>
        /// <param name="lbl">Label�ؼ�</param>
        /// <param name="inputObj">Ҫ��ʾ�Ķ���</param>
        public static void SetLabel(Label lbl, object inputObj)
        {
            SetLabel(lbl, inputObj.ToString());
        }
       /// <summary>
       /// �ַ�������
       /// </summary>
       /// <param name="inputString">Ҫ�������ַ���</param>
       /// <param name="maxLength">��󳤶�</param>
       /// <returns>�����������ַ���</returns>
        public static string InputText(string inputString, int maxLength)
        {
            StringBuilder retVal = new StringBuilder();

            // ����Ƿ�Ϊ��
            if ((inputString != null) && (inputString != String.Empty))
            {
                inputString = inputString.Trim();

                //��鳤��
                if (inputString.Length > maxLength)
                    inputString = inputString.Substring(0, maxLength);

                //�滻Σ���ַ�
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
                retVal.Replace("'", " ");// �滻������
            }
            return retVal.ToString();

        }
        /// <summary>
        /// ת���� HTML code
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
        ///����html�� ��ͨ�ı�
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
            sqlText = sqlText.Replace(",", "");//ȥ��,
            sqlText = sqlText.Replace("<", "");//ȥ��<
            sqlText = sqlText.Replace(">", "");//ȥ��>
            sqlText = sqlText.Replace("--", "");//ȥ��--
            sqlText = sqlText.Replace("'", "");//ȥ��'
            sqlText = sqlText.Replace("\"", "");//ȥ��"
            sqlText = sqlText.Replace("=", "");//ȥ��=
            sqlText = sqlText.Replace("%", "");//ȥ��%
            sqlText = sqlText.Replace(" ", "");//ȥ���ո�
            return sqlText;
        }
        #endregion               

        #region �������Ĳ����ǲ���ĳЩ����õ������ַ����������Ŀǰ������������İ�ȫ���
        /// <summary>
        /// �������Ĳ����ǲ���ĳЩ����õ������ַ����������Ŀǰ������������İ�ȫ���
        /// </summary>
        /// <param name="strInput">�����ַ���</param>
        /// <param name="list">����õ������ַ�������</param>
        /// <returns>���ؽ��</returns>
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
