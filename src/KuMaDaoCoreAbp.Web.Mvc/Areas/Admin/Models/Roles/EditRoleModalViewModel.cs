using System.Collections.Generic;
using System.Linq;
using KuMaDaoCoreAbp.Roles.Dto;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Roles
{
    public class EditRoleModalViewModel
    {
        public RoleDto Role { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }

        public bool HasPermission(PermissionDto permission)
        {
            return Permissions != null && Role.Permissions.Any(p => p == permission.Name);
        }
    }
}
