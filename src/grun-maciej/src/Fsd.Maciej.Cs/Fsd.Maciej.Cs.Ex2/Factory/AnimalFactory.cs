using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    public class AnimalFactory
    {
        public List<Animal> CreateAnimal(AnimalType animalType, string[] animalName)
        {
            List<Animal> animalList = new List<Animal>();

            switch (animalType)
            {
                case AnimalType.Cat:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Cat { Name = animalName[i] });
                    }
                    break;

                case AnimalType.Cow:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Cow { Name = animalName[i] });
                    }
                    break;

                case AnimalType.Dog:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Dog { Name = animalName[i] });
                    }
                    break;

                case AnimalType.Sheep:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Sheep { Name = animalName[i] });
                    }
                    break;
            }
            return animalList;
        }
    }
}