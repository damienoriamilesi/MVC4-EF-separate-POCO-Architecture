using System.Web.Mvc;
using System.Web.Routing;

namespace MyWebSite.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Referential", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}