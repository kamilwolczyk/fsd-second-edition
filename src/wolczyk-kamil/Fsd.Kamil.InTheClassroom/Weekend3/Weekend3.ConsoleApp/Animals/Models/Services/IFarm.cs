using System.Collections.Generic;
using Weekend3.ConsoleApp.Animals.Models.Entities;

namespace Weekend3.ConsoleApp.Animals.Models.Services
{
    public interface IFarm
    {
        void AddNewAnimals(List<Animal> animals);

        List<string> IntroduceAllAnimals();
    }
}