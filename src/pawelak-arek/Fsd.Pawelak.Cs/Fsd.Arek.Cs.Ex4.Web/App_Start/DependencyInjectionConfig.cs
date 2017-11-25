﻿using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;
using Fsd.Arek.Cs.Ex4.Services.Services;

namespace Fsd.Arek.Cs.Ex4.Web.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void ContainerConfig()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<FakeAdvertServices>().As<IAdvertsServices>().InstancePerLifetimeScope();
            builder.RegisterType<Warehause>().As<IWarehause>().InstancePerLifetimeScope();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}