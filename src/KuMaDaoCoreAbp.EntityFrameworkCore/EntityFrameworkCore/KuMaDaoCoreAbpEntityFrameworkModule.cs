using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using KuMaDaoCoreAbp.EntityFrameworkCore.Seed;

namespace KuMaDaoCoreAbp.EntityFrameworkCore
{
    [DependsOn(
        typeof(KuMaDaoCoreAbpCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class KuMaDaoCoreAbpEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<KuMaDaoCoreAbpDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        KuMaDaoCoreAbpDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        KuMaDaoCoreAbpDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KuMaDaoCoreAbpEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
