using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class KuaiDi100
    {
        private string _message;

        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        private string _status;

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _state;

        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        private List<KuaiDi100Detail> _data;

        public List<KuaiDi100Detail> data
        {
            get { return _data; }
            set { _data = value; }
        }

    }

    public class KuaiDi100Detail
    {
        private string _time;

        public string time
        {
            get { return _time; }
            set { _time = value; }
        }

        private string _context;

        public string context
        {
            get { return _context; }
            set { _context = value; }
        }

    }

   
}
