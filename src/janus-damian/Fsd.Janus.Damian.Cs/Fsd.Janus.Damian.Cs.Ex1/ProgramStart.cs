using System;

namespace Fsd.Janus.Damian.Cs.Ex0
{
    class ProgramStart
    {
        public static void RunStart(int exerciseNumber, string exerciseName)
        {
            const string line = "----------------------------------------------------";

            Console.WriteLine($"Exercise {exerciseNumber} - {exerciseName}");
            Console.WriteLine(line);
            Console.WriteLine($"Today is {DateTime.Now} \n");
        }
    }
}
