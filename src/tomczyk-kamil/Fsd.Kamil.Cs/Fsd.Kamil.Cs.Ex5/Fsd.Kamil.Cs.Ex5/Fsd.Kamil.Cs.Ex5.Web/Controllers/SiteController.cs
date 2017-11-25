using Fsd.Kamil.Cs.Ex5.Domain.Services.Products;
using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex5.Controllers
{
    public class SiteController : Controller
    {
        private readonly IManualProductService __productService;

        public SiteController(IManualProductService productService)
        {
            __productService = productService;
        }

        public ActionResult Home()
        {
            return View(__productService.GetProductsCount());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Logo()
        {
            return PartialView();
        }
    }
}