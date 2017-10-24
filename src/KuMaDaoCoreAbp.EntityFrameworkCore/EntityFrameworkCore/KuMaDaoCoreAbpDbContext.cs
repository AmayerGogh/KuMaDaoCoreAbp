using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KuMaDaoCoreAbp.Authorization.Roles;
using KuMaDaoCoreAbp.Authorization.Users;
using KuMaDaoCoreAbp.MultiTenancy;

namespace KuMaDaoCoreAbp.EntityFrameworkCore
{
    public class KuMaDaoCoreAbpDbContext : AbpZeroDbContext<Tenant, Role, User, KuMaDaoCoreAbpDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public KuMaDaoCoreAbpDbContext(DbContextOptions<KuMaDaoCoreAbpDbContext> options)
            : base(options)
        {
        }
    }
}
