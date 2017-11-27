using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupaDoUsunięcia
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-IEHP3D4\SQLEXPRESS; Database=PZPN;User Id=sa; Password = vtvfbdqh12;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM PLAYERS WHERE Number =@SelectedNumber";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int id = (int)reader[0];
                    string FirstName = (string)reader[1];
                    string LastName = (string)reader[2];
                    int number = (int)reader[3];
                }
            };

            Console.ReadKey();
        }
    }
}
