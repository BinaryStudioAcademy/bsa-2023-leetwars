using AutoMapper;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagDto>().ReverseMap();
        }
    }
}
