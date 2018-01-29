using System.Collections.Generic;

namespace Pzpn.Team.Domain.Api.Entities
{
    public class FootballTeam
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CoachName { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
