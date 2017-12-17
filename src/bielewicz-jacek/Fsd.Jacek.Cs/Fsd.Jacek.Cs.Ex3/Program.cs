using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Jacek.Cs.Ex3.Tools;

namespace Fsd.Jacek.Cs.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            customerService.Service();
        }
    }
}
