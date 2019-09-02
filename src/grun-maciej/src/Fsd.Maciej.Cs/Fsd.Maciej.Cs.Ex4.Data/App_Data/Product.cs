using Fsd.Maciej.Cs.Ex4.Data;
using Fsd.Maciej.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Maciej.Cs.Ex4.Data.App_Data
{
    public class Product 
    {
        private List<Product> _products;

        public Product(string Manufacturer, string Model, decimal Price, DateTime ProductionDate, ProductType Type)
        {
            
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public ProductType Type { get; set; }

        public IEnumerable<Product> ProductsRepo()
        {
            // _products = new List<Product>();
            _products.Add(new Product(Manufacturer = "Amika", Model = "ABC-12", Price = 1250, ProductionDate = new DateTime(2008, 3, 1), Type = ProductType.WashMachine));
            _products.Add(new Product(Manufacturer = "Lenovo", Model = "ThinkPad T430", Price = 6500, ProductionDate = new DateTime(2017, 11, 1), Type = ProductType.Notebook));
            _products.Add(new Product(Manufacturer = "Kingston", Model = "Abcd-11", Price = 15, ProductionDate = new DateTime(2017, 11, 1), Type = ProductType.Mouse ));
            _products.Add(new Product(Manufacturer = "Nokia", Model = "Lumia", Price = 650, ProductionDate = new DateTime(2013, 11, 1), Type = ProductType.Phon ));
            _products.Add(new Product(Manufacturer = "Samsung", Model = "A5", Price = 1800, ProductionDate = new DateTime(2016, 11, 1), Type = ProductType.Phon ));
            _products.Add(new Product(Manufacturer = "Huawei", Model = "P10", Price = 1200, ProductionDate = new DateTime(2017, 1, 1), Type = ProductType.Phon ));
            _products.Add(new Product(Manufacturer = "Logitech", Model = "M185", Price = 65, ProductionDate = new DateTime(2015, 11, 1), Type = ProductType.Mouse ));
            _products.Add(new Product(Manufacturer = "Logitech", Model = "M285", Price = 65, ProductionDate = new DateTime(2015, 11, 1), Type = ProductType.Keyboard ));
            _products.Add(new Product(Manufacturer = "Lg", Model = "Lg2343", Price = 650, ProductionDate = new DateTime(2017, 11, 1), Type = ProductType.Monitor ));
            _products.Add(new Product(Manufacturer = "Prestigio", Model = "3333", Price = 432, ProductionDate = new DateTime(2015, 11, 1), Type = ProductType.Tablet ));


            return _products;
        }
    }
    

}