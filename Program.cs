
using DapperCrud.DbContext;
using DapperCrud.Entity;
using DapperCrud.Repository;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static IConfigurationRoot Configuration;
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BuildConfiguration();
        var dapperDbContext = new DapperDbContext(Configuration.GetConnectionString("NorthWindDS"));
        
        IRepositoryBase<Supplier> supplierRepo = new SupplierRepository(dapperDbContext);
        //var listSupps = supplierRepo.FindAll();
        //foreach (var item in listSupps)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //supp by id
        //var supById = supplierRepo.FindById(27);
        //Console.WriteLine(supById);

        ///create
        //var newSupps = new Supplier
        //{
        //    CompanyName = "x com",
        //    ContactName = "ilon",
        //    ContactTitle = "ceo",
        //    HomePage = "ex.com"
        //};

        //newSupps = supplierRepo.Save(ref newSupps);
        //Console.WriteLine(newSupps.ToString());

        ///update
        //var updateSupps = new Supplier
        //{
        //    SupplierID = 31,
        //    CompanyName = "x com update",
        //    ContactName = "ilon update",
        //    ContactTitle = "ceo update",
        //    HomePage = "ex.com update"
        //};

        //updateSupps = supplierRepo.Update(updateSupps);
        //Console.WriteLine(updateSupps.ToString());

        //delete 

        //supplierRepo.Delete(30);
    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        Console.WriteLine(Configuration.GetConnectionString("NorthWindDS"));
    }
}
