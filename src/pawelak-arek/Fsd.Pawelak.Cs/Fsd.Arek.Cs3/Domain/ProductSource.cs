using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs3.Domain
{
    public class ProductSource
    {
        public List<Product> GetProduct()
        {
            return new List<Product>
            {
                new Product("Lenovo Tab",950,1),
                new Product("Asus Zenfone",450,2),
                new Product("Lenovo Tab",950,1),
                new Product("Lenovo Tab",900,3),
            };
        }
    }
}
