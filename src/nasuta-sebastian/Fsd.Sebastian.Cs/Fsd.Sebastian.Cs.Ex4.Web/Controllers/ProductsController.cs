﻿using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Web.Mappings;
using Fsd.Sebastian.Cs.Ex4.Web.Models.PagedLists;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductProvider _productProvider;

        public ProductsController(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        public ActionResult Products(int? page, int? items)
        {
            ProductListModel list = new ProductListModel
            {
                Products = _productProvider.GetAllProducts().Select(entity => ProductMapper.ToModel(entity))
            };

            int pageNumber = page ?? 1;
            int pageSize = items ?? list.Products.Count();

            PagedListModel pagedList = new PagedListModel
            {
                Products = list.Products.ToPagedList(pageNumber, pageSize)
            };
            
            return View(pagedList);
        }

        public ActionResult Details(string producer, string model)
        {
            return View(ProductMapper.ToModel(_productProvider.GetSelectedProduct(producer, model)));
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

            return RedirectToAction("Products");
        }
    }
}