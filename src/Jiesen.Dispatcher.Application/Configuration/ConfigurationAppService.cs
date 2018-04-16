using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Jiesen.Dispatcher.Configuration.Dto;

namespace Jiesen.Dispatcher.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DispatcherAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
