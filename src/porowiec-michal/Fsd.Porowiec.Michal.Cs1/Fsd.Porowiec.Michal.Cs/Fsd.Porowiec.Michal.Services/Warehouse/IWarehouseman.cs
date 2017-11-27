using Fsd.Porowiec.Michal.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Services.Warehouse.Services
{
    public interface IWarehouseman
    {
        IEnumerable<Product> GetProducts(int page, int items);

        List<Product> TakeProducts();
    }
}
