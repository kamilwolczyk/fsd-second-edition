using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Porowiec.Michal.Services.Warehouse;
using Fsd.Porowiec.Michal.Services.Warehouse.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

            builder.RegisterType<SQLWarehauseman>().As<IWarehouseman>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}