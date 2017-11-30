using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Fsd.Kamil.Cs.Ex5.Domain.Services.Products;

namespace Fsd.Kamil.Cs.Ex5.Web
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterResolver()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            builder.RegisterType<ManualProductService>().As<IManualProductService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}