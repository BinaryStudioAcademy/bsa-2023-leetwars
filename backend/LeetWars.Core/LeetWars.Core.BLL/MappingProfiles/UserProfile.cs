using AutoMapper;
using LeetWars.Core.Common.DTO.Badge;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.Subscription;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.DTO.UserLanguageLevel;
using LeetWars.Core.Common.DTO.UserSolution;
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

            CreateMap<User, UserFullDto>()
                .ForMember(x => x.Badges, opt =>
                    opt.MapFrom(x => x.UserBadges));
            CreateMap<Subscription,SubscriptionDto>();
            CreateMap<Language, LanguageDto>();
            CreateMap<UserLanguageLevel, UserLanguageLevelDto>();
            CreateMap<UserSolution, UserSolutionDto>();
            CreateMap<Challenge, ChallengeDto>();
            CreateMap<UserBadge, BadgeDto>()
                .ForMember(x => x.Name, opt =>
                    opt.MapFrom(x => x.Badge!.Name))
                .ForMember(x => x.Icon, opt =>
                    opt.MapFrom(x => x.Badge!.Icon));
        }
    }
}
