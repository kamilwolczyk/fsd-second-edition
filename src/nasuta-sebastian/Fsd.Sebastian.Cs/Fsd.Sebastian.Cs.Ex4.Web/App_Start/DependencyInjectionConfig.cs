using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Sebastian.Cs.Ex4.Services.Products;
using Fsd.Sebastian.Cs.Ex4.Services.Products.Sql;
using System.Web.Mvc;

namespace Fsd.Sebastian.Cs.Ex4.Web
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

            builder.RegisterType<SqlProductProvider>().As<IProductProvider>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
