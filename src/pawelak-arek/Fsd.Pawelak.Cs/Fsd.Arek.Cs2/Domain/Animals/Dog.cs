using Fsd.Arek.Cs2.Domain;
using Fsd.Arek.Cs2.Domain.Animals;

public class Dog : Animal, IVoice
{
    public Dog(string name, AnimalType animalType) 
        : base(name, animalType)
    {
    }

    public string GetVoice()
    {
        return "Hau Hau Hau";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GetVoice()}";
    }
}
