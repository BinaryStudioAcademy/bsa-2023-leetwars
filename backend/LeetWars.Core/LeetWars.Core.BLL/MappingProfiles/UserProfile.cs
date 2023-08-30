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
            CreateMap<User, UserFullDto>().IncludeMembers(x => x.PreferredLanguages).IncludeMembers(x => x.LanguagesWithLevels).IncludeMembers(x => x.Solutions).IncludeMembers(x => x.Challenges).IncludeMembers(x => x.Subscriptions);
        }
    }
}
