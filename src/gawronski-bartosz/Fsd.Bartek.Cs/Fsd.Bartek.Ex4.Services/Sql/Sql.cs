using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Ex4.Services.Sql
{
    public static class Sql
    {
        public static string connectionString = @"Server=.\BARTEK;Database=Shop;User Id=sa;Password=restVen;";

        public static SqlConnection  Connect()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

        public static SqlCommand OpenConnect(SqlConnection connection, string query)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            return command;
        }

        public static SqlCommand OpenConnect(SqlConnection connection, string query, SqlParameters[] parameters)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            foreach (SqlParameters item in parameters)
            {
                command.Parameters.AddWithValue(item.Id,item.Value );
            }

            return command;
        }
    }
}
