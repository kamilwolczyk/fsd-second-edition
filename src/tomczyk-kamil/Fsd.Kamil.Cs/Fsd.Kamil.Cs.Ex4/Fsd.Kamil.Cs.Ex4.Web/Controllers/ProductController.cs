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
        public ActionResult Product()
        {
            string page = Request.QueryString["page"];
            string items = Request.QueryString["items"];

            IEnumerable<Product> products = _productService.GetProducts();

            if (page == null || items == null)
            {
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
            else
            {
                ProductListModel list = new ProductListModel
                {
                    Products = _productService.SetPageItems(int.Parse(page), int.Parse(items)).Select(entity => new ProductModel
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
}