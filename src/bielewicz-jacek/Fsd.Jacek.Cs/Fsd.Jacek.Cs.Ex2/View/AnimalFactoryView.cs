using System;
using System.Collections.Generic;
using Fsd.Jacek.Cs.Ex2.Animals;

namespace Fsd.Jacek.Cs.Ex2.MVC
{
    class AnimalFactoryView : BaseView
    {
        private AnimalFactoryController _controller = null;
        private AnimalFactoryModel _model = null;

        public AnimalFactoryView(BaseController controller, BaseModel model) : base(controller, model)
        {
            if (controller is AnimalFactoryController)
            {
                _controller = controller as AnimalFactoryController;
            }

            if (model is AnimalFactoryModel)
            {
                _model = model as AnimalFactoryModel;
            }
        }

        static int ReadAnimalCount()
        {
            string input = Console.ReadLine();
            int value = 0;
            if (int.TryParse(input, out value))
            {
                return value;
            }
            return 0;
        }

        public override void Update()
        {
            Console.Write("Number of cats: ");
            string input;
            int animalCount = ReadAnimalCount();
            List<string> names = new List<string>();

            for (int i = 0; i < animalCount; i++)
            {
                Console.Write("Name of cat: ");
                input = Console.ReadLine();
                names.Add(input);
            }

            _controller.CreateCats(animalCount, names);

            Console.Write("Number of pigs: ");
            animalCount = ReadAnimalCount();
            names = new List<string>();

            for (int i = 0; i < animalCount; i++)
            {
                Console.Write("Name of pigs: ");
                input = Console.ReadLine();
                names.Add(input);
            }

            _controller.CreatePigs(animalCount, names);

            Console.Write("Number of Horses: ");
            animalCount = ReadAnimalCount();
            names = new List<string>();

            for (int i = 0; i < animalCount; i++)
            {
                Console.Write("Name of hores: ");
                input = Console.ReadLine();
                names.Add(input);
            }

            _controller.CreateHores(animalCount, names);

            Console.Write("Number of dogs: ");
            animalCount = ReadAnimalCount();
            names = new List<string>();

            for (int i = 0; i < animalCount; i++)
            {
                Console.Write("Name of dog: ");
                input = Console.ReadLine();
                names.Add(input);
            }

            _controller.CreateDogs(animalCount, names);

            foreach (IAnimal animal in _model.Animals)
            {
                Console.WriteLine("Hello My name is " + animal.Name + " " + animal.Voice);
            }
            Console.ReadLine();
        }
    }
}
