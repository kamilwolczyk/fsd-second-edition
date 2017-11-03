using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bielewicz.Jacek.Cs2.AnimalFactory
{
    class Horse : IAnimal
    {
       string _name = string.Empty;
       public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Sound
        {
            get
            {
                return "Iaaa!";
            }
        }

    }
}
