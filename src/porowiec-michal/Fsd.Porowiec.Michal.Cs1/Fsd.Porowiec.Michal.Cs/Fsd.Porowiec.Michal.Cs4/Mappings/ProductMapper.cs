using Fsd.Porowiec.Michal.Cs4.Models;
using Fsd.Porowiec.Michal.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Porowiec.Michal.Cs4.Mappings
{
    public class ProductMapper
    {
        public static ProductModel ToModel(Product product)
        {
            return new ProductModel()
            {
                Model = product.Model,
                Producer = product.Producer,
                Price = product.Price,
                DateOfProduction = product.DateOfProduction,
                Type = product.Type
            };
        }
    }
}