﻿using Pzpn.Team.Domain.Api.Services;
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

        public PlayerController()
        {
            _playerService = new InMemoryPlayerService();
        }

        public ActionResult List()
        {
            PlayerListModel list = new PlayerListModel
            {
                Players = _playerService.GetAllTeam().Select(entity => PlayerMapper.ToModel(entity))
            };

            return View(list);
        }
    }
}