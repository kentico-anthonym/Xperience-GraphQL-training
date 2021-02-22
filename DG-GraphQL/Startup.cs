using CMS.DataEngine;
using DG_GraphQL.Middleware;
using DGModels;
using DGModels.Types;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DancingGraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Types
            services.AddSingleton<DancingGoatData>();
            services.AddSingleton<DancingGoatQuery>();
            services.AddSingleton<DancingGoatMutation>();
            services.AddSingleton<CoffeeModel>();
            services.AddSingleton<CoffeeInputType>();
            services.AddSingleton<BrewerModel>();
            services.AddSingleton<BrewerInputType>();
            services.AddSingleton<ProductInterface>();
            services.AddSingleton<DancingGoatSchema>();

            services.AddLogging(builder => builder.AddConsole());
            services.AddHttpContextAccessor();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
            })
            .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
            .AddSystemTextJson()
            .AddUserContextBuilder(httpContext => new GraphQLUserContext { User = httpContext.User });
        }
        public IHostingEnvironment Environment { get; set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    //await context.Response.WriteAsync("Hello World!");
            //});

            app.UseGraphQL<DancingGoatSchema>("/graphql");

            app.UseGraphQLPlayground();
            //app.UseGraphQLWebSockets<DancingGoatSchema>("/graphql-ws");
            //app.UseGraphiQLServer();
            //app.UseGraphQLAltair();
            //app.UseGraphQLVoyager();
        }
    }
}
