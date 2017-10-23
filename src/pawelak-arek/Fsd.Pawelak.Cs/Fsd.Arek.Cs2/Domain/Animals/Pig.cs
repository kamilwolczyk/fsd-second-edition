public class Pig:Animal
{
    public Pig(string name)
        : base(name)
    {
    }

    public override string GiveVoice()
    {
        return "Hrum hrum hrum";
    }
}