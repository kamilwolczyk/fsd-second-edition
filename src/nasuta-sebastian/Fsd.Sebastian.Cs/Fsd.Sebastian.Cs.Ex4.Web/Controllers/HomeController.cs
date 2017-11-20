using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Web.Mappings;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductProvider _productProvider;

        public HomeController(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        public ActionResult Index()
        {
            return View(_productProvider.GetProductsCount());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}