using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KuMaDaoCoreAbp.Roles.Dto;
using KuMaDaoCoreAbp.Users.Dto;

namespace KuMaDaoCoreAbp.Users
{
    /// <summary></summary>
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        /// <summary></summary>
        Task<ListResultDto<RoleDto>> GetRoles();
        /// <summary></summary>
        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
