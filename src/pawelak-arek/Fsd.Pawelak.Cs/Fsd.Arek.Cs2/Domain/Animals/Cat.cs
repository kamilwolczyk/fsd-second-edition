using Fsd.Arek.Cs2.Domain.Animals;
using Fsd.Arek.Cs2.Domain.Enum;

public class Cat : Animal,IVoice
{
    public Cat(string name)
        : base(name)
    {
    }

    public override string GetInformationAboutAnimal()
    {
        return $"{AnimalsType.cat} name: {Name}";
    }

    public string GiveVoice()
    {
        return "Miauuuu";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GiveVoice()}";
    }
}
