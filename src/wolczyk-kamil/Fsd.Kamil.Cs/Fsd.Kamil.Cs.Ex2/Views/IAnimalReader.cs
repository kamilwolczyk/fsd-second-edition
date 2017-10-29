namespace Fsd.Kamil.Cs.Ex2.Views
{
    public interface IAnimalReader
    {
        int GetAnimalCount(string speciesName);

        string GetAnimalName(string animalName);
    }
}
