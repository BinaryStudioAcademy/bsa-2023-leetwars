using AutoMapper;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public class ChallengeProfile : Profile
    {
        public ChallengeProfile()
        {
            CreateMap<Challenge, ChallengePreviewDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author != null ? $"{src.Author.FirstName} {src.Author.LastName}" : null))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Languages, opt => opt.MapFrom(src => src.Versions.Select(version => version.Language)))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Versions.FirstOrDefault() != null ? src.Versions.First().Status : 0));
        }
    }
}
