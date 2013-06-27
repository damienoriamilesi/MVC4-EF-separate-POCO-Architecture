using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using MyWebSite.App_Start;
using MyWebSite.Service;
using Unity.AutoRegistration;
using Unity.Mvc4;

namespace MyWebSite
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Bootstrapper.Initialise();

            var container = new UnityContainer();
            

            var services = Assembly.GetAssembly(typeof(ReferentialService));

            var types = AllClasses.FromLoadedAssemblies().Where(x=>x.Assembly.ContainsType<ReferentialService>());//FromAssemblies(services);//.Where(x=>!x.Name.EndsWith("Service")

            container.RegisterTypes(
                                    types,
                                    WithMappings.FromAllInterfaces,
                                    WithName.TypeName,
                                    WithLifetime.Transient
                                    );            
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));


        }
    }
}