using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Pzpn.Core.Cryptography;
using Pzpn.Team.Domain.Api.Services;
using Pzpn.Team.Domain.Services;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace Pzpn.Team.Web
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterResolver()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            builder.RegisterType<SecurityService>().As<ISecurityService>();
            builder.RegisterType<FakeUserService>().As<IUserService>();
            builder.RegisterType<EfPlayerService>().As<IPlayerService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}