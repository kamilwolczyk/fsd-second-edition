using Pzpn.Team.Domain.Api.Services;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class SiteController : Controller
    {
        private readonly IPlayerService _playerService;

        public SiteController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public ActionResult Home()
        {
            return View(_playerService.GetPlayerCount());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}