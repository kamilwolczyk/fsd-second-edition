using Fsd.Kamil.Cs.Ex4.Data.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Fsd.Kamil.Cs.Ex4.Services.Products
{
    public class MockProductService : IProductService
    {
        private IEnumerable<ProductBase> _products = new List<ProductBase>
        {
            new Monitor(1, "Benq", "GL2460", 499, new DateTime(2013,12,1)),
            new Monitor(2, "Sony", "Bravia", 1499, new DateTime(2016,8,12)),
            new Mouse(3, "Logitech", "M175", 49, new DateTime(2015,1,10)),
            new Notebook(4, "MSI", "FL62", 4250, new DateTime(2016,9,19)),
            new Notebook(5, "Apple", "Macbook Pro", 8400, new DateTime(2016,2,11)),
            new Keyboard(6, "Logitech", "K120", 109, new DateTime(2012,2,1)),
            new Tablet(7, "Samsung", "Galaxy Tab", 850, new DateTime(2016,3,30)),
            new Notebook(8, "Dell", "Inspiron", 5000, new DateTime(2017,2,7))
        };


        public IEnumerable<ProductBase> GetAllProducts()
        {
            return _products;
        }

        public ProductBase GetById(int productId)
        {
            return _products.FirstOrDefault(product => product.Id == productId);
        }

        public int GetProductCount()
        {
            return _products.Count();
        }
    }
}
