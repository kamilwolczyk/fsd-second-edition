using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2
{
    public interface IAnimal
    {
        string Name { get; set; }

        string Voice();
    }
}
