using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web.UI;
using System.Web;
using System.Security.Cryptography;
using System.IO;

namespace MFXinY.Common
{
    /// <summary>
    /// 安全相关的工具，比如：加密、解密 html编码对象、html解码对象等
    /// </summary>
    public class SecurityTools
    {
        #region 加密、解密
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="password">要加密的字符串</param>
        /// <returns>返回加密后的结果</returns>
        public static string MD5Encrypt(string password)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
        }
        /// <summary>   
        /// 利用DES加密算法加密字符串（可解密）   
        /// </summary>   
        /// <param name="pToEncrypt">被加密的字符串</param>   
        /// <param name="sKey">密钥（只支持8个字节的密钥）</param>   
        /// <returns>加密后的字符串</returns>   
        public static string Encrypt(string pToEncrypt, string sKey)
        {
            //访问数据加密标准(DES)算法的加密服务提供程序 (CSP) 版本的包装对象   
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);　//建立加密对象的密钥和偏移量   
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);　 //原文使用ASCIIEncoding.ASCII方法的GetBytes方法   


            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);//把字符串放到byte数组中   

            MemoryStream ms = new MemoryStream();//创建其支持存储区为内存的流　   
            //定义将数据流链接到加密转换的流   
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            //上面已经完成了把加密后的结果放到内存中去   
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }
        /// <summary>   
        /// 利用DES加密算法解密字符串
        /// </summary>   
        /// <param name="pToDecrypt">被解密的字符串</param>   
        /// <param name="sKey">密钥（只支持8个字节的密钥，同前面的加密密钥相同）</param>   
        /// <returns>返回被解密的字符串</returns>   
        public static string Decrypt(string pToDecrypt, string sKey)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
                for (int x = 0; x < pToDecrypt.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }

                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);　//建立加密对象的密钥和偏移量，此值重要，不能修改   
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);

                cs.FlushFinalBlock();

                //建立StringBuild对象，createDecrypt使用的是流对象，必须把解密后的文本变成流对象   
                StringBuilder ret = new StringBuilder();

                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch (Exception)
            {
                return "error";
            }
        }  
        #endregion
        #region 对象进行html编码，防止脚本注入
        /// <summary>
        /// html编码对象（排除不编码的字段）
        /// </summary>
        /// <param name="objSource">源对象</param>
        /// <param name="obj">编码后的对象</param>
        /// <param name="field">排除不编码的字段</param>
        /// <returns>编码对象结果是否成功</returns>
        public static IAOPResult HtmlEncode(object objSource, object obj, string[] field)
        {
            try
            {
                Type type = objSource.GetType();
                Type type2 = obj.GetType();
                if (!type.Equals(type2))
                {
                    return new AOPResult(-100, "源对象与目标对象的类型不一致");
                }
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (!field.Contains(item.Name))
                    {
                        if (item.CanWrite == true && item.PropertyType == typeof(String))
                        {
                            item.SetValue(obj, HttpUtility.HtmlEncode(item.GetValue(objSource, null).ToString()), null);
                        }
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// 对一个对象进行html编码
        /// </summary>
        /// <param name="objSource">源对象</param>
        /// <returns>返回编码结果</returns>
        public static IAOPResult HtmlEncode(object objSource)
        {
            try
            {
                Type type = objSource.GetType();
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (item.CanWrite == true && item.PropertyType == typeof(String))
                    {
                        var value = item.GetValue(objSource, null);
                        item.SetValue(objSource, HttpUtility.HtmlEncode(value == null ? string.Empty : value.ToString()), null);
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// 对一个对象进行html编码 （排除不编码的字段）
        /// </summary>
        /// <param name="objSource">要编码的对象</param>
        /// <param name="field">排除的字段数组</param>
        /// <returns>返回编码结果</returns>
        public static IAOPResult HtmlEncode(object objSource, string[] field)
        {
            try
            {
                Type type = objSource.GetType();
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (!field.Contains(item.Name))
                    {
                        if (item.CanWrite == true && item.PropertyType == typeof(String))
                        {
                            var value = item.GetValue(objSource, null);
                            item.SetValue(objSource, HttpUtility.HtmlEncode(value == null ? string.Empty : value.ToString()), null);
                        }
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// 对一个对象进行html编码 （排除不编码的某字段）
        /// </summary>
        /// <param name="objSource">源对象</param>
        /// <param name="field">排除的字段</param>
        /// <returns>返回编码结果</returns>
        public static IAOPResult HtmlEncode(object objSource, string field)
        {
            return HtmlEncode(objSource, new string[] { field });
        }
        /// <summary>
        /// html解码对象（排除不解码的字段）
        /// </summary>
        /// <param name="objSource">源对象</param>
        /// <param name="obj">解码后的对象</param>
        /// <param name="field">排除的字段</param>
        /// <returns>解码对象结果是否成功</returns>
        public static IAOPResult HtmlDecode(object objSource, object obj, string[] field)
        {
            try
            {
                Type type = objSource.GetType();
                Type type2 = obj.GetType();
                if (!type.Equals(type2))
                {
                    return new AOPResult(-100, "源对象与目标对象的类型不一致");
                }
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (!field.Contains(item.Name))
                    {
                        if (item.CanWrite == true && item.PropertyType == typeof(String))
                        {
                            var value = item.GetValue(objSource, null);
                            item.SetValue(objSource, HttpUtility.HtmlEncode(value == null ? string.Empty : value.ToString()), null);
                        }
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// html解码一个对象
        /// </summary>
        /// <param name="objSource">要解码的对象</param>
        /// <returns>解码结果</returns>
        public static IAOPResult HtmlDecode(object objSource)
        {
            try
            {
                Type type = objSource.GetType();
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (item.CanWrite == true && item.PropertyType == typeof(String))
                    {
                        var value = item.GetValue(objSource, null);
                        item.SetValue(objSource, HttpUtility.HtmlDecode(value == null ? string.Empty : value.ToString()), null);
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// html解码一个对象（排除不解码的字段）
        /// </summary>
        /// <param name="objSource">源对象</param>
        /// <param name="field">排除的字段数组</param>
        /// <returns>返回解码结果</returns>
        public static IAOPResult HtmlDecode(object objSource, string[] field)
        {
            try
            {
                Type type = objSource.GetType();
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (!field.Contains(item.Name))
                    {
                        if (item.CanWrite == true && item.PropertyType == typeof(String))
                        {
                            var value = item.GetValue(objSource, null);
                            item.SetValue(objSource, HttpUtility.HtmlDecode(value == null ? string.Empty : value.ToString()), null);
                        }
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        ///  html解码一个对象（排除不解码的字段）
        /// </summary>
        /// <param name="objSource">源对象</param>
        /// <param name="field">排除的字段</param>
        /// <returns>返回解码结果</returns>
        public static IAOPResult HtmlDecode(object objSource, string field)
        {
            try
            {
                Type type = objSource.GetType();
                PropertyInfo[] propertyArray = type.GetProperties();

                //分别给每个字段赋值
                foreach (var item in propertyArray)
                {
                    if (field != item.Name && item.CanWrite == true && item.PropertyType == typeof(String))
                    {
                        var value = item.GetValue(objSource, null);
                        item.SetValue(objSource, HttpUtility.HtmlDecode(value == null ? string.Empty : value.ToString()), null);
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        #endregion
    }
}
