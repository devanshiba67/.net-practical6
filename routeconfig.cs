
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication14
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            // Product Routing
            routes.MapRoute(
                name: "Product",
                url: "Product/{action}/{id}",
                defaults: new
                {
                    controller = "Product",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            // Default Routing
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
