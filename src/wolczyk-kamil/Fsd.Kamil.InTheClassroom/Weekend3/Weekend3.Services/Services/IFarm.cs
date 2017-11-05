using System.Collections.Generic;
using Weekend3.Data.Entities;

namespace Weekend3.Services.Services
{
    public interface IFarm
    {
        void AddNewAnimals(List<Animal> animals);

        List<string> IntroduceAllAnimals();
    }
}