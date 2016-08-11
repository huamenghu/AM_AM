using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace AM.BLL
{
    /// <summary>
    /// 快递查询
    /// </summary>
    public class Express
    {
        public string key
        {
            get
            {
                return DB.Instant.ConfigManager.GetValue("ExpressKey");
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="ordernum">订单单号</param>
        /// <param name="name">快递公司代码</param>
        /// <returns></returns>
        public KuaiDi100 Search(string ordernum, string name)
        {
            var url = string.Format("http://api.kuaidi100.com/api?id={0}&com={1}&nu={2}&show=0&muti=1&order=desc", key, name, ordernum);
            //发送请求，返回结果

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding encode = Encoding.UTF8;
            StreamReader reader = new StreamReader(stream, encode);
            string detail = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();
            var ret = serializer.Deserialize<KuaiDi100>(detail);

            return ret;
        }

        public KuaiDi100 SearchM(string ordernum, string name)
        {
            var url = string.Format("http://m.kuaidi100.com/query?type={0}&postid={1}&id=1&valicode=&temp={2}",  name, ordernum,(new Random()).NextDouble());
            //发送请求，返回结果

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding encode = Encoding.UTF8;
            StreamReader reader = new StreamReader(stream, encode);
            string detail = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();
            var ret = serializer.Deserialize<KuaiDi100>(detail);

            return ret;
        }

        public List<ExExpress> SearchExpress(string ordernum, string name)
        {
            List<ExExpress> list = new List<ExExpress>();
            var kd = SearchM(ordernum, name);
            if (kd.data != null && kd.data.Count > 0)
            {
                list = kd.data.Select(a => new ExExpress { expressdate = a.time, expresscontent = a.context }).ToList();
            }
            return list;
        }
    }
}