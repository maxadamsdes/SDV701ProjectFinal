using System;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Net.Http.Headers;

namespace InstrumentShop.RestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/aspnet/web-api/overview/olderversions/self-host-a-web-api
            //Add an HTTP URL Namespace Reservation
            //netsh http add urlacl url=http://localhost:8080/ user=DESKTOP-R899KKB\matt
            //netsh http delete urlacl url=http://localhost:8080/
            // Set up server configuration
            Uri _baseAddress = new Uri("http://localhost:8080/");
            HttpSelfHostConfiguration config = new
           HttpSelfHostConfiguration(_baseAddress);
            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{action}/{id}",
             defaults: new { id = RouteParameter.Optional }
             );
            //config.EnableCors(new EnableCorsAttribute("*", headers: "*", methods:"*")); //needed for Angular/Vue
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new
           MediaTypeHeaderValue("text/html"));
            // Trying to let JSON contain Type Names (i.e. class names)
            // Small benefit for JSON overhead:
            // + allows class names to be discovered.
            // - sub-types only work if client and server are M'soft and share DTO dll,
            // which defeats the purpose of platform independent services
            //config.Formatters.JsonFormatter.SerializerSettings.TypeNameHandling = TypeNameHandling.Objects;
            //config.Formatters.JsonFormatter.SerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
            // Create server
            HttpSelfHostServer server = new HttpSelfHostServer(config);
            // Start listening
            server.OpenAsync().Wait();
            Console.WriteLine("Gallery Web-API Self hosted on " + _baseAddress);
            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
            server.CloseAsync().Wait();
        }
    }
}
