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
    public class CategoryDataProvider : ICategoryDataProvider
    {
        private readonly IConfiguration configuration;

        public CategoryDataProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Category> GetCategories()

        {

            var connection = GetNewConnection();

            

            var category = new List<Category>();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT CategoryId, CategoryName, Description FROM Categories";

            connection.Open();
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                var category1 = new Category();
                category1.CategoryId = (int)dataReader["CategoryId"];
                category1.CategoryName = (string)dataReader["CategoryName"];
                category1.Description = (string)dataReader["Description"];


                category.Add(category1);
            }

            return category;



        }

        private SqlConnection GetNewConnection()
        {
            
            string connectionString = configuration.GetConnectionString("NorthwindConnectionString");
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public void CrateCategories(Category category)
        {
            var connection = GetNewConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[Categories]
                   ([CategoryName]
                   ,[Description])
            OUTPUT INSERTED.CategoryID
             VALUES
                   (@CategoryName
                   ,@Description); SELECT SCOPE_IDENTITY();

";
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            command.Parameters.AddWithValue("@Description", category.Description);

            connection.Open();
            //command.ExecuteNonQuery();
            category.CategoryId = (int)command.ExecuteScalar();
            connection.Close();




        }

        public void UpdateCategories(Category category)
        {
            var connection = GetNewConnection();
            {
                var command = connection.CreateCommand();
                command.CommandText = @"
                 UPDATE Categories
                 SET
                 
                 CategoryName = @CategoryName,
                 Description = @Description
                 WHERE CategoryId = @CategoryId

                ";

                command.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                command.Parameters.AddWithValue("@Description", category.Description);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();



            }
        }

        public Category GetCategoryById(int id)
        {
            var connection = GetNewConnection();
            return connection.QueryFirstOrDefault<Category>("SELECT * FROM Categories WHERE CategoryId = @id", new { id });


        }

        public void DeleteProduct(int productId)
        {
            var connection = GetNewConnection();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Categories Where CategoryId = @CategoryId";
            command.Parameters.AddWithValue("@CategoryId", productId);

            connection.Open();

            command.ExecuteNonQuery();


            connection.Close();
        }
    }
}


