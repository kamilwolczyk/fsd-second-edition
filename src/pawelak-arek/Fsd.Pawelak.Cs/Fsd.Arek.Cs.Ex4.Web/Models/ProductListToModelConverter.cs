using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Arek.Cs.Ex4.Web.Models
{
    public class ProductListToModelConverter
    {
        public static ProductListModel Convert(IEnumerable<Product> ProductList)
        {
            ProductListModel productList = new ProductListModel
            {
                Products = ProductList.Select(entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Price = entity.Price,
                    Type = entity.Type,
                    DateOfProduction = entity.DateOfProduction
                })
            };
            return productList;
        }
    }
}