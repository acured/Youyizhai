using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace YouyizhaiWebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute("PostHomeSourceList", "PostHomeSourceList", new { controller = "Resouce", action = "PostHomeSourceList" });
            config.Routes.MapHttpRoute("PostSourceDetails", "PostSourceDetails", new { controller = "Resouce", action = "PostSourceDetails" });
            config.Routes.MapHttpRoute("PostPreOrderSource", "PostPreOrderSource", new { controller = "Resouce", action = "PostPreOrderSource" });
            config.Routes.MapHttpRoute("PostOrderSource", "PostOrderSource", new { controller = "Resouce", action = "PostOrderSource" });
            config.Routes.MapHttpRoute("PostReleaseSource", "PostReleaseSource", new { controller = "Resouce", action = "PostReleaseSource" });

            config.Routes.MapHttpRoute("PostAddSource", "PostAddSource", new { controller = "Resouce", action = "PostAddSource" });
            config.Routes.MapHttpRoute("PostUpdateSource", "PostUpdateSource", new { controller = "Resouce", action = "PostUpdateSource" });
            config.Routes.MapHttpRoute("PostDeleteSource", "PostDeleteSource", new { controller = "Resouce", action = "PostDeleteSource" });
        }
    }
}
