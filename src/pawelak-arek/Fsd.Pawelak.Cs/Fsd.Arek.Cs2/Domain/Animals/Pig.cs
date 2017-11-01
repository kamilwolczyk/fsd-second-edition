using Fsd.Arek.Cs2.Domain;
using Fsd.Arek.Cs2.Domain.Animals;

public class Pig : Animal, IVoice
{
    public Pig(string name)
        : base(name)
    {
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