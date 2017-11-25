using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Core.SQL
{
    public class SqlHellper : ISqlDatabase
    {
        private const string _connectionString = @"Server=.\SQLEXPRESS;Database=fsdProducts;User Id=sa;Password=123456789;";

        public SqlDataReader SqlSelectNoParametrs(string query)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void InsertToDatabaseTable(Dictionary<string, string> value, string tableName)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(_connectionString);

            string query = $"INSERT INTO {tableName} ({string.Join(", ", value.Keys.ToArray())}) VALUES ({string.Join(", ", value.Values.ToArray())})";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlConnection1;

            sqlConnection1.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}
