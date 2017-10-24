using Abp.AutoMapper;
using KuMaDaoCoreAbp.Sessions.Dto;

namespace KuMaDaoCoreAbp.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}