using System;

namespace Fsd.Sebastian.Cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            HeaderAndFooter hf = new HeaderAndFooter();
            hf.Header();
            CharCounter cc = new CharCounter();
            cc.Run(args);
            hf.Footer();
        }
    }
}