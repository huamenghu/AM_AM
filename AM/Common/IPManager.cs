﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace AM.Common
{
    public class IPManager
    {
        Manager manager;
        public IPManager(Manager manager)
        {
            this.manager = manager;
        }


        /// <summary>
        /// 获取真实的IP地址，包括内网与代理
        /// </summary>
        /// <returns></returns>
        public string GetIP()
        {
            string result = String.Empty;
            try
            {
                result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                //可能有代理   
                if (!string.IsNullOrWhiteSpace(result))
                {
                    //没有"." 肯定是非IP格式  
                    if (result.IndexOf(".") == -1)
                    {
                        result = null;
                    }
                    else
                    {
                        //有","，估计多个代理。取第一个不是内网的IP。  
                        if (result.IndexOf(",") != -1)
                        {
                            result = result.Replace(" ", string.Empty).Replace("\"", string.Empty);
                            string[] temparyip = result.Split(",;".ToCharArray());
                            if (temparyip != null && temparyip.Length > 0)
                            {
                                for (int i = 0; i < temparyip.Length; i++)
                                {
                                    //找到不是内网的地址  
                                    if (IsIPAddress(temparyip[i])
                                        && temparyip[i].Substring(0, 3) != "10."
                                        && temparyip[i].Substring(0, 7) != "192.168"
                                        && temparyip[i].Substring(0, 7) != "172.16.")
                                    {
                                        return temparyip[i];
                                    }
                                }
                            }
                        }
                        //代理即是IP格式  
                        else if (IsIPAddress(result))
                        {
                            return result;
                        }
                        //代理中的内容非IP  
                        else
                        {
                            result = null;
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(result))
                {
                    result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
                if (string.IsNullOrWhiteSpace(result))
                {
                    result = HttpContext.Current.Request.UserHostAddress;
                }
            }
            catch { }
            return result;
        }

        public bool IsIPAddress(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length < 7 || str.Length > 15)
                return false;
            string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}{1}";
            Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }


    }
}