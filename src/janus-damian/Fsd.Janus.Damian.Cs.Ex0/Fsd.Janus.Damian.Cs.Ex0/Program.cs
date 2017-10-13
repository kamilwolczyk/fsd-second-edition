using System;

namespace Fsd.Janus.Damian.Cs.Ex0
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramStart.RunStart(1, "Introduction");
            CharacterCounter characterCounter = new CharacterCounter();
            characterCounter.RunCounter(args);
            ProgramEnd.RunEnd();
        }
    }
}
