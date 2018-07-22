using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace KuMaDaoCoreAbp.Controllers
{
    public abstract class KuMaDaoCoreAbpControllerBase: AbpController
    {
        protected KuMaDaoCoreAbpControllerBase()
        {
            LocalizationSourceName = KuMaDaoCoreAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
