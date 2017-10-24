using Fsd.Bartek.Cs2.Ex2.Domain.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Cs2.Ex2.Domain
{
    class Fabric
    {
        public Cat[] Cat;

        public Dog[] Dog;

        public Pig[] Pig;

        public Cow[] Cow;

        public void FabricCat(int count)
        {
            Cat = new Cat[count];

            for (int i = 0; i < count; i++)
            {
                Cat[i] = new Animals.Cat(""); //interface method to ask name
            }
        }

        public void FabricDog(int count)
        {
            Dog = new Dog[count];

            for (int i = 0; i < count; i++)
            {
                Dog[i] = new Animals.Dog(""); //interface method to ask name
            }
        }

        public void FabricPig(int count)
        {
            Pig = new Pig[count];

            for (int i = 0; i < count; i++)
            {
                Pig[i] = new Animals.Pig(""); //interface method to ask name
            }
        }

        public void FabricCow(int count)
        {
            Cow = new Cow[count];

            for (int i = 0; i < count; i++)
            {
                Cow[i] = new Animals.Cow(""); //interface method to ask name
            }
        }
    }
}
