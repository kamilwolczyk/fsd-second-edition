using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Web.Mappings;
using System.Linq;
using System.Web.Http;

namespace Pzpn.Team.Web.Controllers.Api
{
    public class PlayersController : ApiController
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public IHttpActionResult GetList()
        {
            return Ok(_playerService.GetAllTeam().Select(PlayerMapper.ToSummaryDto));
        }
    }
}
