using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    partial class Program
    {
        private static void Main(string[] args)
        {
            Introduction.ViewHeader();

            GetAnimalName animalName = new GetAnimalName();

            AnimalFactory newCat = new AnimalFactory();
            List<Animal> myList = newCat.CreateAnimal(AnimalType.Cat, animalName.GetName(AnimalType.Cat));

            AnimalFactory newDog = new AnimalFactory();
            myList.AddRange(newDog.CreateAnimal(AnimalType.Dog, animalName.GetName(AnimalType.Dog)));

            AnimalFactory newCow = new AnimalFactory();
            myList.AddRange(newCow.CreateAnimal(AnimalType.Cow, animalName.GetName(AnimalType.Cow)));

            AnimalFactory newSheep = new AnimalFactory();
            myList.AddRange(newSheep.CreateAnimal(AnimalType.Sheep, animalName.GetName(AnimalType.Sheep)));

            PresentMyAnimals.Show(myList);
            Console.ReadKey();
        }
    }
}