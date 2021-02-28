using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Delete(T entity);
        void Delete(object id);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetByKey(object key);
        void Insert(T entity);
        void Update(T entity);
    }
}
