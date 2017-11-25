using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Fsd.Sebastian.Cs.Ex4.Services.Products
{
    public class SqlProductProvider : IProductProvider
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=music_equipment;User Id=sa;Password=lubieplacki;";
        
        public IEnumerable<Product> GetAllProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

                SqlDataReader reader = command.ExecuteReader();

                ICollection<Product> productList = new List<Product>();

                while (reader.Read())
                {
                    productList.Add(
                        new Product(
                            (string)reader[1],
                            (string)reader[2],
                            (decimal)reader[3],
                            (DateTime)reader[4],
                            (ProductType)Enum.Parse(typeof(ProductType), (string)reader[5])
                        )
                    );
                }

                return productList;
            };
        }

        public int GetProductsCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Products", connection);

                return (int)command.ExecuteScalar();
            }
        }

        public Product GetSelectedProduct(string producer, string model)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT * FROM Products WHERE Producer = '{producer}' AND Model = '{model}'", connection);

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return new Product((string)reader[1],(string)reader[2],(decimal)reader[3],(DateTime)reader[4],(ProductType)Enum.Parse(typeof(ProductType), (string)reader[5]));
            }
        }
    }
}