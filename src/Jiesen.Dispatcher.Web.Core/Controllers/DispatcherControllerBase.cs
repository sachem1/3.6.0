using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Jiesen.Dispatcher.Controllers
{
    public abstract class DispatcherControllerBase: AbpController
    {
        protected DispatcherControllerBase()
        {
            LocalizationSourceName = DispatcherConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
