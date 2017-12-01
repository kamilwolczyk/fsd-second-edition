using Fsd.Porowiec.Michal.Data.Products;
using Fsd.Porowiec.Michal.Services.Warehouse.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Services.Warehouse
{
    public class SQLWarehauseman : IWarehouseman
    {
        string connectionString = @"Server=DESKTOP-IEHP3D4\SQLEXPRESS ;Database= produkty; User Id=sa; Password=vtvfbdqh12;";

        public void AddProduct(string model, string producer, double price, DateTime dateOfProduction, ProductType type)
        {

        }

        public Product GetProductByModel(string model)
        {
            return (TakeProducts().First(product => product.Model == model));
        }

        public IEnumerable<Product> GetProducts(int page, int items)
        {
            List<Product> productList = TakeProducts();

            if (page == 0 || items == 0)
            {
                page = 0;
                items = productList.Count();
            }

            return productList.Skip(page == 0 ? page : (page - 1) * items).Take(items);
        }

        public List<Product> TakeProducts()
        {
            List<Product> Products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM products";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader[0];
                    string Model = (string)reader[1];
                    string Producer = (string)reader[2];
                    double Price = (double)reader[3];
                    DateTime Date = (DateTime)reader[4];
                    int Type = (int)reader[5];

                    Products.Add(new Product(Model, Producer, Price, Date, (ProductType)Type, id));
                };

                return Products;
            }
        }
    }
}
