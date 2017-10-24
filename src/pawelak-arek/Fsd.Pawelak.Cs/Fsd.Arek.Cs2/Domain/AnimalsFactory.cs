using Fsd.Arek.Cs2.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs2.Domain
{
    public class AnimalsFactory
    {
        // public List<Animal> AnimalList { get; set; }

        private List<Animal> _animalList = new List<Animal>();

        public List<Animal> AnimalList
        {
            get
            {
                return _animalList;
            }
            private set
            {
            }
        }

        public void CreateAnimalsInFactory(int numberOfAnimal, AnimalsType animalsType)
        {
            for (int i = 1; i <= numberOfAnimal; i++)
            {
                if (animalsType == AnimalsType.cat)
                    _animalList.Add(new Cat("cat" + i));
                else if (animalsType == AnimalsType.cow)
                    _animalList.Add(new Cow("cow" + i));
                else if (animalsType == AnimalsType.dog)
                    _animalList.Add(new Dog("dog" + i));
                else if (animalsType == AnimalsType.pig)
                    _animalList.Add(new Pig("pig" + i));
            }
        }

        public List<string> GetNameAnimals(AnimalsType animalsType)
        {
            List<string> nameAnimals = new List<string>();

            foreach (Animal animal in AnimalList)
            {
                if (animal is Cat && animalsType == AnimalsType.cat)
                    nameAnimals.Add(animal.FullPresent());
                else if (animal is Cow && animalsType == AnimalsType.cow)
                    nameAnimals.Add(animal.FullPresent());
                else if (animal is Dog && animalsType == AnimalsType.dog)
                    nameAnimals.Add(animal.FullPresent());
                else if (animal is Pig && animalsType == AnimalsType.pig)
                    nameAnimals.Add(animal.FullPresent());
            }

            return nameAnimals;
        }
    }
}
