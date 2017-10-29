using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    class SheepFactory
    {
        public List<Sheep> MakeAnimal()
        {
            int howManyAnimal;

            string nameForAnimal;

            Console.Write("\nhow many sheep do you need? ");

            howManyAnimal = int.Parse(Console.ReadLine());

            List<Sheep> CatList = new List<Sheep>();

            for (int i = 0; i < howManyAnimal; i++)
            {
                Console.Write("sheep name: ");
                nameForAnimal = Console.ReadLine();
                CatList.Add(new Sheep { Name = nameForAnimal });
            }
            return CatList;
        }

        public void View(List<Sheep> SheepList)
        {
            foreach (Sheep acat in SheepList)
                Console.WriteLine(acat.AbautMe());

        }
    }
}