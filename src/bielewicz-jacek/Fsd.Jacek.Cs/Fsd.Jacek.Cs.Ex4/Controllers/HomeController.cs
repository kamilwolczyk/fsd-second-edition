using System.Web.Mvc;
using Fsd.Jacek.Cs.Ex4.Data;

namespace Fsd.Jacek.Cs.Ex4.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View(_productService.GetProductCount());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Success(string message)
        {
            return View(message);
        }
    }
}