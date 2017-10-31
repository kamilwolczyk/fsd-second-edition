using Fsd.Bartek.Cs2.Ex2.Domain.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Bartek.Cs2.Ex2.Domain.UI;

namespace Fsd.Bartek.Cs2.Ex2.Domain
{
    public class Fabric
    {
        public List<Animal> Animals = new List<Animal>();

        public void FabricAnimal(int count, string type)
        {
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "cats":
                        Animals.Add(new Cat(ProgramUi.InsertName($"{type}")));
                        break;
                    case "dogs":
                        Animals.Add(new Dog(ProgramUi.InsertName($"{type}")));
                        break;
                    case "cows":
                        Animals.Add(new Cow(ProgramUi.InsertName($"{type}")));
                        break;
                    case "pigs":
                        Animals.Add(new Pig(ProgramUi.InsertName($"{type}")));
                        break;
                }
            }
        }
    }
}
