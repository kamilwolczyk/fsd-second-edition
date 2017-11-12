using Fsd.Artur.Cs2.ConsoleActions.Readers;
using Fsd.Artur.Cs2.ConsoleActions.Writers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Artur.Cs2
{
    class Program
    {
        private static void Main(string[] args)
        {
            ConsoleMessages.Start();

            ConsoleAnimalReader animalReader = new ConsoleAnimalReader();
            AnimalWriter animalWriter = new AnimalWriter();
            AnimalsFactory animalsCreator = new AnimalsFactory(animalReader);

            List<INoise> animals = animalsCreator.GenerateAnimals();

            AnimalsPresenter farm = new AnimalsPresenter(animals.ToArray());

            farm.MakeNoise(animalWriter);

            Console.ReadKey();
        }
    }
}
