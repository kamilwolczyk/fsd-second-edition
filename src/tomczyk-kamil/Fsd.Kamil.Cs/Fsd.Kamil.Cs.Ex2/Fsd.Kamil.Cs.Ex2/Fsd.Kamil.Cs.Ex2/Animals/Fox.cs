using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2.Animals
{
    public class Fox : IAnimal
    {
        public string Name { get; set; }

        public string Voice()
        {
            return "Ring Ding Ding Ding Ding";
        }
    }
}
