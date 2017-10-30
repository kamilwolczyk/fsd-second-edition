using Fsd.Artur.Cs2.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.ConsoleActions.Writers
{
    class EndMessage
    {
        public void MakeNoise(List<string>[] animals )
        {
            for(int i=0; i<4; i++)
            {
                for(int y=0; y<animals[i].Count; y++)
                {
                    if(i==0)
                    {
                        Cat Cat = new Cat(animals[i][y]);
                        Console.WriteLine(Cat.MakeNoise());

                    }
                    if (i == 1)
                    {
                        Dog Dog = new Dog(animals[i][y]);
                        Console.WriteLine(Dog.MakeNoise());

                    }
                    if (i == 2)
                    {
                        Cow Cow = new Cow(animals[i][y]);
                        Console.WriteLine(Cow.MakeNoise());

                    }
                    if (i == 3)
                    {
                        Pig Pig = new Pig(animals[i][y]);
                        Console.WriteLine(Pig.MakeNoise());

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
