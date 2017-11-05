using System.Collections.Generic;
using Weekend3.Data.Enums;

namespace Weekend3.ConsoleApp.Animals.Views
{
    public interface IUserInterface
    {
        List<string> GetNames(AnimalSpecies animalSpecies);

        void ShowNames(List<string> names);
    }
}