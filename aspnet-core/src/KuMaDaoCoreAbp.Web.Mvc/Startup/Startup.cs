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
using Abp.Extensions;
using Microsoft.AspNetCore.Mvc.Cors.Internal;



#if FEATURE_SIGNALR
using Owin;
using Abp.Owin;
using KuMaDaoCoreAbp.Owin;
#endif

namespace KuMaDaoCoreAbp.Web.Startup
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
            //默认的链接数据库方式
            //services.AddDbContext<EntityFrameworkCore.KuMaDaoCoreAbpDbContext>(m => m.UseSqlServer(Configuration.GetConnectionString("")));
            //MVC
            services.AddMvc(options =>
            {
                //abp带 可以为所有的POST、PUT、PATCH和DLETE actions自动进行防伪造校验。
                //允许跨域
                options.Filters.Add(new CorsAuthorizationFilterFactory(DefaultCorsPolicyName));
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
           
            //see https://github.com/aspnet/Security/issues/1310
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(o => o.LoginPath = new Microsoft.AspNetCore.Http.PathString("/admin/account/login"));
            //Configure Abp and Dependency Injection
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
            app.UseCors(DefaultCorsPolicyName); // Enable CORS!
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
