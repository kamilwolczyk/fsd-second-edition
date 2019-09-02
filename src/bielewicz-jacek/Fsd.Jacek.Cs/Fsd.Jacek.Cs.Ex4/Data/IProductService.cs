using System.Collections.Generic;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public interface IProductService
    {
        ProductFrame GetById(int productId);

        IEnumerable<ProductFrame> GetAllProducts();

        int GetProductCount();
    }
}
