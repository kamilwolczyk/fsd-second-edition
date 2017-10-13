using System;

namespace Fsd.Sebastian.Cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            new ContentPresenter().Header();
            new CharCounter().Run(args);
            new ContentPresenter().Footer();
        }
    }
}