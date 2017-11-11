using Fsd.Janus.Damian.Cs.Ex4.Models.Products;
using Fsd.Janus.Damian.Data.Entities;
using Fsd.Janus.Damian.Services.Services.Products;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Janus.Damian.Cs.Ex4.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController()
        {
            _productService = new FakeProductService();
        }

        public ActionResult Index(int? page)
        {
            IEnumerable<Product> products = _productService.GetProducts();

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