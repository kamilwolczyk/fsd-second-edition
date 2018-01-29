using Fsd.Kamil.Cs.Ex4.Data.Entities;
using Fsd.Kamil.Cs.Ex4.Models.Products;
using Fsd.Kamil.Cs.Ex4.Services.Services.Products;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex4.Web.Controllers
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

    }
}