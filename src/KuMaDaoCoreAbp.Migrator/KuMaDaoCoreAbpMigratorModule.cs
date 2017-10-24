using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using KuMaDaoCoreAbp.Configuration;
using KuMaDaoCoreAbp.EntityFrameworkCore;
using KuMaDaoCoreAbp.Migrator.DependencyInjection;

namespace KuMaDaoCoreAbp.Migrator
{
    [DependsOn(typeof(KuMaDaoCoreAbpEntityFrameworkModule))]
    public class KuMaDaoCoreAbpMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public KuMaDaoCoreAbpMigratorModule(KuMaDaoCoreAbpEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(KuMaDaoCoreAbpMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                KuMaDaoCoreAbpConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KuMaDaoCoreAbpMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
