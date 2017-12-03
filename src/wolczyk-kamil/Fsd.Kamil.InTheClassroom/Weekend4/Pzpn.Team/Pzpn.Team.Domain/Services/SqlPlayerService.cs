using System.Collections.Generic;
using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Domain.Sql;
using Pzpn.Team.Domain.TableMappings;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Pzpn.Team.Domain.Services
{
    public class SqlPlayerService : TableRepository<Player>, IPlayerService
    {
        public SqlPlayerService() 
            : base(new PlayerMap())
        {
        }

        public void AddNewPlayer(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Player> GetAllTeam()
        {
            return GetAllEntities();
        }

        public Player GetPlayerByNumber(int number)
        {
            SqlParameter numberParameter = new SqlParameter("@SelectedNumber", SqlDbType.Int);
            numberParameter.Value = number;

            return GetFilteredEntities("Number=@SelectedNumber", new[] { numberParameter }).FirstOrDefault();
        }

        public int GetPlayerCount()
        {
            return GetCount();
        }
    }
}
