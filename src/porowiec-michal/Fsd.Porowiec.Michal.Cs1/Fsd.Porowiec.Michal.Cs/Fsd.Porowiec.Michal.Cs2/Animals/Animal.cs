 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs2.Animals
{
    abstract class Animal
    {
        public string Type { get; protected set; }
        public string Name { get; protected set; }
        public string Voice { get; set; }
        

        protected string GetVoice()
        {
            return Voice;
        }
    }
}
