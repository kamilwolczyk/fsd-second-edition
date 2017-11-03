using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Bielewicz.Jacek.Cs2.AnimalFactory;

namespace Fsd.Bielewicz.Jacek.Cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            int animalCount = 0;

            Console.WriteLine("Insert number of Pigs: ");
            animalCount = AnimalCount.ReadAnimalCount();
            for (int i = 0; i < animalCount; i++)
            {
                Console.WriteLine("Pig name: ");
                string name = Console.ReadLine();
                IAnimal animal = new Pig();
                animal.Name = name;
                animals.Add(animal);
            }

            Console.WriteLine("Insert number of Cats: ");
            animalCount = AnimalCount.ReadAnimalCount();
            for (int i = 0; i < animalCount; i++)
            {
                Console.WriteLine("Cat name: ");
                string name = Console.ReadLine();
                IAnimal animal = new Cat();
                animal.Name = name;
                animals.Add(animal);
            }

            Console.WriteLine("Insert number of Dogs: ");
            animalCount = AnimalCount.ReadAnimalCount();
            for (int i = 0; i < animalCount; i++)
            {
                Console.WriteLine("Dog name: ");
                string name = Console.ReadLine();
                IAnimal animal = new Dog();
                animal.Name = name;
                animals.Add(animal);
            }

            Console.WriteLine("Insert number of Horses: ");
            animalCount = AnimalCount.ReadAnimalCount();
            for (int i = 0; i < animalCount; i++)
            {
                Console.WriteLine("Horse name: ");
                string name = Console.ReadLine();
                IAnimal animal = new Horse();
                animal.Name = name;
                animals.Add(animal);
            }

            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine("Hello, my name is {0}, {1})", animals[i].Name, animals[i].Sound);
            }
            Console.ReadLine();
        }
    }
}
