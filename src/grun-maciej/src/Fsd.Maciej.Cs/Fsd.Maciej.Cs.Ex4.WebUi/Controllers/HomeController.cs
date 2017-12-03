using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Maciej.Cs.Ex4.WebUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            ViewBag.Color = id;
            return View("ActionName");
        }
        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "About";
            return View("ActionName");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}