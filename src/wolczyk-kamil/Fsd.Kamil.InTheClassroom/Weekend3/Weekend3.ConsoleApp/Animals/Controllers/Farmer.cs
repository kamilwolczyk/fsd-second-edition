using System.Collections.Generic;
using Weekend3.ConsoleApp.Animals.Views;
using Weekend3.Data.Entities;
using Weekend3.Data.Enums;
using Weekend3.Services.Factories;
using Weekend3.Services.Services;

namespace Weekend3.ConsoleApp.Animals.Controllers
{
    public class Farmer : IFarmer
    {
        public void DoWork()
        {
            IUserInterface ui = new ConsoleUserInterface();
            IAnimalFactory animalFactory = new AnimalFactory();
            IFarm farm = new Farm();

            foreach (AnimalSpecies item in System.Enum.GetValues(typeof(AnimalSpecies)))
            {
                List<string> nameList = ui.GetNames(item);
                List<Animal> animalList = animalFactory.CreateAnimals(item, nameList.ToArray());
                farm.AddNewAnimals(animalList);
            }
        }
    }
}