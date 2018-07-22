using Abp.AspNetCore.Mvc.ViewComponents;

namespace KuMaDaoCoreAbp.Web.Views
{
    public abstract class KuMaDaoCoreAbpViewComponent : AbpViewComponent
    {
        protected KuMaDaoCoreAbpViewComponent()
        {
            LocalizationSourceName = KuMaDaoCoreAbpConsts.LocalizationSourceName;
        }
    }
}