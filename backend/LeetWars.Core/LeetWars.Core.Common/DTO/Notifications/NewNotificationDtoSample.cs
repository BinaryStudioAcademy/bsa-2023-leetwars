namespace LeetWars.Core.Common.DTO.Notifications
{
    public class NewNotificationDtoSample
    {
        public TypeNotifications TypeNotification { get; set; }

        public string? Message { get; set; }

        public DateTime DateSending { get; set; } = DateTime.UtcNow;
    }
}
