using Fsd.Janus.Damian.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Janus.Damian.Services.Services.Products
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        int GetProductsCount();
    }
}
