using System;
using Fsd.Jacek.Cs3.Tools;

namespace Fsd.Jacek.Cs3
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
