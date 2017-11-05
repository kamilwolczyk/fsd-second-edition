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



            ConsoleMessages.Start();

            ConsoleAnimalReader animalReader = new ConsoleAnimalReader();
            AnimalsFactory animalsCreator = new AnimalsFactory(animalReader);
            List<string>[] animals = animalsCreator.CreatListOfAnimals();

            AnimalsPresenter animal = new AnimalsPresenter();
            animal.ShowAnimals(animals);
        }
    }
}
