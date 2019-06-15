using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.MultiTenancy;

namespace KuMaDaoCoreAbp.MultiTenancy.Dto
{
    /// <summary></summary>
    [AutoMapTo(typeof(Tenant))]
    public class CreateTenantDto
    {
        /// <summary></summary>
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        [RegularExpression(AbpTenantBase.TenancyNameRegex)]
        public string TenancyName { get; set; }
        /// <summary></summary>
        [Required]
        [StringLength(AbpTenantBase.MaxNameLength)]
        public string Name { get; set; }
        /// <summary></summary>
        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }
        /// <summary></summary>

        [StringLength(AbpTenantBase.MaxConnectionStringLength)]
        public string ConnectionString { get; set; }
        /// <summary></summary>

        public bool IsActive {get; set;}
    }
}
