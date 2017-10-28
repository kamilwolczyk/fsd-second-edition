using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Bielewicz.Jacek.Cs1.Tools;


namespace Fsd.Bielewicz.Jacek.Cs1
{
    class Program
    { 
        static void Main(string[] args)
        {
            View view = new View();
            view.Begining();
            Counting counting = new Counting();
            counting.Count(args);
        } 
    }
}

    

