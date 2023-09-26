using AutoMapper;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.MappingProfiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile() 
        {
            CreateMap<NotificationDto, Notification>()
                .ForMember(dest => dest.SenderId, opt => opt.MapFrom(src => src.Sender!.Id))
                .ForMember(dest => dest.ChallengeId, opt => opt.MapFrom(src => src.Challenge!.Id))
                .ForMember(dest => dest.Challenge, opt => opt.Ignore())
                .ForMember(dest => dest.Sender, opt => opt.Ignore());
        }
    }
}
