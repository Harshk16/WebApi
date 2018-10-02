using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using WebApi.Core.Interfaces;
using WebApi.Core.Model.Interfaces;
using WebApi.Core.Model.Models;
using WebApi.Core.Service;
using WebApi.Data.Repository;

namespace WebApi.Web.Api
{
    public static class AutoFacConfig
    {
        public static void ConfigureDependencyInjection()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<GenericRepository<User>>().As<IRepository<User>>();

            builder.RegisterType<TestService>().As<ITestService>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}