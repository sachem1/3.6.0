using Abp.Authorization;
using Jiesen.Dispatcher.Authorization.Roles;
using Jiesen.Dispatcher.Authorization.Users;

namespace Jiesen.Dispatcher.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
