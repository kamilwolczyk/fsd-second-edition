using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Porowiec.Michal.Data.Products;

namespace Fsd.Porowiec.Michal.Services.Warehouse.Services
{
    public abstract class SliceProductArray
    {
        public static IEnumerable<Product> SliceProducts(int page, int items)
        {
            List<Product> _productArray = Warehouseman.GetProducts();

            List<Product> finalPage = new List<Product>();

            int lowestIndex = items * (page - 1);

            for (int i = lowestIndex; i <= lowestIndex + (items - 1); i++)
                finalPage.Add(_productArray[i]);

            return finalPage;
        }
    }
}
