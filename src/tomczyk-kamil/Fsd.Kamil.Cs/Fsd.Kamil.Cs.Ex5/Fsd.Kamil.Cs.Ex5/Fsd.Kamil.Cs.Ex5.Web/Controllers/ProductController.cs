using Fsd.Kamil.Cs.Ex5.Domain.Api.Entities;
using Fsd.Kamil.Cs.Ex5.Models.Products;
using Fsd.Kamil.Cs.Ex5.Domain.Services.Products;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Fsd.Kamil.Cs.Ex5.Web.Mappings;
using Fsd.Kamil.Cs.Ex5.Domain.Services.SQL;

namespace Fsd.Kamil.Cs.Ex5.Web.Controllers
{
    public class ProductController : Controller
    {
        private IManualProductService _productService;

        public ProductController()
        {
            _productService = new ManualProductService();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product(int? page, int? items)
        {
            IEnumerable<Product> products = _productService.GetProducts(page, items);

            ProductListModel list = new ProductListModel
            {
                Products = products.Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    ProductionDate = entity.ProductionDate,
                    Type = entity.Type
                })
            };
            return View(list);
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
        public ActionResult Add(ProductModel productModel, SqlProductServices sql, Product product)
        {
            if (!ModelState.IsValid)
                return View(productModel);

            if (!_productService.TryAddProduct(productModel.Producer, productModel.Model, productModel.Price, productModel.ProductionDate, productModel.Type))
            {
                ModelState.Clear();
                productModel.ProductAddFailed = true;
                return View(productModel);
            }

            sql.SQLQuery(product);

            return RedirectToAction("SuccessMessage");
        }

        [HttpGet]
        public ActionResult SuccessMessage()
        {
            return View();
        }
    }
}