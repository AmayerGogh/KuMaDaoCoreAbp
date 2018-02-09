using System;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using KuMaDaoCoreAbp.Authentication.JwtBearer;
using KuMaDaoCoreAbp.Configuration;
using KuMaDaoCoreAbp.Identity;
using KuMaDaoCoreAbp.Web.Resources;
using Castle.Facilities.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System.Linq;
using KuMaDaoCoreAbp.Web.Startup._pingins;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Amayer.Modules.Ueditor;



#if FEATURE_SIGNALR
using Owin;
using Abp.Owin;
using KuMaDaoCoreAbp.Owin;
#endif

namespace KuMaDaoCoreAbp.Web.Startup
{
    public class Startup
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //默认的链接数据库方式
            //services.AddDbContext<EntityFrameworkCore.KuMaDaoCoreAbpDbContext>(m => m.UseSqlServer(Configuration.GetConnectionString("")));
            //MVC
            services.AddMvc(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });
            // 为了兼容sqlserver 2008
            //.ConfigureApplicationPartManager(manager =>
            //{
            //    manager.FeatureProviders.Remove(manager.FeatureProviders.First(f => f is MetadataReferenceFeatureProvider));
            //    manager.FeatureProviders.Add(new ReferencesMetadataReferenceFeatureProvider());
            //})
            //;

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            services.AddScoped<IWebResourceManager, WebResourceManager>();
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
               // options.IncludeXmlComments("c:/Code/KuMaDaoCoreAbp/src/KuMaDaoCoreAbp.Web.Mvc/bin/Debug/netcoreapp2.0/KuMaDaoCoreAbp.Application.xml");
                // Assign scope requirements to operations based on AuthorizeAttribute
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            //see https://github.com/aspnet/Security/issues/1310
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(o => o.LoginPath = new Microsoft.AspNetCore.Http.PathString("/admin/account/login"));
            //Configure Abp and Dependency Injection

            services.AddUEditorService();
            return services.AddAbp<KuMaDaoCoreAbpWebMvcModule>(options =>
            {
                //Configure Log4Net logging
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                );               
            });
        
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); //Initializes ABP framework.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            //app.UseCookieAuthentication
            //app.UseCookieAuthentication(new Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions
            //{
               
            //    LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login")
            //});
            app.UseStaticFiles();
            
            app.UseAuthentication( );
            app.UseJwtTokenMiddleware();
            

#if FEATURE_SIGNALR
            //Integrate to OWIN
            app.UseAppBuilder(ConfigureOwinServices);
#endif

            app.UseMvc(routes =>
            {
              //  routes.MapRoute(
              //name: "other",
              //template: "{Apis}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //  Enable middleware to serve generated Swagger as a JSON endpoint
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

            app.MapSignalR();
        }
#endif
    }
}
