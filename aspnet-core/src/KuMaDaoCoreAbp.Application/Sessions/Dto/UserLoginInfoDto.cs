using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp.Sessions.Dto
{
    /// <summary></summary>
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        /// <summary></summary>
        public string Name { get; set; }
        /// <summary></summary>
        public string Surname { get; set; }
        /// <summary></summary>
        public string UserName { get; set; }
        /// <summary></summary>
        public string EmailAddress { get; set; }
    }
}
