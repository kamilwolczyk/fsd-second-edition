﻿using Fsd.Bartek.Cs2.Ex2.Domain.UI;
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
                        Producent.FabricCat(int.Parse(number));
                        break;
                    case "dogs":
                        Producent.FabricDog(int.Parse(number));
                        break;
                    case "pigs":
                        Producent.FabricPig(int.Parse(number));
                        break;
                    case "cows":
                        Producent.FabricCow(int.Parse(number));
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
            foreach (var item in producent.Cat)
            {
                Console.WriteLine(item.Voice());
            }
            foreach (var item in producent.Dog)
            {
                Console.WriteLine(item.Voice());
            }
            foreach (var item in producent.Pig)
            {
                Console.WriteLine(item.Voice());
            }
            foreach (var item in producent.Cow)
            {
                Console.WriteLine(item.Voice());
            }
        }
    }
}
