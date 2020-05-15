using System;
using System.Collections.Generic;
using System.Text;

namespace codenation.stone.data.Repository
{
    interface IRepository<T> where T : class
    {
        public T Get(Guid Id);
        public IEnumerable<T> GetAll();
        public void Create(T Model);
        public void Update(T Model);
        public void Delete(T Model);
    }
}
