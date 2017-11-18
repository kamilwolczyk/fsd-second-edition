using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My name is Kamil Tomczyk. Every day I struggle with my homework ;)";
            return View();
        }
    }
}