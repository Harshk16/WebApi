using Autofac;
using WebApi.Core.Interfaces;
using WebApi.Core.Service;

namespace WebApi.Infrastructure.DependencyInjection.Api
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestService>().As<ITestService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
