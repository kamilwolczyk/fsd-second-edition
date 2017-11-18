using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Services.Products;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Sebastian.Cs.Ex4.Web.Models.Products
{
    public class ProductListModel
    {
        private IProductProvider _productProvider;

        public IEnumerable<ProductModel> Products { get; set; }

        public ProductListModel()
        {
            _productProvider = new SampleProductProvider();

            IEnumerable<Product> products = _productProvider.GetAllProducts();

            Products = products.Select(entity => new ProductModel
            {
                Producer = entity.Producer,
                Model = entity.Model,
                Price = entity.Price,
                Date = entity.Date,
                Type = entity.Type
            });
        }
    }
}