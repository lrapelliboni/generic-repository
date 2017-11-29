using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepository
{
    public class DbContext<TEntity> where TEntity : class
    {

        private static IList<TEntity> _items = new List<TEntity>();
        
        public void Add(TEntity obj)
        {
            _items.Add(obj);
        }

        public void Remove(TEntity obj)
        {
            _items.Remove(obj);
        }

        public IEnumerable<TEntity> ToList()
        {
            return _items.ToList();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _items.ToList().Where(predicate);
        }
    }
}