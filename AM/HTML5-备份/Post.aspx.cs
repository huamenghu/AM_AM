using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AM.HTML5
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ss = "";
          string[] names = Request.Form.AllKeys;
          
          for (int i = 0; i < names.Length; i++)
          {
              string[] fuck = Request.Form.GetValues(names[i]);
              ss = ss + fuck[0] + ",";
          }
        }
    }
}