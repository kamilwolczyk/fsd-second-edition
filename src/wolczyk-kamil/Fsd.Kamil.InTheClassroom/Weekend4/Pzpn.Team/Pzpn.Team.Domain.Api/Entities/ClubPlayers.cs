using System;

namespace Pzpn.Team.Domain.Api.Entities
{
    public class ClubPlayers
    {
        public int Id { get; set; }

        public bool IsActual { get; set; }

        public int FootballClubId { get; set; }

        public int PlayerId { get; set; }

        public virtual FootballClub FootballClub { get; set; }

        public virtual Player Player { get; set; }
    }
}
