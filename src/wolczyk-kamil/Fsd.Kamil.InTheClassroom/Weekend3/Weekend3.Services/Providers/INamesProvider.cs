using System.Collections.Generic;
using Weekend3.Data.Enums;

namespace Weekend3.Services.Providers
{
    public interface INamesProvider
    {
        List<string> GetNames(AnimalSpecies animalSpecies);

        void ShowNames(List<string> names);
    }
}