using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Northwind.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Data
{
    public class SupplierDataProvider : ISupplierDataProvider
    {
        private readonly IConfiguration configuration;

        public SupplierDataProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Supplier> GetSuppliers()
        {
            var connection = GetNewConnection();

            var suppliers = new List<Supplier>();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";

            connection.Open();
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var supplier1 = new Supplier();
                /*  supplier1.SupplierId = (int)dataReader["SupplierId"];
                  supplier1.CompanyName = (string)dataReader["CompanyName"];
                  supplier1.ContactName = (string)dataReader["ContactName"];
                  supplier1.ContactTitle = (string)dataReader["ContactTitle"];
                  supplier1.Address = (string)dataReader["Address"];
                  supplier1.City = (string)dataReader["City"];
                  supplier1.Region = dataReader["Region"] != DBNull.Value ? (string)dataReader["Region"] : null;
                  //supplier1.Region = (string)dataReader["Region"];
                  supplier1.PostalCode = (string)dataReader["PostalCode"];
                  supplier1.Country = (string)dataReader["Country"];
                  supplier1.Phone = (string)dataReader["Phone"];
                  //supplier1.Fax = (string)dataReader["Fax"];
                  supplier1.Fax = dataReader["Fax"] != DBNull.Value ? (string)dataReader["Fax"] : null;
                  //supplier1.HomePage=(string)dataReader["HomePage"];
                  supplier1.HomePage = dataReader["HomePage"] != DBNull.Value ? (string)dataReader["Homepage"] : null;
                */
                supplier1.SupplierId = dataReader["SupplierId"] != DBNull.Value ? (int)dataReader["SupplierId"] : default;
                supplier1.CompanyName = dataReader["CompanyName"] != DBNull.Value ? (string)dataReader["CompanyName"] : throw new InvalidCastException("CompanyName cannot be null.");
                supplier1.ContactName = dataReader["ContactName"] != DBNull.Value ? (string)dataReader["ContactName"] : null;
                supplier1.ContactTitle = dataReader["ContactTitle"] != DBNull.Value ? (string)dataReader["ContactTitle"] : null;
                supplier1.Address = dataReader["Address"] != DBNull.Value ? (string)dataReader["Address"] : null;
                supplier1.City = dataReader["City"] != DBNull.Value ? (string)dataReader["City"] : null;
                supplier1.Region = dataReader["Region"] != DBNull.Value ? (string)dataReader["Region"] : null;
                supplier1.PostalCode = dataReader["PostalCode"] != DBNull.Value ? (string)dataReader["PostalCode"] : null;
                supplier1.Country = dataReader["Country"] != DBNull.Value ? (string)dataReader["Country"] : null;
                supplier1.Phone = dataReader["Phone"] != DBNull.Value ? (string)dataReader["Phone"] : null;
                supplier1.Fax = dataReader["Fax"] != DBNull.Value ? (string)dataReader["Fax"] : null;
                supplier1.HomePage = dataReader["HomePage"] != DBNull.Value ? (string)dataReader["HomePage"] : null;





                suppliers.Add(supplier1);
            }
            return suppliers;



        }

        private SqlConnection GetNewConnection()
        {

            string connectionString = configuration.GetConnectionString("NorthwindConnectionString");
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        /*
public Supplier GetSupplierById(int id)
{
   var connection = configuration.GetConnectionString("NorthwindConnectionString");



}
*/

        public void Createsupplier(Supplier supplier)
        {
            var connection = GetNewConnection();
            {
                var command = connection.CreateCommand();
                command.CommandText = @"
        INSERT INTO [dbo].[Suppliers]
            ([CompanyName]
            ,[ContactName]
            ,[ContactTitle]
            ,[Address]
            ,[City]
            ,[Region]
            ,[PostalCode]
            ,[Country]
            ,[Phone]
            ,[Fax]
            ,[HomePage])
        OUTPUT INSERTED.SupplierID
        VALUES
            (@CompanyName
            ,@ContactName
            ,@ContactTitle
            ,@Address
            ,@City
            ,@Region
            ,@PostalCode
            ,@Country
            ,@Phone
            ,@Fax
            ,@HomePage);
             ";

                command.Parameters.AddWithValue("@CompanyName", supplier.CompanyName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactName", supplier.ContactName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@City", supplier.City ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Region", supplier.Region ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PostalCode", supplier.PostalCode ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Country", supplier.Country ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Phone", supplier.Phone ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Fax", supplier.Fax ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@HomePage", supplier.HomePage ?? (object)DBNull.Value);

                connection.Open();
                supplier.SupplierId = (int)command.ExecuteScalar();
                connection.Close();
            }

        }

        public void UpdateSuppliers(Supplier supplier)
        {
            var connection = GetNewConnection();
            {
                var command = connection.CreateCommand();
                command.CommandText = @"
                 UPDATE Suppliers
                 SET
                 
                 CompanyName = @CompanyName,
                 ContactName = @ContactName,
                 ContactTitle = @ContactTitle,
                 Address = @Address,
                 City = @City,
                 Region = @Region,
                 PostalCode = @PostalCode,
                 Country = @Country,
                 Phone = @Phone,
                 Fax = @Fax,
                 HomePage = @HomePage
                 WHERE SupplierId = @SupplierId;
                    ";
                command.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                command.Parameters.AddWithValue("@CompanyName", supplier.CompanyName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactName", supplier.ContactName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@City", supplier.City ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Region", supplier.Region ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PostalCode", supplier.PostalCode ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Country", supplier.Country ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Phone", supplier.Phone ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Fax", supplier.Fax ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@HomePage", supplier.HomePage ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();

                //supplier.SupplierId = (int)command.ExecuteScalar();

                connection.Close();

            }
        }
        public Supplier GetSupplierById(int id)
        {
            var connection = GetNewConnection();
           return connection.QueryFirstOrDefault<Supplier>("SELECT * FROM Suppliers WHERE SupplierId = @id", new { id });


        }

        public void DeleteProduct(int productId)
        {
            var connection = GetNewConnection();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Suppliers Where SupplierId = @SupplierId";
            command.Parameters.AddWithValue("@SupplierId", productId);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
