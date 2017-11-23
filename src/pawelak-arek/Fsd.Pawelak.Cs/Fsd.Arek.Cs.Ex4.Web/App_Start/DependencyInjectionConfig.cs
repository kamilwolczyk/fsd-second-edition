using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace Fsd.Arek.Cs.Ex4.Web.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void ContainerConfig()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}