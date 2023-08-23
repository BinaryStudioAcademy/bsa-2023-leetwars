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
           .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.UserName))
           .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
           .ForMember(dest => dest.Languages, opt => opt.MapFrom(src => src.Versions.Select(version => version.Language)));
        }
    }
}
