using System.Threading.Tasks;
using KuMaDaoCoreAbp.Configuration.Dto;

namespace KuMaDaoCoreAbp.Configuration
{
    /// <summary></summary>
    public interface IConfigurationAppService
    {
        /// <summary></summary>
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
