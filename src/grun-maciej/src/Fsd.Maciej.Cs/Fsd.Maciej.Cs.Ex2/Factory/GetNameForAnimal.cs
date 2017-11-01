using System;

namespace Fsd.Maciej.Cs.Ex2
{
    public class GetAnimalName
    {
        public string[] GetName(AnimalType animalType)
        {
            string[] animalName;
            int animalCount = 0;

            switch (animalType)
            {
                case AnimalType.Cat:
                    animalCount = AnimalCount("how many cats do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;

                case AnimalType.Cow:
                    animalCount = AnimalCount("how many cows do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;

                case AnimalType.Dog:
                    animalCount = AnimalCount("how many dogs do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;

                case AnimalType.Sheep:
                    animalCount = AnimalCount("how many sheep do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;
            }
            return animalName = null;
        }

        private int AnimalCount(string question)
        {
            Console.Write(question);

            while (true)
            {
                string number = Console.ReadLine();
                bool checkMyNumber = Int32.TryParse(number, out int checkedNumber);

                if (checkMyNumber & checkedNumber >= 0)
                {
                    return checkedNumber;
                }
                else
                {
                    Console.WriteLine("\nValue incorrect! Please try again.\n");
                    Console.Write(question);
                }
            }
        }

        private string[] GetNameAnimal(int animalCount)
        {
            string[] animalName = new string[animalCount];

            for (int i = 0; i < animalCount; i++)
            {
                Console.Write("animal name: ");
                animalName[i] = Console.ReadLine();
            }

            Console.WriteLine();
            return animalName;
        }
    }
}