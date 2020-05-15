using System;
using System.Collections.Generic;
using System.Text;

namespace codenation.stone.data.Repository
{
    public class Repository : IRepository
    {
        public void Create<T>(T Model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public T Get<T>()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(Guid Id, T Model)
        {
            throw new NotImplementedException();
        }
    }
}
