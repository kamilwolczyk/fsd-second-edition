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

            int takeItems = (items == null) ? _productService.GetProductCount() : items.Value ;

            int skipPage = (page == null) ? 1 : page.Value;

            ProductListModel model = new ProductListModel();
            ConvertModel convert = new ConvertModel();

            model = convert.Convert(model, products);
            model.Take = takeItems;
            model.Skip = skipPage;

            return View(model);
        }
    }
}