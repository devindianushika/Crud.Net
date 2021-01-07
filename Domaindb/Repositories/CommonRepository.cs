using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaindb.Repositories
{
    public class CommonRepository<T> : ICommonRepository<T> where T : class
    {
        private readonly StudentContext _studentContext;
            public CommonRepository(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public void Create(T entity)
        {
            this._studentContext.Set<T>().Add(entity);
            this._studentContext.SaveChanges();
        }
        public IEnumerable<T>GetAll()//enu:a type of list can calculate
        {
            return _studentContext.Set<T>().ToList();

        }
        public void Update(T obj)
        {
            _studentContext.Update(obj);
            this._studentContext.SaveChanges();

        }
    }
}
