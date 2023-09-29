namespace LeetWars.Core.DAL.Entities
{
    public class UserNotification
    {
        public long ReceiverId { get; set; }
        public long NotificationId { get; set; }
        public bool IsRead { get; set; }
        public Notification? Notification { get; set; }
        public User? Receiver { get; set; }
    }
}
