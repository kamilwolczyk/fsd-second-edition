using Fsd.Arek.Cs2.Domain.Enum;

public class Pig:Animal
{
    public Pig(string name)
        : base(name)
    {
    }

    public override string FullPresent()
    {
        return $"{AnimalsType.pig} name: {Name}";
    }

    public override string GiveVoice()
    {
        return "Hrum hrum hrum";
    }
}