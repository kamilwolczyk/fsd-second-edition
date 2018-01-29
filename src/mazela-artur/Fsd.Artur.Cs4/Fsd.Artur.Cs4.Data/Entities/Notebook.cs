using Fsd.Artur.Cs4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs4.Data.Entities
{
    public class Notebook : Product
    {
        public Notebook(int id, string producer, string model, decimal price, DateTime productionDate)
            : base(id, producer, model, price, productionDate, ProductType.Notebook)
        { }
    }
}
