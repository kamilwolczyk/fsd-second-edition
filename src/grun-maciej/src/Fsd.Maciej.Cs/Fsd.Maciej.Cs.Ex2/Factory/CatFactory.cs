using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    internal class CatFactory
    {
        public List<Cat> MakeAnimal()
        {
            int howManyAnimal;

            string nameForAnimal;

            Console.Write("\nhow many cats do you need? ");

            howManyAnimal = int.Parse(Console.ReadLine());

            List<Cat> CatList = new List<Cat>();

            for (int i = 0; i < howManyAnimal; i++)
            {
                Console.Write("cat name: ");
                nameForAnimal = Console.ReadLine();
                CatList.Add(new Cat { Name = nameForAnimal });
            }
            return CatList;
        }

        public void View(List<Cat> catsList)
        {
            foreach (Cat acat in catsList)
                Console.WriteLine(acat.AbautMe());
            
        }
    }
}