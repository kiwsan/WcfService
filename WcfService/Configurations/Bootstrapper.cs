using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Configurations
{
    internal static class Bootstrapper
    {
        internal static void RegisterIoc()
        {
            var builder = new ContainerBuilder();

            // Register manager implementations.
            builder.RegisterType<Service>().As<IService>().SingleInstance();

            // Register service implementations.
            builder.RegisterType<Service>().SingleInstance();

            // Set the dependency resolver.
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }
    }
}