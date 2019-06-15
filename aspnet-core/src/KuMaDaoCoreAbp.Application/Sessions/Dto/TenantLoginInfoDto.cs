using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KuMaDaoCoreAbp.MultiTenancy;

namespace KuMaDaoCoreAbp.Sessions.Dto
{
    /// <summary></summary>
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        /// <summary></summary>
        public string TenancyName { get; set; }
        /// <summary></summary>
        public string Name { get; set; }
    }
}
