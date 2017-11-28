using System.Data.SqlClient;

namespace Fsd.Sebastian.Cs.Ex4.Services.Sql
{
    public static class SqlService
    {
        private static string _connectionString=@"Server=.\SQLEXPRESS;Database=music_equipment;User Id=sa;Password=lubieplacki;";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public static SqlCommand GetCommand(string query)
        {
            SqlConnection connection = GetConnection();

            connection.Open();

            return new SqlCommand(query, connection);
        }
    }
}
