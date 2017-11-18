using Fsd.Arek.Cs.Ex4.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Arek.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        private IWarehause _warehause = new Warehause(); 

        public ActionResult Index()
        {
            return View(_warehause.GetProductCount());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}