using System.Collections.Generic;

namespace Fsd.Maciej.Cs.Ex2
{
    public class AnimalFactory
    {
        public List<Animal> MakeAnimal(int animalType, string[] animalName)
        {
            List<Animal> animalList = new List<Animal>();

            switch ((int)animalType)
            {
                case 1:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Cat { Name = animalName[i] });
                    }
                    break;

                case 2:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Cow { Name = animalName[i] });
                    }
                    break;

                case 3:
                    for (int i = 0; i < animalName.Length; i++)
                    {
                        animalList.Add(new Dog { Name = animalName[i] });
                    }
                    break;

                case 4:
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