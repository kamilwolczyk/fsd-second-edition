using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Sebastian.Cs.Ex4.Services.Products
{
    public class SampleProductProvider : IProductProvider
    {
        private IEnumerable<Product> _productList = new List<Product>
        {
            new Product("Fender", "Stratocaster", 517, new DateTime(2010, 5, 26), ProductType.ElectricGuitar),
            new Product("Epiphone", "Les Paul", 429, new DateTime(2005, 12, 1), ProductType.ElectricGuitar),
            new Product("Fender", "Mustang", 475, new DateTime(1997, 3, 12), ProductType.ElectricGuitar),

            new Product("Martin", "D-18", 2299, new DateTime(2008, 12, 18), ProductType.AcousticGuitar),
            new Product("Ibanez", "PF15", 145, new DateTime(2015, 5, 18), ProductType.AcousticGuitar),
            new Product("Fender", "ESC105", 96, new DateTime(2012, 11, 18), ProductType.AcousticGuitar),

            new Product("Rickenbacker", "4003", 2359, new DateTime(1988, 6, 21), ProductType.BassGuitar),
            new Product("Rickenbacker", "4004L", 2689, new DateTime(2001, 10, 13), ProductType.BassGuitar),
            //new Product("Yamaha", "RBX4A2", 511, new DateTime(2015, 10, 29), ProductType.BassGuitar),
            //new Product("Yamaha", "BB 235", 313, new DateTime(2016, 9, 25), ProductType.BassGuitar),
            //new Product("Yamaha", "TRBX174", 171, new DateTime(2013, 4, 2), ProductType.BassGuitar),
            //new Product("Fender", "Precision", 613, new DateTime(1999, 10, 12), ProductType.BassGuitar),
            //new Product("Fender", "Jazz", 613, new DateTime(2002, 12, 16), ProductType.BassGuitar),
            //new Product("Ibanez", "SR300", 299, new DateTime(2012, 1, 30), ProductType.BassGuitar),

            //new Product("Pearl", "S1330", 179, new DateTime(2000, 12, 23), ProductType.Drum),
            //new Product("Ludwig", "LM402T", 710, new DateTime(1989, 2, 3), ProductType.Drum),

            //new Product("Yamaha", "EZ220", 169, new DateTime(2012, 11, 6), ProductType.Keyboard),
            //new Product("Casio", "CTK-1500", 119, new DateTime(2005, 5, 15), ProductType.Keyboard),
            //new Product("KORG", "microARRANGER", 499, new DateTime(2017, 1, 26), ProductType.Keyboard),

            //new Product("Shure", "PGA48", 42, new DateTime(2009, 11, 15), ProductType.Microphone),
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        public int GetProductsCount()
        {
            return _productList.Count();
        }

        public Product GetSelectedProduct(string producer, string model)
        {
            return _productList.First(product => (product.Producer==producer && product.Model == model));
        }
    }
}
