using Dao;
using AM.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MFXinY.Common;
using System.Web.Mvc;

namespace AM.Controllers
{
    public class userController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData()
        {
            int total;  //记录总条数                                                                     
            Dictionary<string, object> result = new Dictionary<string, object>();//键值对字典            
            try
            {
                int pageSize = int.Parse(Request["rows"].ToString());  //分页大小                      
                int pageIndex = int.Parse(Request["page"].ToString()); //当前页码                      
                if (pageIndex < 1) pageIndex = 1;
                string username = Request["username"] == null ? string.Empty : Request["username"].ToString();
                string usernickname = Request["usernickname"] == null ? string.Empty : Request["usernickname"].ToString();
                string userphone = Request["userphone"] == null ? string.Empty : Request["userphone"].ToString();

                var data = from a in DB.Instant.UserManager.Where(a => (string.IsNullOrEmpty(username) ? true : a.username.IndexOf(username) > -1)
                     && (string.IsNullOrEmpty(usernickname) ? true : a.usernickname.IndexOf(usernickname) > -1)
                     && (string.IsNullOrEmpty(userphone) ? true : a.userphone.IndexOf(userphone) > -1)
                     )
                           join b in DB.Instant.GradeManager.Where(t => true) on a.gradeid equals b.gradeid into c
                           from bb in c.DefaultIfEmpty()
                           select new
                 {
                     a.userid,
                     a.username,
                     a.usernickname,
                     a.userphone,
                     a.usersex,
                     a.userpoints,
                     bb.gradename
                 };
                total = data.Count();
                var list = data.OrderBy(a => a.userid).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().Select(a => new
                {
                    a.userid,
                    a.username,
                    a.usernickname,
                    a.userphone,
                    usersex = a.usersex == "m" ? "男" : (a.usersex == "f" ? "女" : "保密"),
                    a.userpoints,
                    a.gradename
                });
                result.Add("rows", list);
                result.Add("total", total);
                return Json(result);
            }
            catch { return Json(""); }
        }
        public JsonResult FillForm(String id)
        {
            var data = DB.Instant.UserManager.Where(a => a.userid == id).ToList().Select(a => new
            {
                a.userid,
                //a.userlogo,
                a.username,
                a.usernickname,
                a.userphone,
                a.usersex,
                a.userpoints,
            }).FirstOrDefault();
            return Json(data);
        }
        #region 更新 add update delete
        [HttpPost]
        public JsonResult Add(FormCollection form, HttpPostedFileBase userlogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (userlogo != null && userlogo.ContentLength > 1)
            {
                var root = "/fileupload/user/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(userlogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            var t = new user();
            MVCTools.SetValueFormToModel(t, form);
            t.ishuanxin = false;
            if (!string.IsNullOrEmpty(t.password))
            {
                t.password = SecurityTools.MD5Encrypt(t.password);
            }
            else
            {
                t.password = SecurityTools.MD5Encrypt(DataStore.DefaultPassword);
            }
            //检查用户名与编号是否有重复
            IAOPResult r = null;
            var check1 = DB.Instant.UserManager.Count(a => a.username == t.username);
            if (check1 > 0)
            {
                r = new AOPResult(-1, "用户名重复，请检查");
            }
            else
            {
                if (rx != null)
                {
                    if (rx.IsSuccess)
                    {
                        t.userlogo = rx.ResultDescription;
                    }
                    else
                    {
                        return Json(rx, "text/html");
                    }
                }
                t.userid = Guid.NewGuid().ToString();
                r = DB.Instant.UserManager.Add(t);
            }
            return Json(r, "text/html");
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Update(string id, FormCollection form, HttpPostedFileBase userlogo)
        {
            IAOPResult rx = null;
            //上传文件
            if (userlogo != null && userlogo.ContentLength > 1)
            {
                var root = "/fileupload/user/Original/";
                var fileName = Guid.NewGuid().ToString().Replace("-", "");
                rx = MVCTools.UploadFile(userlogo, root, 2, fileName, true, DataStore.ImgageTtpe);
            }

            IAOPResult r = null;
            var t = DB.Instant.UserManager.Find(id);
            var pp = t.password;
            MVCTools.SetValueFormToModel(t, form);
            if (!string.IsNullOrEmpty(form.Get("password")))
            {
                if (string.IsNullOrEmpty(form.Get("password2")))
                {
                    r = new AOPResult(-1, "请输入确认密码！");
                }
                else
                {
                    t.password = SecurityTools.MD5Encrypt(form.Get("password"));
                }
            }
            else
            {
                t.password = pp;  //设回原密码
            }
            if (r == null)
            {
                if (rx != null)
                {
                    if (rx.IsSuccess)
                    {
                        t.userlogo = rx.ResultDescription;
                    }
                    else
                    {
                        return Json(rx, "text/html");
                    }
                }
                r = DB.Instant.UserManager.Update(t);
            }
            return Json(r, "text/html");
        }
        public JsonResult Delete(string id)
        {
            List<user> us = new List<user>();
            var ids = id.Split(',');
            foreach (var item in ids)
            {
                us.Add(new user() { userid = item });
            }
            var r = DB.Instant.UserManager.Delete(us);
            return Json(r, "text/html");
        }

        #endregion
        public JsonResult ViewResult(string id)
        {
            var result = DB.Instant.UserManager.Where(a => a.userid == id).FirstOrDefault();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            if (result != null)
            {

                list.Add(new KeyValuePair<string, string>("用户名", result.username));
                list.Add(new KeyValuePair<string, string>("用户昵称", result.usernickname));
                list.Add(new KeyValuePair<string, string>("联系方式", result.userphone));
                list.Add(new KeyValuePair<string, string>("性别", result.usersex));
                list.Add(new KeyValuePair<string, string>("用户积分", result.userpoints.ToString()));
                list.Add(new KeyValuePair<string, string>("用户Logo", string.Format("<img src='{0}' class='img'/>", result.userlogo)));
                //list.Add(new KeyValuePair<string, string>("密码", result.password));
            }
            else
            {

            }
            var r = MVCTools.BuildViewString(list);
            return Json(r);
        }

        public JsonResult GetList()
        {
            var list = DB.Instant.UserManager.Where(a => true).Select(a => new
            {
                a.userid,
                a.username
            }).ToList();
            return Json(list);
        }
    }
}
