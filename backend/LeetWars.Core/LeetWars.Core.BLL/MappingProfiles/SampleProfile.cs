﻿using AutoMapper;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public sealed class SampleProfile : Profile
    {
        public SampleProfile()
        {
            CreateMap<Sample, SampleDto>();
            CreateMap<SampleDto, Sample>();
            CreateMap<NewSampleDto, Sample>();
            CreateMap<User, UserDto>();
            CreateMap<NewUserDto, User>();
        }
    }
}
