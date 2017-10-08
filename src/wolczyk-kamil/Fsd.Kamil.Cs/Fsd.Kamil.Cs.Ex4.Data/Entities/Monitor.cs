using Fsd.Kamil.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Kamil.Cs.Ex4.Data.Entities
{
    public class Monitor : ProductBase
    {
        public Monitor(int id, string producer, string model, decimal price, DateTime productionDate)
            : base(id, producer, model, price, productionDate, ProductType.Monitor)
        { }
    }
}
