using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Authorization;

namespace KuMaDaoCoreAbp.Roles.Dto
{
    /// <summary></summary>
    [AutoMapFrom(typeof(Permission))]
    public class PermissionDto : EntityDto<long>
    {
        /// <summary></summary>
        public string Name { get; set; }
        /// <summary></summary>
        public string DisplayName { get; set; }
        /// <summary></summary>
        public string Description { get; set; }
    }
}
