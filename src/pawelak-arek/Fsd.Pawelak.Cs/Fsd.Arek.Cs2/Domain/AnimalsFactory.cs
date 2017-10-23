using Fsd.Arek.Cs2.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs2.Domain
{
    class AnimalsFactory
    {
        List<Animal> _animalList = new List<Animal>();

        public List<Cat> CatList { get; set; }

        public List<Cow> CowList { get; set; }

        public List<Dog> DogList { get; set; }

        public List<Pig> PigList { get; set; }

        public void CreateAnimalsInFactory(int numberOfAnimal, AnimalsType animalsType)
        {
            for (int i = 0; i < numberOfAnimal; i++)
            {
                if (animalsType == AnimalsType.cat)
                    _animalList.Add(new Cat("cat" + i));
                else if (animalsType == AnimalsType.cows)
                    _animalList.Add(new Cow("cow" + i));
                else if (animalsType == AnimalsType.dogs)
                    _animalList.Add(new Dog("dog" + i));
                else if (animalsType == AnimalsType.pigs)
                    _animalList.Add(new Pig("pig" + i));
            }
        }

        public void GetCatList()
        {
            foreach (Cat cat in _animalList)
                CatList.Add(cat);
        }

        public void GetCowList()
        {
            foreach (Cow cow in _animalList)
                CowList.Add(cow);
        }

        public void GetDogList()
        {
            foreach (Dog dog in _animalList)
                DogList.Add(dog);
        }

        public void GetPigList()
        {
            foreach (Pig pig in _animalList)
                PigList.Add(pig);
        }
    }
}
