using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MFXinY.EF;
using System.Collections;
using Dao;
using MFXinY.Common;
using System.Data.Entity;

namespace AM.BLL
{
    public class UserManager : MFXinYEFBase<user>
    {
        DB db;
        public UserManager(DB db)
        {
            this.db = db;
        }
        /// <summary>
        /// 根据手机号码获取用户
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public user GeyUserByPhone(string phone)
        {
            user u = null;
            try
            {
                using (var db = new amEntities())
                {
                    u = db.user.FirstOrDefault(a => a.userphone == phone);
                }
            }
            catch (Exception Exc)
            {

            }
            return u;
        }

        public user GeUserByPhoneAndPwd(string phone, string password)
        {
            user u = null;
            try
            {
                using (var db = new amEntities())
                {
                    u = db.user.FirstOrDefault(a => a.userphone == phone && a.password == password);
                }
            }
            catch (Exception Exc)
            {

                throw;
            }
            return u;
        }

        /// <summary>
        /// 根据手机号码更新密码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IAOPResult UpdatePwdByPhone(string phone, string password)
        {
            AOPResult aop = null;
            try
            {
                using (var db = new amEntities())
                {
                    user u = db.user.FirstOrDefault(a => a.userphone == phone);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "phone不存在");
                    }
                    else
                    {
                        u.password = password;
                        db.SaveChanges();
                        aop = new AOPResult(0, "修改成功");
                    }
                }
            }
            catch (Exception Exc)
            {
                aop = new AOPResult(-100, Exc.Message);
            }
            return aop;
        }

        /// <summary>
        /// 根据用户编号更新用户头像
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="userlogo"></param>
        /// <returns></returns>
        public IAOPResult UpdateUserlogoByUserID(string userid, string userlogo)
        {
            AOPResult aop = null;
            //Guid ug = Guid.Empty;
            //Guid.TryParse(userid, out ug);
            try
            {
                using (var db = new amEntities())
                {
                    user u = db.user.FirstOrDefault(a => a.userid == userid);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "userid不存在");
                    }
                    else
                    {
                        u.userlogo = userlogo;
                        db.SaveChanges();
                        aop = new AOPResult(0, "修改成功");
                    }
                }
            }
            catch (Exception Exc)
            {
                aop = new AOPResult(-100, Exc.Message);
            }
            return aop;
        }

        /// <summary>
        /// 个人信息获取
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public user GeyUserByUserID(string userid)
        {
            user u = null;
            //Guid ug = Guid.Empty;
            //Guid.TryParse(userid, out ug);
            try
            {
                using (var db = new amEntities())
                {
                    u = db.user.FirstOrDefault(a => a.userid == userid);
                }
            }
            catch (Exception Exc)
            {

            }
            return u;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="usernickname"></param>
        /// <param name="username"></param>
        /// <param name="userphone"></param>
        /// <param name="usersex"></param>
        /// <returns></returns>
        public IAOPResult UpdateUserinfoByUserID(string userid, string usernickname, string username, string userphone, string usersex)
        {
            AOPResult aop = null;
            //Guid ug = Guid.Empty;
            //Guid.TryParse(userid, out ug);
            try
            {
                using (var db = new amEntities())
                {
                    user u = db.user.FirstOrDefault(a => a.userid == userid);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "userid不存在");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(usernickname))
                        {
                            u.usernickname = usernickname;
                        }
                        if (!string.IsNullOrEmpty(username))
                        {
                            u.username = username;
                        }
                        if (!string.IsNullOrEmpty(userphone))
                        {
                            u.userphone = userphone;
                        }
                        if (!string.IsNullOrEmpty(usersex))
                        {
                            u.usersex = usersex;
                        }
                        db.SaveChanges();
                        aop = new AOPResult(0, "修改成功");
                    }
                }
            }
            catch (Exception Exc)
            {
                aop = new AOPResult(-100, Exc.Message);
            }
            return aop;
        }

        public IAOPResult UpdatemyPwdByUserID(string userid, string oldpwd, string newpwd)
        {
            AOPResult aop = null;
            //Guid ug = Guid.Empty;
            //Guid.TryParse(userid, out ug);
            try
            {
                using (var db = new amEntities())
                {
                    user u = db.user.FirstOrDefault(a => a.userid == userid & a.password == oldpwd);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "原始密码错误");
                    }
                    else
                    {
                        u.password = newpwd;
                        db.SaveChanges();
                        aop = new AOPResult(0, "修改成功");
                    }
                }
            }
            catch (Exception Exc)
            {
                aop = new AOPResult(-100, Exc.Message);
            }
            return aop;
        }

        /// <summary>
        /// 设置某一收货地址为默认地址
        /// </summary>
        public IAOPResult UpdateSetMyDddrDefault(string userid, string addrid)
        {
            AOPResult aop = null;

            //Guid gu = Guid.Empty;
            //Guid.TryParse(userid, out gu);
            try
            {
                using (var db = new amEntities())
                {
                    user u = db.user.FirstOrDefault(a => a.userid == userid);
                    if (u == null)
                    {
                        aop = new AOPResult(1, "userid不存在");
                    }
                    else
                    {
                        addr ar = db.addr.FirstOrDefault(a => a.addrid == addrid);
                        if (ar == null)
                        {
                            aop = new AOPResult(1, "addrid不存在");
                        }
                        else
                        {
                            u.addrid = addrid;
                            db.SaveChanges();
                            aop = new AOPResult(0, "设置成功");
                        }

                    }
                }
            }
            catch (Exception Exc)
            {
                aop = new AOPResult(-100, Exc.Message);
            }
            return aop;
        }

        #region 重写增删改
        public override IAOPResult Add(user model)
        {
            var r = base.Add(model);
            return r;
        }
        public override MFXinY.Common.IAOPResult Add(List<user> list)
        {

            var r = base.Add(list);
            return r;
        }
        public override IAOPResult Update(user model)
        {
            var r = base.Update(model);
            return r;
        }
        public override MFXinY.Common.IAOPResult Update(List<user> list)
        {

            var r = base.Update(list);
            return r;
        }
        public override IAOPResult Delete(List<user> list)
        {
            var r = base.Delete(list);
            return r;
        }

        public override IAOPResult Delete(user model)
        {
            var r = base.Delete(model);
            return r;
        }
        #endregion
    }
}
