using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Kamil.Cs.Ex2.Animals;

namespace Fsd.Kamil.Cs.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            FarmMaker newFactory = new FarmMaker();
            newFactory.NewAnimal();          
        }
    }
}
