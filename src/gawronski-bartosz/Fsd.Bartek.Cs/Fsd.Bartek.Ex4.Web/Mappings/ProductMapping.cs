using Fsd.Bartek.Ex4.Data.Entities;
using Fsd.Bartek.Ex4.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Bartek.Ex4.Web.Mappings
{
    public class ProductMapping
    {
        public static ProductModel ToProductModel(Product entity)
        {
            return new ProductModel
            {
                Id = entity.Id,
                Producer = entity.Producer,
                Model = entity.Model,
                Price = entity.Price,
                ProductionData = entity.ProductionData,
                Type = entity.Type
            };
        }
    }
}