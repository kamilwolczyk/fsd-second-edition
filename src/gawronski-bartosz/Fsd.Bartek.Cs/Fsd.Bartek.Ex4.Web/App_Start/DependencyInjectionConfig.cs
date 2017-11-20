using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Bartek.Ex4.Services.Services;
using System.Web.Mvc;

namespace Fsd.Bartek.Ex4.Web
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterResolve()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();        
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            builder.RegisterType<ProductsService>().As<IProductsService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
