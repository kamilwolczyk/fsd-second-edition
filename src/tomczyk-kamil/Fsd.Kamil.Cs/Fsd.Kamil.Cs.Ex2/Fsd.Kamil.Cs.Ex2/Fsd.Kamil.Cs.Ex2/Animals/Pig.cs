using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Pig : IAnimal
    {
        public string Name { get; set; }

        public string Voice()
        {
            return "Kłi Kłi Kłi";
        }
    }
}
