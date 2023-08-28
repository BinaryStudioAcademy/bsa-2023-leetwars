﻿using AutoMapper;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.DAL.Entities;

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
                        .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Versions.Any() ? src.Versions.First().Status : 0));
        }
    }
}
