using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Weekend3.Data.Entities;
using Weekend3.Services.Services.Users;
using Weekend3.Web.Models.Users;

namespace Weekend3.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController()
        {
            _userService = new FakeUserService();
        }

        public ActionResult List()
        {
            IEnumerable<User> users = _userService.GetUsers();

            //UserListModel model = new UserListModel();
            //List<UserModel> list = new List<UserModel>();

            //foreach (var entity in users)
            //{
            //    UserModel userModel = new UserModel
            //    {
            //        FirstName = entity.FirstName,
            //        LastName = entity.LastName
            //    };

            //    list.Add(userModel);
            //}

            //model.Users = list;


            UserListModel list = new UserListModel
            {
                Users = users.Select(entity => new UserModel
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName
                })
            };
            return Json(list, JsonRequestBehavior.AllowGet);
            return View(list);
        }
    }
}