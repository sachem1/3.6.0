using System.Threading.Tasks;
using Abp.Application.Services;
using Jiesen.Dispatcher.Sessions.Dto;

namespace Jiesen.Dispatcher.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
