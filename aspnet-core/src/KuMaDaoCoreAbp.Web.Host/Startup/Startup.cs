﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Swashbuckle.AspNetCore.Swagger;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using Abp.Extensions;
using KuMaDaoCoreAbp.Authentication.JwtBearer;
using KuMaDaoCoreAbp.Configuration;
using KuMaDaoCoreAbp.Identity;

#if FEATURE_SIGNALR
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;
using KuMaDaoCoreAbp.Owin;
using Abp.Owin;
#endif

namespace KuMaDaoCoreAbp.Web.Host.Startup
{
    public class Startup
    {
        private const string DefaultCorsPolicyName = "localhost";

        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddMvc(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory(DefaultCorsPolicyName));
            });

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);
           

            // Swagger - Enable this line and the related lines in Configure method to enable swagger UI
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "KuMaDaoCoreAbp API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);

                // Define the BearerAuth scheme that's in use
                options.AddSecurityDefinition("bearerAuth", new ApiKeyScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                //options.IncludeXmlComments("C:/Code/KuMaDaoCoreAbp/src/KuMaDaoCoreAbp.Web.Host/bin/Debug/netcoreapp2.0/KuMaDaoCoreAbp.Application.xml");
                options.IncludeXmlComments(@"D:\Amayer\KuMaDaoCoreAbp\src\KuMaDaoCoreAbp.Web.Host\bin\Debug\netcoreapp2.0\KuMaDaoCoreAbp.Application.xml");
                // Assign scope requirements to operations based on AuthorizeAttribute
                //options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            //允许跨域
            services.AddCors(options =>
            {
                options.AddPolicy(DefaultCorsPolicyName, builder =>
                {
                    // App:CorsOrigins in appsettings.json can contain more than one address separated by comma.
                    builder
                    .WithOrigins(_appConfiguration["App:CorsOrigins"].Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(o => o.RemovePostFix("/"))
                    .ToArray())
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            // Configure Abp and Dependency Injection
            return services.AddAbp<KuMaDaoCoreAbpWebHostModule>(options =>
            {
                // Configure Log4Net logging
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                );
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); // Initializes ABP framework.

            app.UseCors(DefaultCorsPolicyName); // Enable CORS!

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseJwtTokenMiddleware();

#if FEATURE_SIGNALR
            // Integrate to OWIN
            app.UseAppBuilder(ConfigureOwinServices);
#endif

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();
            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                options.InjectOnCompleteJavaScript("/swagger/ui/abp.js");
                options.InjectOnCompleteJavaScript("/swagger/ui/on-complete.js");
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "KuMaDaoCoreAbp API V1");
                options.ShowRequestHeaders();
            }); // URL: /swagger
        }

#if FEATURE_SIGNALR
        private static void ConfigureOwinServices(IAppBuilder app)
        {
            app.Properties["host.AppName"] = "KuMaDaoCoreAbp";

            app.UseAbp();
            
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                    EnableJSONP = true
                };
                map.RunSignalR(hubConfiguration);
            });
        }
#endif
    }
}
