using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 无忧新闻 扩展类
    /// </summary>
    public class ExNews
    {
        public string newsid { get; set; }
        public string newstitle { get; set; }
        public string newsislogo { get; set; }
        public string newslogo { get; set; }
        public string newssummary { get; set; }

    }
    public class ExNewsList : Base
    {
        public int currentpage { get; set; }
        public int pagesize { get; set; }
        public int countpage { get; set; }
        public int countitems { get; set; }
        public List<ExNews> news { get; set; }
    }

    public class ExNewsDetail:Base
    {
        public string newsid { get; set; }
        public string newstitle { get; set; }
        public string newsislogo { get; set; }
        public string newslogo { get; set; }
        public string newssummary { get; set; }
        public string newsdate { get; set; }
        public string newscontent { get; set; }

    }
}
