using System;

namespace Fsd.Jacek.Cs.Ex4.Data
{
    public class Alkohol : ProductFrame
    {
        public Alkohol(int id, string model, string manufacter, decimal price, DateTime dateOfProducktion) : base(id, ProductType.Alkohol, model, manufacter, dateOfProducktion, price) { }
    }
}