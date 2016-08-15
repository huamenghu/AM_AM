using Dao;
using AM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using MFXinY.Common;
using System.Data;
using AM.Model;
using System.IO;
using AM.Common;
namespace AM.Controllers
{
    public class winow_checkController : BaseController
    {
        winow_checkBLL btBLL = new winow_checkBLL();
        string tableName = "winow_check";
        public JsonResult GetData()
        {
            int total;  //记录总条数
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码
                if (pageIndex < 1) pageIndex = 1;
                string trainname = Request["trainname"] == null ? string.Empty : Request["trainname"].ToString();
                //string traintel = Request["traintel"] == null ? string.Empty : Request["traintel"].ToString();
                //string trainID = Request["trainID"] == null ? string.Empty : Request["trainID"].ToString();
                //string traintypeid = Request["traintypeid"] == null ? string.Empty : Request["traintypeid"].ToString();
                //string state = Request["state"] == null ? string.Empty : Request["state"].ToString();
                var whereStr = string.Empty;
                if (!string.IsNullOrEmpty(trainname))
                {
                    whereStr = " GCMC like '%" + trainname + "%' ";
                }
                int count = 0;
                var list = btBLL.GetListByPage(whereStr, string.Empty, (pageIndex - 1) * pageSize, (pageIndex - 1) * pageSize + pageSize, out count);

                result.Add("rows", list);
                result.Add("total", count);
                return Json(result);
            }
            catch { return Json(""); }
        }


        public JsonResult FillForm(String id)
        {
            var data = btBLL.GetModel(id);
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form)
        {
            var t = new winow_check();
            MVCTools.SetValueFormToModel(t, form);
            t.Guid =Guid.NewGuid().ToString();
            t.userid = "admin";
            t.CreateDate = DateTime.Now;
            t.userid = UserName;

            AOPResult r = new AOPResult(0, (btBLL.Add(t).ToString()));
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form)
        {
            var t = btBLL.GetModel(id);
            MVCTools.SetValueFormToModel(t, form);
            AOPResult r = new AOPResult(0,(btBLL.Update(t).ToString()));
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            id = ToolManager.GetSqlStr(id);
            AOPResult r = new AOPResult(0, (btBLL.DeleteList(id).ToString()));
            return Json(r, "text/html");
        }

        #endregion

        public JsonResult ViewResult(string id)
        {
            var resultdt = btBLL.GetModelDataTable(id);
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            basket_trainBLL btraninBLL = new basket_trainBLL();
            Dictionary<string, string> dary = btraninBLL.GetColumnInfo(tableName);
            if (resultdt != null)
            {
                foreach (DataColumn item in resultdt.Columns)
                {
                    if (item.ColumnName != "Guid" && item.ColumnName != "userid" && item.ColumnName != "CreateDate")
                        list.Add(new KeyValuePair<string, string>(dary[item.ColumnName], resultdt.Rows[0][item.ColumnName].ToString()));
                }
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }
        public FileResult Export(string id)
        {
            id = ToolManager.GetSqlStr(id);
            DataTable dt = btBLL.GetDataByGuidList(id).Tables[0];
            //创建Excel文件的对象
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            //添加一个sheet
            NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
            //给sheet1添加第一行的头部标题
            NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
            //row1.RowStyle.FillBackgroundColor = "";
            basket_trainBLL btraninBLL = new basket_trainBLL();
            Dictionary<string, string> dary = btraninBLL.GetColumnInfo(tableName);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var columnName = dt.Columns[i].ColumnName;
                columnName = dary[columnName];
                row1.CreateCell(i).SetCellValue(columnName);
            }
            //将数据逐步写入sheet1各个行
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    rowtemp.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString().Trim());
                }
            }
            string strdate = DateTime.Now.ToString("yyyyMMddhhmmss");//获取当前时间
            // 写入到客户端 
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            ms.Seek(0, SeekOrigin.Begin);
            return File(ms, "application/vnd.ms-excel", strdate + "Excel.xls");
        }
        
    }
}