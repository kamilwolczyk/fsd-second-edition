using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Domain.Services;
using Pzpn.Team.Web.Mappings;
using Pzpn.Team.Web.Models.Players;
using System.Linq;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public ActionResult List()
        {
            PlayerListModel list = new PlayerListModel
            {
                Players = _playerService.GetAllTeam().Select(entity => PlayerMapper.ToModel(entity))
            };

            return View(list);
        }

        [ActionName("details")]
        public ActionResult DisplayPlayerDetails(uint number)
        {
            return View(PlayerMapper.ToModel(_playerService.GetPlayerByNumber(number)));
        }


        public ActionResult Players()
        {
            PlayerListModel list = new PlayerListModel
            {
                Players = _playerService.GetAllTeam().Select(entity => PlayerMapper.ToModel(entity))
            };

            return View(list);
        }

        [HttpGet]
        public ActionResult Edit(uint number)
        {
            ViewBag.ShouldAdvertsBeShown = true;

            return View(PlayerMapper.ToModel(_playerService.GetPlayerByNumber(number)));
        }   

        [HttpPost]
        public ActionResult Edit(uint number, PlayerModel player)
        {
            if (!ModelState.IsValid)
                return View(player);
            //todo validate model and save in db 


            return RedirectToAction("Edit", new { number = player.Number });
        }

    }
}