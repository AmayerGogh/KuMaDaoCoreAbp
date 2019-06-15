using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using KuMaDaoCoreAbp.Authorization.Roles;

namespace KuMaDaoCoreAbp.Roles.Dto
{
    /// <summary></summary>
    public class RoleMapProfile : Profile
    {
        /// <summary></summary>
        public RoleMapProfile()
        {
           
           
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
          
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);
           
            CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
            
            CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
        }
    }
}
