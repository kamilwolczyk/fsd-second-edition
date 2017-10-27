using Fsd.Porowiec.Michal.Cs2.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Porowiec.Michal.Cs2
{
    class AnimalFactory
    {
        string line = "-----------------------------";

        List<Animal> animals = new List<Animal>();

        int Dogs;

        int Lions;

        int Cats;


        String[] animalList =
        {
            "Cat",
            "Lion",
            "Dog"
        };

        public void Run()
        {
            Header(2, "Interfaces");

            AboutAnimals();

            for (int i = 0; i < animalList.Length; i++)
                Segregation(i);

            for (int i = 0; i < animalList.Length; i++)
                AnimalsSounds(animalList[i]);

            Console.ReadLine();
        }

        void AboutAnimals()
        {
            for (int i = 0; i < animalList.Length; i++)
            {
                Console.WriteLine($"What number of {animalList[i]} you want to create?");

                string input = Console.ReadLine();

                int number = Int32.Parse(input);

                AddAnimal(number, i);
            }
        }


        void Segregation(int i)
        {
            Console.WriteLine($"Insert number of {animalList[i]}s: {SegregationType(i)}");
            DisplayAnimals(animalList[i]);
            Console.WriteLine();
        }

        int SegregationType(int i)
        {
            int returning = 0;

            switch (animalList[i])
            {

                case "Lion":
                    returning = Lions;
                    break;
                case "Cat":
                    returning = Cats;
                    break;
                case "Dog":
                    returning = Dogs;
                    break;

            }
            return returning;
        }

        void AddAnimal(int number, int i)
        {
            for (int x = 0; x < number; x++)
            {
                Console.WriteLine($"What should be the name of {x + 1} animal?");
                string name = Console.ReadLine();
                switch (animalList[i])
                {
                    case "Cat":
                        animals.Add(new Cat(name));
                        Cats++;
                        break;
                    case "Lion":
                        animals.Add(new Lion(name));
                        Lions++;
                        break;
                    case "Dog":
                        animals.Add(new Dog(name));
                        Dogs++;
                        break;
                    default:
                        throw new Exception("Can't Find such a animal Type in AddAnimal Methode.");
                }
            }
        }

        void Header(int number, string name)
        {
            Console.WriteLine(line);
            Console.WriteLine($"Exercise {number} - {name}");
            Console.WriteLine(line);
        }

        void DisplayAnimals(string type)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Type == type)
                {
                    Console.WriteLine($"{animals[i].Type} name : {animals[i].Name} ");
                }
            }
        }

        void AnimalsSounds(string type)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Type == type)
                {
                    Console.WriteLine($"Hi my name is {animals[i].Name}, {animals[i].Voice} ");
                }
            }
        }
    }
}
