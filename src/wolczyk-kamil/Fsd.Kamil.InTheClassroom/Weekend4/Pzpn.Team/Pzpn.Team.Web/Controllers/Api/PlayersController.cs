using System.Net.Http;
using System.Web.Http;

namespace Pzpn.Team.Web.Controllers.Api
{
    [RoutePrefix("api/players")]
    public class PlayersController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("5");
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult DoSthWithPlayer()
        {
            return Ok();
        }
    }
}
