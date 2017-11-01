using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    public static class PresentMyAnimals
    {
        public static void Show(List<Animal> listAnimal)
        {
            foreach (Animal acat in listAnimal)
                Console.WriteLine(acat.AbautMe());
        }
    }
}