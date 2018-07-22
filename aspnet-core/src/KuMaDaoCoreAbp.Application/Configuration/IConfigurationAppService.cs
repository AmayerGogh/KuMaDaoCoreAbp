using System.Threading.Tasks;
using KuMaDaoCoreAbp.Configuration.Dto;

namespace KuMaDaoCoreAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
