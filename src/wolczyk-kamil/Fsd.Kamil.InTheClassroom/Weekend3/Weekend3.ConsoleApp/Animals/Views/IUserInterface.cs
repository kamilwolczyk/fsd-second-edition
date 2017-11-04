using System.Collections.Generic;
using Weekend3.ConsoleApp.Animals.Models.Enums;

namespace Weekend3.ConsoleApp.Animals.Views
{
    public interface IUserInterface
    {
        List<string> GetNames(AnimalSpecies animalSpecies);

        void ShowNames(List<string> names);
    }
}