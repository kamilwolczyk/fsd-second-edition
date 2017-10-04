using System.Web.Mvc;
using Fsd.Kamil.Cs.Ex4.Data.Entities;
using Fsd.Kamil.Cs.Ex4.Services.Products;

namespace Fsd.Kamil.Cs.Ex4.Web.Controllers
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