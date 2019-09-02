using System;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public class Fish : ProductFrame
    {
        public Fish(int id, string model, string manufacter, decimal price, DateTime dateOfProducktion) : base(id, ProductType.Fish, model, manufacter, dateOfProducktion, price) { }
    }
}