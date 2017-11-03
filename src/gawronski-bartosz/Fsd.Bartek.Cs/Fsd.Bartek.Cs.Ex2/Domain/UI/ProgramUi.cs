using Fsd.Bartek.Cs2.Ex2.Domain.UI;
using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class ProgramUi
    {
        public static void InsertNumber()
        {
            AnimalFactory Producer = new AnimalFactory();

            string[] animals = { "cats", "dogs", "cows", "pigs" };

            foreach (var item in animals)
            {
                Console.Write($"Insert number of {item}: ");
                string number = Console.ReadLine();

                Producer.FabricAnimal(int.Parse(number), item);
            }

            DisplayAnimals(Producer);
        }

        public static string InsertName(string type)
        {
            Console.Write($"{type} name:");
            string name = Console.ReadLine();
            return name;
        }

        public static void DisplayAnimals(AnimalFactory producer)
        {
            foreach (var item in producer.Animals)
            {
                Console.WriteLine(item.Voice());
            }
        }
    }
}
