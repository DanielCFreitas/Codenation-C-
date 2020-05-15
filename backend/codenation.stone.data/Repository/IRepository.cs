using System;
using System.Collections.Generic;
using System.Text;

namespace codenation.stone.data.Repository
{
    interface IRepository
    {
        public T Get<T>();
        public List<T> GetAll<T>();
        public void Create<T>(T Model);
        public void Update<T>(Guid Id, T Model);
        public void Delete(Guid Id);
    }
}
