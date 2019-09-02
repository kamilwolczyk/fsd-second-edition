using System;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public class Cigarets : ProductFrame
    {
        public Cigarets(int id, string model, string manufacter, decimal price, DateTime dateOfProducktion) : base(id, ProductType.Cigarets, model, manufacter, dateOfProducktion, price) { }
    }
}