using Fsd.Bartek.Ex4.Services.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Data.Enums;

namespace Fsd.Bartek.Ex4.Services.Sql
{
    public class SqlConnect : IProductsService
    {
        string connectionString = @"Server=.\BARTEK;Database=Shop;User Id=sa;Password=restVen;";

        SqlConnection Connect()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

        public IEnumerable<Product> GetProducts(int page, int items)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = Connect())
            {
                connection.Open();

                string query = $"Select * from Products";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product()
                        {
                            Id = (int)reader[0],
                            Producer = (string)reader[1],
                            Model = (string)reader[2],
                            Price = (double)reader[3],
                            ProductionData = (DateTime)reader[4],
                            Type = (ProductsType)reader[5]
                        });
                }
            }

            if (page == 0 || items == 0)
            {
                page = 0;
                items = products.Count();
            }

            return products.Skip(page == 0 ? page : (page - 1) * items).Take(items);
        }

        public Product GetProductByIdNumber(int id)
        {
            Product product = new Product();

            using (SqlConnection connection = Connect())
            {
                connection.Open();

                string query = $"Select * from Products Where Id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    product = new Product()
                    {
                        Id = (int)reader[0],
                        Producer = (string)reader[1],
                        Model = (string)reader[2],
                        Price = (double)reader[3],
                        ProductionData = (DateTime)reader[4],
                        Type = (ProductsType)reader[5]
                    };
                }
            }

            return product;
        }

        public void AddProduct(string producer, string model, double price, DateTime productionDate, int type)
        {
            using (SqlConnection connection = Connect())
            {
                connection.Open();

                string query = $"Insert Products (Producer, Model, Price, ProductionDate, TypeId) Values(@producer,@model,@price,@productionDate,@type)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@producer", producer);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@productionDate", productionDate);
                command.Parameters.AddWithValue("@type", type);

                command.ExecuteNonQuery();
            }
        }
    }
}
