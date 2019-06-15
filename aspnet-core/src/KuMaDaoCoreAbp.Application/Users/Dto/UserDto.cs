using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp.Users.Dto
{
    /// <summary></summary>
    [AutoMapFrom(typeof(User))]
    public class UserDto : EntityDto<long>
    {
        /// <summary></summary>
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }
        /// <summary></summary>
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }
        /// <summary></summary>
        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }
        /// <summary></summary>
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        /// <summary></summary>

        public bool IsActive { get; set; }
        /// <summary></summary>
        public string FullName { get; set; }
        /// <summary></summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary></summary>
        public DateTime CreationTime { get; set; }
        /// <summary></summary>
        public string[] RoleNames { get; set; }
    }
}
