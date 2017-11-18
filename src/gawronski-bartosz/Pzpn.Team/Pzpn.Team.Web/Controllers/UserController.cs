using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _userServices;
        // GET: User
        public UserController(IUserService user)
        {
            _userServices = user;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel player)
        {
            if (!ModelState.IsValid)
                return View();
            if(_userServices.CheckUser(player))

            return RedirectToAction("OnLogin");
        }

        public ActionResult OnLogin()
        {
            return View();
        }
    }
}