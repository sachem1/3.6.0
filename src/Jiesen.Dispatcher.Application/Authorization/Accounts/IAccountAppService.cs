using System.Threading.Tasks;
using Abp.Application.Services;
using Jiesen.Dispatcher.Authorization.Accounts.Dto;

namespace Jiesen.Dispatcher.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
