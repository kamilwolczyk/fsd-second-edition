using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Web.Mappings;
using Fsd.Sebastian.Cs.Ex4.Web.Models.PagedLists;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using PagedList;
using System.Data;
using System.Data.SqlClient;
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
            
            string connectionString = @"Server=.\SQLEXPRESS;Database=music_equipment;User Id=sa;Password=lubieplacki;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"INSERT INTO Products(Producer, Model, Price, Date, Type) VALUES('{productModel.Producer}', '{productModel.Model}', '{productModel.Price}', '{productModel.Date}', '{productModel.Type}')", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = command;

                adapter.Fill(new DataSet());

                return RedirectToAction("Products");
                                
                //    throw new System.NotImplementedException();
                

            }
                
        }
    }
}