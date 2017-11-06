using Fsd.Arek.Cs2.Domain.Animals;
using Fsd.Arek.Cs2.Domain;
using System;

public abstract class Animal : INamePresenter
{
    public string Name { get; set; }

    public AnimalType AnimalType;

    public Animal(string name, AnimalType animalType)
    {
        Name = name;
        AnimalType = animalType;
    }

    public abstract string SayHello();

    public string GetPresenterAnimal()
    {
        return $"{AnimalType} name {Name}";
    }
}
