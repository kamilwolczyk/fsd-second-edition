using System;

namespace Fsd.Artur.Cs2.ConsoleActions.Writers
{
    public class AnimalWriter : IAnimalWriter
    {
        public void ShowAnimals(INoise animal)
        {
            Console.WriteLine(animal.MakeNoise());
        }
    }
}
