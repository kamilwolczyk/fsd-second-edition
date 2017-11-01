using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Kamil.Cs.Ex2.Animals;

namespace Fsd.Kamil.Cs.Ex2
{
    public class FarmMaker
    {
        Menu menu = new Menu();

        public void NewAnimal()
        {
            menu.StartText(2);
            var animals = new List<IAnimal>();

            foreach (AnimalType animal in Enum.GetValues(typeof(AnimalType)))
            {
                Console.Write($"Insert number of {animal}:");
                string animalCount = Console.ReadLine();

                for (int i = 1; i < int.Parse(animalCount) + 1; i++)
                {
                    Console.Write($"{animal} {i} name:");
                    string animalName = Console.ReadLine();
                    if (animal == AnimalType.Dog)
                        animals.Add(new Dog { Name = animalName });
                    else if (animal == AnimalType.Fox)
                        animals.Add(new Fox { Name = animalName });
                    else if (animal == AnimalType.Horse)
                        animals.Add(new Horse { Name = animalName });
                    else if (animal == AnimalType.Pig)
                        animals.Add(new Pig { Name = animalName });
                }
            }

            ShowAnimals(animals);
            menu.EndText();
            Console.ReadKey();
        }

        public void ShowAnimals(IEnumerable<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine("Hello, my name is {0}, {1}", animal.Name, animal.Voice());
            }
        }
    }



    
}
