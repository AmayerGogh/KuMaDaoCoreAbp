﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KuMaDaoCoreAbp.Authorization.Roles;
using KuMaDaoCoreAbp.Authorization.Users;
using KuMaDaoCoreAbp.MultiTenancy;
using KuMaDaoCoreAbp.Articles;
using KuMaDaoCoreAbp.Types;
using KuMaDaoCoreAbp.Files;
using KuMaDaoCoreAbp.Categories;

namespace KuMaDaoCoreAbp.EntityFrameworkCore
{
    public class KuMaDaoCoreAbpDbContext : AbpZeroDbContext<Tenant, Role, User, KuMaDaoCoreAbpDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public KuMaDaoCoreAbpDbContext(DbContextOptions<KuMaDaoCoreAbpDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleDetail> ArticleDetail { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<BaseData> BaseData { get; set; }
        public virtual DbSet<BaseDataType> BaseDataType { get; set; }

        public virtual DbSet<File> File { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //表名配置
            // modelBuilder.Entity<Articles.Article>().ToTable("Article");
            base.OnModelCreating(modelBuilder);
        }
    }
}
