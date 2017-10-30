using System.Collections.Generic;
using KuMaDaoCoreAbp.Roles.Dto;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
