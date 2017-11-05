using System.Collections.Generic;
using System.Linq;
using Weekend3.Data.Entities;

namespace Weekend3.Services.Services
{
    public class Farm : IFarm
    {
        private List<Animal> _animals;

        public Farm()
        {
            _animals = new List<Animal>();
        }

        public void AddNewAnimals(IEnumerable<Animal> animals)
        {
            _animals.AddRange(animals);
        }

        public IEnumerable<string> IntroduceAllAnimals()
        {
            return _animals.Select(animal => animal.SayHello());
        }
    }
}