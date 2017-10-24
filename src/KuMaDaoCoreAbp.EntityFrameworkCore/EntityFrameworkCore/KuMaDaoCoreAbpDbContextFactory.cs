using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using KuMaDaoCoreAbp.Configuration;
using KuMaDaoCoreAbp.Web;

namespace KuMaDaoCoreAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KuMaDaoCoreAbpDbContextFactory : IDesignTimeDbContextFactory<KuMaDaoCoreAbpDbContext>
    {
        public KuMaDaoCoreAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KuMaDaoCoreAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KuMaDaoCoreAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KuMaDaoCoreAbpConsts.ConnectionStringName));

            return new KuMaDaoCoreAbpDbContext(builder.Options);
        }
    }
}
