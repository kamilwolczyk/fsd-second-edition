using Fsd.Kamil.Cs.Ex5.Domain.Api.Enums;
using Fsd.Kamil.Cs.Ex5.Domain.Services.Products;
using System;
using System.Data.SqlClient;

namespace Fsd.Kamil.Cs.Ex5.Domain.Services.SQL
{
    public class SqlProductServices
    {
        public static void SQLQuery(string Producer, string Model, string Price, DateTime ProductionDate, ProductTypes Type)
        {
            string connectionString = SqlMainServices.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products(Producer, Model, Price, ProductionDate, Type) VALUES(@Producer, @Model, @Price, @ProductionDate, @Type)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@Producer", Producer);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@ProductionDate", ProductionDate);
                    cmd.Parameters.AddWithValue("@Type", Type);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }
    }
}
