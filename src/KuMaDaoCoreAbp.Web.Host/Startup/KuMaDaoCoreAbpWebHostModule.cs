using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuMaDaoCoreAbp.Configuration;

namespace KuMaDaoCoreAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(KuMaDaoCoreAbpWebCoreModule))]
    public class KuMaDaoCoreAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KuMaDaoCoreAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KuMaDaoCoreAbpWebHostModule).GetAssembly());
        }
    }
}
