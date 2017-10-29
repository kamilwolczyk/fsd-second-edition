using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    class DogFactory
    {
        public List<Dog> MakeAnimal()
        {
            int howManyAnimal;

            string nameForAnimal;

            Console.Write("\nhow many dogs do you need? ");

            howManyAnimal = int.Parse(Console.ReadLine());

            List<Dog> CatList = new List<Dog>();

            for (int i = 0; i < howManyAnimal; i++)
            {
                Console.Write("dog name: ");
                nameForAnimal = Console.ReadLine();
                CatList.Add(new Dog { Name = nameForAnimal });
            }
            return CatList;
        }

        public void View(List<Dog> dogList)
        {
            foreach (Dog acat in dogList)
                Console.WriteLine(acat.AbautMe());

        }

    }
}