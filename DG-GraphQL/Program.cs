using CMS.DataEngine;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DancingGraphQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = CMSApplication.Init();
            
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
