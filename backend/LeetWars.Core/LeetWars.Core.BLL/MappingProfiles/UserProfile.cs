using AutoMapper;
using LeetWars.Core.BLL.MappingProfiles.Resolvers;
using LeetWars.Core.Common.DTO.Badge;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Subscription;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.DTO.UserLanguageLevel;
using LeetWars.Core.Common.DTO.UserSolution;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(s => s.ImagePath,
                    opt => opt
                        .ConvertUsing<ImageNameFormatter, string>(src => src.ImagePath!))
                .ReverseMap();

            CreateMap<User, BriefUserInfoDto>().ReverseMap();

            CreateMap<NewUserDto, User>();

            CreateMap<UpdateUserInfoDto, User>();

            CreateMap<User, UserFullDto>()
                .ForMember(s => s.ImagePath,
                    opt => opt
                        .ConvertUsing<ImageNameFormatter, string>(src => src.ImagePath!))
                .ForMember(x => x.Badges, opt =>
                    opt.MapFrom(x => x.UserBadges)).ReverseMap();
            CreateMap<Subscription, SubscriptionDto>();

            CreateMap<UserLanguageLevel, UserLanguageLevelDto>();
            CreateMap<UserSolution, UserSolutionDto>();
            CreateMap<Challenge, ChallengeDto>();
            CreateMap<Badge, BadgeDto>()
                .ForMember(s => s.Icon,
                    opt => opt
                        .ConvertUsing<ImageNameFormatter, string>(src => src.Icon))
                .ForMember(s => s.IconGif,
                    opt => opt
                        .ConvertUsing<ImageNameFormatter, string>(src => src.IconGif));

            CreateMap<UserBadge, BadgeDto>()
                .IncludeMembers(x => x.Badge);
        }
    }
}
