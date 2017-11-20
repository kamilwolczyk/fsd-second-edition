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
                    Id = 1,
                    Producer = "Lenovo",
                    Model = "Z51",
                    Price = 2000,
                    ProductionData = "20.02.2017",
                    Type = ProductsType.Computer
                },
                new Product
                {
                    Id = 2,
                    Producer = "Lenovo",
                    Model = "Z50",
                    Price = 2100,
                    ProductionData = "2.02.2016",
                    Type = ProductsType.Computer
                },
                new Product
                {
                    Id = 3,
                    Producer = "Xiaomi",
                    Model = "Mi5",
                    Price = 2200,
                    ProductionData = "1.02.2015",
                    Type = ProductsType.Phone
                },
                new Product
                {
                    Id = 4,
                    Producer = "Alicja w Krainie Czarów",
                    Price = 2300,
                    ProductionData = "21.05.2014",
                    Type = ProductsType.Book
                },
                new Product
                {
                    Id = 5,
                    Producer = "Office",
                    Model = "2015",
                    Price = 2400,
                    ProductionData = "30.10.2013",
                    Type = ProductsType.Software
                },
                new Product
                {
                    Id = 6,
                    Producer = "JBL",
                    Model = "VTX12",
                    Price = 2500,
                    ProductionData = "12.02.2012",
                    Type = ProductsType.HeadPhones
                },
            };
        }

        public IEnumerable<Product> GetProducts(int page, int items )
        {
            List<Product> products = Products();

            if (page == 0 || items == 0)
            {
                page = 0;
                items = products.Count();
            }

            return products.Skip(page == 0 ? page : (page - 1) * items).Take(items);            
        }

        public Product GetProductByIdNumber(int id)
        {
            return Products().FirstOrDefault(product => product.Id == id);
        }
    }
}
