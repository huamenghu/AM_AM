
using AM.Model;
using AM.BLL;
using AM.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using AM.Common;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class AppMController : BaseController
    {
        public void addbasket_train(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_trainBLL bll = new basket_trainBLL();
            basket_train model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            bll.AddAndCheck(model);
        }
        public ActionResult basket_train()
        {
            return View();
        }
    }
}