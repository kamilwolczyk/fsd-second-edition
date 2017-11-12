using Fsd.Artur.Cs4.Models.Index;
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
            IndexModel model = new IndexModel();
            model.Count = _productService.GetProductCount();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Artur Mazela";

            return View();
        }
    }
}