using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<IStartup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context,next) =>
            {
                logger.LogInformation("MW1 : Incoming request.");
                await next();
                logger.LogInformation("MW1 : Outgoing response.");
            });

            app.Use(async (context,next) =>
            {
                logger.LogInformation("MW2 : Incoming request.");
                await next();
                logger.LogInformation("MW2 : Outgoing response.");
            });

            app.Run(async (context) =>
            {
                logger.LogInformation("End of pipeline");
                await context.Response.WriteAsync(_config["MyKey"]);
            });
        }
    }
}
