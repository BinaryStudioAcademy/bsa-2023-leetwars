using AutoMapper;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.LanguageVersion;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, LanguageDto>().ReverseMap();

            CreateMap<Language, LanguageFullDto>().ReverseMap();

            CreateMap<LanguageVersion, LanguageVersionDto>().ReverseMap();
        }
    }
}
