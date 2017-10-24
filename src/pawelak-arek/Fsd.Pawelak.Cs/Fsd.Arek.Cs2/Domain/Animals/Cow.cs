using Fsd.Arek.Cs2.Domain.Enum;

public class Cow:Animal
{
    public Cow(string name)
        : base(name)
    {
    }

    public override string FullPresent()
    {
        return $"{AnimalsType.cow} name: {Name}";
    }

    public override string GiveVoice()
    {
        return "Muuuuuu";
    }
}
