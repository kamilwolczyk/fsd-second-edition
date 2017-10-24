using Fsd.Arek.Cs2.Domain.Enum;

public class Cat : Animal
{
    public Cat(string name)
        : base(name)
    {
    }

    public override string FullPresent()
    {
        return $"{AnimalsType.cat} name: {Name}";
    }

    public override string GiveVoice()
    {
        return "Miauuuu";
    }
}
