using CMS.DataEngine;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DancingGraphQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CMSApplication.Init();
            CreateWebHostBuilder(args).Build().RunAsync();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
