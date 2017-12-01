using System;
using System.Collections.Generic;
using System.Linq;
namespace Fsd.Jacek.Cs.Ex4.Data
{
    public class ProductServiceImpDelivery : IProductService
    {
        private IEnumerable<ProductFrame> _productFrame = new List<ProductFrame>
        {
        new Alkohol(1, "Wodka Wyborowa", "Polmos", 28, new DateTime(2017,11,20)),
        new Alkohol(2, "Wodka Żytnia", "Polmos", 25, new DateTime(2017,11,22)),
        new Alkohol(3, "Whisky Dimple", "Dimple", 28, new DateTime(1992,11,20)),
        new Vegetable(4, "Carrot", "PGR", 28, new DateTime(2017,09,20)),
        new Cigarets(5, "Popularne", "Philip Moris", 28, new DateTime(1999,11,20)),
        new Cigarets(6, "Klubowe", "Philip Moris", 28, new DateTime(2017,11,20)),
        new Fruits(7, "Apple", "PGR", 28, new DateTime(2017,11,20)),
        new Fruits(8, "Orange", "PGR", 28, new DateTime(2017,11,20)),
        new Fruits(9, "Pinapple", "PGR", 28, new DateTime(2017,11,20)),
        new Fruits(10, "StarFruit", "PGR", 28, new DateTime(2017,11,20)),
        new Fish(11, "Shark", "Fisher", 28, new DateTime(2017,11,20)),
        new Fish(12, "Hering", "Fisher", 25, new DateTime(2017,11,22)),
        new Fish(13, "Flądra", "Fisher", 28, new DateTime(1992,11,20)),
        new Vegetable(14, "Carrot", "PGR", 28, new DateTime(2017,09,20)),
        new Cigarets(15, "Popularne", "Philip Moris", 28, new DateTime(1999,11,20)),
        new Vegetable(16, "Whisky Dimple", "PGR", 28, new DateTime(2017,11,20)),
        new Alkohol(17, "Tyskie", "SabMuller", 28, new DateTime(2017,11,20)),
        new Alkohol(18, "Lech", "SabMuller", 28, new DateTime(2017,11,20)),
        new Fruits(19, "Rosberry", "PGR", 28, new DateTime(2017,11,20)),
        new Fish(20, "Salmon", "Fisher", 28, new DateTime(2017,11,20)),
        };

        public IEnumerable<ProductFrame> GetAllProducts()
        {
            return _productFrame;
        }

        public ProductFrame GetById(int productId)
        {
            return _productFrame.FirstOrDefault(product => product.Id == productId);
        }

        public int GetProductCount()
        {
            return _productFrame.Count();
        }
    }
}