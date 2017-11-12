using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductListModel list = new ProductListModel();

            return View(list.Products.Count());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}