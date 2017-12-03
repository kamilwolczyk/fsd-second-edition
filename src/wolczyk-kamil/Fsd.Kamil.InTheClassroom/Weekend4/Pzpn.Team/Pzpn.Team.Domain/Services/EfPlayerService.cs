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

        public void AddNewPlayer(Player player)
        {
            _pzpnDb.Players.Add(player);
            _pzpnDb.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var player = _pzpnDb.Players.FirstOrDefault(x=>x.Id == id);

            if (player == null)
                throw new ArgumentException($"Player with id {id} has not been found");

            _pzpnDb.Players.Remove(player);
            _pzpnDb.SaveChanges();
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
