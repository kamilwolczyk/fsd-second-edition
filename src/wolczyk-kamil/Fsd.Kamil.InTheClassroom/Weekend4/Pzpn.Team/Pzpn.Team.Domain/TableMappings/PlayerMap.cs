using Pzpn.Team.Domain.Api.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Pzpn.Team.Domain.TableMappings
{

    public class PlayerMap : ITableMap<Player>
    {
        public string TableName => "Players";

        public IEnumerable<string> Columns => new[] {
            "Id",
            "FirstName",
            "LastName",
            "Number"
        };

        public Player ToEntity(SqlDataReader reader)
        {
            return new Player
            {
                Id = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                Number = (int)reader[3],
            };
        }
    }
}
