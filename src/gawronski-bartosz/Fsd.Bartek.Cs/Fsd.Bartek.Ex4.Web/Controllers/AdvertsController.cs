using Fsd.Bartek.Ex4.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Bartek.Ex4.Web.Controllers
{
    public class AdvertsController : Controller
    {
        public ActionResult Display()
        {
            return PartialView(new AdvertModel()
            {
                CompanyName = "NIKE",
                Marketingtext = "KUPUJ U NAS WSYSZYSTKIE BUTY"
            });
        }
    }
}