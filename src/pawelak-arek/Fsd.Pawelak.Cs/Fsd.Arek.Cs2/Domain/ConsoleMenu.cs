using Fsd.Arek.Cs2.Domain.Enum;
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

            GetUserInformation(AnimalsFactory, AnimalsType.cat);
            GetUserInformation(AnimalsFactory, AnimalsType.cow);
            GetUserInformation(AnimalsFactory, AnimalsType.dog);
            GetUserInformation(AnimalsFactory, AnimalsType.pig);

            foreach (Animal animal in AnimalsFactory.AnimalList)
                Console.WriteLine(animal.SayHello());

            Console.ReadKey();
        }

        public void SetHeader(int numberExcercise, string line)
        {
            Console.WriteLine($"Excercise nr {numberExcercise} \n{line}");
        }

        public int GetIntDataFromUser(AnimalsType type)
        {
            Console.WriteLine($"Insert number of {type}");
            return int.Parse(Console.ReadLine());
        }

        public void WriteInformationFromList(List<string> list)
        {
            foreach (string text in list)
                Console.WriteLine($"{text}");
        }

        public void GetUserInformation(AnimalsFactory factory, AnimalsType animalsType)
        {
            int numberOfAnimals = GetIntDataFromUser(animalsType);
            factory.CreateAnimalsInFactory(numberOfAnimals, animalsType);
            WriteInformationFromList(factory.GetNameAnimals(animalsType));
        }
    }
}
