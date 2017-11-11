using Fsd.Janus.Damian.Data.Entities;
using Fsd.Janus.Damian.Data.Enums;
using System.Collections.Generic;

namespace Fsd.Janus.Damian.Services.Services.Products
{
    public class FakeProductService : IProductService
    {
        private List<Product> _productsList = new List<Product>
        {
            new Product("Audi", "A3", 90000, "01/01/2017", ProductType.Car),
            new Product("Renault", "megane", 70000, "01/01/2017", ProductType.Car),
            new Product("Skoda", "Rapid", 61000, "2/.03/2017", ProductType.Car),
            new Product("Ford", "Focus", 75000, "26/08/2017", ProductType.Car),
            new Product("Citroen", "C5", 80000, "20/11/2017", ProductType.Car),

            new Product("Kompania Piwowarska", "Zubr", 2.20, "01/01/2017", ProductType.Beer),
            new Product("Grupa Zywiec", "Zywiec", 3.10, "02/02/2017", ProductType.Beer),
            new Product("Kompania Piwowarska", "Grolsh", 4.20, "03/03/2017", ProductType.Beer),
            new Product("Kompania Piwowarska", "Tyskie", 2.90, "04/04/2017", ProductType.Beer),

            new Product("Stock Polska", "Zoladkowa Gorzka", 24.00, "05/05/2017", ProductType.Vodka),
            new Product("Stock Polska", "Stock Presige", 26.50, "06/06/2017", ProductType.Vodka),
            new Product("Stock Polska", "Lubelska", 19.90, "07/07/2017", ProductType.Vodka),
            new Product("Polmos Zyrardow", "Belvedere", 85.00, "08/08/2017", ProductType.Vodka),

            new Product("Apple", "IPhone X", 5000, "10/05/2017", ProductType.Phone),
            new Product("Apple", "IPhone 8", 3600, "10/05/2017", ProductType.Phone),
            new Product("Xiaomi", "Mi A1", 1100, "10/05/2017", ProductType.Phone),
            new Product("BlackBerry", "Key One", 2400, "10/05/2017", ProductType.Phone),
            new Product("Samsung", "Galaxy S8", 3300, "10/05/2017", ProductType.Phone),

            new Product("Wedel", "Pawelek", 1.40, "11/11/2011", ProductType.Snack),
            new Product("Olza", "PrincPolo", 2.00, "12/12/2012", ProductType.Snack),
        };

        public IEnumerable<Product> GetProducts()
        {
            return _productsList;
        }

        public int GetProductsCount()
        {
            return _productsList.Count;
        }
    }
}
