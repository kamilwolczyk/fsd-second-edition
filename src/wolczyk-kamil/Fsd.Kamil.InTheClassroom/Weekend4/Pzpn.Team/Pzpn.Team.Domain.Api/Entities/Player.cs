using System.Collections.Generic;

namespace Pzpn.Team.Domain.Api.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Number { get; set; }

        public int Age { get; set; }

        public int TeamId { get; set; }

        public virtual FootballTeam Team { get; set; }

        public virtual ICollection<ClubPlayers> ClubPlayers { get; set; }
    }
}
