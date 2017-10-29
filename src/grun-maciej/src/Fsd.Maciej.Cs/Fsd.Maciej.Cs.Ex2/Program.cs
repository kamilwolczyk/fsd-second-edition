using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Introduction.ViewHeader();

            CatFactory newCat = new CatFactory();
            List<Cat> catList = newCat.MakeAnimal();

            CowFactory newCow = new CowFactory();
            List<Cow> cowList = newCow.MakeAnimal();

            DogFactory newDog = new DogFactory();
            List<Dog> dogList = newDog.MakeAnimal();

            SheepFactory newSheep = new SheepFactory();
            List<Sheep> sheepList = newSheep.MakeAnimal();

            newCat.View(catList);
            newCow.View(cowList);
            newDog.View(dogList);
            newSheep.View(sheepList);

            Console.ReadKey();
        }
        static class Introduction
        {
            public static  void ViewHeader()
            {
                Console.WriteLine("Exercise 2");
                Console.WriteLine("------------------------------------------");
            }


        }
    }
}