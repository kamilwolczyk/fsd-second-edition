using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Porowiec.Michal.Cs4.App_Start
{
    public class DependencyIncectionStart
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

           //Here insert new dependency injection

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}