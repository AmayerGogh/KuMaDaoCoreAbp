using Abp.Authorization;
using KuMaDaoCoreAbp.Authorization.Roles;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
