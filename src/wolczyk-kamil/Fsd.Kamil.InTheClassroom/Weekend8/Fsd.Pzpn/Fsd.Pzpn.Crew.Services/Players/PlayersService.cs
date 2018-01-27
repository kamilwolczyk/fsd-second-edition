using System.Collections.Generic;
using Fsd.Pzpn.Crew.Api.Entities;
using Fsd.Pzpn.Crew.Api.Services;
using Fsd.Pzpn.Ef;

namespace Fsd.Pzpn.Crew.Services.Players
{
    public class PlayersService : IPlayersService
    {
        private readonly PzpnDbContext _dbContext;

        public PlayersService(PzpnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Player> GetAll()
        {
            return _dbContext.Players;
        }
    }
}
