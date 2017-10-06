using System.Linq;
using Autofac;
using System.Reflection;
//using Belatrix.Logger.Service.Interfaces;
using Belatrix.Logger.Domain;
using Belatrix.Logger.Interfaces;
using Belatrix.Logger.Transversal;
using Belatrix.Logger.Service;
using Belatrix.Logger.Service.Interfaces;

namespace Belatrix.Logger.UnitTest
{
    public static class IocConfigTest
    {

        public static IContainer RegisterIoc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<JobLoggerFileDomain>().Keyed<IJobloggerDomain>(Configuration.File);
            builder.RegisterType<JobLoggerDatabaseDomain>().Keyed<IJobloggerDomain>(Configuration.Database);

            builder.RegisterType<JobLoggerService>().As<IJobLoggerService>();

            builder.RegisterAssemblyTypes(Assembly.Load("Belatrix.Logger.Service.Interfaces"))
           .Where(t => t.Name.EndsWith("Services"))
           .AsImplementedInterfaces()
           .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.Load("Belatrix.Logger.Repository"))
               .Where(t => t.Name.EndsWith("Repository"))
               .AsImplementedInterfaces()
               .InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
