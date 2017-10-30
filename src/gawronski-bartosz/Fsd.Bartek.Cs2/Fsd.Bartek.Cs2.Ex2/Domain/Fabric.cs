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
                Animals.Add(new Animals.Cat(ProgramUi.InsertName($"{type}")));
            }
        }
    }
}
