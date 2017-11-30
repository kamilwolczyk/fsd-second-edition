using Fsd.Kamil.Cs.Ex5.Models.Products;
using Fsd.Kamil.Cs.Ex5.Domain.Services.Products;
using System.Linq;
using System.Web.Mvc;
using Fsd.Kamil.Cs.Ex5.Web.Mappings;
using Fsd.Kamil.Cs.Ex5.Domain.Services.SQL;

namespace Fsd.Kamil.Cs.Ex5.Web.Controllers
{
    public class ProductController : Controller
    {
        private IManualProductService _productService;

        public ProductController(IManualProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            ProductListModel list = new ProductListModel
            {
                Products = _productService.GetAllProducts().Select(entity => ProductMapper.ToModel(entity))
            };

            return View(list);
        }

        public ActionResult Details(string model)
        {
            return View(ProductMapper.ToModel(_productService.GetProductByModel(model)));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new ProductModel());
        }

        [HttpPost]
        public ActionResult Add(ProductModel productModel)
        {
            if (!ModelState.IsValid)
                return View(productModel);

            SqlProductServices.SQLQuery(productModel.Producer, productModel.Model, productModel.Price, productModel.ProductionDate, productModel.Type);
            
            return RedirectToAction("SuccessMessage");
        }

        [HttpGet]
        public ActionResult SuccessMessage()
        {
            return View();
        }
    }
}