using System.Collections.Generic;
using Fsd.Jacek.Cs.Ex2.Animals;

namespace Fsd.Jacek.Cs.Ex2.MVC
{
    class AnimalFactoryModel : BaseModel

    {
        public List<IAnimal> Animals = new List<IAnimal>();
    }
}