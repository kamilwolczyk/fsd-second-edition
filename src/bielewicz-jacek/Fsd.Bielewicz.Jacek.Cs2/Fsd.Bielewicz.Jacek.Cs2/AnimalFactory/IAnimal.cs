using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bielewicz.Jacek.Cs2.AnimalFactory
{
    interface IAnimal
    {
        string Name { get; set; }
        
        string Sound { get; }
    }
}
