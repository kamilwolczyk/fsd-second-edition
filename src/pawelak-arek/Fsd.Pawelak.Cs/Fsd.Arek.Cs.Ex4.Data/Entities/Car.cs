using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Data.Entities
{
    public class Car : Product
    {
        public Car(int id, string producer, string model, decimal price, string type, DateTime dateOfProduction) : 
            base(id, producer, model, price, type, dateOfProduction)
        {
        }
    }
}
