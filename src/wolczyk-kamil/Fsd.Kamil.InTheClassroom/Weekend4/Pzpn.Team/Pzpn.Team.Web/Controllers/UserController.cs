using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Web.Models.Users;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
                return View(loginModel);

            if (!_userService.TryLoginUser(loginModel.Login, loginModel.Password))
            {
                ModelState.Clear();
                loginModel.LoginFailed = true;
                return View(loginModel);
            }

            return RedirectToAction("SuccessMessage");
        }

        [HttpGet]
        public ActionResult SuccessMessage()
        {
            return View();
        }
    }
}