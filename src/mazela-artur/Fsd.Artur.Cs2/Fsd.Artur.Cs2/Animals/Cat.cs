using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Miau Miau Miau.";
        }
    }
}
