using Fsd.Janus.Damian.Cs.Ex2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Janus.Damian.Cs.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderInfo.Run(2, "Interfaces");
            AnimalsFactory animalsFactory = new AnimalsFactory();
            animalsFactory.Run();
            FooterInfo.Run();
        }
    }
}
