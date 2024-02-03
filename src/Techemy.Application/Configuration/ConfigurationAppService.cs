using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Techemy.Configuration.Dto;

namespace Techemy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TechemyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
