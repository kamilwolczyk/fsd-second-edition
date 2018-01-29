using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
           // int selectedNumber = 16;

            string connectionString = @"Server=.\SQLEXPRESS;Database=fsdProducts;User Id=sa;Password=123456789;";
            List<Product> product = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Car";

                SqlCommand command = new SqlCommand(query, connection);

                //SqlParameter numberParameter = new SqlParameter("@SelectedNumber", SqlDbType.Int);
                //numberParameter.Value = selectedNumber;
                //command.Parameters.Add(numberParameter);

                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    product.Add(new Product((int)reader[0], (string)reader[1], (string)reader[2], (decimal)reader[3], (string)reader[4], (DateTime)reader[5]));
                }
            }

            Console.ReadKey();
        }
    }
}
