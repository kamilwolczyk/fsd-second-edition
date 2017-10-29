using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Hau Hau Hau.";
        }
    }
}
