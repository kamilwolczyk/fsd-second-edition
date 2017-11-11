using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductProvider _productProvider;

        public ProductsController()
        {
            _productProvider = new SampleProductProvider();
        }

        public ActionResult Products(int? page, int? items)
        {
            IEnumerable<Product> products = _productProvider.GetAllProducts();

            ProductListModel list = new ProductListModel
            {
                Products = products.Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    Date = entity.Date,
                    Type = entity.Type
                })
            };

            int pageNumber = (page ?? 1);
            int pageSize = items ?? list.Products.Count();

            var pagedList = list.Products.ToPagedList(pageNumber, pageSize);

            ViewBag.OnePageOfProducts = pagedList;
            ViewBag.PageSize = pagedList.PageSize;
            ViewBag.ProductsCount = list.Products.Count();
            return View();
        }
    }
}