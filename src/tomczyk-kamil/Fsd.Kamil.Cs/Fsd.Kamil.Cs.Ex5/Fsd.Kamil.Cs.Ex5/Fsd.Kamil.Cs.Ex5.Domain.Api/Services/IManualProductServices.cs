using Fsd.Kamil.Cs.Ex5.Domain.Api.Entities;
using Fsd.Kamil.Cs.Ex5.Domain.Api.Enums;
using System;
using System.Collections.Generic;

namespace Fsd.Kamil.Cs.Ex5.Domain.Services.Products
{
    public interface IManualProductService
    {
        IEnumerable<Product> GetProducts(int? page, int? items);

        IEnumerable<Product> GetAllProducts();

        Product GetProductByModel(string model);

        int GetProductsCount();

        bool TryAddProduct(string producer, string model, string price, DateTime productionDate, ProductTypes type);
    }
}
