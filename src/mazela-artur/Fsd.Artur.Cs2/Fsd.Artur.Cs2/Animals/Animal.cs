using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.Animals
{
    public class Animal
    {
        private string _name;

        protected Animal(string name)
        {
            _name = name;
        }

        protected string SayHello()
        {
            return $"Hello, my name is {_name}";
        }
    }
}
