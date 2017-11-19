using System;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedNumber = 16;

            string connectionString = @"Server=.\SQLEXPRESS;Database=pzpn;User Id=sa;Password=lubieplacki;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Players WHERE Number=@SelectedNumber";

                SqlCommand command = new SqlCommand(query, connection);

                SqlParameter numberParameter = new SqlParameter("@SelectedNumber", SqlDbType.Int);
                numberParameter.Value = selectedNumber;
                command.Parameters.Add(numberParameter);
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader[0];
                    string firstName = (string)reader[1];
                    string lastName = (string)reader[2];
                    int number = (int)reader[3];
                }
            }

            Console.ReadKey();
        }
    }
}
