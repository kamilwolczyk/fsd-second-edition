using System;

namespace Fsd.Kamil.Cs.Ex2.Views
{
    public class AnimalWriter : IAnimalWriter
    {
        public void Show(ISound animal)
        {
            Console.WriteLine(animal.MakeNoise());
        }
    }
}
