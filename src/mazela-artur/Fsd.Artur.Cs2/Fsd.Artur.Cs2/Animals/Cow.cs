using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.Animals
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name)
        { }

        public string MakeNoise()
        {
            return $"{SayHello()}, Muuu Muuu Muuu.";
        }
    }
}
