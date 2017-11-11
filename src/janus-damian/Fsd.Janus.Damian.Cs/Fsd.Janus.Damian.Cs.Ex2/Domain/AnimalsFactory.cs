using Fsd.Janus.Damian.Cs.Ex2.Domain.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Janus.Damian.Cs.Ex2.Domain
{
    class AnimalsFactory
    {
        private List<Animal> AnimalsList = new List<Animal>();

        public void Run()
        {
            foreach (AnimalType animalType in Enum.GetValues(typeof(AnimalType)))
            {
                Console.Write($"Insert number of {animalType}: ");
                int number = int.Parse(Console.ReadLine());
                CreateAnimalsFactory(number, animalType);

                
            }
        }

        public void CreateAnimalsFactory(int animalsNumber, AnimalType animalsType)
        {
            for (int i = 1; i <= animalsNumber; i++)
            {
                switch(animalsType)
                {
                    case AnimalType.Cat:
                        AnimalsList.Add(new Cat($"cat{i}"));
                        break;
                    case AnimalType.Dog:
                        AnimalsList.Add(new Dog($"dog{i}"));
                        break;
                    case AnimalType.Horse:
                        AnimalsList.Add(new Horse($"horse{i}"));
                        break;
                    case AnimalType.Monkey:
                        AnimalsList.Add(new Monkey($"monkey{i}"));
                        break;
                    default:
                        break;
                }
            }
        }


    }
}
