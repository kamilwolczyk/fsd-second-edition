using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using Fsd.Sebastian.Cs.Ex4.Services.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fsd.Sebastian.Cs.Ex4.Services.Products.Sql
{
    public class SqlProductProvider : IProductProvider
    {
        public IEnumerable<Product> GetAllProducts()
        {
            using (SqlService.GetConnection())
            {
                SqlDataReader reader = SqlService.GetCommand("SELECT * FROM Products").ExecuteReader();

                ICollection<Product> productList = new List<Product>();

                while (reader.Read())
                {
                    productList.Add(ProductToReturn(reader));
                }

                return productList;
            };
        }

        public int GetProductsCount()
        {
            using (SqlService.GetConnection())
            {
                return (int)SqlService.GetCommand("SELECT COUNT(*) FROM Products").ExecuteScalar();
            }
        }

        public Product GetSelectedProduct(string producer, string model)
        {
            using (SqlService.GetConnection())
            {
                SqlDataReader reader = SqlService.GetCommand("SELECT * FROM Products " +
                    $"WHERE Producer = '{producer}' AND Model = '{model}'").ExecuteReader();

                reader.Read();

                return ProductToReturn(reader);
            }
        }

        private Product ProductToReturn(SqlDataReader reader)
        {
            return new Product(
                    (string)reader[1],
                    (string)reader[2],
                    (decimal)reader[3],
                    (DateTime)reader[4],
                    (ProductType)Enum.Parse(typeof(ProductType), (string)reader[5])
                    );
        }
    }
}