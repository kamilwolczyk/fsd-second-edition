using Fsd.Sebastian.Cs2.Animals;
using System;
using System.Collections.Generic;

namespace Fsd.Sebastian.Cs2
{
    public class AnimalFactory
    {
        private List<Animal> _animals;

        private int numberOfAnimals;

        private string animalType;

        public void Start()
        {
            _animals = new List<Animal>();

            animalType = "cat";
            numberOfAnimals = SetAnimalsCount(animalType);
            for (int i = 0; i < numberOfAnimals; i++)
                _animals.Add(new Cat(ConsolePresenter.GetString($"{animalType} name: ")));

            animalType = "dog";
            numberOfAnimals = SetAnimalsCount(animalType);
            for (int i = 0; i < numberOfAnimals; i++)
                _animals.Add(new Dog(ConsolePresenter.GetString($"{animalType} name: ")));

            animalType = "cow";
            numberOfAnimals = SetAnimalsCount(animalType);
            for (int i = 0; i < numberOfAnimals; i++)
                _animals.Add(new Cow(ConsolePresenter.GetString($"{animalType} name: ")));

            animalType = "sheep";
            numberOfAnimals = SetAnimalsCount(animalType);
            for (int i = 0; i < numberOfAnimals; i++)
                _animals.Add(new Sheep(ConsolePresenter.GetString($"{animalType} name: ")));

            foreach (var animal in _animals)
            {
                ConsolePresenter.PrintString(animal.SayHello());
            }
        }

        private int SetAnimalsCount(string speciesType)
        {
            int numberOfAnimals = int.Parse(ConsolePresenter.GetString($"Insert number of {speciesType}s: "));

            return numberOfAnimals;
        }
    }
}
