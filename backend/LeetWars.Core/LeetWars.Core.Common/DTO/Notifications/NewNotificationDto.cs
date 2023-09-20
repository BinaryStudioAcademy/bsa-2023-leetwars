using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.User;
using System.Text.Json.Serialization;

namespace LeetWars.Core.Common.DTO.Notifications
{
    public class NewNotificationDto
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeNotifications TypeNotification { get; set; }

        public BriefUserInfoDto? Sender { get; set; }

        public BriefChallengeInfoDto? Challenge { get; set; }

        public string? ReceiverId { get; set; }

        public string? Message { get; set; }

        public DateTime DateSending { get; set; } = DateTime.UtcNow;
    }
}
