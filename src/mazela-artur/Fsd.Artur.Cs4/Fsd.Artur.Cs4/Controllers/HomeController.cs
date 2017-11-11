using Fsd.Artur.Cs4.Services.Products;
using System.Web.Mvc;

namespace Fsd.Artur.Cs4.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController()
        {
            _productService = new ProductService();
        }

        public ActionResult Index()
        {
            ViewBag.count = _productService.GetProductCount();

            return View(ViewBag.count);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Artur Mazela";

            return View();
        }
    }
}