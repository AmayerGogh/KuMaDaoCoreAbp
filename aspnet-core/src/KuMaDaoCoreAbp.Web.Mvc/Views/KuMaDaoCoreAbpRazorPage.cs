using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace KuMaDaoCoreAbp.Web.Views
{
    public abstract class KuMaDaoCoreAbpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected KuMaDaoCoreAbpRazorPage()
        {
            LocalizationSourceName = KuMaDaoCoreAbpConsts.LocalizationSourceName;
        }
    }
}
