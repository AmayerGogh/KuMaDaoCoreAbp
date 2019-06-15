using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using KuMaDaoCoreAbp.MultiTenancy;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class KuMaDaoCoreAbpAppServiceBase : ApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        public TenantManager TenantManager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UserManager UserManager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        protected KuMaDaoCoreAbpAppServiceBase()
        {
            LocalizationSourceName = KuMaDaoCoreAbpConsts.LocalizationSourceName;
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }
        /// <summary>
        /// 
        /// </summary>
        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
