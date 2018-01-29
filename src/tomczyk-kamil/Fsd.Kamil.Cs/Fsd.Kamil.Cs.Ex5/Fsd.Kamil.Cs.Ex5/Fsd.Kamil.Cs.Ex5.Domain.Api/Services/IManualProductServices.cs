using Fsd.Kamil.Cs.Ex5.Domain.Api.Entities;
using System.Collections.Generic;

namespace Fsd.Kamil.Cs.Ex5.Domain.Services.Products
{
    public interface IManualProductService
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProductByModel(string model);

        int GetProductsCount();
    }
}
