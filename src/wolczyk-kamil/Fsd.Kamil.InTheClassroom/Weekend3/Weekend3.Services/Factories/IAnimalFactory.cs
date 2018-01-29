using System.Collections.Generic;
using Weekend3.Data.Entities;
using Weekend3.Data.Enums;

namespace Weekend3.Services.Factories
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal(AnimalSpecies species, string name);

        List<Animal> CreateAnimals(AnimalSpecies species, string[] names);
    }
}