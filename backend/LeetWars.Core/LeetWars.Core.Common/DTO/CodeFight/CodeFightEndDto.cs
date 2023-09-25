using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Core.Common.DTO.CodeFight
{
    public class CodeFightEndDto
    {
        public bool IsSenderWinner { get; set; }
        public NewNotificationDto Notification { get; set; } = null!;
    }
}
