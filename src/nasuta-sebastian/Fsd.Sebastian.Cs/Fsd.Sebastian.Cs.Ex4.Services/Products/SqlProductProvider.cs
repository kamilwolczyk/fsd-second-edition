using Fsd.Sebastian.Cs.Ex4.Data.Entities;
using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Fsd.Sebastian.Cs.Ex4.Services.Products
{
    public class SqlProductProvider : IProductProvider
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=music_equipment;User Id=sa;Password=lubieplacki;";

        private IEnumerable<Product> _productList = new List<Product>
        {
            
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        public int GetProductsCount()
        {
            return _productList.Count();
        }

        public Product GetSelectedProduct(string producer, string model)
        {
            throw new NotImplementedException();
        }
    }
}