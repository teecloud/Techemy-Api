using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Techemy.Controllers
{
    public abstract class TechemyControllerBase: AbpController
    {
        protected TechemyControllerBase()
        {
            LocalizationSourceName = TechemyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
