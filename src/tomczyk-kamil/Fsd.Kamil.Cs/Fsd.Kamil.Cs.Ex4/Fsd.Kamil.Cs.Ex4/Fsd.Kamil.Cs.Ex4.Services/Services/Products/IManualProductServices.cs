using Fsd.Kamil.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Kamil.Cs.Ex4.Services.Services.Products
{
    public interface IManualProductService
    {
        IEnumerable<Product> GetProducts(int? page, int? items);
    }
}