using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MyWebSite.Controllers;
using MyWebSite.Service;
using Unity.Mvc4;
using Unity.AutoRegistration;

namespace MyWebSite
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            try
            {
                var container = new UnityContainer();

                var services = Assembly.GetAssembly(typeof (ReferentialService));

                var types = AllClasses.FromAssemblies(services);//.Where(x=>!x.Name.EndsWith("Service")

                container.RegisterTypes(
                                        types,
                                        WithMappings.None,
                                        WithName.TypeName,
                                        WithLifetime.Hierarchical
                                        );

                DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            }
            catch (ReflectionTypeLoadException ex)
            {
                
            }
        }
    }
}