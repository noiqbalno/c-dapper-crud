using DapperCrud.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud.Repository
{
    internal interface ISupplierRepository
    {
        IEnumerable<Supplier> FindAllSuppliers();
        Supplier FindSupplierById(long id);
        Supplier CreateSupplier(ref Supplier supplier);
        Supplier UpdateSupplier(Supplier supplier);
        void DeleteSupplier(long id);
    }
}
