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
        public void MakeSomeNoise(List<string>[] _animals )
        {
            for(int i=0; i<4; i++)
            {
                for(int y=0; y<_animals[i].Count; y++)
                {
                    if(i==0)
                    {
                        Cat Cat = new Cat(_animals[i][y]);
                        Console.WriteLine(Cat.MakeNoise());

                    }
                    if (i == 1)
                    {
                        Dog Dog = new Dog(_animals[i][y]);
                        Console.WriteLine(Dog.MakeNoise());

                    }
                    if (i == 2)
                    {
                        Cow Cow = new Cow(_animals[i][y]);
                        Console.WriteLine(Cow.MakeNoise());

                    }
                    if (i == 3)
                    {
                        Pig Pig = new Pig(_animals[i][y]);
                        Console.WriteLine(Pig.MakeNoise());

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
