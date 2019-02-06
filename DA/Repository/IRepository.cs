using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public interface IRepository<T, in TPk> where T :class
    {
        T Get(TPk id, params Expression<Func<T, object>>[] children);

        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] children);
        IEnumerable<T> Find(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] children);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);
        //void AddOrUpdate(T entity);

        void Remove(T entity);
        void Delete(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
