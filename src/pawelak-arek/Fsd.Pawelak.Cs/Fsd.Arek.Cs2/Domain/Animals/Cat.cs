using Fsd.Arek.Cs2.Domain;
using Fsd.Arek.Cs2.Domain.Animals;

public class Cat : Animal, IVoice
{
    public Cat(string name, AnimalType animalType) 
        : base(name, animalType)
    {
    }

    public string GetVoice()
    {
        return "Miauuuu";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GetVoice()}";
    }
}
