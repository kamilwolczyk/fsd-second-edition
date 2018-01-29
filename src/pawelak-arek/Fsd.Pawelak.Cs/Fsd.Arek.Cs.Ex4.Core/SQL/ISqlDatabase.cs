using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fsd.Arek.Cs.Ex4.Core.SQL
{
    public interface ISqlDatabase
    {
        SqlDataReader SqlSelectNoParametrs(string query);

        void InsertToDatabaseTable(Dictionary<string, string> value, string tableName);
    }
}