using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs2.Animals
{
    class Lion : Animal
    {
        public Lion(string name)
            :base()
        {
            Name = name;
            Type = "Lion";
            Voice = "ROOOOAR";
        }
    }
}
