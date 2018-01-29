using Fsd.Sebastian.Cs.Ex4.Services.Products;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class PageController : Controller
    {
        private readonly IProductProvider _productProvider;

        public PageController(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        public ActionResult Home()
        {
            return View(_productProvider.GetProductsCount());
        }

        public ActionResult About()
        {
            return View();
        }
    }
}