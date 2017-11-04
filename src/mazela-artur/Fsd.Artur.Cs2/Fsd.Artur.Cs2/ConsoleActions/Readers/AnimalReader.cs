﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs2.ConsoleActions.Readers
{
    public class ConsoleAnimalReader : IAnimalReader
    {
        public int GetCount(string name)
        {
            Console.Write($"Insert number of {name}s: ");
            return int.Parse(Console.ReadLine());
        }

        public string GetName(string animalName)
        {
            Console.Write($"{animalName} name: ");
            return Console.ReadLine();
        }
    }
}
