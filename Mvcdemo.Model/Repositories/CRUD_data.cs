using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvcdemo.Model.Repositories
{

    public class CRUD_data
    {
        //改成DbContext
        public CRUD_data(DbContext context)
        {
            if (context == null) { throw new ArgumentNullException(); }
            _context = context;
        }

        //改存取範圍，改成 protected
        //在改成存取範圍，改成 private
        //改成DbContext
        private DbContext _context;

        //加入新增、修改、刪除，Create()、Update()、Delete()、GetAll()方法
        //<T> 、  where T : class
        public void Create<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Added;
        }
        //<T> 、  where T : class
        public void Update<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Modified;
        }
        //<T> 、  where T : class
        public void Delete<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Deleted;
        }

        ////<T> 
        //public abstract IQueryable<T> GetAll<T>();

        ////拿掉
        //public abstract IQueryable<T> GetAll<T>() where T : class

        //加入以下
        //拿掉Expression<Func<T,TKey>> keySelector
        public IQueryable<T> GetAll<T, TKey>()

        //加入
        //拿掉.OrderBy();
        where T : class
        {
            return _context.Set<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
