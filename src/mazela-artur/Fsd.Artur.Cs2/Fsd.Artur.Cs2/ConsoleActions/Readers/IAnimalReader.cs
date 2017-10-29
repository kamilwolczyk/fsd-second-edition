using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.ConsoleActions.Readers
{
    public interface IAnimalReader
    {
        int GetCount(string count);

        string GetName(string name);
    }
}
