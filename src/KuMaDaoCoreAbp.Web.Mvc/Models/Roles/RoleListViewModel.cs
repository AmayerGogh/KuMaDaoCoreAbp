using System.Collections.Generic;
using KuMaDaoCoreAbp.Roles.Dto;

namespace KuMaDaoCoreAbp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
