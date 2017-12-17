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
            string connectionstring = @"server=desktop-iehp3d4\sqlexpress; database=pzpn; user id=sa; password = vtvfbdqh12;";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                string query = "select * from players where number =@selectednumber";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    int id = (int)reader[0];
                    string firstname = (string)reader[1];
                    string lastname = (string)reader[2];
                    int number = (int)reader[3];
                }
            };

            Console.ReadKey();
        }
    }
}
