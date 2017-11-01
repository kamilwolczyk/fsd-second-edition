using System;
using System.Collections.Generic;

namespace Fsd.Arek.Cs2.Domain
{
    public class ConsoleMenu
    {
        const string line = "-----------------------------------";

        public void Run()
        {
            AnimalsFactory AnimalsFactory = new AnimalsFactory();
            SetHeader(2, line);

            foreach (AnimalType animalType in Enum.GetValues(typeof(AnimalType)))
                GetUserInformation(AnimalsFactory, animalType);

            foreach (Animal animal in AnimalsFactory.AnimalList)
                Console.WriteLine(animal.SayHello());

            Console.ReadKey();
        }

        public void SetHeader(int numberExcercise, string line)
        {
            Console.WriteLine($"Excercise nr {numberExcercise} \n{line}");
        }

        public int GetIntDataFromUser(AnimalType type)
        {
            int number = 0;
            Console.WriteLine($"Insert number of {type}");

            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            return number;
        }

        public void WriteInformationFromList(List<string> list)
        {
            foreach (string text in list)
                Console.WriteLine($"{text}");
        }

        public void GetUserInformation(AnimalsFactory factory, AnimalType animalsType)
        {
            int numberOfAnimals = GetIntDataFromUser(animalsType);
            factory.CreateAnimalsInFactory(numberOfAnimals, animalsType);
            WriteInformationFromList(factory.PresentAnimals(animalsType));
        }
    }
}
