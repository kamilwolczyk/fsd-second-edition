using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fsd.Arek.Cs.Ex4.Services.Services;
using Fsd.Arek.Cs.Ex4.Data.Entities;
using Fsd.Arek.Cs.Ex4.Web.Models;
using System.Reflection;

namespace Fsd.Arek.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        private IWarehause _warehause;

        private IPaginationPage<Product> _paginationPage;

        public ProductController(IWarehause warehause)
        {
            _warehause = warehause;
        }

        public ActionResult List(int? page, int? items)
        {
            IPaginationPage<Product> paginationList = new Pagination<Product>();
            IEnumerable<Product> listproduct;

            if (page != null && items != null)
                listproduct = paginationList.CreatePagePositionList(_warehause.GetAllProducts(), (int)page, (int)items);
            else
                listproduct = _warehause.GetAllProducts();

            return View(ProductToListModelConverter.Convert(listproduct));
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel)
        {
            List<string> productValues = new List<string>();
            int i = 0;

            foreach (PropertyInfo p in productModel.GetType().GetProperties())
            {
                if (i != 0)
                    productValues.Add(Convert.ToString($"'{p.GetValue(productModel)}'"));
                i++;
            }

            if (!ModelState.IsValid)
                return View();

            _warehause.AddProduct(productValues);
            return RedirectToAction("List");
        }
    }
}