﻿using Abp.Modules;
using Abp.Reflection.Extensions;
using KuMaDaoCoreAbp.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace KuMaDaoCoreAbp.Web.Startup
{
    [DependsOn(typeof(KuMaDaoCoreAbpWebCoreModule))]
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
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KuMaDaoCoreAbpWebMvcModule).GetAssembly());
        }
    }
}