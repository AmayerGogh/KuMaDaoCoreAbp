using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using KuMaDaoCoreAbp.Authorization.Roles;

using Abp.Authorization.Roles;

namespace KuMaDaoCoreAbp.Roles.Dto
{
    /// <summary></summary>
    [AutoMapTo(typeof(Role))]
    public class CreateRoleDto
    {
        /// <summary></summary>
        [Required]
        [StringLength(AbpRoleBase.MaxNameLength)]
        public string Name { get; set; }
        /// <summary></summary>
        [Required]
        [StringLength(AbpRoleBase.MaxDisplayNameLength)]
        public string DisplayName { get; set; }
        /// <summary></summary>

        public string NormalizedName { get; set; }
        /// <summary></summary>
        [StringLength(Role.MaxDescriptionLength)]
        public string Description { get; set; }
        /// <summary></summary>
        public bool IsStatic { get; set; }
        /// <summary></summary>
        public List<string> Permissions { get; set; }
    }
}
