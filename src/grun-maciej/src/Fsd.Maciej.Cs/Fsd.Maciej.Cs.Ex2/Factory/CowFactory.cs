using System;
using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    class CowFactory
    {
        public List<Cow> MakeAnimal()
        {
            int _howManyAnimal;

            string _nameForAnimal;

            Console.Write("\nhow many cows do you need? ");

            _howManyAnimal = int.Parse(Console.ReadLine());

            List<Cow> CatList = new List<Cow>();

            for (int i = 0; i < _howManyAnimal; i++)
            {
                Console.Write("cow name: ");
                _nameForAnimal = Console.ReadLine();
                CatList.Add(new Cow { Name = _nameForAnimal });
            }
            return CatList;
        }

        public void View(List<Cow> CowList)
        {
            foreach (Cow acat in CowList)
                Console.WriteLine(acat.AbautMe());

        }
    }
}