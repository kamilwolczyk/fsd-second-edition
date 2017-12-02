using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Pzpn.Team.Domain.Sql
{
    public class SqlDatabaseClient
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["pzpnDev"].ConnectionString;

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string query, Func<SqlDataReader, TEntity> mapper, SqlParameter[] parameters = null)
        {
            List<TEntity> result = new List<TEntity>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    result.Add(mapper(reader));
            }

            return result;
        }

        public T ExecuteScalar<T>(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                return (T)command.ExecuteScalar();
            }
        }
    }
}
