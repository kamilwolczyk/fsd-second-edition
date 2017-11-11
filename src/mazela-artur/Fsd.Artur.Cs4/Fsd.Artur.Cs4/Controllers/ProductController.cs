using Fsd.Artur.Cs4.Data.Entities;
using Fsd.Artur.Cs4.Models.Products;
using Fsd.Artur.Cs4.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Artur.Cs4.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public ActionResult List(int? page, int? items)
        {
            IEnumerable<Product> products = _productService.GetProducts();

            int takeItems;

            if (items == null)
            {
                takeItems = _productService.GetProductCount(); ;
            }
            else
            {
                takeItems = items.Value;
            }

            int skipPage;

            if (page == null)
            {
                skipPage = 1;
            }
            else
            {
                skipPage = page.Value;
            }

            ProductListModel model = new ProductListModel();
            List<ProductModel> list = new List<ProductModel>();

            foreach (var variable in products)
            {
                ProductModel productModel = new ProductModel
                {
                    Id = variable.Id,

                    Producer = variable.Producer,

                    Model = variable.Model,

                    Price = variable.Price,

                    ProductionDate= variable.ProductionDate,

                    Type = variable.Type,
                };

                list.Add(productModel);
            }

            model.Products = list;
            model.Take = takeItems;
            model.Skip = skipPage;

            return View(model);
        }
    }
}