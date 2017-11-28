using System.Collections.Generic;
using System.Data.SqlClient;

namespace Pzpn.Team.Domain.Mappers
{
    public interface ITableMap<T>
    {
        string TableName { get; }

        IEnumerable<string> Columns { get; }

        T ToEntity(SqlDataReader reader);
    }
}
