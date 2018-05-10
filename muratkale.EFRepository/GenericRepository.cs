using muratkale.Data.EFModelContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace muratkale.EFRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected EFContext _context;

        public GenericRepository(EFContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> filter = null)
        {
            var query = _context.Set<T>() as IQueryable<T>;
            if (filter != null)
                query = query.Where(filter);
            //foreach (var includeProperty in includeProperties.Split
            //  (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            //{
            //    query = query.Include(includeProperty);
            //}
            //if (orderBy != null)
            //    return orderBy(query);
            //else
            //    return query;

            return query;
        }

        public virtual List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Find(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T FirstOrDefault(Expression<Func<T, bool>> query)
        {
            return _context.Set<T>().FirstOrDefault(query);
        }

        public virtual T Add(T t)
        {
            _context.Set<T>().Add(t);
            SaveChanges();
            return t;
        }

        public virtual List<T> AddBulk(List<T> tList)
        {
            _context.Set<T>().AddRange(tList);
            SaveChanges();
            return tList;
        }

        public virtual int Delete(int? id = null, T entity = null)
        {
            if (id != null)
            {
                entity = Find((int)id);
            }
            _context.Set<T>().Remove(entity);
            return SaveChanges();
        }

        public virtual int DeleteBulk(List<T> entityList)
        {
            _context.Set<T>().RemoveRange(entityList);
            return SaveChanges();
        }

        public virtual T Update(T t, object key)
        {
            if (t == null)
                return null;
            T exist = Find(key);
            if (exist != null)
            {
                _context.Entry(exist).CurrentValues.SetValues(t);
                SaveChanges();
            }
            return exist;
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}