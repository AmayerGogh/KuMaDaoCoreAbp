using System.Threading.Tasks;
using Abp.Application.Services;
using KuMaDaoCoreAbp.Authorization.Accounts.Dto;

namespace KuMaDaoCoreAbp.Authorization.Accounts
{
    /// <summary></summary>
    public interface IAccountAppService : IApplicationService
    {
        /// <summary></summary>
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);
        /// <summary></summary>
        Task<RegisterOutput> Register(RegisterInput input);
    }
}
