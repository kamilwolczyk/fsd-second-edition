using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
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
            ProductListModel list = null;

            if (page == null || items == null || page <= 0 || items <= 0)
            {
                IEnumerable<Product> products = _productProvider.GetAllProducts();

                list = new ProductListModel
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

                return View(list);
            }
            else
            {
                IEnumerable<Product> products = _productProvider.GetSelectedProducts((page-1)*items, items);

                list = new ProductListModel
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

                return View("ProductsFormated", list);
            }
        }
    }
}