public class Cat : Animal
{
    public Cat(string name)
        : base(name)
    {
    }

    public override string GiveVoice()
    {
        return "Miauuuu";
    }
}
