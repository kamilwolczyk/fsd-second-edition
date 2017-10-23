public class Dog:Animal
{
    public Dog(string name)
        : base(name)
    {
    }

    public override string GiveVoice()
    {
        return "Hau Hau Hau";
    }
}
