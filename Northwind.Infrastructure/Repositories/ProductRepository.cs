/*using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly NorthwindDBcontext northwindD;
        

        public ProductRepository(NorthwindDBcontext northwindD)
        {
            this.northwindD = northwindD;
            
        }


        public void Add(Product product)
        {
            
        }

        public IEnumerable<Product> GetAll()
        {
            
            throw new NotImplementedExce
        }

      
       

    }

}
*/

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.Application.Abstractions;
using Northwind.Domain;
using System;
using System.Collections.Generic;

namespace Northwind.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindDBcontext _northwindD;
        private readonly IConfiguration configuration;

        public ProductRepository(NorthwindDBcontext northwindD,IConfiguration configuration)
        {
            _northwindD = northwindD;
            configuration = configuration;
        }

        public void Add(Product product)
        {
            // Implementación para añadir un producto

            var connectionString = configuration.GetConnectionString("NorthwindConnectionString");

            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Products (ProductName, SupplierId, CategoryId, UnitPrice, QuantityPerUnit, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) 
                    VALUES (@ProductName, @SupplierId, @CategoryId, @UnitPrice, @QuantityPerUnit, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";

                // Agregar parámetros para evitar SQL Injection
                command.Parameters.AddWithValue("@ProductName", product.ProductName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                command.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Discontinued", product.Discontinued);

                connection.Open();
                command.ExecuteNonQuery();
            }


        }

        public IEnumerable<Product> GetAll()
        {
            var products = new List<Product>();

            // Obtén la cadena de conexión desde la configuración
            var connectionString = configuration.GetConnectionString("NorthwindConnectionString");

            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Products";

                connection.Open();
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var product1 = new Product
                    {
                        ProductId = (int)dataReader["ProductId"],
                        ProductName = (string)dataReader["ProductName"],
                        SupplierId = (int)dataReader["SupplierId"],
                        CategoryId = (int)dataReader["CategoryId"],
                        QuantityPerUnit = (string)dataReader["QuantityPerUnit"],
                        UnitPrice = (decimal)dataReader["UnitPrice"],
                        UnitsInStock = dataReader["UnitsInStock"] != DBNull.Value ? (short?)Convert.ToInt16(dataReader["UnitsInStock"]) : (short?)null,
                        UnitsOnOrder = dataReader["UnitsOnOrder"] != DBNull.Value ? (short?)Convert.ToInt16(dataReader["UnitsOnOrder"]) : (short?)null,
                        ReorderLevel = dataReader["ReorderLevel"] != DBNull.Value ? (short?)Convert.ToInt16(dataReader["ReorderLevel"]) : (short?)null,
                        Discontinued = (bool)dataReader["Discontinued"]
                    };

                    products.Add(product1);
                }

                connection.Close();
            }

            return products;
        }
    }
}

