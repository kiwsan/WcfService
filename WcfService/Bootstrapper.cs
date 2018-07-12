using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;

namespace WcfService
{
    internal static class Bootstrapper
    {
        internal static void RegisterIoc()
        {
            var builder = new ContainerBuilder();

            // Register manager implementations.
            builder.RegisterType<AppConfigurationService>().As<IAppConfigurationService>().SingleInstance();

            // Register service implementations.
            builder.RegisterType<Service1>().SingleInstance();

            // Set the dependency resolver.
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }
    }
}
