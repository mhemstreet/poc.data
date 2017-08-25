using Autofac;
using Autofac.Integration.Mvc;
using poc.web.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poc.web.App_Start
{
    public static class AutofacConfig
    {
        public static IContainer RegisterDependencyResolvers()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<WebModule>();
            // builder.RegisterGeneric(typeof(GenericRepository<>))
            //        .As(typeof(IGenericRepository<>))
            //        .InstancePerRequest();


            //builder.RegisterType<DBCustomerEntities>()
            //      .As<DbContext>()
            //      .InstancePerRequest();

            //builder.RegisterType<DbFactory>()
            //       .As<IDbFactory>()
            //       .InstancePerRequest();

            //RegisterDependencyMappingDefaults(builder);
            //RegisterDependencyMappingOverrides(builder);
            IContainer container = builder.Build();
            // Set Up MVC Dependency Resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            return container;
        }
    }
}