using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.Animals
{
    public class Fox : Animal
    {
        public string VoiceOfAnimal = "Ring Ding Ding Ding Ding";

        public Fox(string name, int number)
            : base(name, number)
        {
        }

        List<Fox> foxList = new List<Fox>();

        public void NewFox()
        {
            string foxCount = Console.ReadLine();

            for (int i = 1; i < int.Parse(foxCount)+1; i++)
            {
                Console.Write($"fox {i} name:");
                Name = Console.ReadLine();
                foxList.Add(new Fox(Name, i));
            }
        }

        public void FoxDisplay()
        {
            foreach (var foxPet in foxList)
                Console.WriteLine(foxPet.Hello());
        }

        public override string Hello()
        {
            return $"{base.Hello()} {VoiceOfAnimal}";
        }
    }
}
