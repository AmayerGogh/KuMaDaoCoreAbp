using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KuMaDaoCoreAbp.Authorization.Roles;
using KuMaDaoCoreAbp.Authorization.Users;
using KuMaDaoCoreAbp.MultiTenancy;
using KuMaDaoCoreAbp.Migrations;

namespace KuMaDaoCoreAbp.EntityFrameworkCore
{
    public class KuMaDaoCoreAbpDbContext : AbpZeroDbContext<Tenant, Role, User, KuMaDaoCoreAbpDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public KuMaDaoCoreAbpDbContext(DbContextOptions<KuMaDaoCoreAbpDbContext> options)
            : base(options)
        {
        }

           
        public virtual DbSet<Articles.Article> Article { get; set; }
        public virtual DbSet<Articles.ArticleDetail> ArticleDetail { get; set; }
    }
}
