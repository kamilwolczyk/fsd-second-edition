namespace Fsd.Jacek.Cs.Ex2.MVC
{
    abstract class BaseView
    {
        public BaseView(BaseController controller, BaseModel model) { }

        public abstract void Update();
    }
}
