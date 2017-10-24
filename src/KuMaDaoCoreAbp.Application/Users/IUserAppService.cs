using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Roles.Dto;
using KuMaDaoCoreAbp.Users.Dto;

namespace KuMaDaoCoreAbp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
