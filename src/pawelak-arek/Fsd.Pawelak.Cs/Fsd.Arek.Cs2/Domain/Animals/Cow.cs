using Fsd.Arek.Cs2.Domain;
using Fsd.Arek.Cs2.Domain.Animals;

public class Cow : Animal, IVoice
{
    public Cow(string name)
        : base(name)
    {
    }

    public string GetVoice()
    {
        return "Muuuuuu";
    }

    public override string SayHello()
    {
        return $"Hello, my name is: {Name}, {GetVoice()}";
    }
}
