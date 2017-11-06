using Fsd.Bartek.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Bartek.Ex4.Services.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetProducts();
    }
}
