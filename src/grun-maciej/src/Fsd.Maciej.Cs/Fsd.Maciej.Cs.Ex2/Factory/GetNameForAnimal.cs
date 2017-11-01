using System;

namespace Fsd.Maciej.Cs.Ex2
{
    public class GetAnimalName
    {
        public string[] GetName(int typeOfAnimal)
        {
            string[] animalName;
            int animalCount = 0;

            switch ((int)typeOfAnimal)
            {
                case 1:
                    animalCount = AnimalCount("how many cats do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;

                case 2:
                    animalCount = AnimalCount("how many cows do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;

                case 3:
                    animalCount = AnimalCount("how many dogs do you need? ");
                    animalName = new string[animalCount];
                    animalName = GetNameAnimal(animalCount);
                    return animalName;

                case 4:
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

                if (checkMyNumber)
                {
                    return checkedNumber;
                }
                else
                {
                    Console.WriteLine("wrong arguments please try again");
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