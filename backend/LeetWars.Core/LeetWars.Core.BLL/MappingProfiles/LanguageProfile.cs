﻿using AutoMapper;
using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, LanguageDto>();
            CreateMap<Language, LanguageDto>().ReverseMap();
        }
    }
}
