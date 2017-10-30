using Fsd.Artur.Cs2.ConsoleActions;
using Fsd.Artur.Cs2.Animals;
using Fsd.Artur.Cs2.ConsoleActions.Readers;
using Fsd.Artur.Cs2.ConsoleActions.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2
{
    class Program
    {
        private static void Main(string[] args)
        {
            StartMessage.BeginMessage();

            AnimalReader animalReader = new AnimalReader();
            CreateAnimals animalsCreator = new CreateAnimals(animalReader);
            List<string>[] animals = animalsCreator.CreatListOfAnimals();

            EndMessage Animal = new EndMessage();
            Animal.MakeNoise(animals);
        }
    }
}
