using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Web.Mappings;
using Pzpn.Team.Web.Models;
using Pzpn.Team.Web.Models.Players;
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
        private readonly IUserService _userService;
        private readonly Login _loginModel;

        public HomeController(IPlayerService playerService, IUserService userService)
        {
            _playerService = playerService;
            _userService = userService;
            _loginModel = new Login();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(_loginModel);
        }

        [HttpPost]
        public ActionResult Login(Login loginModel)
        {
            
            if((ModelState.IsValid) && (_userService.CheckUser(loginModel.Email, loginModel.Password)))
                return RedirectToAction("Home");

            return View(loginModel);
        }


        public ActionResult Home()
        {
            PlayerListModel list = new PlayerListModel
            {
                Players = _playerService.GetAllTeam().Select(entity => PlayerMapper.ToModel(entity))
            };

            return View(list);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}