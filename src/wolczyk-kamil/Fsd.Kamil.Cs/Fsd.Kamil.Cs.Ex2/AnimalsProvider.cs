using System;
using System.Collections.Generic;
using Fsd.Kamil.Cs.Ex2.Animals;
using Fsd.Kamil.Cs.Ex2.Views;

namespace Fsd.Kamil.Cs.Ex2
{
    public class AnimalsProvider
    {
        private IAnimalReader _reader;

        public AnimalsProvider(IAnimalReader reader)
        {
            _reader = reader;
        }

        public IEnumerable<ISound> GenerateAnimals()
        {
            var animals = new List<ISound>();
            animals.AddRange(GenerateAnimalForSpecies<Cat>("cat"));
            animals.AddRange(GenerateAnimalForSpecies<Dog>("dog"));
            animals.AddRange(GenerateAnimalForSpecies<Cow>("cow"));
            animals.AddRange(GenerateAnimalForSpecies<Sheep>("sheep"));
            return animals;
        }

        private IEnumerable<ISound> GenerateAnimalForSpecies<TAnimal>(string speciesName) where TAnimal : ISound
        {
            var animalNumber = _reader.GetAnimalCount(speciesName);
            var animals = new List<ISound>();

            for (var i = 0; i < animalNumber; i++)
                animals.Add((TAnimal)Activator.CreateInstance(typeof(TAnimal), _reader.GetAnimalName(speciesName)));
                        
            return animals;
        }
    }
}