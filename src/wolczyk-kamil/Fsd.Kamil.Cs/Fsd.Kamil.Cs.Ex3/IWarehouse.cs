using System.Collections.Generic;
using Fsd.Kamil.Cs.Ex3.Models;

namespace Fsd.Kamil.Cs.Ex3
{
    public interface IWarehouse
    {
        void AddProduct(Product product);

        bool TryGetProduct(Product product);

        IEnumerable<Product> GetAvailableProducts();
    }
}