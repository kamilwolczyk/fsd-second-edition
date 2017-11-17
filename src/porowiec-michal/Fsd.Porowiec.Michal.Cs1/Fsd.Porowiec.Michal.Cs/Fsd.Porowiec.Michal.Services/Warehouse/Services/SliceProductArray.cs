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
        public static IEnumerable<Product> SliceProducts(string page, string items)
        {
            List<Product> _productArray = Warehouseman.GetProducts();

            List<Product> finalPage = new List<Product>();

            int lowestIndex = Int32.Parse(items) * (Int32.Parse(page) - 1);

            for (int i = lowestIndex; i <= lowestIndex + (Int32.Parse(items) - 1); i++)
                finalPage.Add(_productArray[i]);

            return finalPage;
        }
    }
}
