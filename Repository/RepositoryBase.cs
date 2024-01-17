using DapperCrud.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud.Repository
{
    internal abstract class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        protected readonly DapperDbContext _dapperDbContext;
        protected RepositoryBase(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public virtual void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public abstract T FindById(long id);

        public virtual T Save(ref T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
