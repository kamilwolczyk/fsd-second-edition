using System.Collections.Generic;
using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Domain.Api.Services;
using System.Linq;

namespace Pzpn.Team.Domain.Services
{
    public class InMemoryPlayerService : IPlayerService
    {
        private List<Player> _players;

        public InMemoryPlayerService()
        {
            _players = new List<Player>
            {
                new Player
                {
                    Number = 1,
                    FirstName = "Wojciech",
                    LastName = "Szczęsny"
                },
                new Player
                {
                    Number = 10,
                    FirstName = "Grzegorz",
                    LastName = "Krychowiak"
                },
                new Player
                {
                    Number = 9,
                    FirstName = "Robert",
                    LastName = "Lewandowski"
                },
            };
        }

        public IEnumerable<Player> GetAllTeam()
        {
            return _players;
        }

        public Player GetPlayerByNumber(int number)
        {
            return _players.FirstOrDefault(player => player.Number == number);
        }

        public int GetPlayerCount()
        {
            return _players.Count();
        }
    }
}
