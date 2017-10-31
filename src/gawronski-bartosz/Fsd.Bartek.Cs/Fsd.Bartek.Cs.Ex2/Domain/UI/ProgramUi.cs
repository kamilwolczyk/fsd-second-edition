using Fsd.Bartek.Cs2.Ex2.Domain.UI;
using System;

namespace Fsd.Bartek.Cs2.Ex2.Domain.UI
{
    public abstract class ProgramUi
    {
        public static void InsertNumber()
        {
            Fabric Producent = new Fabric();

            string[] animals = { "cats", "dogs", "cows", "pigs" };

            foreach (var item in animals)
            {
                Console.Write($"Insert number of {item}: ");
                string number = Console.ReadLine();
                switch (item)
                {
                    case "cats":
                        Producent.FabricAnimal(int.Parse(number),item);
                        break;
                    case "dogs":
                        Producent.FabricAnimal(int.Parse(number),item);
                        break;
                    case "pigs":
                        Producent.FabricAnimal(int.Parse(number),item);
                        break;
                    case "cows":
                        Producent.FabricAnimal(int.Parse(number),item);
                        break;
                }
            }

            DisplayAnimals(Producent);
        }

        public static string InsertName(string type)
        {
            Console.Write($"{type} name:");
            string name = Console.ReadLine();
            return name;
        }

        public static void DisplayAnimals(Fabric producent)
        {
            foreach (var item in producent.Animals)
            {
                Console.WriteLine(item.Voice());
            }
        }
    }
}
