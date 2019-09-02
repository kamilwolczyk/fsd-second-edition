using System;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public class Vegetable : ProductFrame
    {
        public Vegetable(int id, string model, string manufacter, decimal price, DateTime dateOfProducktion) : base(id, ProductType.Vegetable, model, manufacter, dateOfProducktion, price) { }
    }

}