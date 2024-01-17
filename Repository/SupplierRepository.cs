using DapperCrud.DbContext;
using DapperCrud.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCrud.Repository
{
    //internal class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    internal class SupplierRepository : RepositoryBase<Supplier>
    {
        public SupplierRepository(DapperDbContext dapperDbContext) : base(dapperDbContext)
        {
        }

        public override Supplier Save(ref Supplier supplier)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "insert into Suppliers (CompanyName,ContactName,ContactTitle,HomePage) values (@companyName,@contactName,@contactTitle,@homePage);",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@suppId",
                        DataType = DbType.Int32,
                        Value = supplier.SupplierID
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@companyName",
                        DataType = DbType.String,
                        Value = supplier.CompanyName
                    }
                    ,
                    new SqlCommandParameterModel() {
                        ParameterName = "@contactName",
                        DataType = DbType.String,
                        Value = supplier.ContactName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@contactTitle",
                        DataType = DbType.String,
                        Value = supplier.ContactTitle
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@homePage",
                        DataType = DbType.String,
                        Value = supplier.HomePage
                    }
                }
            };

            _dapperDbContext.ExecuteNonQuery(model);
            _dapperDbContext.Dispose();

            return supplier;
        }

        public override void Delete(long id)
        {
            var sql = $"DELETE FROM Suppliers WHERE SupplierID={id}";

            _dapperDbContext.ExecuteNonQuery(sql);
            _dapperDbContext.Dispose();
        }

        public override IEnumerable<Supplier> FindAll()
        {
            var sql = "SELECT SupplierID, CompanyName, ContactName, ContactTitle HomePage from Suppliers";
            var dataSet = _dapperDbContext.ExecuteReader<Supplier>(sql);

            while (dataSet.MoveNext())
            {
                var item = dataSet.Current;
                yield return item;
            }

            _dapperDbContext.Dispose();
        }

        public override Supplier FindById(long id)
        {
            var sql = $"SELECT SupplierID, CompanyName, ContactName, ContactTitle HomePage from Suppliers WHERE SupplierID={id}";
            var dataSet = _dapperDbContext.ExecuteReader<Supplier>(sql);

            var supplier = new Supplier();

            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (dataSet.MoveNext())
            {
                supplier = dataSet.Current;
            }


            return supplier;
        }

        public override Supplier Update(Supplier supplier)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "UPDATE Suppliers SET CompanyName=@companyName, ContactName=@contactName, ContactTitle=@contactTitle, HomePage=@homePage WHERE SupplierID=@suppId",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@suppId",
                        DataType = DbType.Int32,
                        Value = supplier.SupplierID
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@companyName",
                        DataType = DbType.String,
                        Value = supplier.CompanyName
                    }
                    ,
                    new SqlCommandParameterModel() {
                        ParameterName = "@contactName",
                        DataType = DbType.String,
                        Value = supplier.ContactName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@contactTitle",
                        DataType = DbType.String,
                        Value = supplier.ContactTitle
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@homePage",
                        DataType = DbType.String,
                        Value = supplier.HomePage
                    }
                }
            };

            _dapperDbContext.ExecuteNonQuery(model);
            _dapperDbContext.Dispose();

            return supplier;
        }
    }
}
