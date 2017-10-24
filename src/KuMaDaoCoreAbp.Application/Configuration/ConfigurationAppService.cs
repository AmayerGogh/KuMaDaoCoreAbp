using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using KuMaDaoCoreAbp.Configuration.Dto;

namespace KuMaDaoCoreAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KuMaDaoCoreAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
