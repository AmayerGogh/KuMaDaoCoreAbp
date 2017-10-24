using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace KuMaDaoCoreAbp.EntityFrameworkCore
{
    public static class KuMaDaoCoreAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KuMaDaoCoreAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KuMaDaoCoreAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
