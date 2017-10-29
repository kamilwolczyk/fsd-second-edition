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

            var animalReader = new AnimalReader();
            var animalsCreator = new CreateAnimals(animalReader);
            var animals = animalsCreator.CreatListOfAnimals();

            EndMessage Animal = new EndMessage();
            Animal.MakeSomeNoise(animals);
        }
    }
}
