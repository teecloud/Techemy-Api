using Abp.Authorization;
using Techemy.Authorization.Roles;
using Techemy.Authorization.Users;

namespace Techemy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
