using Fsd.Artur.Cs4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Artur.Cs4.Models.Products
{
    public class ConvertModel
    {
        public ProductListModel Convert (ProductListModel model, IEnumerable<Product> products)
        {
            List<ProductModel> list = new List<ProductModel>();

            foreach (var variable in products)
            {
                ProductModel productModel = new ProductModel
                {
                    Id = variable.Id,
                    Producer = variable.Producer,
                    Model = variable.Model,
                    Price = variable.Price,
                    ProductionDate = variable.ProductionDate,
                    Type = variable.Type,
                };

                list.Add(productModel);
            }

            model.Products = list;

            return model;
        }
    }
}