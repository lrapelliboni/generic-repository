using System;
using System.Collections.Generic;

namespace GenericRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}
