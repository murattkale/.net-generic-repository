using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace muratkale.EFRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Where(Expression<Func<T, bool>> filter = null);
        List<T> GetAll();
        T Add(T t);
        T Update(T t, object key);
        T Find(object id);
        T FirstOrDefault(Expression<Func<T, bool>> query);
        int Delete(int? id = null, T entity = null);
        int DeleteBulk(List<T> entityList);
        int SaveChanges();
        int Count();
        void Dispose();

    }
}