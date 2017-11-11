using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Janus.Damian.Cs.Ex2.Domain.Animals
{
    class Cat : Animal, ISound
    {
        public Cat(string name) : base(name) { }

        public string MakeSound()
        {
            return $"{GetWelcome()}, Mrrr mrr.";
        }
    }
}
