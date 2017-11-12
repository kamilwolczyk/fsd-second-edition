using Fsd.Artur.Cs4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs4.Services.Products
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        int GetProductCount();
    }
}
