using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Xml;
using Newtonsoft.Json.Serialization;

namespace VideoRent
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var Setting = config.Formatters.JsonFormatter.SerializerSettings;
            Setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            Setting.Formatting = (Newtonsoft.Json.Formatting)Formatting.Indented;
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
