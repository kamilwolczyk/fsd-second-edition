using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bielewicz.Jacek.Cs2.AnimalFactory
{
    class AnimalCount
    {
        public static int ReadAnimalCount()
        {
            string animalCountString = Console.ReadLine();
            int value = 0;
            if (int.TryParse(animalCountString, out value))
            {
                return value;
            }
            return 0;
        }
    }
}
