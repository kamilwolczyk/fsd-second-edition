using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public interface IWarehause
    {
        int GetProductCount();

        IEnumerable<Product> GetAllProducts();
    }
}
