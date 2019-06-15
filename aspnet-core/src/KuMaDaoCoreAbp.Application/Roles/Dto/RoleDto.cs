using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using Abp.AutoMapper;
using KuMaDaoCoreAbp.Authorization.Roles;

namespace KuMaDaoCoreAbp.Roles.Dto
{
    /// <summary></summary>
    [AutoMap(typeof(Role))]
    public class RoleDto : EntityDto<int>
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
