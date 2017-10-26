using Fsd.Arek.Cs2.Domain.Animals;
using Fsd.Arek.Cs2.Domain.Enum;

public class Cow:Animal,IVoice
{
    public Cow(string name)
        : base(name)
    {
    }

    public override string GetInformationAboutAnimal()
    {
        return $"{AnimalsType.cow} name: {Name}";
    }

    public string GiveVoice()
    {
        return "Muuuuuu";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GiveVoice()}";
    }
}
