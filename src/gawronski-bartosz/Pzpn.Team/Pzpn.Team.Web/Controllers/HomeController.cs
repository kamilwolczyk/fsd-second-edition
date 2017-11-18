using Pzpn.Team.Domain.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayerService _playerService;

        public HomeController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public ActionResult Index()
        {
            return View(_playerService.PlayerCount());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}