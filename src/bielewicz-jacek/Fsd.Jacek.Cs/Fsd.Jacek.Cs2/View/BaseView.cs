namespace Fsd.Jacek.Cs2.MVC
{
    abstract class BaseView
    {
        public BaseView(BaseController controller, BaseModel model)
        {}
        public abstract void Update();
    }
}
