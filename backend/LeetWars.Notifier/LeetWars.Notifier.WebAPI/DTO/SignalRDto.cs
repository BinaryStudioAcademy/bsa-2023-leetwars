namespace LeetWars.Notifier.WebAPI.DTO
{
    public class SignalRDto
    {
        public string ConnectionID { get; set; } = string.Empty;
        public string JsonEntityToSend { get; set; } = string.Empty;

    }
}
