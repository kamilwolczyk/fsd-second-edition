using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.Animals
{
    public class Horse : Animal
    {
        public string VoiceOfAnimal = "Iha Iha Pfrr Pfrr";

        public Horse(string name, int number)
            : base(name, number)
        {
        }

        List<Horse> horseList = new List<Horse>();

        public void NewHorse()
        {
            string horseCount = Console.ReadLine();

            for (int i = 1; i < int.Parse(horseCount)+1; i++)
            {
                Console.Write($"horse {i} name:");
                Name = Console.ReadLine();
                horseList.Add(new Horse(Name, i));
            }
        }

        public void HorseDisplay()
        {
            foreach (var horsePet in horseList)
                Console.WriteLine(horsePet.Hello());
        }

        public override string Hello()
        {
            return $"{base.Hello()} {VoiceOfAnimal}";
        }
    }
}
