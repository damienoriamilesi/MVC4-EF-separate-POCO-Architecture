using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MyWebSite.Data;
using MyWebSite.Service;
using Unity.Mvc4;
using UnityConfiguration;

namespace MyWebSite.Web
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers
      
      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      //container.AddNewExtension<UnityContainerExtensions.>();
      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.Configure(c => c.Scan(scan =>
        {
            scan.AssemblyContaining<ReferentialService>();
            scan.AssemblyContaining<ReferentialRepository>();

            scan.WithNamingConvention();
        }));
    }
  }
}