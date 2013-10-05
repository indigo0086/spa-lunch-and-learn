using System;
using System.Web.Http.SelfHost;
using LunchAndLearnService.Controllers;
using AttributeRouting.Web.Http.SelfHost;
using WebApiContrib.MessageHandlers;

namespace LunchAndLearnHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8080");
            config.Routes.MapHttpAttributeRoutes(cfg => cfg.AddRoutesFromController<LunchAndLearnController>());
            config.MessageHandlers.Add(new SimpleCorsHandler());
            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                Console.WriteLine("Starting Service...");
                server.OpenAsync().Wait();
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
