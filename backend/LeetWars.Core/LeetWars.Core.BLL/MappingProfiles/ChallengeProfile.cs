using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.BLL.MappingProfiles.Resolvers;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.ChallengeVersion;
using LeetWars.Core.Common.DTO.Test;
using LeetWars.Core.Common.DTO.UserSolution;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public class ChallengeProfile : Profile
    {
        public ChallengeProfile()
        {
            CreateMap<Challenge, ChallengePreviewDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author != null ? $"{src.Author.FirstName} {src.Author.LastName}" : null))
                .ForMember(dest => dest.LevelName, opt => opt.MapFrom(src => src.Level != null ? src.Level.Name : null))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Languages, opt => opt.MapFrom(src => src.Versions.Select(version => version.Language)))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Versions.Any() ? src.Versions.First().Status : 0))
                .ForMember(dest => dest.IsStarry, opt => opt.MapFrom<ChallengeStarResolver>())
                .ForMember(dest => dest.StarsAmount, opt => opt.MapFrom(src => src.Stars.Count));

            CreateMap<ChallengeVersion, ChallengeVersionFullDto>();
            
            CreateMap<UserSolution, UserSolutionDto>();
            
            CreateMap<Test, TestDto>();
            
            CreateMap<ChallengeLevel, ChallengeLevelDto>();
            
            CreateMap<Challenge, ChallengeFullDto>();

            CreateMap<NewChallengeDto, Challenge>()
                .ForMember(dest => dest.Tags, opt => opt.Ignore())
                .ForMember(dest => dest.Versions, opt => opt.Ignore());
            
            CreateMap<NewChallengeVersionDto, ChallengeVersion>();

            CreateMap<Challenge, ChallengeDto>();

            CreateMap<Challenge, BriefChallengeInfoDto>();

            CreateMap<ChallengeStar, ChallengeStarDto>()
                .ForMember(dest => dest.IsStar, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.Challenge, opt => opt.MapFrom(src => src.Challenge))
                .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.AuthorId));

            CreateMap<ChallengeStarDto, ChallengeStar>()
                .ForMember(dest => dest.ChallengeId, opt => opt.MapFrom(src => src.Challenge.Id))
                .ForMember(dest => dest.Challenge, opt => opt.Ignore());
        }
    }
}
