using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.Animals
{
    public abstract class Animal
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public Animal(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public virtual string Hello()
        {
            return $"Hello, my name is {Name}{Number}, ";
        }
     }
    
}
