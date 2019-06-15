using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp.Users.Dto
{
    /// <summary></summary>
    [AutoMapTo(typeof(User))]
    public class CreateUserDto : IShouldNormalize
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
        public string[] RoleNames { get; set; }
        /// <summary></summary>

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }
        /// <summary></summary>
        public void Normalize()
        {
            if (RoleNames == null)
            {
                RoleNames = new string[0];
            }
        }
    }
}
