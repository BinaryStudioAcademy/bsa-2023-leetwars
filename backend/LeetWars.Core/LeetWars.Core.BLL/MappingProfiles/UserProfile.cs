using AutoMapper;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public sealed class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserDto>();
            CreateMap<UserDto,User>();
            CreateMap<NewUserDto, User>();
            CreateMap<User, UserFullDto>();
        }
    }
}
