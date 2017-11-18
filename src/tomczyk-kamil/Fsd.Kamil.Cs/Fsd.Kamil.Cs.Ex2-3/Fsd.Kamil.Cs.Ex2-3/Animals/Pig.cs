using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Kamil.Cs.Ex2_3.Animals
{
    public class Pig : Animal
    {
        public string VoiceOfAnimal = "Kłi Kłi Kłi";

        public Pig(string name, int number)
            : base(name, number)
        {
        }

        List<Pig> pigList = new List<Pig>();

        public void NewPig()
        {
            string pigCount = Console.ReadLine();

            for (int i = 1; i < int.Parse(pigCount)+1; i++)
            {
                Console.Write($"pig {i} name:");
                Name = Console.ReadLine();
                pigList.Add(new Pig(Name, i));
            }
        }

        public void PigDisplay()
        {
            foreach (var pigPet in pigList)
                Console.WriteLine(pigPet.Hello());
        }

        public override string Hello()
        {
            return $"{base.Hello()} {VoiceOfAnimal}";
        }
    }
}
