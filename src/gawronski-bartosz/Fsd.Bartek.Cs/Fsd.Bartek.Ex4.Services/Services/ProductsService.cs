using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Ex4.Services.Services
{
    public class ProductsService : IProductsService
    {
        private List<Product> Products()
        {
            return new List<Product>
            {
                new Product
                {
                    Producer = "Lenovo",
                    Model = "Z51",
                    Price = 2000,
                    ProductionData = "20.02.2017",
                    Type = ProductsType.Computer
                },
                new Product
                {
                    Producer = "Lenovo",
                    Model = "Z50",
                    Price = 2100,
                    ProductionData = "2.02.2016",
                    Type = ProductsType.Computer
                },
                new Product
                {
                    Producer = "Xiaomi",
                    Model = "Mi5",
                    Price = 2200,
                    ProductionData = "1.02.2015",
                    Type = ProductsType.Phone
                },
                new Product
                {
                    Producer = "Alicja w Krainie Czarów",
                    Price = 2300,
                    ProductionData = "21.05.2014",
                    Type = ProductsType.Book
                },
                new Product
                {
                    Producer = "Office",
                    Model = "2015",
                    Price = 2400,
                    ProductionData = "30.10.2013",
                    Type = ProductsType.Software
                },
                new Product
                {
                    Producer = "JBL",
                    Model = "VTX12",
                    Price = 2500,
                    ProductionData = "12.02.2012",
                    Type = ProductsType.HeadPhones
                },
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products();
        }

        public IEnumerable<Product> DividedList(int page, int items)
        {
            List<Product> products = Products();

            List<Product> dividedProducts = new List<Product>();

            int firstIndex = items * (page - 1);

            int lastIndex = firstIndex + (items - 1);

            for(int i = firstIndex; i <= lastIndex; i++)
            {
                dividedProducts.Add(products[i]);
            }

            return dividedProducts;            
        }
    }
}
