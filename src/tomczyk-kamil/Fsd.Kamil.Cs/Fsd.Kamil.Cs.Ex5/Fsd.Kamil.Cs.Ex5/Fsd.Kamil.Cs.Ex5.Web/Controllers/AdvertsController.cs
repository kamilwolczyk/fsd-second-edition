using Fsd.Kamil.Cs.Ex5.Web.Models.Adverts;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex5.Web.Controllers
{
    public class AdvertsController : Controller
    {
        public ActionResult DisplaySite()
        {
            return View();
        }

        public ActionResult DisplayOtherProducts()
        {
            return PartialView(new AdvertList
            {
                Items = new List<string>
                {
                    "Kupuj tanie dżemy ! Tylko Stonka!",

                    "Szukasz markowych ubrań?",

                    "Wybierz TERA",

                    "Promocja! Nawet do -50%!",

                    "Płyn do naczyń tylko 3,99 PLN. HOT!"
                }
            });
        }

        public ActionResult DisplaySites()
        {
            return PartialView(new AdvertSites
            {
                Sites = new List<string>
                {
                    "http://www.piotripawel.pl/",

                    "http://ccc.eu/pl/"
                }
            });
        }
    }
}