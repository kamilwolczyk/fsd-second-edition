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
            AnimalsFactory animalsFactory = new AnimalsFactory();
            SetHeader(2, line);

            int numberOfAnimals = GetInformationFromUser(AnimalsType.cat);
            animalsFactory.CreateAnimalsInFactory(numberOfAnimals, AnimalsType.cat);




            WriteInformationAboutObject("cat name: ", animalsFactory.CatList);


            numberOfAnimals = GetInformationFromUser(AnimalsType.cows);

            

            animalsFactory.CreateAnimalsInFactory(numberOfAnimals, AnimalsType.cows);
            numberOfAnimals = GetInformationFromUser(AnimalsType.dogs);
            animalsFactory.CreateAnimalsInFactory(numberOfAnimals, AnimalsType.dogs);
            numberOfAnimals = GetInformationFromUser(AnimalsType.pigs);
            animalsFactory.CreateAnimalsInFactory(numberOfAnimals, AnimalsType.pigs);
        }

        public void SetHeader(int numberExcercise, string line)
        {
            Console.WriteLine($"Excercise nr {numberExcercise} \n{line}");
        }

        public int GetInformationFromUser(AnimalsType type)
        {
            Console.WriteLine($"Insert number of {type}");
            return int.Parse(Console.ReadLine());
        }

        public void WriteInformationAboutObject(string content, List<Cat> animalList)
        {
            foreach(Animal animal in animalList)
            Console.WriteLine($"{content}: {animal.Name}");
        }

        
    }
}
