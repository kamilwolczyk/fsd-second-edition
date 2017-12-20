using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Porowiec.Michal.Cs4.Controllers
{
    public class AdvertsController : Controller
    {
        // GET: Adverts
        public ActionResult Display()
        {
            return PartialView();
        }
    }
}