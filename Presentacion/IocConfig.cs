using Autofac;
//using Presentacion.LoggerService;
using Belatrix.Logger.Service;
using Belatrix.Logger.Service.Interfaces;
//using Presentacion.LoggerService;
using System.ServiceModel;

namespace Belatrix.Logger.App
{
    public static class IocConfigApp
    {

        public static IContainer RegisterIoc()
        {
            ContainerBuilder builder = new ContainerBuilder();

      



            return builder.Build();
        }
    }
}
