using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.Animals
{
    public class Pig : Animal
    {
        public Pig(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Chrum Chrum Chrum.";
        }
    }
}
