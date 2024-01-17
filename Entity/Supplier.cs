using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud.Entity
{
    internal class Supplier
    {
        public int SupplierID { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? HomePage { get; set; }
        public override string ToString()
        {
            return $"SupplierID: {SupplierID}\n" +
                   $"CompanyName: {CompanyName}\n" +
                   $"ContactName: {ContactName}\n" +
                   $"ContactTitle: {ContactTitle}\n" +
                   $"HomePage: {HomePage}\n";
        }
    }
}
