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
    public class AnimalsFactory
    {
        private IAnimalReader _readAnimal;

        public AnimalsFactory(IAnimalReader readAnimal)
        {
            _readAnimal = readAnimal;
        }

        public List<string>[] CreatListOfAnimals()
        {
            List<string>[] animals = new List<string>[4];
            animals[0] = GetAnimalNames("Cat");
            animals[1] = GetAnimalNames("Dog");
            animals[2] = GetAnimalNames("Cow");
            animals[3] = GetAnimalNames("Pig");
            return animals;
        }

        private List<string> GetAnimalNames(string animalName)
        {
            int animalNumber = _readAnimal.GetCount(animalName);
            List<string> animals = new List<string>();

            for (var i = 0; i < animalNumber; i++)
            {
                animals.Add(_readAnimal.GetName(animalName));
            }

            return animals;
        }
    }
}
