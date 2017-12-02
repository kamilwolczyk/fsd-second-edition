using System.Collections.Generic;

namespace Pzpn.Team.Domain.Api.Entities
{
    public class FootballClub
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ClubPlayers> ClubPlayers { get; set; }
    }
}
