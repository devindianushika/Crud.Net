using System;
using System.Collections.Generic;
using System.Text;

namespace Domaindb
{
    public interface ICommonRepository<T> where T : class
    {
        public void Create(T entity);
        public IEnumerable<T>GetAll();
        public void Update(T obj);

    }
}
