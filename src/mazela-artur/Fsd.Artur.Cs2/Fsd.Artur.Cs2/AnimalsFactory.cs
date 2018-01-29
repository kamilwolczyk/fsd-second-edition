using Fsd.Artur.Cs2.Animals;
using Fsd.Artur.Cs2.ConsoleActions.Readers;
using System;
using System.Collections.Generic;

namespace Fsd.Artur.Cs2
{
    public class AnimalsFactory
    {
        private IAnimalReader _readAnimal;

        public AnimalsFactory(IAnimalReader readAnimal)
        {
            _readAnimal = readAnimal;
        }

        public List<INoise> GenerateAnimals()
        {
            List<INoise> animals = new List<INoise>();
            animals.AddRange(GenerateListOfAnimals<Cat>("Cat"));
            animals.AddRange(GenerateListOfAnimals<Dog>("Dog"));
            animals.AddRange(GenerateListOfAnimals<Cow>("Cow"));
            animals.AddRange(GenerateListOfAnimals<Pig>("Pig"));
            return animals;
        }

        private List<INoise> GenerateListOfAnimals<INoise>(string animalName) 
        {
            int animalNumber = _readAnimal.GetCount(animalName);

            List<INoise> animals = new List<INoise>();

            for (int i = 0; i < animalNumber; i++)
                animals.Add((INoise)Activator.CreateInstance(typeof(INoise), _readAnimal.GetName(animalName)));

            return animals;
        }
    }
}
