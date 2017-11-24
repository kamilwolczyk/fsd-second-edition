using Fsd.Bartek.Ex4.Services.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Bartek.Ex4.Data.Entities;

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
            List<Product> products;

            using (SqlConnection connection = Connect())
            {
                connection.Open();

                string query = $"Select * from Products";

                SqlCommand command = new SqlCommand(query, connection);
                //TODO : ZAIMPLEMENTUJ QUERY

            }

            return products = new List<Product>();
        }

        public Product GetProductByIdNumber(int id)
        {
            Product product = new Product();

            using (SqlConnection connection = Connect())
            {
                connection.Open();

                string query = $"";

                SqlCommand command = new SqlCommand(query, connection);
                //TODO : ZAIMPLEMENTUJ QUERY
            }

            return product;
        }

        public void AddProduct(string producer, string model, double price, string productionDate, int type)
        {
            using (SqlConnection connection = Connect())
            {
                connection.Open();

                string query = $"Insert into Products Values({producer}, {model},{price},{productionDate},{type})";

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
