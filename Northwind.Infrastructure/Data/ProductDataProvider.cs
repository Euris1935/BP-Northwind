
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Data
{
    public class ProductDataProvider : IProductDataProvider
    {
        private readonly IConfiguration configuration;

        public ProductDataProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Category> GetCategories() 
        {
            var conecction = GetNewConnection();
            var categories = conecction.Query<Category>("SELECT CategoryName, CategoryId FROM Categories");
            return categories;
        
        }
        public IEnumerable<Supplier> GetSuppliers()
        {
            var connection = GetNewConnection();
            var suppliers = connection.Query<Supplier>
                ("SELECT SupplierId FROM Suppliers");

            return suppliers;
        }




        private SqlConnection GetNewConnection()
        {
            string connectionstring = configuration.GetConnectionString("NorthwindConnectionString");
            var connection = new SqlConnection(connectionstring);

            return connection;
        }

        public List<Product> GetProducts()
        {

            var connection = GetNewConnection();


            var products = new List<Product>();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT ProductId, ProductName, SupplierId, CategoryId, UnitPrice, QuantityPerUnit, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";



            connection.Open();

            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var productss = new Product();
                productss.ProductId = (int)dataReader["ProductId"];
                productss.ProductName = (string)dataReader["ProductName"];
                productss.SupplierId = (int)dataReader["SupplierId"];
                productss.CategoryId = (int)dataReader["CategoryId"];
                productss.QuantityPerUnit = (string)dataReader["QuantityPerUnit"];
                productss.UnitPrice = (decimal)dataReader["UnitPrice"];

                productss.UnitsInStock = (short?)Convert.ToInt32(dataReader["UnitsInStock"]);
                productss.UnitsOnOrder = (short?)Convert.ToInt32(dataReader["UnitsOnOrder"]);
                productss.ReorderLevel = (short?)Convert.ToInt32(dataReader["ReorderLevel"]);


                productss.Discontinued = (bool)dataReader["Discontinued"];


                products.Add(productss);



            }


            //var dataTable = new DataTable();
            //dataTable.Load(dataReader);

            connection.Close();

            return products;

        }
        public Product GetProductById(int id) 
        {
         var connection = GetNewConnection();
         return connection.QueryFirstOrDefault<Product>("SELECT * FROM Products WHERE ProductId = @id", new { id });
        
        
        }
     
        public void CraeteProduct(Product product)
        {
            var connection = GetNewConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[Products]
                   ([ProductName]
                   ,[SupplierID]
                   ,[CategoryID]
                   ,[QuantityPerUnit]
                   ,[UnitPrice]
                   ,[UnitsInStock]
                   ,[UnitsOnOrder]
                   ,[ReorderLevel]
                   ,[Discontinued])
             OUTPUT INSERTED.ProductID
             VALUES
                   (@ProductName,
                   @SupplierID,
                   @CategoryID,
                   @QuantityPerUnit,
                   @UnitPrice,
                   @UnitsInStock,
                   @UnitsOnOrder,
                   @ReorderLevel,
                   @Discontinued); SELECT SCOPE_IDENTITY();

";

            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@SupplierId", product.SupplierId);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
            command.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
            command.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
            command.Parameters.AddWithValue("@Discontinued", product.Discontinued);

            connection.Open();
            //command.ExecuteNonQuery();

            var scalarValue = command.ExecuteScalar();
            product.ProductId = Convert.ToInt32(scalarValue);

            connection.Close();



        }

        public void UpdateProducts(Product product) 
        {
            var connection = GetNewConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
             UPDATE Products
             SET
             
             ProductName = @ProductName,
             SupplierId = @SupplierId,
             CategoryId = @CategoryId,
             QuantityPerUnit = @QuantityPerUnit,
             UnitPrice = @UnitPrice,
             UnitsInStock = @UnitsInStock,
             UnitsOnOrder = @UnitsOnOrder,
             ReorderLevel = @ReorderLevel,
             Discontinued = @Discontinued
             WHERE ProductId = @ProductId

             ";
            command.Parameters.AddWithValue("@ProductId", product.ProductId);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@SupplierId", product.SupplierId);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
            command.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
            command.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
            command.Parameters.AddWithValue("@Discontinued", product.Discontinued);

            connection.Open();
            command.ExecuteNonQuery();

            // var scalarValue = command.ExecuteScalar();
            // product.ProductId = Convert.ToInt32(scalarValue);

            connection.Close();

        }

        public void DeleteProduct(int productId)
        {
            var connection = GetNewConnection();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Products Where ProductId = @ProductId";
            command.Parameters.AddWithValue("@ProductId", productId);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }


}
