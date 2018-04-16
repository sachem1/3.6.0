using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jiesen.Dispatcher.MultiTenancy.Dto;

namespace Jiesen.Dispatcher.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
