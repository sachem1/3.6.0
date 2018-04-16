using System.Threading.Tasks;
using Jiesen.Dispatcher.Configuration.Dto;

namespace Jiesen.Dispatcher.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
