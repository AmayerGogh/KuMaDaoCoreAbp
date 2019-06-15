using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.MultiTenancy.Dto;

namespace KuMaDaoCoreAbp.MultiTenancy
{
    /// <summary></summary>
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
