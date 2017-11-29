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
        public IEnumerable<Product> GetProducts(int page, int items)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = Sql.Connect())
            {
                string query = $"Select * from Products";

                SqlCommand command = Sql.OpenConnect(connection, query);

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

            using (SqlConnection connection = Sql.Connect())
            {
                string query = $"Select * from Products Where Id = @id";

                SqlCommand command = Sql.OpenConnect(connection, query, new SqlParameters[] { new SqlParameters("@id", id) });

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
            using (SqlConnection connection = Sql.Connect())
            {
                string query = $"Insert Products (Producer, Model, Price, ProductionDate, TypeId) Values(@producer,@model,@price,@productionDate,@type)";

                SqlCommand command = Sql.OpenConnect(connection, query, new SqlParameters[] { new SqlParameters("@producer", producer), new SqlParameters("@model", model), new SqlParameters("@price", price), new SqlParameters("@productionDate", productionDate), new SqlParameters("@type", type)});

                command.ExecuteNonQuery();
            }
        }
    }
}
