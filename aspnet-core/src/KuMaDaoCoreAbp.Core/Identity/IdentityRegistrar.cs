using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using KuMaDaoCoreAbp.Authorization;
using KuMaDaoCoreAbp.Authorization.Roles;
using KuMaDaoCoreAbp.Authorization.Users;
using KuMaDaoCoreAbp.Editions;
using KuMaDaoCoreAbp.MultiTenancy;

namespace KuMaDaoCoreAbp.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
