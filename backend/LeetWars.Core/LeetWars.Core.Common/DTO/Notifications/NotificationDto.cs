using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Friendship;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Notifications
{
    public class NotificationDto : Entity<long>
    {
        public TypeNotifications TypeNotification { get; set; }
        public BriefUserInfoDto? Sender { get; set; }
        public BriefChallengeInfoDto? Challenge { get; set; }
        public bool IsRead { get; set; }
        public UpdateFriendshipDto? UpdateFriendship { get; set; }
        public string? ReceiverId { get; set; }
        public string? Message { get; set; }
        public DateTime DateSending { get; set; } = DateTime.UtcNow;
        public long? ShowFor { get; set; }
    }
}
