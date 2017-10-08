using System;
using System.Collections.Generic;
using System.Linq;
using Fsd.Kamil.Cs.Ex3.Models;

namespace Fsd.Kamil.Cs.Ex3
{
    public class StandardWarehouse : IWarehouse
    {
        private readonly IList<Product> _products;

        public StandardWarehouse()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            var existingProduct = FindProduct(product.Name);

            if (existingProduct == null)
            {
                _products.Add(product);
                return;
            }

            existingProduct.Count += product.Count;
        }

        public bool TryGetProduct(Product product)
        {
            var existingProduct = FindProduct(product.Name);

            if (existingProduct == null || existingProduct.Count < product.Count)
                throw new InvalidOperationException($"{product.Count} number of {product.Name} is not available.");

            existingProduct.Count -= product.Count;
            return true;
        }

        public IEnumerable<Product> GetAvailableProducts()
        {
            return _products;
        }

        private Product FindProduct(string name)
        {
            return _products.FirstOrDefault(product => product.Name == name);
        }
    }
}