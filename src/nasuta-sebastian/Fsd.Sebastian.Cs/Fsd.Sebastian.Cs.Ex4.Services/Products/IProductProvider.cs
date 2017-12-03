using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs.Ex4.Services.Products
{
    public interface IProductProvider
    {
        IEnumerable<Product> GetAllProducts();

        int GetProductsCount();

        Product GetSelectedProduct(string producer, string model);
    }
}
