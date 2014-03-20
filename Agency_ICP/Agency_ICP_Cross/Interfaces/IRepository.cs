using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agency_ICP_Cross.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(object id);
        void Update(T entity);
        T FetchById(object id);
        IQueryable<T> Fetch(string includeProperties = "");
    }
}
