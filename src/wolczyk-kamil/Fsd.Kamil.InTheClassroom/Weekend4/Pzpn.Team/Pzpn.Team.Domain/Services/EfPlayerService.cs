using System.Collections.Generic;
using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Domain.Api.Services;
using System;
using Pzpn.Team.Domain.Ef;
using System.Linq;

namespace Pzpn.Team.Domain.Services
{
    public class EfPlayerService : IPlayerService
    {
        private readonly PzpnDbContext _pzpnDb;

        public EfPlayerService()
        {
            _pzpnDb = new PzpnDbContext();
        }

        public IEnumerable<Player> GetAllTeam()
        {
            return _pzpnDb.Players;
        }

        public Player GetPlayerByNumber(int number)
        {
            return _pzpnDb.Players.FirstOrDefault(player => player.Number == number);
        }

        public int GetPlayerCount()
        {
            return _pzpnDb.Players.Count();
        }
    }
}
