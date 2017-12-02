using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server =.\SQLEXPRESS; Database = PZPN; User Id =sa;Password =restVen";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select * from Players";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader =  command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader[0];
                    string FirstName = (string)reader[1];
                    string LastName = (string)reader[2];
                    int Number = (int)reader[3];
                }
                
            }

                


            Console.ReadKey();
        }
    }
}
