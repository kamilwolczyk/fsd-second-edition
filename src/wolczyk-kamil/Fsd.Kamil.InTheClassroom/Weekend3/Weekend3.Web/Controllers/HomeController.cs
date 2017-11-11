using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weekend3.Web.Models;

namespace Weekend3.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HelloWorld(int id)
        {
            HelloWorldModel model = new HelloWorldModel()
            {
                Name = "Wojciech"
            };

            return View(model);
        }

        public ActionResult Date()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}