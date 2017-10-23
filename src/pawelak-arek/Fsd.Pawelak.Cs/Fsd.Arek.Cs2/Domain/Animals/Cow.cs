public class Cow:Animal
{
    public Cow(string name)
        : base(name)
    {
    }

    public override string GiveVoice()
    {
        return "Muuuuuu";
    }
}
