using Fsd.Artur.Cs2.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.ConsoleActions.Writers
{
    class AnimalsPresenter
    {
        public void ShowAnimals(List<string>[] animals)
        {
            for (int i = 0; i < animals.Length ; i++)
            {
                for (int y = 0; y < animals[i].Count; y++)
                {
                    if (i == 0)
                    {
                        Cat cat = new Cat(animals[i][y]);
                        Console.WriteLine(cat.MakeNoise());

                    }
                    if (i == 1)
                    {
                        Dog dog = new Dog(animals[i][y]);
                        Console.WriteLine(dog.MakeNoise());

                    }
                    if (i == 2)
                    {
                        Cow cow = new Cow(animals[i][y]);
                        Console.WriteLine(cow.MakeNoise());

                    }
                    if (i == 3)
                    {
                        Pig pig = new Pig(animals[i][y]);
                        Console.WriteLine(pig.MakeNoise());

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
