using System.Collections.Generic;
using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Domain.Api.Services;

namespace Pzpn.Team.Domain.Services
{
    public class SqlPlayerService : IPlayerService
    {
        public IEnumerable<Player> GetAllTeam()
        {
            throw new System.NotImplementedException();
        }

        public Player GetPlayerByNumber(uint number)
        {
            throw new System.NotImplementedException();
        }

        public int GetPlayerCount()
        {
            throw new System.NotImplementedException();
        }
    }
}
