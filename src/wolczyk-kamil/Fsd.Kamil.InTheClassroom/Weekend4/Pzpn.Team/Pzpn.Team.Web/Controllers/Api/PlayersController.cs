using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Web.Mappings;
using Pzpn.Team.Web.Models.Players;
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

        [HttpPost]
        public IHttpActionResult CreatePlayer([FromBody]PlayerDto playerDto)
        {
            if (playerDto == null)
                return BadRequest();

            _playerService.AddNewPlayer(PlayerMapper.ToPlayer(playerDto));
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _playerService.DeleteById(id);
                return Ok();
            }
            catch (System.Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
