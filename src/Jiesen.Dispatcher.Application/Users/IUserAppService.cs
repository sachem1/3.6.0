using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jiesen.Dispatcher.Roles.Dto;
using Jiesen.Dispatcher.Users.Dto;

namespace Jiesen.Dispatcher.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
