using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Core.Common.DTO.CodeFight
{
    public class CodeFightRequestNotificationDto
    {
        public long SenderId { get; set; }
        public long ReceiverId { get; set; }
        public NotificationDto Notification { get; set; } = null!;
    }
}
