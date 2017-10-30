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
    public class CreateAnimals
    {
        private IAnimalReader _readAnimal;

        public CreateAnimals(IAnimalReader readAnimal)
        {
            _readAnimal = readAnimal;
        }

        public List<string>[] CreatListOfAnimals()
        {
            List<string>[] animals = new List<string>[4];
            animals[0] = Animal("Cat");
            animals[1] = Animal("Dog");
            animals[2] = Animal("Cow");
            animals[3] = Animal("Pig");
            return animals;
        }

        private List<string> Animal(string animalName)
        {
            int animalNumber = _readAnimal.GetCount(animalName);
            List < string > animals = new List<string>();

            for (var i = 0; i < animalNumber; i++)
            {
                animals.Add(_readAnimal.GetName(animalName));
            }

           return animals;
        }
    }
}
