using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Web.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Sebastian.Cs.Ex4.Web.Mappings
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
                Date = entity.Date,
                Type = entity.Type
            };
}
    }
}