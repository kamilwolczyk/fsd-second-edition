using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    public enum AnimalType
    {
        cat = 1,
        cow,
        dog,
        sheep,
    }

    partial class Program
    {
        private static void Main(string[] args)
        {
            Introduction.ViewHeader();

            GetAnimalName animalName = new GetAnimalName();

            AnimalFactory newCat = new AnimalFactory();
            int animalType = (int)AnimalType.cat;
            List<Animal> myList = newCat.MakeAnimal(animalType, animalName.GetName(animalType));

            AnimalFactory newDog = new AnimalFactory();
            animalType = (int)AnimalType.dog;
            myList.AddRange(newDog.MakeAnimal(animalType, animalName.GetName(animalType)));

            AnimalFactory newCow = new AnimalFactory();
            animalType = (int)AnimalType.cow;
            myList.AddRange(newCow.MakeAnimal(animalType, animalName.GetName(animalType)));

            AnimalFactory newSheep = new AnimalFactory();
            animalType = (int)AnimalType.sheep;
            myList.AddRange(newSheep.MakeAnimal(animalType, animalName.GetName(animalType)));

            PresentMyAnimals.Show(myList);
            Console.ReadKey();
        }
    }
}