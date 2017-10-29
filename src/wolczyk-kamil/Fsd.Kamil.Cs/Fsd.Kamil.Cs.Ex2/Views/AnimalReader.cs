using System;

namespace Fsd.Kamil.Cs.Ex2.Views
{
    public class AnimalReader : IAnimalReader
    {
        public int GetAnimalCount(string speciesName)
        {
            Console.Write($"Insert number of {speciesName}s: ");
            return int.Parse(Console.ReadLine());             
        }

        public string GetAnimalName(string animalName)
        {
            Console.Write($"{animalName} name: ");
            return Console.ReadLine();
        }
    }
}
