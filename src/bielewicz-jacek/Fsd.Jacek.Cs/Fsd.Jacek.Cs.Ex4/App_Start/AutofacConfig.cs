using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Jacek.Cs.Ex4.Data;
using System.Web.Mvc;

namespace Fsd.Jacek.Cs.Ex4.Web
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<ProductServiceImpDelivery>().As<IProductService>().InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}