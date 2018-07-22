using System.Collections.Generic;
using KuMaDaoCoreAbp.Roles.Dto;
using KuMaDaoCoreAbp.Users.Dto;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}