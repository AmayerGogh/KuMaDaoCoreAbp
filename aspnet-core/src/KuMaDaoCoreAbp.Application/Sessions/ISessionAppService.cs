using System.Threading.Tasks;
using Abp.Application.Services;
using KuMaDaoCoreAbp.Sessions.Dto;

namespace KuMaDaoCoreAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
