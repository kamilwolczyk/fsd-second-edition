using Fsd.Kamil.Cs.Ex5.Domain.Api.Entities;
using Fsd.Kamil.Cs.Ex5.Models.Products;

namespace Fsd.Kamil.Cs.Ex5.Web.Mappings
{
    public class ProductMapper
    {
        public static ProductModel ToModel(Product entity)
        {
            return new ProductModel
            {
                Producer = entity.Producer,
                Model = entity.Model,
                Price = entity.Price,
                ProductionDate = entity.ProductionDate,
                Type = entity.Type
            };
        }
    }
}