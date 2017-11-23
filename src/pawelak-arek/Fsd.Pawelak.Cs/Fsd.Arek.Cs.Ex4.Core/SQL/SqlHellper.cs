using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Core.SQL
{
    public static class SqlHellper
    {
        const string _connectionString = @"Server=.\SQLEXPRESS;Database=fsdProducts;User Id=sa;Password=123456789;";

        public static SqlDataReader SqlAllValue(string query)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }


        public static Int32 ExecuteNonQuery(String connectionString, String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                    // type is only for OLE DB.  
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
