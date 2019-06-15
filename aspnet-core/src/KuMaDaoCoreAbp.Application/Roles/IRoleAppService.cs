using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Roles.Dto;

namespace KuMaDaoCoreAbp.Roles
{
    /// <summary></summary>
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        /// <summary></summary>
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
