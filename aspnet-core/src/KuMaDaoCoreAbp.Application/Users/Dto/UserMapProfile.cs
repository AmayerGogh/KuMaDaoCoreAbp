using AutoMapper;
using KuMaDaoCoreAbp.Authorization.Users;

namespace KuMaDaoCoreAbp.Users.Dto
{
    /// <summary></summary>
    public class UserMapProfile : Profile
    {
        /// <summary></summary>
        public UserMapProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
        }
    }
}
