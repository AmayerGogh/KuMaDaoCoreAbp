using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuMaDaoCoreAbp.Articles.Authorization;
//using KuMaDaoCoreAbp.Articles.Authorization;
using KuMaDaoCoreAbp.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace KuMaDaoCoreAbp.Web.Startup
{
    [DependsOn(typeof(KuMaDaoCoreAbpWebCoreModule))]//依赖该模块
    public class KuMaDaoCoreAbpWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KuMaDaoCoreAbpWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
            
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<KuMaDaoCoreAbpNavigationProvider>();

            Configuration.Authorization.Providers.Add<ArticleAppAuthorizationProvider>();

            
        }

        public override void Initialize()
        {
            //禁用多租户
            //Configuration.MultiTenancy.IsEnabled = true;
            //这行代码的写法基本上是不变的。它的作用是把当前程序集的特定类或接口注册到依赖注入容器中。
            IocManager.RegisterAssemblyByConvention(typeof(KuMaDaoCoreAbpWebMvcModule).GetAssembly());
            //为一个模块创建配置 测试
            //Configuration.Modules.MyModule().SampleConfig1 = false;
            
        }
    }

    #region 测试
    //public static class MyModuleConfigurationExtensions
    //{
    //    public static MyModuleConfig MyModule(this IModuleConfigurations moduleConfigurations)
    //    {
    //        return moduleConfigurations.AbpConfiguration.GetOrCreate("MyModuleConfig", () =>
    //            moduleConfigurations.AbpConfiguration.IocManager.Resolve<MyModuleConfig>()
    //        );
    //    }
    //}

    //public class MyModuleConfig
    //{
    //    public bool SampleConfig1 { get; set; }

    //}

    ////直接就能使用
    //public class MyService : ITransientDependency
    //{
    //    private readonly MyModuleConfig _configuration;

    //    public MyService(MyModuleConfig configuration)
    //    {
    //        _configuration = configuration;
    //    }


    //    public void DoIt()
    //    {
    //        if (_configuration.SampleConfig1)
    //        {
    //            //...
    //        }
    //    }
    //}
    #endregion

}