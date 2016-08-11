using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace AM.BLL
{
    public class MVCTools
    {
        /// <summary>
        /// 给对象赋值
        /// </summary>
        /// <param name="t"></param>
        /// <param name="form"></param>
        public static void SetValueFormToModel(object t, FormCollection form)
        {
            var ps = form.GetType().GetProperties();
            var pst = t.GetType().GetProperties();
            var x = ps[2].GetValue(form, null) as string[];
            foreach (var item in pst)
            {
                var type = item.PropertyType;
                if (type.IsValueType || type == typeof(string))
                {
                    var pt = x.FirstOrDefault(a => a == item.Name);
                    if (pt != null)
                    {
                        var val = form.Get(pt);
                        if (!string.IsNullOrEmpty(val))
                        {
                            item.SetValue(t, DBConvert.ChangeType(val, type), null);
                        }
                        else if (type == typeof(string))
                        {
                            if (string.IsNullOrEmpty(val))
                            {
                                item.SetValue(t, DBConvert.ChangeType(string.Empty, type), null);
                            }
                            else
                            {
                                item.SetValue(t, DBConvert.ChangeType(val, type), null);
                            }
                        }
                        else
                        {
                            item.SetValue(t, DBConvert.ChangeType(null, type), null);
                        }
                    }
                    else if (type == typeof(bool) || type == typeof(bool?))
                    {
                        item.SetValue(t, false, null);
                    }
                }
            }
        }
        /// <summary>
        /// 获取客户端真实IP
        /// </summary>
        /// <returns></returns>
        public static string GetRealIP()
        {
            string result = String.Empty;

            result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (result != null && result != String.Empty)
            {
                //可能有代理 
                if (result.IndexOf(".") == -1)     //没有“.”肯定是非IPv4格式 
                    result = null;
                else
                {
                    if (result.IndexOf(",") != -1)
                    {
                        //有“,”，估计多个代理。取第一个不是内网的IP。 
                        result = result.Replace(" ", "").Replace("'", "");
                        string[] temparyip = result.Split(",;".ToCharArray());
                        for (int i = 0; i < temparyip.Length; i++)
                        {
                            if (IsIPAddress(temparyip[i])
                                && temparyip[i].Substring(0, 3) != "10."
                                && temparyip[i].Substring(0, 7) != "192.168"
                                && temparyip[i].Substring(0, 7) != "172.16.")
                            {
                                return temparyip[i];     //找到不是内网的地址 
                            }
                        }
                    }
                    else if (IsIPAddress(result)) //代理即是IP格式 
                        return result;
                    else
                        result = null;     //代理中的内容 非IP，取IP 
                }
            }

            string IpAddress = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            if (null == result || result == String.Empty)
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            if (result == null || result == String.Empty)
                result = HttpContext.Current.Request.UserHostAddress;
            return result;
        }

        public static bool IsIPAddress(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length < 7 || str.Length > 15)
                return false;
            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";
            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }
        /// <summary>
        /// 属性,值  :中间以逗号分隔
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToProperty(string name, object obj, bool isString = false, string split = ":")
        {
            if (obj == null)
            {
                return "";
            }
            string value = obj.ToString();
            if (string.IsNullOrEmpty(value) || value == "px" || value == ";" || value == ",")
            {
                return "";
            }
            var endFlag = string.Empty;
            if (value.EndsWith(";") || value.EndsWith(","))
            {
                endFlag = value.Substring(value.Length - 1);
                value = value.Substring(0, value.Length - 1);
            }
            if (value.IndexOf("False") > -1 | value.IndexOf("True") > -1)
            {
                value = value.ToLower();
            }
            if (isString == true)
            {
                if (value.IndexOf("'") == -1)
                {
                    return string.Format("{0}{1}'{2}'{3}", name, split, value, endFlag);
                }
                else
                {
                    return string.Format("{0}{1}\"{2}\"{3}", name, split, value, endFlag);
                }
            }
            else
            {
                return string.Format("{0}{1}{2}{3}", name, split, value, endFlag);
            }
        }
        public static string ToProperty(string name, bool? value)
        {
            if (value == null || value == false)
            {
                return "";
            }
            return string.Format("{0}='true',", name);
        }
        /// <summary>
        /// 生成手机验证码
        /// </summary>
        /// <returns></returns>
        public static string CreateSMSCode()
        {
            var r = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < DataStore.SMSCodeLength; i++)
            {
                var x = r.Next(0, 10);
                sb.Append(x);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 生成订单单号
        /// </summary>
        /// <returns></returns>
        public static string GetOrderNumber()
        {
            string Number = DateTime.Now.ToString("yyMMddHHmmss");//yyyyMMddHHmmssms
            return Number + Next(1000, 3).ToString();
        }
        private static int Next(int numSeeds, int length)
        {
            // Create a byte array to hold the random value.  
            byte[] buffer = new byte[length];
            // Create a new instance of the RNGCryptoServiceProvider.  
            System.Security.Cryptography.RNGCryptoServiceProvider Gen = new System.Security.Cryptography.RNGCryptoServiceProvider();
            // Fill the array with a random value.  
            Gen.GetBytes(buffer);
            // Convert the byte to an uint value to make the modulus operation easier.  
            uint randomResult = 0x0;//这里用uint作为生成的随机数  
            for (int i = 0; i < length; i++)
            {
                randomResult |= ((uint)buffer[i] << ((length - 1 - i) * 8));
            }
            // Return the random number mod the number  
            // of sides. The possible values are zero-based  
            return (int)(randomResult % numSeeds);
        }

        /// <summary>  
        /// 创建GET方式的HTTP请求  
        /// </summary>  
        /// <param name="url">请求的URL</param>  
        /// <param name="timeout">请求的超时时间</param>  
        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>  
        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>  
        /// <returns></returns>  
        public static HttpWebResponse CreateGetHttpResponse(string url, int? timeout, string userAgent, CookieCollection cookies)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.UserAgent = DataStore.DefaultUserAgent;
            if (!string.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;
            }
            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            return request.GetResponse() as HttpWebResponse;
        }
        /// <summary>
        /// 过滤script脚本中特殊字符，比如'
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static string FilterScriptFormat(string f)
        {
            return f.Replace("'", "‘").Replace("\"", "’");
        }

        public static string BuildViewString(List<KeyValuePair<string, string>> list)
        {
            //组合table
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("   <table class=\"viewTable\">");
            var len = (list.Count + 1) / 2;
            for (int i = 0; i < len; i++)
            {
                sb.Append(" <tr class='viewtr'>");
                sb.AppendFormat("<td class=\"viewtd1\">{0}：</td>", list[2 * i].Key);
                sb.AppendFormat("<td class=\"viewtd2\">{0}</td>", list[2 * i].Value);
                if (list.Count > 2 * i + 1)
                {
                    sb.AppendFormat("<td class=\"viewtd3\">{0}：</td>", list[2 * i + 1].Key);
                    sb.AppendFormat("<td class=\"viewtd4\">{0}</td>", list[2 * i + 1].Value);
                }
                else
                {
                    sb.AppendFormat("<td class=\"viewtd3\">{0}</td>", string.Empty);
                    sb.AppendFormat("<td class=\"viewtd4\">{0}</td>", string.Empty);
                }
                sb.Append(" </tr>");
            }

            sb.AppendFormat("</table>");
            return sb.ToString();
        }
        public static string BuildViewString1(List<KeyValuePair<string, string>> list)
        {
            //组合table
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("   <table class=\"viewTable\">");
            var len = list.Count ;
            for (int i = 0; i < len; i++)
            {
                sb.Append(" <tr class='viewtr'>");
                sb.AppendFormat("<td class=\"viewtd1\">{0}：</td>", list[ i].Key);
                sb.AppendFormat("<td class=\"viewtd2\">{0}</td>", list[ i].Value);
                              
                sb.Append(" </tr>");
            }

            sb.AppendFormat("</table>");
            return sb.ToString();
        }

        public static string DateTimeConvertToString(object obj, string format = "yyyy-MM-dd")
        {
            if (obj == null)
                return string.Empty;
            try
            {
                return Convert.ToDateTime(obj).ToString(format);
            }
            catch { return obj.ToString(); }
        }

        public static string ConvertToString(object obj)
        {
            if (obj == null)
                return string.Empty;
            return obj.ToString();
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fileFileAccessory"></param>
        /// <param name="root">上传文件夹到这个目录下(比如：../CoalQualityTest/Upload/)</param>
        /// <param name="maxLen">文件限制上传大小，单位M</param>
        /// <param name="filename">新文件名称</param>
        /// <param name="isReplace">若有同名的是否覆盖</param>
        /// <param name="filetype">文件类型数组</param>
        /// <returns></returns>
        public static IAOPResult UploadFile(HttpPostedFileBase fileFileAccessory, string root, int maxLen, string filename, bool isReplace, string[] filetype)
        {
            #region 统一格式
            if (root.Substring(root.Length - 1) != "/" && root.Substring(root.Length - 1) != "\\")
            {
                root += "/";
            }
            #endregion
            //得到文件大小
            int fileLength = fileFileAccessory.ContentLength;
            double dblMB = fileLength / 1024 / 1024;
            dblMB = Math.Round(dblMB, 2);
            fileLength = Convert.ToInt32(dblMB);
            //得到文件名字
            string fileTitle = fileFileAccessory.FileName.ToString();
            //得到文件类型           
            string fileType = fileTitle.Substring(fileTitle.LastIndexOf(".") + 1); //string fileType = fileFileAccessory.ContentType;
            //文件保存在服务器上的位置
            string path = "";

            if (string.IsNullOrEmpty(filename.Trim()))
            {
                filename = fileTitle;
            }
            bool flag = false;
            StringBuilder sb = new StringBuilder();
            if (!(fileFileAccessory.ContentLength > 0))
            {
                return new AOPResult(-100, "错误：没有选择文件");
            }
            foreach (var item in filetype)
            {
                sb.Append(item.ToLower());
                sb.Append(",");
                if (item.ToLower() == fileType.ToLower())
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                return new AOPResult(-100, "此文件格式不允许上传,允许上传的格式为：" + sb.ToString().Substring(0, sb.ToString().Length - 1));
            }
            if (maxLen == 0 || fileLength < maxLen)
            {
                string rootpath = HttpContext.Current.Server.MapPath(root);
                if (!System.IO.Directory.Exists(rootpath))
                {
                    System.IO.Directory.CreateDirectory(rootpath);
                }
                string dbPath = root + filename + "." + fileType;//数据库中存放的路径
                path = HttpContext.Current.Server.MapPath(dbPath);//文件在服务器上的路径
                if (System.IO.File.Exists(path) && isReplace == false)
                {
                    return new AOPResult(-100, "错误：已经有同名文件");
                }
                else
                {
                    fileFileAccessory.SaveAs(path);
                    return new AOPResult(0, dbPath);
                }
            }
            else
            {
                return new AOPResult(-100, "错误：文件不得大于" + maxLen + "M.");
            }
        }

        /// <summary>
        /// 自动编号计算编号
        /// </summary>
        /// <param name="pcode"></param>
        /// <param name="curNo1"></param>
        /// <param name="curNo2"></param>
        /// <returns></returns>
        public static string GetAutoCode(string pcode, string curNo1, string curNo2)
        {
            var code = string.Empty;
            if (string.IsNullOrEmpty(pcode))
            {
                if (!string.IsNullOrEmpty(curNo1))
                {
                    code = string.Format("{0:d" + DataStore.EveryLayerLength + "}", Convert.ToInt32(curNo1) + 1);
                }
                else
                {
                    code = string.Format("{0:d" + DataStore.EveryLayerLength + "}", 1);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(curNo2))
                {
                    code = string.Format("{0}{1:d" + DataStore.EveryLayerLength + "}", pcode, Convert.ToInt32(curNo2.Substring(curNo2.Length - DataStore.EveryLayerLength)) + 1);
                }
                else
                {
                    code = string.Format("{0}{1:d" + DataStore.EveryLayerLength + "}", pcode, 1);
                }
            }
            return code;
        }
    }
}