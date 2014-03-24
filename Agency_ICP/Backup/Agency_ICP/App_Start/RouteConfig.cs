using System.Web.Routing;
using System.Web.Mvc;

namespace Agency_ICP.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "SaleEntrust", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}