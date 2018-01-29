using System;
using System.Collections.Generic;
using Weekend3.Data.Enums;
using Weekend3.Services.Providers;

namespace Weekend3.ConsoleApp.Animals.Views
{
    public class ConsoleUserInterface : INamesProvider
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
