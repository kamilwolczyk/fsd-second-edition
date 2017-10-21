using System;

namespace Fsd.Sebastian.Cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContentPresenter content = new ContentPresenter();
            content.Header();
            new CharCounter().Run(args);
            content.Footer();
        }
    }
}