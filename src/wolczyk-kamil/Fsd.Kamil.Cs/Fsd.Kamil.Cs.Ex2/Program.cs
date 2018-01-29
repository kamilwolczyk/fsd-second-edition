using Fsd.Kamil.Cs.Ex2.Views;
using System;
using System.Linq;

namespace Fsd.Kamil.Cs.Ex2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainView.Header();

            var animalReader = new AnimalReader();
            var animalWriter= new AnimalWriter();

            var animalsProvider = new AnimalsProvider(animalReader);
            var animals = animalsProvider.GenerateAnimals();
            var zoo = new Zoo(animals.ToArray());
            zoo.MakeSomeNoise(animalWriter);

            Console.ReadKey();
        }
    }
}