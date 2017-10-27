using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs2.Animals
{
    class Cat :Animal
    {
        public Cat(string name)
            :base()
        {
            Name = name;
            Type = "Cat";
            Voice = "Mew Mew Mew Mew";
        }
    }
}
