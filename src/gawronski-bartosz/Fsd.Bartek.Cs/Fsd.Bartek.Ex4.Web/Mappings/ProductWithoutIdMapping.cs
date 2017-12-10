using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Web.Models;

namespace Fsd.Bartek.Ex4.Web.Mappings
{
    public class ProductWithoutIdMapping
    {
        public static ProductWithoutIdModel ToProductWithoutIdModel(Product entity)
        {
            return new ProductWithoutIdModel
            {
                Producer = entity.Producer,
                Model = entity.Model,
                Price = entity.Price,
                ProductionData = entity.ProductionData,
                Type = entity.Type
            };
        }
    }
}