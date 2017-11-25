using Fsd.Kamil.Cs.Ex5.Domain.Api.Entities;
using System.Data.SqlClient;

namespace Fsd.Kamil.Cs.Ex5.Domain.Services.SQL
{
    public class SqlProductServices
    {
        public void SQLQuery(Product newProduct)
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=Products;User Id=sa;Password=kamil;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products(Producer, Model, Price, ProductionDate, Type) VALUES(@Producer, @Model, @Price, @ProductionDate, @Type)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@Producer", newProduct.Producer);
                    cmd.Parameters.AddWithValue("@Model", newProduct.Model);
                    cmd.Parameters.AddWithValue("@Price", newProduct.Price);
                    cmd.Parameters.AddWithValue("@ProductionDate", newProduct.ProductionDate);
                    cmd.Parameters.AddWithValue("@Type", newProduct.Type);

                    SqlDataReader reader = cmd.ExecuteReader();

                    connection.Close();
                }
            }
        }
    }
}
