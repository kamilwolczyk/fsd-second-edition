using Fsd.Arek.Cs2.Domain.Animals;

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract string GetInformationAboutAnimal();

    public abstract string SayHello();
 
}
