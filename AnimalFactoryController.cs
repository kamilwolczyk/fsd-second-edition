using System.Collections.Generic;
using Fsd.Jacek.Cs2.Animals;

namespace Fsd.Jacek.Cs2.MVC
{
    class AnimalFactoryController : BaseController
    {
        AnimalFactoryView _view = null;
        AnimalFactoryModel _model = null;

        public AnimalFactoryController()
        {
            _model = new AnimalFactoryModel();
            _view = new AnimalFactoryView(this, _model);
        }

        public void ShowView()
        {
            _view.Update();
        }

        public void CreateCats(int count, List<string> names)
        {
            for (int i = 0; i < count; i++)
            {
                Cat newCat = new Cat();
                newCat.Name = names[i];

                _model.Animals.Add(newCat);
            }
        }
        
        public void CreatePigs(int count, List<string> names)
        {
            for (int i = 0; i < count; i++)
            {
                Pig newCat = new Pig();
                newCat.Name = names[i];

                _model.Animals.Add(newCat);
            }
        }
        
        public void CreateHores(int count, List<string> names)
        {
            for (int i = 0; i < count; i++)
            {
                Horse newCat = new Horse();
                newCat.Name = names[i];

                _model.Animals.Add(newCat);
            }
        }

        public void CreateDogs(int count, List<string> names)
        {
            for (int i = 0; i < count; i++)
            {
                Dog newCat = new Dog();
                newCat.Name = names[i];

                _model.Animals.Add(newCat);
            }
        }
    }
}
