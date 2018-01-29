using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pzpn.Team.Web.Controllers
{
    public class AdvertController : Controller
    {

        // GET: Advert
        public ActionResult Display()
        {
            return PartialView();
        }
    }
}