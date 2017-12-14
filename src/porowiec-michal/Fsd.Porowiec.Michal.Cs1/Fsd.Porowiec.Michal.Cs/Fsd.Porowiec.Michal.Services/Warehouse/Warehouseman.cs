    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Porowiec.Michal.Data.Products;
using Fsd.Porowiec.Michal.Services.Warehouse.Services;

namespace Fsd.Porowiec.Michal.Services.Warehouse
{
    public class Warehouseman
    {
        //public List<Product> TakeProducts()
        //{
        //    return new List<Product>
        //    {
        //        new Product("Mazda 6","Mazda",35000.0,DateTime.Now, ProductType.Machine,1),
        //        new Product("Chleb","Mazda",3.20,DateTime.Now, ProductType.Food,1),
        //        new Product("Tynk","Mazda",50.00,DateTime.Now,ProductType.BuildingMaterial,1),
        //        new Product("Gucci GG0084S","Mazda", 1300,DateTime.Now,ProductType.Making,1),
        //        new Product("Mazda 6","Mazda",35000.00,DateTime.Now, ProductType.Machine,1),
        //        new Product("Chleb","Mazda",3.20,DateTime.Now, ProductType.Food,1)
        //    };
        //}

        //public IEnumerable<Product> GetProducts(int page, int items)
        //{
        //    List<Product> productList = TakeProducts();

        //    if (page == 0 || items == 0)
        //    {
        //        page = 0;
        //        items = productList.Count();
        //    }

        //    return productList.Skip(page == 0 ? page : (page - 1) * items).Take(items);
        //}

        //public Product GetProductByModel(string model)
        //{
        //    return (TakeProducts().First(product => product.Model == model));
        //}

        //public void AddProduct(string model, string producer, double price, string dateOfProduction, ProductType type)
        //{

        //}

        //public void AddProduct(string model, string producer, double price, DateTime dateOfProduction, ProductType type)
        //{

        //}
    }
}
