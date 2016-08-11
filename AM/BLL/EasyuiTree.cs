using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AM.BLL
{
    public class EasyuiTree
    {
        private string _id            ;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _text;

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        private List<EasyuiTree> _children;

        public List<EasyuiTree> children
        {
            get { return _children; }
            set { _children = value; }
        }
    }
}