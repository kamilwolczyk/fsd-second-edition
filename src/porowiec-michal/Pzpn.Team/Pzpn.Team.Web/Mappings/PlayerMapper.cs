using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Web.Models.Players;

namespace Pzpn.Team.Web.Mappings
{
    public class PlayerMapper
    {
        public static PlayerModel ToModel(Player entity)
        {
            return new PlayerModel
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Number = entity.Number
            };
        }
    }
}