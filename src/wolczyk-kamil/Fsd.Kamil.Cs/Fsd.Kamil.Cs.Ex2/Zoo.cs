using Fsd.Kamil.Cs.Ex2.Views;
using System;

namespace Fsd.Kamil.Cs.Ex2
{
    public class Zoo
    {
        private readonly ISound[] _animals;

        public Zoo(ISound[] animals)
        {
            _animals = animals;
        }

        public void MakeSomeNoise(IAnimalWriter writer)
        {
            foreach (var animal in _animals)
                writer.Show(animal);
        }
    }
}