using System.Threading.Tasks;
using Abp.Application.Services;
using KuMaDaoCoreAbp.Sessions.Dto;

namespace KuMaDaoCoreAbp.Sessions
{
    /// <summary></summary>
    public interface ISessionAppService : IApplicationService
    {
        /// <summary></summary>
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
