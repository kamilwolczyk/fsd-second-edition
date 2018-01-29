using Fsd.Artur.Cs4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Artur.Cs4.Services.Products
{
    public class ProductService : IProductService
    {
        private IEnumerable<Product> _products = new List<Product>
        {
            new Notebook(1, "Alienware", "17", 6000, new DateTime(2014,1,1)),
            new Tablet(2, "Samsung", "Galaxy Tab 3", 1500, new DateTime(2015,2,2)),
            new Phone(3, "Samung", "Galaxy S8", 4000, new DateTime(2015,3,3)),
            new PC(4, "MSI", "Aerogis", 14000, new DateTime(2015,4,4)),
            new Monitor(5, "Benq", "Zowie", 1200, new DateTime(2016,5,5)),
            new Keyboard(6, "Logitech", "K300", 400, new DateTime(2016,6,6)),
            new Mouse(7, "Tracer", "Recon", 100, new DateTime(2016,7,7)),
            new Speakers(8, "Tracer", "LoudSpace", 350, new DateTime(2017,8,8)),
            new Headphones(9, "Samsung", "RDX340", 800, new DateTime(2017,9,9)),
            new Webcam(10, "Samsung", "MyWeb", 150, new DateTime(2017,10,10)),            
        };

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public int GetProductCount()
        {
            return _products.Count();
        }
    }
}
