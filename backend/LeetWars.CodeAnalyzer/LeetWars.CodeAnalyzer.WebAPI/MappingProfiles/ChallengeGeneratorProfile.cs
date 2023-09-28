using AutoMapper;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;

namespace LeetWars.CodeAnalyzer.WebAPI.MappingProfiles
{
    public class ChallengeGeneratorProfile : Profile
    {
        public ChallengeGeneratorProfile()
        {
            CreateMap<ChallengeGenerateRequestDto, ChallengeGenerateResponseDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language));

            CreateMap<OpenAiChallengeGenerateResponseDto, ChallengeGenerateResponseDto>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CompleteSolution, opt => opt.MapFrom(src => src.CompleteSolution))
                .ForMember(dest => dest.InitialSolution, opt => opt.MapFrom(src => src.InitialSolution))
                .ForMember(dest => dest.TestCases, opt => opt.MapFrom(src => src.Tests))
                .ForMember(dest => dest.ExampleTestCases, opt => opt.MapFrom(src => src.TestsSubset));
        }

    }
}
