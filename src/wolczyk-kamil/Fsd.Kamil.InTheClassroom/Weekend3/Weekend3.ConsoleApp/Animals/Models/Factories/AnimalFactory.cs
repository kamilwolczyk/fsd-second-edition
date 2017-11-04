using System;
using System.Collections.Generic;
using Weekend3.ConsoleApp.Animals.Models.Entities;
using Weekend3.ConsoleApp.Animals.Models.Enums;

namespace Weekend3.ConsoleApp.Animals.Models.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public List<Animal> CreateAnimals(AnimalSpecies species, string[] names)
        {
            List<Animal> list = new List<Animal>();

            foreach (string name in names)
                CreateAnimal(species, name);

            return list;
        }

        public Animal CreateAnimal(AnimalSpecies species, string name)
        {
            switch (species)
            {
                case AnimalSpecies.Cat:
                    return new Cat(name);
                case AnimalSpecies.Dog:
                    return new Dog(name);
                default:
                    throw new NotImplementedException("Class for selected species has not been found");
            }
        }
    }
}