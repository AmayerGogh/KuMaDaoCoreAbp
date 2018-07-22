using System.Threading.Tasks;
using Abp.Application.Services;
using KuMaDaoCoreAbp.Authorization.Accounts.Dto;

namespace KuMaDaoCoreAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
