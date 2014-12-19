using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTests
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private BlogContext Context
        {
            get
            {
                return new BlogContext();
            }
        }

        public IQueryable<T> Query()
        {
            return Context.Set<T>();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}