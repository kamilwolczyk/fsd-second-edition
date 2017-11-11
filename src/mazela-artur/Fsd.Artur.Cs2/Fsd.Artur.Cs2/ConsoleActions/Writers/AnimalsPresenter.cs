namespace Fsd.Artur.Cs2.ConsoleActions.Writers
{
    public class AnimalsPresenter
    {
        private readonly INoise[] _animals;

        public AnimalsPresenter(INoise[] animals)
        {
            _animals = animals;
        }

        public void MakeNoise(IAnimalWriter writer)
        {
            foreach (var animal in _animals)
                writer.ShowAnimals(animal);
        }
    }
}
