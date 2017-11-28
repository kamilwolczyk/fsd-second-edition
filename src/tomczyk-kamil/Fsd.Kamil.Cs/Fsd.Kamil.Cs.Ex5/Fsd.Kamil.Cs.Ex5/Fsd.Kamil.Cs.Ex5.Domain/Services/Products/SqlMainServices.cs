using System;
using System.Collections.Generic;
using Fsd.Kamil.Cs.Ex5.Domain.Api.Entities;
using System.Data.SqlClient;
using Fsd.Kamil.Cs.Ex5.Domain.Api.Enums;

namespace Fsd.Kamil.Cs.Ex5.Domain.Services.Products
{
    public class SqlMainServices : IManualProductService
    {
        private List<Product> _allProducts;

        public static string connectionString = @"Server=.\SQLEXPRESS;Database=Products;User Id=sa;Password=kamil;";

        public IEnumerable<Product> GetAllProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";

                SqlDataReader reader = GetCmd(query, connection).ExecuteReader();

                _allProducts = new List<Product>();

                while (reader.Read())
                {
                    _allProducts.Add(NewProduct(reader));
                }

                return _allProducts;
            }
        }

        public Product GetProductByModel(string model)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM Products WHERE Model = '{model}'"; //Nie zapominać o apostrofie

                SqlDataReader reader = GetCmd(query, connection).ExecuteReader();
                reader.Read();

                return NewProduct(reader);
            }
        }

        public int GetProductsCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT (*) FROM Products";

                return (int)GetCmd(query, connection).ExecuteScalar();
            }
        }

        private SqlCommand GetCmd(string query, SqlConnection connection)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            return new SqlCommand(query, connection);
        }

        private Product NewProduct(SqlDataReader reader)
        {
            return new Product
            {
                Producer = (string)reader[0],
                Model = (string)reader[1],
                Price = (string)reader[2],
                ProductionDate = (DateTime)reader[3],
                Type = (ProductTypes)Enum.Parse(typeof(ProductTypes), (string)reader[4])
            };
        }
    }
}
