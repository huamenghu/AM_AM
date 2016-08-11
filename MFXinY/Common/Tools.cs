using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web;
using System.Net;

namespace MFXinY.Common
{
    /// <summary>
    /// 常用工具类，主要有：复制对象，上传文件、下载文件、删除文件、得到最终的异常信息等
    /// </summary>
    public class Tools
    {
        #region 复制对象，主要是对于数据库表某条记录 每个字段分别复制其内容（可以排除不复制的字段）

        /// <summary> 
        /// 把源对象的值复制到目标对象 
        /// </summary> 
        /// <param name="SourceObject">源对象</param> 
        /// <param name="TargetObject">目标对象</param> 
        /// <returns>返回AOPResult</returns> 
        public static IAOPResult CopyToObject(object SourceObject, object TargetObject, bool CheckEqualType = true)
        {
            try
            {
                Type TS = SourceObject.GetType();
                Type TT = TargetObject.GetType();
                if (CheckEqualType == true)
                {
                    if (!TS.Equals(TT))
                    {
                        return new AOPResult(-100, "源对象与目标对象的类型不一致");
                    }
                }
                FieldInfo[] fieldInfos = TS.GetFields(BindingFlags.Instance | BindingFlags.Public);
                PropertyInfo[] propertyInfos = TS.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (var item in fieldInfos)
                {
                    item.SetValue(TargetObject, item.GetValue(SourceObject));
                }
                foreach (var item in propertyInfos)
                {
                    if (item.CanWrite == true && (item.PropertyType.IsValueType == true || item.PropertyType == typeof(String)))
                    {
                        item.SetValue(TargetObject, item.GetValue(SourceObject, null), null);
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception Exc)
            {
                return new AOPResult(-100, Exc.Message);
            }
        }
        /// <summary> 
        /// 把源对象的值复制到目标对象,排除不需要复制的字段 
        /// </summary> 
        /// <param name="SourceObject">源对象</param> 
        /// <param name="TargetObject">目标对象</param> 
        /// <param name="field">不需要复制的字段</param> 
        /// <returns>返回AOPResult</returns> 
        public static IAOPResult CopyToObject(object SourceObject, object TargetObject, string[] field, bool CheckEqualType = true)
        {
            try
            {
                Type TS = SourceObject.GetType();
                Type TT = TargetObject.GetType();
                if (CheckEqualType == true)
                {
                    if (!TS.Equals(TT))
                    {
                        return new AOPResult(-100, "源对象与目标对象的类型不一致");
                    }
                }
                FieldInfo[] fieldInfos = TS.GetFields(BindingFlags.Instance | BindingFlags.Public);
                PropertyInfo[] propertyInfos = TS.GetProperties(BindingFlags.Instance | BindingFlags.Public);

                StringBuilder sb = new StringBuilder();
                sb.Append(",");
                foreach (var item in field)
                {
                    sb.Append(item + ",");
                }
                foreach (var item in fieldInfos)
                {
                    if (!sb.ToString().Contains("," + item.Name + ","))
                    {

                        item.SetValue(TargetObject, item.GetValue(SourceObject));

                    }

                }
                foreach (var item in propertyInfos)
                {
                    if (!sb.ToString().Contains("," + item.Name + ","))
                    {
                        if (item.CanWrite == true && (item.PropertyType.IsValueType == true || item.PropertyType == typeof(String)))
                        {
                            item.SetValue(TargetObject, item.GetValue(SourceObject, null), null);
                        }
                    }
                }
                return new AOPResult(0);
            }
            catch (Exception Exc)
            {
                return new AOPResult(-100, Exc.Message);
            }
        }
        #endregion
        #region  异常处理
        /// <summary>
        /// 得到最终的异常信息
        /// </summary>
        /// <param name="e">异常对象</param>
        /// <returns>返回最终的异常信息</returns>
        public static string GetFinallExceptionMessage(Exception e)
        {
            if (e.InnerException != null)
            {
                return GetFinallExceptionMessage(e.InnerException);
            }
            else
            {
                return e.Message;
            }
        }
        #endregion
        #region 上传文件,下载文件,删除文件等
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fileFileAccessory">上传控件</param>
        /// <param name="uploadPath">上传文件夹到这个目录下(比如：~/CoalQualityTest/Upload/，注意，路径请以根目录开头(~/))</param>
        /// <param name="maxLen">文件限制上传大小，单位M</param>
        /// <param name="filename">新文件名称,若为空，则默认为原文件名称</param>
        /// <param name="isReplace">若有同名的是否覆盖</param>
        /// <param name="filetype">文件类型数组</param>
        /// <returns>返回上传文件结果，描述信息为上传后文件的相对路径</returns>
        public static IAOPResult UploadFile(System.Web.HttpPostedFile fileFileAccessory, string uploadPath, int maxLen, string filename, bool isReplace, string[] filetype)
        {
            //统一格式
            if (uploadPath.Substring(uploadPath.Length - 1) != "/" && uploadPath.Substring(uploadPath.Length - 1) != "\\")
            {
                uploadPath += "/";
            }

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
                string rootpath = HttpContext.Current.Server.MapPath(uploadPath);
                if (!System.IO.Directory.Exists(rootpath))
                {
                    System.IO.Directory.CreateDirectory(rootpath);
                }
                string dbPath = uploadPath + filename + "." + fileType;//数据库中存放的路径
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
        /// 下载文件 保存文件到服务器，命名规则是用guid命名，只保证不重名
        /// </summary>
        /// <param name="fileurl">远程文件url ag. http ://www.baidu.com/1.jpg </param>       
        /// <param name="path">保存文件到服务器 的 相对路径 如：  ~/upload/ 请注意，格式为：~/upload/,要以根目录写起（~/）</param>
        /// <returns>返回下载文件结果,描述信息为保存到服务器上的相对路径</returns>
        public static IAOPResult DownLoadFile(string fileurl, string path)
        {
            string extName = fileurl.Substring(fileurl.LastIndexOf("."));
            string guid = Guid.NewGuid().ToString().Replace("-", string.Empty);
            string filename = string.Format("{0}{1}", guid, extName);
            return DownLoadFile(fileurl, filename, path);
        }
        /// <summary>
        /// 下载文件 保存文件到服务器
        /// </summary>
        /// <param name="fileurl">远程文件url ag. http: //www.baidu.com/1.jpg </param>
        /// <param name="fileName">保存服务器时的文件名称，包括扩展名 比如   2011图片.jpg</param>
        /// <param name="path">保存到服务器的相对路径，请注意，格式为：~/upload/,要以根目录写起（~/）</param>
        /// <returns>返回下载文件结果，描述为保存文件的路径Path</returns>
        public static IAOPResult DownLoadFile(string fileurl, string fileName, string path)
        {
            try
            {
                using (var client = new WebClient())
                {
                    string path1 = HttpContext.Current.Server.MapPath(path);
                    client.DownloadFile(fileurl, path1);   //从远程下载文件到服务器
                    return new AOPResult(0, string.Format("{0}{1}", path, fileName));
                }
            }
            catch (Exception e)
            {
                return new AOPResult(-100, e.Message);
            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="url">要删除文件的相对路径 比如：~/upload/</param>
        public static void DeleteFile(string url)
        {
            try
            {
                if (!string.IsNullOrEmpty(url))
                {
                    var path = HttpContext.Current.Server.MapPath(url);//文件在服务器上的路径
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
            }
            catch { }
        }
        #endregion
    }
}
