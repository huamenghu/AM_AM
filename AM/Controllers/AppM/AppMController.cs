
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
    public class AppMController : Controller
    { 
        public void addbasket_train(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_trainBLL bll = new basket_trainBLL();
            basket_train model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            bll.AddAndCheck(model);
        }
        public void addbasket_check(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_checkBLL bll = new basket_checkBLL();
            basket_check model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addbasket_install(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_installBLL bll = new basket_installBLL();
            basket_install model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addbasket_keep(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_keepBLL bll = new basket_keepBLL();
            basket_keep model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addbasket_made(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_madeBLL bll = new basket_madeBLL();
            basket_made model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addbasket_rent(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            basket_rentBLL bll = new basket_rentBLL();
            basket_rent model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addbuilding_hoist(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            building_hoistBLL bll = new building_hoistBLL();
            building_hoist model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addjsj_keep(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            jsj_keepBLL bll = new jsj_keepBLL();
            jsj_keep model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addqzj_check(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            qzj_checkBLL bll = new qzj_checkBLL();
            qzj_check model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addsafe_lock(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            safe_lockBLL bll = new safe_lockBLL();
            safe_lock model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addstaging_check(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            staging_checkBLL bll = new staging_checkBLL();
            staging_check model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addtower_crane(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            tower_craneBLL bll = new tower_craneBLL();
            tower_crane model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addwinow_check(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            winow_checkBLL bll = new winow_checkBLL();
            winow_check model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addwt_check(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            wt_checkBLL bll = new wt_checkBLL();
            wt_check model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
        public void addxsweit_check(string obj)
        {
            DataSet ds = ToolManager.JsonToDataSet(obj);
            xsweit_checkBLL bll = new xsweit_checkBLL();
            xsweit_check model = bll.DataRowToModel(ds.Tables[0].Rows[0]);
            model.CreateDate = DateTime.Now;
            model.Guid = Guid.NewGuid().ToString();
            bll.AddAndCheck(model);
        }
       

        public ActionResult basket_train()
        {
            return View();
        }
        public ActionResult basket_check()
        {
            return View();
        }
        public ActionResult basket_install()
        {
            return View();
        }
        public ActionResult basket_keep()
        {
            return View();
        }
        public ActionResult basket_made()
        {
            return View();
        }
        public ActionResult basket_rent()
        {
            return View();
        }
        public ActionResult building_hoist()
        {
            return View();
        }
        public ActionResult jsj_keep()
        {
            return View();
        }
        public ActionResult qzj_check()
        {
            return View();
        }
        public ActionResult safe_lock()
        {
            return View();
        }
        public ActionResult staging_check()
        {
            return View();
        }
        public ActionResult tower_crane()
        {
            return View();
        }
        public ActionResult winow_check()
        {
            return View();
        }
        public ActionResult wt_check()
        {
            return View();
        }
        public ActionResult xsweit_check()
        {
            return View();
        }
    }
}