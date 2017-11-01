using Fsd.Arek.Cs2.Domain.Animals;
using Fsd.Arek.Cs2.Domain;
using System;

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract string SayHello();
}
