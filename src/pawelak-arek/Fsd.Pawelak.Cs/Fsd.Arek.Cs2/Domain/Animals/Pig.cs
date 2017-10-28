using Fsd.Arek.Cs2.Domain.Animals;
using Fsd.Arek.Cs2.Domain.Enum;

public class Pig : Animal, IVoice
{
    public Pig(string name)
        : base(name)
    {
    }

    public override string GetInformationAboutAnimal()
    {
        return $"{AnimalsType.pig} name: {Name}";
    }

    public string GetVoice()
    {
        return "Hrum hrum hrum";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GetVoice()}";
    }
}