using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public interface IRepository<T>
    {
        IQueryable<T> Query();

        T GetByID(int id);

        void Delete(int id);

        void Save(T entity);
    }
}
