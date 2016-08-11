using MFXinY.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MFXinY.EF
{
    public class EFBase<T> where T : class,new()
    {
        //创建EF框架的上下文  
        // protected DbContext dataBase;
        public virtual DbContext DataBase { get { return null; } }

        public virtual void RefreshDbContext()
        {
        }
        #region Add 添加对象
        /// <summary>
        /// 添加一个对象
        /// </summary>
        /// <param name="model">要添加的对象</param>
        /// <returns>添加对象结果</returns>
        public virtual IAOPResult Add(T model)
        {
            List<T> list = new List<T>();
            list.Add(model);
            return Add(list);
        }
        /// <summary>
        /// 添加一组对象
        /// </summary>
        /// <param name="list">要添加的一组对象</param>
        /// <returns>添加结果</returns>
        public virtual IAOPResult Add(List<T> list)
        {
            try
            {
                foreach (var item in list)
                {
                    if (item != null)
                    {
                        DataBase.Entry<T>(item).State = EntityState.Detached;
                        DataBase.Set<T>().Attach(item);
                        DataBase.Entry<T>(item).State = EntityState.Added;
                    }
                }
                DataBase.SaveChanges();
                //解除与dbContext的关系
                foreach (var item in list)
                {
                    DataBase.Entry<T>(item).State = EntityState.Detached;
                }
                return new AOPResult(0, list.Count.ToString());
            }
            catch (Exception e)
            {
                //解除与dbContext的关系
                foreach (var item in list)
                {
                    DataBase.Entry<T>(item).State = EntityState.Detached;
                }
                //RefreshDbContext();
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        #endregion

        #region Update 更新对象
        /// <summary>
        /// 实现对数据库的修改功能
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IAOPResult Update(T model)
        {
            List<T> list = new List<T>();
            list.Add(model);
            return Update(list);
        }
        /// <summary>
        /// 更新一组对象
        /// </summary>
        /// <param name="list">要更新的一组对象</param>
        /// <returns>更新结果</returns>
        public virtual IAOPResult Update(List<T> list)
        {
            try
            {
                foreach (var model in list)
                {
                    if (model != null)
                    {
                        DataBase.Entry<T>(model).State = EntityState.Detached;
                        DataBase.Set<T>().Attach(model);
                        DataBase.Entry<T>(model).State = EntityState.Modified;
                    }
                }
                DataBase.SaveChanges();
                //解除与dbContext的关系
                foreach (var item in list)
                {
                    DataBase.Entry<T>(item).State = EntityState.Detached;
                }
                return new AOPResult(0, list.Count.ToString());
            }
            catch (Exception e)
            {
                //解除与dbContext的关系
                foreach (var item in list)
                {
                    DataBase.Entry<T>(item).State = EntityState.Detached;
                }
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        /// <summary>
        /// 这个方法修改不了数据，不知为什么
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        //public virtual IAOPResult Update(IQueryable<T> list)
        //{
        //    try
        //    {
        //        foreach (var model in list)
        //        {
        //            if (model != null)
        //            {
        //                DataBase.Entry<T>(model).State = EntityState.Detached;
        //                DataBase.Set<T>().Attach(model);
        //                DataBase.Entry<T>(model).State = EntityState.Modified;
        //            }
        //        }
        //        var i = DataBase.SaveChanges();   //保存后变成unchange
        //        //解除与dbContext的关系
        //        foreach (var item in list)
        //        {
        //            DataBase.Entry<T>(item).State = EntityState.Detached;
        //        }
        //        return new AOPResult(0, i.ToString());
        //    }
        //     catch (Exception e)
        //    {
        //        //解除与dbContext的关系
        //        foreach (var item in list)
        //        {
        //            DataBase.Entry<T>(item).State = EntityState.Detached;
        //        }
        //        return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
        //    }
        //}
        #endregion

        #region 删除对象

        /// <summary>
        /// 实现对数据库的删除功能
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual IAOPResult Delete(T model)
        {
            List<T> list = new List<T>();
            list.Add(model);
            return Delete(list);
        }

        /// <summary>
        /// 删除一组对象
        /// </summary>
        /// <param name="list">要删除的对象集合</param>
        /// <returns>删除结果</returns>
        public virtual IAOPResult Delete(List<T> list)
        {
            try
            {
                foreach (var model in list)
                {
                    if (model != null)
                    {
                        DataBase.Entry<T>(model).State = EntityState.Detached;
                        DataBase.Set<T>().Attach(model);
                        DataBase.Entry<T>(model).State = EntityState.Deleted;
                    }
                }
                DataBase.SaveChanges();  //保存后状态成Detached

                return new AOPResult(0, list.Count.ToString());
            }
            catch (Exception e)
            {
                //解除与dbContext的关系
                foreach (var item in list)
                {
                    DataBase.Entry<T>(item).State = EntityState.Detached;
                }
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        /// <summary>
        /// 通过linq表达式作为条件删除
        /// </summary>
        /// <param name="where">写条件语句，比如："id=1 and id=8"</param>
        /// <returns></returns>
        public virtual IAOPResult Delete(Expression<Func<T, bool>> whereLambda)
        {
            var list = DataBase.Set<T>().Where(whereLambda);
            try
            {
                int sum = 0;
                if (list.Any())
                {
                    foreach (var item in list)
                    {
                        sum++;
                        DataBase.Entry<T>(item).State = EntityState.Detached;
                        DataBase.Set<T>().Attach(item);
                        DataBase.Entry<T>(item).State = EntityState.Deleted;
                    }
                    DataBase.SaveChanges();
                }
                return new AOPResult(0, sum.ToString());
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }

        /// <summary>
        /// 删除全部记录
        /// </summary>
        /// <returns></returns>
        public IAOPResult DeleteAll()
        {
            return ExecuteSqlCommand(string.Format("delete from {0}", typeof(T).Name));
        }
        #endregion

        #region 执行SQL语句
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private IAOPResult ExecuteSqlCommand(string sql, params object[] parameters)
        {
            try
            {
                var r = DataBase.Database.ExecuteSqlCommand(sql, parameters);
                return new AOPResult(0, r.ToString());
            }
            catch (Exception e)
            {
                return new AOPResult(-100, Tools.GetFinallExceptionMessage(e));
            }
        }
        #endregion

        #region IsExist查找是否存在某对象
        /// <summary>
        /// 根据主键查找是否存在对象
        /// </summary>
        /// <param name="parameters">主键</param>
        /// <returns>是否存在</returns>
        public virtual bool IsExist(params object[] parameters)
        {
            var t = Find(parameters);
            return t != null;
        }
        /// <summary>
        /// 根据条件查找对象是否存在 
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public virtual bool IsExist(Expression<Func<T, bool>> whereLambda)
        {
            return DataBase.Set<T>().AsNoTracking().Any(whereLambda);
        }
        #endregion

        #region first 查找第一个符合条件的对象
        public T First()
        {
            return Where(a => true).FirstOrDefault();
        }
        /// <summary>
        /// 通过主键查找第一个
        /// </summary>
        /// <param name="parameters">主键值</param>
        /// <returns>查找结果</returns>
        public T First(params object[] parameters)
        {
            return Find(parameters);
        }
        /// <summary>
        /// 根据条件查找第一个对象
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public T First(Expression<Func<T, bool>> whereLambda)
        {
            var t = DataBase.Set<T>().AsNoTracking().FirstOrDefault(whereLambda);
            return t;
        }
        /// <summary>
        /// 排序查找第一个记录
        /// </summary>
        /// <typeparam name="S">按照某个类（比如：Int32 或 string）进行排序</typeparam>
        /// <param name="whereLambda">查询表达式</param>
        /// <param name="orderByLambda">排序字段</param>
        /// <param name="isAse">是否正序</param>
        /// <returns>查找结果</returns>
        public T First<S>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAse = true)
        {
            T t;
            if (isAse == true)
            {
                t = DataBase.Set<T>().AsNoTracking().OrderBy<T, S>(orderByLambda).FirstOrDefault(whereLambda);
            }
            else
            {
                t = DataBase.Set<T>().AsNoTracking().OrderByDescending<T, S>(orderByLambda).FirstOrDefault(whereLambda);
            }
            return t;
        }
        /// <summary>
        /// 通过主键查找
        /// </summary>
        /// <param name="parameters">主键</param>
        /// <returns>查找结果</returns>
        public T Find(params object[] parameters)
        {
            var t = DataBase.Set<T>().Find(parameters);
            return t;
        }

        #endregion

        #region 查询Where Query QueryList Count
        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="whereLambda">Lambda表达式</param>
        /// <returns>查询结果IQueryable/></returns>
        public IQueryable<T> Where(Expression<Func<T, bool>> whereLambda)
        {
            return DataBase.Set<T>().AsNoTracking().Where<T>(whereLambda).AsQueryable();
        }

        /// <summary>
        /// 查询数据集合
        /// </summary>
        /// <typeparam name="S">按照某个类（比如：Int32 或 string）进行排序</typeparam>     
        /// <param name="recordCount">查询的总条数</param>
        /// <param name="whereLambda">取得排序的条件</param>
        /// <param name="isAsc">如何排序，根据倒叙还是升序</param>
        /// <param name="orderByLambda">根据那个字段进行排序</param>
        /// <returns></returns>
        public IQueryable<T> Query<S>(out int recordCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc = true)
        {
            return Query<S>(1, Int32.MaxValue, out recordCount, whereLambda, orderByLambda, isAsc);
        }
        /// <summary>
        /// 根据条件查询记录条数
        /// </summary>
        /// <param name="whereLambda">条件表达式</param>
        /// <returns>记录条件</returns>
        public int Count(Expression<Func<T, bool>> whereLambda)
        {
            return DataBase.Set<T>().AsNoTracking().Where<T>(whereLambda).Count();
        }
        /// <summary>
        /// 实现对数据的分页查询
        /// </summary>
        /// <typeparam name="S">按照某个类（比如：Int32 或 string）进行排序</typeparam>
        /// <param name="pageIndex">当前第几页</param>
        /// <param name="pageSize">一页显示多少条数据</param>
        /// <param name="recordCount">总条数</param>
        /// <param name="whereLambda">取得排序的条件</param>
        /// <param name="isAsc">如何排序，根据倒叙还是升序</param>
        /// <param name="orderByLambda">根据那个字段进行排序</param>
        /// <returns></returns>
        public IQueryable<T> Query<S>(int pageIndex, int pageSize, out  int recordCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc = true)
        {
            var temp = DataBase.Set<T>().AsNoTracking().Where<T>(whereLambda);
            recordCount = temp.Count(); //得到总的条数
            //排序,获取当前页的数据
            if (isAsc)
            {
                temp = temp.OrderBy<T, S>(orderByLambda)
                     .Skip<T>(pageSize * (pageIndex - 1)) //越过多少条
                     .Take<T>(pageSize).AsQueryable(); //取出多少条
            }
            else
            {
                temp = temp.OrderByDescending<T, S>(orderByLambda)
                    .Skip<T>(pageSize * (pageIndex - 1)) //越过多少条
                    .Take<T>(pageSize).AsQueryable(); //取出多少条
            }
            return temp;
        }
        /// <summary>
        /// 实现对数据的分页查询
        /// </summary>
        /// <typeparam name="S">按照某个类（比如：Int32 或 string）进行排序</typeparam>
        /// <param name="pageIndex">当前第几页</param>
        /// <param name="pageSize">一页显示多少条数据</param>
        /// <param name="recordCount">总条数</param>
        /// <param name="whereLambda">取得排序的条件</param>
        /// <param name="isAsc">如何排序，根据倒叙还是升序</param>
        /// <param name="orderByLambda">根据那个字段进行排序</param>
        /// <returns></returns>
        public List<T> QueryList<S>(int pageIndex, int pageSize, out  int recordCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc = true)
        {
            var temp = DataBase.Set<T>().AsNoTracking().Where<T>(whereLambda);
            recordCount = temp.Count(); //得到总的条数
            //排序,获取当前页的数据
            if (isAsc)
            {
                temp = temp.OrderBy<T, S>(orderByLambda)
                     .Skip<T>(pageSize * (pageIndex - 1)) //越过多少条
                     .Take<T>(pageSize).AsQueryable(); //取出多少条
            }
            else
            {
                temp = temp.OrderByDescending<T, S>(orderByLambda)
                    .Skip<T>(pageSize * (pageIndex - 1)) //越过多少条
                    .Take<T>(pageSize).AsQueryable(); //取出多少条
            }
            return temp.ToList();
        }
        #endregion
    }
}
