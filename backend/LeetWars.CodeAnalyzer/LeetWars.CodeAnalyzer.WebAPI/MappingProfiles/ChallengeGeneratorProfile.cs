using AutoMapper;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;

namespace LeetWars.CodeAnalyzer.WebAPI.MappingProfiles
{
    public class ChallengeGeneratorProfile : Profile
    {
        public ChallengeGeneratorProfile()
        {
            CreateMap<ChallengeGenerateRequestDto, ChallengeGenerateResponseDto>().ReverseMap();

            CreateMap<OpenAiChallengeGenerateResponseDto, ChallengeGenerateResponseDto>()
                .ForMember(dest => dest.TestCases, opt => opt.MapFrom(src => src.Tests))
                .ForMember(dest => dest.ExampleTestCases, opt => opt.MapFrom(src => src.TestsSubset))
                .ReverseMap();
        }
    }
}
