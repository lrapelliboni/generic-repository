using System;
using System.Collections.Generic;

namespace GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext<TEntity> _context;

        public Repository()
        {
            _context = new DbContext<TEntity>();
        }

        public void Add(TEntity obj)
        {
            _context.Add(obj);
        }

        public void Remove(TEntity obj)
        {
            _context.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.ToList();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _context.Find(predicate);
        }
    }
}
