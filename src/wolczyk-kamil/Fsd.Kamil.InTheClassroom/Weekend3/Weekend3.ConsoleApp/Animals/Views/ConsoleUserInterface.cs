using System;
using System.Collections.Generic;
using Weekend3.ConsoleApp.Animals.Models.Enums;

namespace Weekend3.ConsoleApp.Animals.Views
{
    public class ConsoleUserInterface : IUserInterface
    {
        public List<string> GetNames(AnimalSpecies animalSpecies)
        {
            //Console.WriteLine("Set count");
            //int count = int.Parse(Console.ReadLine());
            
            return new List<string>
            {
                "Jan", "Maria"
            };
        }

        public void ShowNames(List<string> names)
        {
            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
