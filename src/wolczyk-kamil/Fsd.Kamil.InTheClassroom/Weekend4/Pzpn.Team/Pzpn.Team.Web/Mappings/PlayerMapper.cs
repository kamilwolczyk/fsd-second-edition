using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Web.Models.Players;
using System.Linq;

namespace Pzpn.Team.Web.Mappings
{
    public class PlayerMapper
    {
        public static PlayerModel ToModel(Player entity)
        {
            var currentClub = entity.ClubPlayers
                .Where(club => club.IsActual)
                .FirstOrDefault();

            return new PlayerModel
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Number = entity.Number,
                CurrentClubName = currentClub?.FootballClub?.Name
            };
        }

        public static PlayerSummaryDto ToSummaryDto(Player entity)
        {
            return new PlayerSummaryDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Number = entity.Number
            };
        }
    }
}