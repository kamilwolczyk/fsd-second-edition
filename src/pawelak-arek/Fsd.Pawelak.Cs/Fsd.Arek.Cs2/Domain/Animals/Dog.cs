using Fsd.Arek.Cs2.Domain.Enum;

public class Dog:Animal
{
    public Dog(string name)
        : base(name)
    {
    }

    public override string FullPresent()
    {
        return $"{AnimalsType.dog} name: {Name}";
    }

    public override string GiveVoice()
    {
        return "Hau Hau Hau";
    }
}
