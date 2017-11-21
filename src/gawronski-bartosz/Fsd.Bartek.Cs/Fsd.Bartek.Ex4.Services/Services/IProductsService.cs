using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Data.Enums;
using System.Collections.Generic;

namespace Fsd.Bartek.Ex4.Services.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetProducts(int page, int items);

        Product GetProductByIdNumber(int id);

        void AddProduct(string producer, string model, double price, string productionDate, int Type);

        bool DateCheck(string date);
    }
}


