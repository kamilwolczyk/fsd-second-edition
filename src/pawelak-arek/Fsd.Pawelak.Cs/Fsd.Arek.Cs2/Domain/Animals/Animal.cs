public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract string FullPresent();
    
    public abstract string GiveVoice();

    public virtual string SayHello()
    {
        return $"Hello, my name is: {Name}, {GiveVoice()}";
    }
}
