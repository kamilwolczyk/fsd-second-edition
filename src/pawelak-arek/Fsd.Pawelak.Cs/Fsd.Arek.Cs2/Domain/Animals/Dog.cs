using Fsd.Arek.Cs2.Domain.Animals;
using Fsd.Arek.Cs2.Domain.Enum;

public class Dog:Animal,IVoice
{
    public Dog(string name)
        : base(name)
    {
    }

    public override string GetInformationAboutAnimal()
    {
        return $"{AnimalsType.dog} name: {Name}";
    }

    public string GiveVoice()
    {
        return "Hau Hau Hau";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GiveVoice()}";
    }
}
