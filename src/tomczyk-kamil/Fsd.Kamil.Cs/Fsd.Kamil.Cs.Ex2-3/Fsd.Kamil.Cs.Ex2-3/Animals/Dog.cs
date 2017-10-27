using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.Animals
{
    public class Dog : Animal
    {
        public string VoiceOfAnimal = "Hau Hau Hau";

        public Dog(string name, int number)
            : base(name, number)
        {
        }

        List<Dog> dogList = new List<Dog>();

        public void NewDog()
        {
            string dogCount = Console.ReadLine();

            for (int i = 1; i < int.Parse(dogCount)+1; i++)
            {
                Console.Write($"dog {i} name:");
                Name = Console.ReadLine();
                dogList.Add(new Dog(Name, i));
            }
        }

        public void DogDisplay()
        {
            foreach (var dogPet in dogList)
                Console.WriteLine(dogPet.Hello());
        }

        public override string Hello()
        {
            return  $"{base.Hello()} {VoiceOfAnimal}";
        }
    }
}
