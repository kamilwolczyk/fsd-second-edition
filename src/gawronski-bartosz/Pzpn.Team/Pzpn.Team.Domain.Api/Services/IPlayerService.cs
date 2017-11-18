using Pzpn.Team.Domain.Api.Entities;
using System.Collections.Generic;

namespace Pzpn.Team.Domain.Api.Services
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetAllTeam();

        Player GetPlayerByNumber(uint number);

        int PlayerCount();
    }
}
