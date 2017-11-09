using System.Collections.Generic;
using Weekend3.Data.Entities;
using Weekend3.Data.Enums;
using Weekend3.Services.Factories;
using Weekend3.Services.Providers;

namespace Weekend3.Services.Services
{
    public class Farmer : IFarmer
    {
        private readonly INamesProvider _namesProvider;

        public Farmer(INamesProvider namesProvider)
        {
            _namesProvider = namesProvider;
        }

        public void DoWork()
        {
            //INamesProvider provider = new ConsoleUserInterface();
            IAnimalFactory animalFactory = new AnimalFactory();
            IFarm farm = new Farm();

            foreach (AnimalSpecies item in System.Enum.GetValues(typeof(AnimalSpecies)))
            {
                List<string> nameList = _namesProvider.GetNames(item);
                List<Animal> animalList = animalFactory.CreateAnimals(item, nameList.ToArray());
                farm.AddNewAnimals(animalList);
            }
        }
    }
}