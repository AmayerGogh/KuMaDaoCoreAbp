using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuMaDaoCoreAbp.Articles.Mapper;
using KuMaDaoCoreAbp.Authorization;
using KuMaDaoCoreAbp.Categories.Mapper;

namespace KuMaDaoCoreAbp
{
    [DependsOn(
        typeof(KuMaDaoCoreAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KuMaDaoCoreAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KuMaDaoCoreAbpAuthorizationProvider>();


            Configuration.Modules.AbpAutoMapper().Configurators.Add(ArticleDtoMapper.CreateMappings);
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomerCategoryMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KuMaDaoCoreAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
            //Configuration.Modules.AbpConfiguration
            
        }
    }
}
