using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fsd.Arek.Cs.Ex4.Services.Services;
using Fsd.Arek.Cs.Ex4.Data.Entities;
using Fsd.Arek.Cs.Ex4.Web.Models;

namespace Fsd.Arek.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        private IWarehause _warehause;

        public ProductController()
        {
            _warehause = new Warehause();
        }

        public ActionResult List(int? page, int? items)
        {
            IPaginationPage<Product> paginationList = new Pagination<Product>();
            IEnumerable<Product> listproduct;

            if (page != null && items != null)
                listproduct = paginationList.CreatePagePositionList(_warehause.GetAllProducts(), (int)page, (int)items);
            else
                listproduct = _warehause.GetAllProducts();
            
            return View(ProductListToModelConverter.Convert(listproduct));
        }
    }
}