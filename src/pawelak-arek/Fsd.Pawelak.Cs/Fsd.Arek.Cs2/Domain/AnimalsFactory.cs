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
                        AnimalList.Add(new Dog($"dog{i}"));
                        break;
                    case AnimalType.Cat:
                        AnimalList.Add(new Cat($"cat{i}"));
                        break;
                    case AnimalType.Cow:
                        AnimalList.Add(new Cow($"cow{i}"));
                        break;
                    case AnimalType.Pig:
                        AnimalList.Add(new Pig($"pig{i}"));
                        break;
                    default:
                        break;
                }
            }
        }

        public List<string> PresentAnimals(AnimalType animalsType)
        {
            List<string> nameAnimals = new List<string>();

            foreach (Animal animal in AnimalList)
            {
                switch (animalsType)
                {
                    case AnimalType.Dog:
                        if (animal is Dog)
                            nameAnimals.Add($"{AnimalType.Dog} name: {animal.Name}");
                        break;
                    case AnimalType.Cat:
                        if (animal is Cat)
                            nameAnimals.Add($"{AnimalType.Cat} name: {animal.Name}");
                        break;
                    case AnimalType.Cow:
                        if (animal is Cow)
                            nameAnimals.Add($"{AnimalType.Cow} name: {animal.Name}");
                        break;
                    case AnimalType.Pig:
                        if (animal is Pig)
                            nameAnimals.Add($"{AnimalType.Pig} name: {animal.Name}");
                        break;
                    default:
                        break;
                }
            }
            return nameAnimals;
        }
    }
}
