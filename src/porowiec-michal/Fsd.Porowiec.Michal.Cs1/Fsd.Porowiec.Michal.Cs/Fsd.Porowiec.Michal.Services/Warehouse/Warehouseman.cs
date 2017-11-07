using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Porowiec.Michal.Data.Products;

namespace Fsd.Porowiec.Michal.Services.Warehouse
{
    public abstract class Warehouseman
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product("Mazda 6",Producer.Mazda,35000.00,"29/10/2011", ProductType.Machine),
                new Product("Chleb",Producer.Kłos,3.20,"07/11/2017", ProductType.Food),
                new Product("Tynk",Producer.Atlas,50.00,"05.06.2017",ProductType.BuildingMaterial),
                new Product("Gucci GG0084S",Producer.Gucci, 1300,"05.10.2017",ProductType.Making),
                new Product("Mazda 6",Producer.Mazda,35000.00,"29/10/2011", ProductType.Machine),
                new Product("Chleb",Producer.Kłos,3.20,"07/11/2017", ProductType.Food),
                new Product("Tynk",Producer.Atlas,50.00,"05.06.2017",ProductType.BuildingMaterial),
                new Product("Gucci GG0084S",Producer.Gucci, 1300,"05.10.2017",ProductType.Making),
                new Product("Mazda 6",Producer.Mazda,35000.00,"29/10/2011", ProductType.Machine),
                new Product("Chleb",Producer.Kłos,3.20,"07/11/2017", ProductType.Food),
                new Product("Tynk",Producer.Atlas,50.00,"05.06.2017",ProductType.BuildingMaterial),
                new Product("Gucci GG0084S",Producer.Gucci, 1300,"05.10.2017",ProductType.Making),
                new Product("Mazda 6",Producer.Mazda,35000.00,"29/10/2011", ProductType.Machine),
                new Product("Chleb",Producer.Kłos,3.20,"07/11/2017", ProductType.Food),
                new Product("Tynk",Producer.Atlas,50.00,"05.06.2017",ProductType.BuildingMaterial),
                new Product("Gucci GG0084S",Producer.Gucci, 1300,"05.10.2017",ProductType.Making)
            };
        }
    }
}
