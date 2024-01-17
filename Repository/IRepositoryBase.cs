using DapperCrud.DbContext;
using DapperCrud.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud.Repository
{
    internal interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();
        //IEnumerable<T> FindById(long id);
        T FindById(long id);
        T Save(ref T entity);
        T Update(T entity);
        void Delete(long id);
    }
}
