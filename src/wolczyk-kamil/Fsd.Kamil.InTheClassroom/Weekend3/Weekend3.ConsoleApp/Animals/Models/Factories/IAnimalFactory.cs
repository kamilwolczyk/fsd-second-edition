using System.Collections.Generic;
using Weekend3.ConsoleApp.Animals.Models.Entities;
using Weekend3.ConsoleApp.Animals.Models.Enums;

namespace Weekend3.ConsoleApp.Animals.Models.Factories
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal(AnimalSpecies species, string name);

        List<Animal> CreateAnimals(AnimalSpecies species, string[] names);
    }
}