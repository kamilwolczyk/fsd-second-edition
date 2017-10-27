using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs2.Animals
{
    class Dog :Animal
    {
        public Dog(string name)
            :base()
        {
            Name = name;
            Type = "Dog";
            Voice = "Hau Hau Hau Hau";
        }
    }
}
