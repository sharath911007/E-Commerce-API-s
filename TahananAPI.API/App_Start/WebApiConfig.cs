using Unity;
using Unity.WebApi;
using System.Web.Http;

using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using TahananAPI.Data.Interface;
using TahananAPI.Data.Repositories;
using TahananAPI.Business.Interface;
using TahananAPI.Business.Managers;

namespace TahananAPI.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var container = new UnityContainer();

            // Regestering the Interfaces and class for unit dependency injuction

         
            container.RegisterType<IMasterRrepository, MasterRepository>();
            container.RegisterType<IMasterManager, MasterManager>();

            container.RegisterType<IAdminRepository, AdminRepository>();
            container.RegisterType<IAdminManager, AdminManager>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            config.DependencyResolver = new UnityDependencyResolver(container);

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
