using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Interfaces.Core;
using OnlineShop.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected OnlineShopDbContext _context;
        protected DbSet<T> _dbSet;

        public BaseRepository(OnlineShopDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }

        public IQueryable<T> Set()
        {
            return _dbSet;
        }

        public void Add(T obj)
        {
            _dbSet.Add(obj);
        }

        public void Remove(T item)
        {
            //_dbSet.Remove(item);
            if (item is IEntity) { (item as IEntity).SystemFields.IsDeleted = true; }    
            //else            //{            //    _dbSet.Remove(item);            //}
          
        }

        public T Find(object id)
        {
            return _dbSet.Find(id);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
