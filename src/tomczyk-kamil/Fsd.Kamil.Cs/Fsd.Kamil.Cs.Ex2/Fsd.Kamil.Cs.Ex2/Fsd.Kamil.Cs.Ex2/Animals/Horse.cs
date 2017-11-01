using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Horse : IAnimal
    {
        public string Name { get; set; }

        public string Voice()
        {
            return "Iha Iha Pfrr Pfrr";
        }
    }
}
