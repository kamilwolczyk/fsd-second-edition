using Pzpn.Team.Domain.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pzpn.Team.Domain.Api.Entities;

namespace Pzpn.Team.Domain.Services
{
    class SQLPlayerService : IPlayerService
    {
        public IEnumerable<Player> GetAllTeam()
        {
            throw new NotImplementedException();
        }

        public Player GetPlayerByNumber(uint number)
        {
            throw new NotImplementedException();
        }
    }
}
