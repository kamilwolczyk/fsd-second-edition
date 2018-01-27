using Fsd.Pzpn.Crew.Api.Entities;
using System.Collections.Generic;

namespace Fsd.Pzpn.Crew.Api.Services
{
    public interface IPlayersService
    {
        IEnumerable<Player> GetAll();
    }
}
