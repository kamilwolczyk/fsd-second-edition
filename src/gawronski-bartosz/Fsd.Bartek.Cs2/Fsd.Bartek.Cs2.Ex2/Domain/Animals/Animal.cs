using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Cs2.Ex2.Domain.Animals
{
    public interface Animal
    {
        string Name { get; set; }

        string Voice();
    }
}
