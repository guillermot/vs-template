using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web_site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "login",
                url: "login",
                defaults: new { controller = "Home", action = "Login" }
            );

            routes.MapRoute(
                name: "user-profile",
                url: "user-profile",
                defaults: new { controller = "Home", action = "UserProfile" }
            );

            routes.MapRoute(
                name: "maps",
                url: "maps",
                defaults: new { controller = "Home", action = "Maps" }
            );

            routes.MapRoute(
                name: "icons",
                url: "icons",
                defaults: new { controller = "Home", action = "Icons" }
            );

            routes.MapRoute(
                name: "typography",
                url: "typography",
                defaults: new { controller = "Home", action = "Typography" }
            );

            routes.MapRoute(
                name: "table-list",
                url: "table-list",
                defaults: new { controller = "Home", action = "TableList" }
            );

            routes.MapRoute(
                name: "notifications",
                url: "notifications",
                defaults: new { controller = "Home", action = "TableList" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
