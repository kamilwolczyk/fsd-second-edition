using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Janus.Damian.Cs.Ex2.Domain
{
    abstract class Animal
    {
        string _name;

        protected Animal(string name)
        {
            _name = name;
        }

        protected string GetWelcome()
        {
            return $"Hello, my name is {_name}";
        }
    }
}
