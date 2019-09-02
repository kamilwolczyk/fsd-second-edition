using System;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public class Fruits : ProductFrame
    {
        public Fruits(int id, string model, string manufacter, decimal price, DateTime dateOfProducktion) : base(id, ProductType.Fruits, model, manufacter, dateOfProducktion, price) { }
    }
}