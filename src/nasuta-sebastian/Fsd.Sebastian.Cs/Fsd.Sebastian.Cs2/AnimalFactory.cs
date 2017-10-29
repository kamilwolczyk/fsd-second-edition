using Fsd.Sebastian.Cs2.Animals;
using System;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs2
{
    public class AnimalFactory
    {
        private List<IAnimalPresenter> _animals;

        public void Start()
        {
            _animals = new List<IAnimalPresenter>();

            _animals.AddRange(CreateAnimals<Cat>("cat"));
            _animals.AddRange(CreateAnimals<Dog>("dog"));
            _animals.AddRange(CreateAnimals<Cow>("cow"));
            _animals.AddRange(CreateAnimals<Sheep>("sheep"));

            foreach (var animal in _animals)
            {
                ConsolePresenter.PrintString(animal.SayHello());
            }
        }

        private List<IAnimalPresenter> CreateAnimals<T>(string animalType) where T : IAnimalPresenter
        {
            List<IAnimalPresenter> animals = new List<IAnimalPresenter>();
            int numberOfAnimals = ConsolePresenter.GetInt($"Insert number of {animalType}s: ");

            for (var i = 0; i < numberOfAnimals; i++)
                animals.Add((T)Activator.CreateInstance(typeof(T), ConsolePresenter.GetString($"{animalType} name: ")));
            
            return animals;
        }
    }
}
