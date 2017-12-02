using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class AdvertsController : Controller
    {
        // GET: Adverts
        public ActionResult Display()
        {
            int count = 3;
            return PartialView(count);
        }
    }
}