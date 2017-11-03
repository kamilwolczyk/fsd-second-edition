using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Sebastian.Cs3
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsolePresenter().Header(3, "Objects");
            Warehouse warehouse = new Warehouse();
        }
    }
}
