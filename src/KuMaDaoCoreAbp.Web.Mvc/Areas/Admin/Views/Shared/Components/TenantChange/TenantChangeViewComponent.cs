using System.Threading.Tasks;
using Abp.AutoMapper;
using KuMaDaoCoreAbp.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Views.Shared.Components.TenantChange
{
    public class TenantChangeViewComponent : KuMaDaoCoreAbpViewComponent
    {
        private readonly ISessionAppService _sessionAppService;

        public TenantChangeViewComponent(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = loginInfo.MapTo<TenantChangeViewModel>();
            return View(model);
        }
    }
}
