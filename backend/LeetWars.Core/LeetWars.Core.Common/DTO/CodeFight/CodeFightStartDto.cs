using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Core.Common.DTO.CodeFight
{
    public class CodeFightStartDto
    {
        public string SenderId { get; set; } = string.Empty;
        public string ReceiverId { get; set; } = string.Empty;
        public long ChallengeId { get; set; }
        public NotificationDto Notification { get; set; } = null!;
    }
}
