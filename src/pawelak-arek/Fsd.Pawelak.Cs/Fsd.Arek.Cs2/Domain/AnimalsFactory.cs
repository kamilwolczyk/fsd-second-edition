using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs2.Domain
{
    public class AnimalsFactory
    {
        public List<Animal> AnimalList { get; set; } = new List<Animal>();

        public void CreateAnimalsInFactory(int numberOfAnimal, AnimalType animalsType)
        {
            for (int i = 1; i <= numberOfAnimal; i++)
            {
                switch (animalsType)
                {
                    case AnimalType.Dog:
                        AnimalList.Add(new Dog($"dog{i}", animalsType));
                        break;
                    case AnimalType.Cat:
                        AnimalList.Add(new Cat($"cat{i}", animalsType));
                        break;
                    case AnimalType.Cow:
                        AnimalList.Add(new Cow($"cow{i}", animalsType));
                        break;
                    case AnimalType.Pig:
                        AnimalList.Add(new Pig($"pig{i}", animalsType));
                        break;
                    default:
                        break;
                }
            }
        }

        public IEnumerable<string> PresentAnimals(AnimalType animalType)
        {
            return AnimalList.Where(x => x.AnimalType == animalType).Select(x => x.GetPresenterAnimal());
        }
    }
}
